
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Large_File_Scanner
{
    public partial class FrmPrincipal : Form
    {
        private readonly string gitattributesFormat = "filter=lfs diff=lfs merge=lfs -text";
        private string diretorioArquivos = string.Empty;
        private string gitattributes = string.Empty;
        private long tamanhoTotalArquivos = 0;

        private List<Arquivo> colecaoDasExtensoes;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Metodos
        private string ProcurarDiretorio()
        {
            var fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                return fdb.SelectedPath;
            }

            return string.Empty;
        }

        //DataGridView
        private void ValidarExtensoes()
        {
            try
            {
                var repositorio = new DirectoryInfo(diretorioArquivos);
                var arquivos = repositorio.GetFiles("*.*", SearchOption.AllDirectories);

                pgbPrincipal.Maximum = arquivos.Count();

                if (colecaoDasExtensoes is not null)
                    colecaoDasExtensoes.Clear();

                colecaoDasExtensoes = new List<Arquivo>();

                AtualizarColecaoDasExtensoes(arquivos);
                AtualizarDataGridView();
                AtualizarLabelStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operação invalida!\nErro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarColecaoDasExtensoes(FileInfo[] arquivos)
        {
            arquivos
                .OrderBy(a => a.Extension)
                .ToList()
                .ForEach(a =>
                {
                    pgbPrincipal.Value++;
                    var extensao = a.Extension;

                    if (string.IsNullOrWhiteSpace(extensao))
                        extensao = "Tipo indefinido";

                    var arquivo = colecaoDasExtensoes.Find(s => s.Extensao == extensao);
                    decimal tamanhoMinimo = txtTamanhoMB.Text.ParaDecimal();
                    decimal tamanhoArquivo = a.Length.ConverterParaUnidadeMedida((int)cboUnidade.SelectedValue);

                    if (tamanhoArquivo >= tamanhoMinimo)
                    {
                        if (arquivo is null)
                        {
                            colecaoDasExtensoes.Add(new Arquivo { Extensao = extensao, Quantidade = 1, Tamanho = a.Length });
                        }
                        else
                        {
                            arquivo.Tamanho += a.Length;
                            arquivo.Quantidade++;
                        }
                    }
                });
        }
        private void AtualizarDataGridView()
        {
            if (colecaoDasExtensoes is not null)
            {
                if (dtgPrincipal.Rows.Count > 0)
                    dtgPrincipal.Rows.Clear();


                OrdenarColecao();
                tamanhoTotalArquivos = 0;

                colecaoDasExtensoes.ForEach(a =>
                {
                    tamanhoTotalArquivos += a.Tamanho;
                    var tamanhoEmDecimal = a.Tamanho.ConverterParaUnidadeMedida((int)cboUnidade.SelectedValue);
                    dtgPrincipal.Rows.Add(
                        chkHeader.Checked,
                        a.Extensao,
                        a.Quantidade,
                        tamanhoEmDecimal
                        );
                });
                dtgPrincipal.Columns["colTamanho"].DefaultCellStyle.Format = String.Format("0.### " + ObterSiglaCboUnidade(), CultureInfo.InvariantCulture);
            }
        }

        //Bind ComboBox
        private void BindCboUnidade()
        {
            List<BindUnidadeMedida> unidadeMedidas = new()
            {
                new BindUnidadeMedida { Indice = 0, NomeExtenso = "Kilobyte", Sigla = "KB" },
                new BindUnidadeMedida { Indice = 1, NomeExtenso = "Megabyte", Sigla = "MB" },
                new BindUnidadeMedida { Indice = 2, NomeExtenso = "Gigabyte", Sigla = "GB" },
            };

            cboUnidade.DataSource = unidadeMedidas;
            cboUnidade.DisplayMember = "NomeExtenso";
            cboUnidade.ValueMember = "Indice";

            cboUnidade.SelectedValue = 0;
        }
        private void BindCboOrdenacao()
        {
            List<BindOrdenacao> ordenacao = new()
            {
                new BindOrdenacao { Indice = 0, Nome = "Extensão"},
                new BindOrdenacao { Indice = 1, Nome = "Quantidade"},
                new BindOrdenacao { Indice = 2, Nome = "Tamanho"}
            };

            cboOrdenacao.DataSource = ordenacao;
            cboOrdenacao.DisplayMember = "Nome";
            cboOrdenacao.ValueMember = "Indice";

            cboOrdenacao.SelectedValue = 2;
        }
        private string ObterSiglaCboUnidade()
        {
            var unidade = (BindUnidadeMedida)cboUnidade.SelectedItem;
            return unidade.Sigla;
        }
        private void OrdenarColecao()
        {
            int ordenacao = (int)cboOrdenacao.SelectedValue;

            if (ordenacao == 0)
                colecaoDasExtensoes = colecaoDasExtensoes.OrderBy(a => a.Extensao).ToList();
            else if (ordenacao == 1)
                colecaoDasExtensoes = colecaoDasExtensoes.OrderByDescending(a => a.Quantidade).ToList();
            else if (ordenacao == 2)
                colecaoDasExtensoes = colecaoDasExtensoes.OrderByDescending(a => a.Tamanho).ToList();
        }

        //Labels
        private void AtualizarLabelStatus()
        {
            string totalExtensoes = dtgPrincipal.Rows.Count.NumerosPersonalizados();
            lblTotalExtensoes.Text = "Extensões: " + totalExtensoes;

            lblTotalArquivos.Text = "Arquivos: 0";
            lblTotalTamanho.Text = "Tamanho: 0";

            if (dtgPrincipal.Rows.Count > 0)
            {
                int totalArquivos = 0; //colQtd
                decimal totalTamanho = 0; //colTamanho

                foreach (DataGridViewRow row in dtgPrincipal.Rows)
                    totalArquivos += (int)row.Cells["colQtd"].Value;

                lblTotalArquivos.Text = "Arquivos: " + totalArquivos.NumerosPersonalizados();

                
                lblTotalTamanho.Text = "Tamanho: " + tamanhoTotalArquivos.NumerosTamanhoPersonalizados();
            }
        }

        #endregion Metodos


        #region Eventos
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarLabelStatus();
            BindCboUnidade();
            BindCboOrdenacao();
        }

        private void btnProcurarDiretorio_Click(object sender, EventArgs e)
        {
            pgbPrincipal.Value = 0;
            ((Button)sender).Enabled = false;

            diretorioArquivos = ProcurarDiretorio();
            if (!String.IsNullOrWhiteSpace(diretorioArquivos))
                ValidarExtensoes();

            ((Button)sender).Enabled = true;
        }

        private void btnGerarTXT_Click(object sender, EventArgs e)
        {
            var diretorioParaSalvarArquivos = ProcurarDiretorio();

            if (String.IsNullOrWhiteSpace(diretorioParaSalvarArquivos))
                return;

            try
            {
                gitattributes = $"{diretorioParaSalvarArquivos}\\.gitattributes.txt";

                using (var gitFile = new StreamWriter(gitattributes))
                {
                    foreach (DataGridViewRow row in dtgPrincipal.Rows)
                    {
                        DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];
                        if (Convert.ToBoolean(checkBoxCell.Value))
                        {
                            gitFile.WriteLine($"*{row.Cells[1].Value} {gitattributesFormat}");
                        }
                    }
                }

                MessageBox.Show("Arquivos criados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao criar o arquivo.\nErro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new();
            frmSobre.ShowDialog();
        }

        private void txtBoxApenasNumerosComCasasDecimais(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ';' || e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(','))
                e.Handled = true;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void txtBoxValidarText_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox is null || string.IsNullOrWhiteSpace(textBox.Text))
            {
                cboUnidade.SelectedValue = 0;
                cboUnidade.Enabled = false;
                return;
            }

            cboUnidade.Enabled = true;
        }

        private void chkHeader_CheckedChanged(object sender, EventArgs e)
        {
            if(dtgPrincipal.Rows.Count <= 0) 
                return;

            try
            {
                foreach (DataGridViewRow row in dtgPrincipal.Rows)
                {
                    row.Cells[0].Value = ((CheckBox)sender).Checked;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao executar operação.\nErro: " + ex.Message);
            }
        }

        #endregion Eventos

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_File_Scanner
{
    public static class Formatacao
    {
        public static decimal ParaDecimal(this string valor)
        {
            return ConverterParaDecimal(valor);
        }

        public static decimal ConverterParaDecimal(this string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return 0;

            decimal resultado = decimal.Parse(valor);
            return resultado;
        }

        public static decimal ConverterParaUnidadeMedida(this long tamanho, int unidadeMedida)
        {
            decimal resultado = 0;

            if (unidadeMedida <= 0) //kb
            {
                resultado = tamanho / 1000;
            }
            else if (unidadeMedida == 1) //mb
            {
                decimal sub1 = tamanho / 1000;
                resultado = sub1 / 1000;
            }
            else if (unidadeMedida == 2) //gb
            {
                decimal sub1 = tamanho / 1000;
                decimal sub2 = sub1 / 1000;
                resultado = sub2 / 1000;
            }

            return resultado;
        }

        public static string VirgulaPorPonto(this string valor)
        {
            return valor.Contains(',') ? valor.Replace(',','.') : valor;
        }
    
        public static string NumerosPersonalizados(this int valor)
        {
            if (valor < 1000)
                return valor.ToString();
            else if (valor > 1000 && valor < 1000000)
                return (valor / 1000).ToString() + "k";
            else
                return (valor / 1000000).ToString() + "m";
        }

        public static string NumerosTamanhoPersonalizados(this long valor)
        {
            decimal sub1 = valor / 1000; //kb
            decimal sub2 = sub1 / 1000;
            decimal sub3 = sub2 / 1000;

            if (sub1 < 1024)
                return sub1.ToString("N0") + " kb";
            else if (sub2 < 1024)
                return sub2.ToString("N2") + " mb";
            else
                return sub3.ToString("N2") + " gb";
        }
    }
}

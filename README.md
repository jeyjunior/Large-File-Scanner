## Large File Scanner ##

[![Plataforma](https://img.shields.io/badge/Plataforma-Windows%20Forms-blue.svg)](https://docs.microsoft.com/pt-br/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8) ![Linguagem](https://img.shields.io/badge/Linguagem-C%23-green.svg) ![Tipo](https://img.shields.io/badge/Tipo-Desktop-purple.svg) ![Versionamento](https://img.shields.io/badge/Versionamento-Git%20LFS-orange.svg) ![GitHub](https://img.shields.io/badge/GitHub-Repository-lightgrey.svg)

O **Large File Scanner** é uma ferramenta desenvolvida para resolver um problema comum no controle de versão de projetos Unity no Git/GitHub. Ao lidar com muitos arquivos pesados, é fácil esquecer de atribuir o uso do Git LFS a alguns deles, o que pode causar problemas de espaço no repositório e limitar a quantidade de projetos que podem ser armazenados na versão gratuita do GitHub.

![Large File Scanner](https://imgs-projetos-jeyjr.netlify.app/windowsformsapp/largefilescanner/lsf-app.png)

### Downloads

Link para **download** (Opção compactada / descompactada):
[Acessar a pasta no Google Drive](https://drive.google.com/drive/folders/1ZXiUT-6_zyZfbp8qB5YeQ4UZjdzP7pHF)

---

## O Problema com Arquivos Pesados no Git

O Git LFS é um recurso do GitHub que armazena arquivos pesados (como áudio e imagens) em um servidor remoto e cria um "ponteiro" para esses arquivos no seu repositório. Embora esse recurso ajude a gerenciar melhor o versionamento de arquivos grandes, pode ser difícil identificar todos os arquivos que devem ser tratados com o Git LFS.

![Arquivos não tratados](https://imgs-projetos-jeyjr.netlify.app/windowsformsapp/largefilescanner/lsf-app-arquivosaberto.png)

### A Solução: Large File Scanner

Para resolver esse problema, desenvolvi o **Large File Scanner**, uma ferramenta desktop que faz uma varredura no seu projeto e identifica todos os arquivos com um tamanho definido por você. Ele retorna todos os formatos existentes no projeto, a quantidade de arquivos desse formato e o tamanho total que eles ocupam no seu projeto. Basta selecionar os arquivos que deseja atribuir ao Git LFS e clicar em "criar arquivos". O Large File Scanner gera automaticamente um arquivo .gitattributes configurado para usar o Git LFS.

![Identificando arquivos](https://imgs-projetos-jeyjr.netlify.app/windowsformsapp/largefilescanner/lfs-app-arquivos.png)

### Como Usar o Large File Scanner

Para utilizar o Git LFS em seu projeto, é necessário instalá-lo em seu computador. Você pode encontrar mais informações sobre o Git LFS em [https://git-lfs.github.com/](https://git-lfs.github.com/).

Após a instalação do Git LFS, basta executar o Large File Scanner e seguir as instruções simples para gerar o arquivo .gitattributes configurado corretamente. Copie e cole esse arquivo no mesmo diretório do seu projeto onde você inicializou o Git. Lembre-se de que as configurações inseridas nesse arquivo se aplicam apenas ao Git LFS. Qualquer configuração adicional relacionada ao seu projeto deve ser feita por você.

### Contribuições

O Large File Scanner é uma ferramenta gratuita e de código aberto, disponível para download em nosso repositório no GitHub. Se você tiver alguma sugestão de melhoria, fique à vontade para abrir uma issue ou uma pull request. Sua contribuição é essencial para tornar essa ferramenta ainda melhor!


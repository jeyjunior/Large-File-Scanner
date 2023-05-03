# Large File Scanner

[![Plataforma](https://img.shields.io/badge/Plataforma-Windows%20Forms-blue.svg)](https://docs.microsoft.com/pt-br/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8)
![Platform](https://img.shields.io/badge/platform-Desktop-purple.svg)



## Descrição

O aplicativo **lista todos os arquivos** do repositório que tiverem **tamanho maior ou igual** ao valor especificado na busca. O usuário pode escolher quais arquivos deseja adicionar ao arquivo `gitattributes.txt`, que receberá a formatação apropriada para ser inserido no `GIT LFS`. Além disso, o aplicativo gera um arquivo secundário com a lista de todos os arquivos, seus tamanhos e endereços dentro do repositório, permitindo uma busca manual e detalhada, caso necessário.

![img-1](https://imgs-projetos-jeyjr.netlify.app/windowsformsapp/largefilescanner/lsf-app.png)

## Vantagens

Mesmo que a equipe ou o usuário tenham organizado e padronizado tudo que entra e sai no projeto, é possível que algum arquivo passe pelo filtro da empresa, entre no commit e depois seja adicionado ao `GIT HUB`, ocupando um espaço **"desnecessário"** ou que poderia ser evitado. Com o `Large File Scanner`, é possível identificar todos os arquivos de qualquer formato conforme o tamanho especificado, mostrando os endereços e permitindo adicionar no `.gitattributes`.


![img-2](https://imgs-projetos-jeyjr.netlify.app/windowsformsapp/largefilescanner/lsf-app-arquivosaberto.png)

## Observações e Cuidados

O aplicativo não instala o `GIT LFS` no repositório e não executa nenhum comando relacionado ao `GIT` ou suas ferramentas e recursos por questões de segurança. O usuário deve realizar a instalação e definir o que entra e sai do arquivo `gitattributes.txt`.

O arquivo gerado do `gitattributes.txt` é apenas um modelo. O usuário deve copiar o conteúdo do arquivo e colá-lo em seu projeto, dentro do arquivo `.gitattributes`. Essa medida foi tomada para evitar possíveis problemas relacionados ao projeto do usuário.

O arquivo gerado pelo aplicativo é apenas a formatação para o `GIT LFS`. Qualquer formatação adicional no arquivo gitattributes deve ser feita pelo usuário.


![img-3](https://imgs-projetos-jeyjr.netlify.app/windowsformsapp/largefilescanner/lfs-app-arquivos.png)

## Uso

O uso do aplicativo e do código do programa é livre. Desenvolvi essa solução para ajudar nos projetos da Unity.

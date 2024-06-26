# TextEditor

Um simples editor de texto de console em C#.

## Descrição

Este projeto é um editor de texto de console básico que permite aos usuários abrir, editar e salvar arquivos de texto. Ele foi criado para demonstrar a manipulação de arquivos e a navegação de menus em um ambiente de console.

## Funcionalidades

- Abrir arquivos de texto existentes.
- Editar arquivos de texto.
- Salvar arquivos de texto com um caminho especificado pelo usuário.

## Como Usar

1. Clone o repositório:
   ```bash
   git clone https://github.com/YagoCrystian/TextEditor.git

2. Navegue até o diretório do projeto:
    ```bash
    cd TextEditor

3. Compile e execute o programa:
    ```bash
    dotnet run

## Menu Principal
>Quando o programa é iniciado, ele exibe um menu com as seguintes opções:

    1. Abrir Arquivo: Solicita ao usuário o caminho de um arquivo de texto e exibe o conteúdo do arquivo.
    2. Editar Arquivo: Permite ao usuário digitar texto que será salvo em um arquivo.
    3. Sair: Encerra o programa.

## Estrutura do Código
Program.cs: Contém a lógica principal do programa, incluindo a navegação do menu e as funções para abrir, editar e salvar arquivos.

## Exemplo de Uso
1. Abrir Arquivo:
    ```bash
    Digite 1 e pressione Enter.
    Insira o caminho do arquivo que deseja abrir e pressione Enter.
    O conteúdo do arquivo será exibido no console.

2. Editar Arquivo:
    ```bash
    Digite 2 e pressione Enter.
    Digite o texto desejado e pressione Esc para sair do modo de edição.
    Insira o caminho onde deseja salvar o arquivo e pressione Enter.
    O arquivo será salvo no local especificado.

3. Sair:
    ```bash
    Digite 0 e pressione Enter para encerrar o programa.

## Melhorias Futuras

- Adicionar suporte a operações de edição de texto mais avançadas.
- Implementar a capacidade de desfazer/redo.
- Criar uma interface gráfica para facilitar o uso.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Licença:
Este projeto está licenciado sob a Licença MIT. Veja o arquivo LICENSE para mais detalhes.


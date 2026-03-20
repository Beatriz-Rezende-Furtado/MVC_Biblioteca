# MVC Biblioteca Virtual
Projeto desenvolvido para a disciplina de Programação Web II com o objetivo de simular uma biblioteca virtual utilizando o padrão de arquitetura MVC (Model-View-Controller).

- **Models**: responsáveis pelos dados do sistema  
  - `Autor.cs`  
  - `Livros.cs`  
  - `DadosBiblioteca.cs`

- **Controllers**: responsáveis pela lógica e controle das páginas  
  - `HomeController.cs`  
  - `LivrosController.cs`  
  - `AutoresController.cs`

- **Views**: responsáveis pela interface visual do sistema  

## Como executar o projeto

1. Instale o .NET SDK (versão 10.0)
2. Baixe ou clone este repositório:
   ```bash
   git clone https://github.com/Beatriz-Rezende-Furtado/MVC_Biblioteca.git
   ```
3. Abra a pasta do projeto no Visual Studio Code
4. Abra o terminal dentro do VS Code
5. Execute o seguinte comando para rodar o projeto:
   ```bash
   dotnet run
   ```
6. Após executar, o sistema estará disponível no navegador
---
## Observações

* Certifique-se de ter o .NET instalado corretamente
* Os dados são simulados em memória no próprio código `DadosBiblioteca.cs`
* Os livros possuem links externos para acesso aos PDFs

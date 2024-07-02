# Sistema de Gerenciamento de Clientes e Produtos

Este é um projeto de aplicação desktop desenvolvido em C# utilizando Windows Forms e PostgreSQL. O sistema tem como objetivo gerenciar clientes, produtos e vendas.

## Estrutura do Projeto

- **DeMariaDesafio** (sua solução)
  - **ControleDeVendas** (seu projeto)
    - ControleDeVendas.csproj
    - **Models**
    - **Views**
    - **Presenters** (ou ViewModels)
    - **DataAccess**
    - **Reports**
    - **Resources**
    - **Tests** (opcional)

## Funcionalidades

- Cadastro, edição e remoção de clientes com informações como nome, endereço, telefone e email.
- Cadastro, edição e remoção de produtos com informações como nome, descrição, preço e estoque.
- Registro de vendas, incluindo seleção de cliente, produtos e quantidade de itens vendidos.
- Geração de relatórios de vendas, clientes e estoque utilizando o ReportViewer.

## Tecnologias Utilizadas

- C#
- Windows Forms
- PostgreSQL 8.6
- Npgsql (Biblioteca para acesso ao PostgreSQL em C#)
- Git (Controle de versão)
- Visual Studio 2022 (IDE)
- pgAdmin 4 (Interface gráfica para gerenciamento do PostgreSQL)
- ReportViewer (Para geração de relatórios)

## Instalação e Uso

Para utilizar este projeto, siga os passos abaixo:

### Pré-requisitos

- Instalar o Visual Studio 2022 ou versão superior.
- Instalar o pgAdmin 4 e PostgreSQL 8.6 ou versão superior.
- Configurar o ambiente de desenvolvimento C#.

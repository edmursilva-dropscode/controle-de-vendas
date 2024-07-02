<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>README - Sistema de Gerenciamento de Clientes e Produtos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 20px;
        }
        h1, h2, h3 {
            color: #333;
        }
        pre {
            background-color: #f4f4f4;
            padding: 10px;
            border: 1px solid #ccc;
            overflow: auto;
        }
        code {
            color: #f66d9b;
        }
        ul {
            list-style-type: none;
            padding: 0;
        }
        ul.tree {
            padding-left: 20px;
        }
        ul.tree li {
            position: relative;
        }
        ul.tree li:before {
            content: "";
            position: absolute;
            top: 0;
            left: -10px;
            border-left: 1px solid #ccc;
            height: 100%;
        }
    </style>
</head>
<body>
    <h1>Sistema de Gerenciamento de Clientes e Produtos</h1>
    
    <p>Este é um projeto de aplicação desktop desenvolvido em C# utilizando Windows Forms e PostgreSQL. O sistema tem como objetivo gerenciar clientes, produtos e vendas.</p>
    
    <h2>Estrutura do Projeto</h2>
    <ul class="tree">
        <li>
            <strong>DeMariaDesafio</strong> (sua solução)
            <ul class="tree">
                <li>
                    <strong>ControleDeVendas</strong> (seu projeto)
                    <ul class="tree">
                        <li>ControleDeVendas.csproj</li>
                        <li><strong>Models</strong></li>
                        <li><strong>Views</strong></li>
                        <li><strong>Presenters</strong> (ou ViewModels)</li>
                        <li><strong>DataAccess</strong></li>
                        <li><strong>Reports</strong></li>
                        <li><strong>Resources</strong></li>
                        <li><strong>Tests</strong> (opcional)</li>
                    </ul>
                </li>
            </ul>
        </li>
    </ul>
    
    <h2>Funcionalidades</h2>
    <ul>
        <li>Cadastro, edição e remoção de clientes com informações como nome, endereço, telefone e email.</li>
        <li>Cadastro, edição e remoção de produtos com informações como nome, descrição, preço e estoque.</li>
        <li>Registro de vendas, incluindo seleção de cliente, produtos e quantidade de itens vendidos.</li>
        <li>Geração de relatórios de vendas, clientes e estoque utilizando o ReportViewer.</li>
    </ul>
    
    <h2>Tecnologias Utilizadas</h2>
    <ul>
        <li>C#</li>
        <li>Windows Forms</li>
        <li>PostgreSQL 8.6</li>
        <li>Npgsql (Biblioteca para acesso ao PostgreSQL em C#)</li>
        <li>Git (Controle de versão)</li>
        <li>Visual Studio 2022 (IDE)</li>
        <li>pgAdmin 4 (Interface gráfica para gerenciamento do PostgreSQL)</li>
        <li>ReportViewer (Para geração de relatórios)</li>
    </ul>
    
    <h2>Instalação e Uso</h2>
    <p>Para utilizar este projeto, siga os passos abaixo:</p>
    
    <h3>Pré-requisitos</h3>
    <ul>
        <li>Instalar o Visual Studio 2022 ou versão superior.</li>
        <li>Instalar o pgAdmin 4 e PostgreSQL 8.6 ou versão superior.</li>
        <li>Configurar o ambiente de desenvolvimento C#.</li>
    </ul>
    
    <h3>Passos para Execução</h3>
    <ol>
        <li>Clone este repositório Git:</li>
        <pre><code>git clone https://github.com/seu-usuario/seu-projeto.git</code></pre>
        <li>Abra o projeto no Visual Studio.</li>
        <li>Configure a conexão com o banco de dados PostgreSQL através do pgAdmin 4.</li>
        <li>Compile e execute o projeto.</li>
    </ol>
    
    <h2>Contribuição</h2>
    <p>Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests com melhorias, correções de bugs ou novas funcionalidades.</p>
    
    <h2>Licença</h2>
    <p>Este projeto está licenciado sob a MIT License. Consulte o arquivo LICENSE.md para obter mais detalhes.</p>
    
    <hr>
    
    <p align="center">README.md gerado por ChatGPT</p>
</body>
</html>

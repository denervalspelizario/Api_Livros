﻿/*
 *  PASSO A PASSO CRIACAO E DESENVOLVIMENTO API
   
 [1] VAMOS LIMPAR O PROJETO EXCLUA WEATHERFORECAST E WEATHERFORESTCONTROLLER

 [2] PROXIMO PASSO SERIA CRIAR A CONEXAO COM O BANCO DE DADOS
     - CRIE UMA PASTA CHAMADA DATA E NELA SERÁ CRIADO A CLASSE  APPDBCONTEXT QUE
       SERÁ O NOSSO CONTEXTO QUE FARA TODO GERENCIAMENTO ENTRE APLICAÇÃO E BANCO DE DADOS
    
    - APÓS A CRIAÇÃO VAMOS INSTALAR OS PACOTES
      Microsoft.EntityFrameworkCore
      Microsoft.EntityFrameworkCore.SqlServer
      Microsoft.EntityFrameworkCore.Design
      Microsoft.EntityFrameworkCore.Tools

    - VOLTANDO AO APPDBCONTEXT CRIE O CONTEXTO E SEU CONSTRUTOR, PORÉM ANTES DE CRIAR 
      A LOGICA DENTRO DO CONSTRUTOR VAMOS CRIAR OS MODELOS QUE SERÃO A BASE DAS 
      TABELAS DO BANCO DE DADOS

    - CRIE UMA PASTA CHAMADA MODELS E NELA CRIE AS CLASSES QUE SERÃO O MODELO PARA AS 
      TABELAS NESTE PROJETO TERA AutorModel e LivroModel  CRIE E JA ADICIONE AS 
      PROPRIEDADES

    -  APOS CRIAR OS MODELS VOLTE PARA O APPDBCONTEXT E FAÇA A LOGICA DE QUAL AS TABELAS 
       SERÃO CRIADAS

    -  CRIADAS A LOGICA DAS TABELAS ANTES DE FAZER O CONTEXT DE FATO PRECISAMOS CRIAR
       PASSAR AS INFORMAÇÕES DO BANCO DE DADOS PARA O NOSSO CONTEXTO A INFORMAÇÕES DO BD
       NOMDE DO BD, SENHA DE USUARIOS ESSAS COISAS TODAS ESSAS INFOS VÃO FICAR NO 
       APPSETTING ENTÃO VAMOS NO APPSETTING ADICIONAR OS DADOS DO BD, COMO É UM ARQUIVO
       JSON ENTÃO NÃO DA PARA ADICIONAR COMENTARIO MAS A REFERENCIA SERÁ 
       "CONNECTIONSTRINGS"

    - PASSANDO AS INFOS DO BANCO DE DADOS PRECISAMOS PEGAR AS INFOS E LEVAR ATÉ O CONTEXT
      E PARA ISSO VAMOS USAR PARA O PROGRAM.CS É LA QUE VAMOS FAZER ESTA LINKAGEM

   
    - AGORA DE FATO VAMOS CRIAR  AS MIGRATION E AS TABELAS  VA EM
      FERRAMENTAS > GERENCIADOR DE PRODUTOS DO NUGET > CONSOLE DO GERENCIADOR DE PACOTES
      VAI ABRIR UM CONSOLE EMBAIXO DO VS, SEGUE OS COMANDOS QUE SERÃO USADOS

      add-migration CriandoBancoDados         *obs CriandoBancoDados pode ser qualquer nome
        
      Esse comando vai criar uma pasta chamada Migrations e tera 2 arquivos
      
      Depois no console adicione o comando de update NO CONSOLE :

      update-database

      ESTE COMANDO UPDATE VAI DE FATO GERAR AS TABELAS NO BANCO, AGORA VÁ NO SQL SERVER DE 
      REFRESH  NO BANCO E VERIFIQUE SE TUDO FOI CRIADO DE FATO LA 

    - AGORA VAMOS CRIAR A ESTRUTURA DE PASTAS 
      CRIE A PASTA SERVICES E DENTRO DELA CRIE A PASTA AUTOR  
 
 */
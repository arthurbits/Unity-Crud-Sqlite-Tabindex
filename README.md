
# Projeto Social Desabrocha


Este é um projeto simples e offline de uma aplicação Crud para cadastrar pessoas em situação de vulnerabilidade. Foi desenvolvido em cerca de 20 horas de trabalho e estudo.

O projeto abrange : 
* CRUD - Cadastro , Alterar , Listar, Procurar por ID, Excluir e buscar através dos campos CPF, RG e Nome simultaneamente.
* TabIndex - troca entre os campos input através da tecla TAB.
* Rolagem de telas com o clicar e arrastar ou rolagem do botão central do mouse.




## Instalação

* Basta criar um novo projeto 2D, já que o mesmo usa apenas o Canvas.
* Criar cada script com o mesmo nome e colar o conteúdo do mesmo.
* Copiar e Colar as pastas Prefab, Images, Streaming Assets e Plugins.
* Caso de algum erro criar um novo banco de dados usando o DB Browser e colar na pasta Streaming Assets.

    
## Demonstração

Ao ligar ele lista os cadastros do banco de dados e em cada registro ele demonstra apenas Nome,Cpf e Rg seguido de 3 botões.

![telaListar](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaListar.png)


* Um demonstra todos os dados do cadastro

![telaInformacao](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaInformacoes.png)

* Um abre a tela que permite excluir o registro.

![telaExcluir](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaExcluir.png)

* O último botão abre novamente a tela Cadastrar mas altera o botão que Cadastra e Ativa o de Editar.
![telaAlterar](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaCadastrarEEditar.png)

### Método de Busca
![telaExemploBuscar](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaExemploBuscar.png)



## Aprendizados

O deploy sem erros foi o maior desafio, sendo que foi o primeiro projeto que fiz com banco de dados local. 
Para quem faz um projeto online, ou com mais de uma pessoa acessando este banco de dados recomendo utilizar o Firebase.
Também precisei aprender sobre a nova forma do Unity 6 de acionar botões, o velho Input.GetKey(KeyCode.D) agora está 
Keyboard.current.tabKey.wasPressedThisFrame ja que o Unity.System.Input não está mais em uso.


## Considerações Finais

O projeto foi um trabalho comunitário bem simples quando vemos o resultado final, mas me trouxe uma maior experiência com Canvas do Unity, os detalhes do deploy de uma aplicação e fazendo tudo da forma mais simples possível.  


# Desabrocha Social Project

This is a simple, offline project for a CRUD application to register people in vulnerable situations. It was developed in about 20 hours of work and study.

The project includes:

* CRUD - Register, Change, List, Search by ID, Delete and search through the CPF, RG and Name fields simultaneously.

* TabIndex - switch between input fields using the TAB key.

* Scrolling screens by clicking and dragging or scrolling with the middle mouse button.


## Installation

* Simply create a new 2D project, since it only uses Canvas.
* Create each script with the same name and paste the contents of it.
* Copy and Paste the Prefab, Images, Streaming Assets and Plugins folders.
* In case of any error, create a new database using the DB Browser and paste it into the Streaming Assets folder.

## Demonstration

When turned on, it lists the database records and in each record it only shows Name, CPF and ID followed by 3 buttons.

![telaListar](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaListar.png)

* One shows all registration data

![telaInformacao](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaInformacoes.png)


* Other opens the screen that allows you to delete the record.

![telaExcluir](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaExcluir.png)

* The last button opens the Register screen again but changes the Register button and activates the Edit button.

![telaAlterar](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaCadastrarEEditar.png)

###Search Method

![telaExemploBuscar](https://github.com/arthurbits/Unity-Crud-Sqlite-Tabindex/blob/43d0d516149f8ef3e9103585657899f5ac806673/imgs/telaExemploBuscar.png)

## Lessons Learned

The error-free deployment was the biggest challenge, since it was the first project I did with a local database.
For those who do an online project, or with more than one person accessing this database, I recommend using Firebase.
I also needed to learn about the new way Unity 6 uses to trigger buttons, the old Input.GetKey(KeyCode.D) is now Keyboard.current.tabKey.wasPressedThisFrame since Unity.System.Input is no longer in use.

## Final Considerations

The project was a very simple community effort when we see the final result, but it gave me greater experience with Unity Canvas, the details of deploying an application and doing everything in the simplest way possible.

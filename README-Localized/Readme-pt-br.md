Amostra principal de API ASP.NET do serviço OneNote
---------------------------------------

Criado pela Microsoft Corporation, 2017. Fornecido como está sem garantia. As marcas comerciais mencionadas aqui pertencem aos proprietários.

DEMO: https://onenoteapisamplegraph.azurewebsites.net

### Introdução

-	Este é um exemplo pequeno que mostra como usar o acesso a recursos do OneNote por meio da API do Microsoft Graph a partir de um servidor ASP.NET.

### Pré-requisitos

**Ferramentas e Bibliotecas** que serão necessárias baixar, instalar e configurar para o seu ambiente de desenvolvimento.

* [Atualização 3 do Visual Studio 2015](https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs) 
  1. Clique em "como instalar uma versão específica do Visual Studio": 
  
  ![Baixar versões anteriores do Visual Studio](./images/HowToInstall.png)

  2. Clique em "My.VisualStudio.com": 
  
  ![Clique em "My.VisualStudio.com"](./images/InstallingEarlierReleases.png)

  3. [Baixe Visual Studio Enterprise 2015 com Atualização 3](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) (registrado com uma conta MSFT) 
  
  ![Instalando versões anteriores](./images/VisualStudioEnterpriseSearch.png)

* [SDK do ASP.NET Core (para .NET Core 1.0)](https://www.microsoft.com/net/download/core)

* [Ferramentas do Visual Studio 2015](https://www.microsoft.com/net/download/core)
  
  ![Instalar Ferramentas do Visual Studio](./images/VisualStudioToolsInstall.png)

### Usando a amostra

Depois de configurar as ferramentas de desenvolvimento, e instalar os pré-requisitos listados acima,....

1.	Baixe este repositório no formato de arquivo ZIP para o seu computador local e extraia os arquivos. Ou clone o repositório em uma cópia local do Git.
2.	Abra o projeto (arquivo .sln) no Visual Studio.
3.	É altamente recomendável que você obtenha seu próprio ID de cliente, segredo e uri de redirecionamento e copie-o para o [Config.cs](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/src/OneNoteApiSample/Config.cs#L9). Você pode obter sua appid, o segredo do aplicativo e o URI de redirecionamento [aqui](http://developer.microsoft.com/pt-br/graph/docs/authorization/auth_register_app_v2)
4.	Para o desenvolvimento local, o exemplo usa o http://localhost:5001/callback.php como URI de redirecionamento. Para produção, você deve alterar isso para apontar para o domínio do aplicativo. >Observação: O Chrome e o Firefox não permitem que os cookies sejam configurados no localhost, e a autenticação não funcionará nesses navegadores durante o desenvolvimento, caso você opte por redirecionar para o localhost.
5.	Verifique se você selecionou a configuração "OneNoteApiSample" ao iniciar o aplicativo localmente. Ver [captura de tela](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/images/OneNoteApiSampleConfiguration.PNG).
6.	Crie e execute o aplicativo (F5)

### Conteúdo

Você pode encontrar mais informações nos links abaixo.

-	Criar páginas:
	-	[POSTAR HTML simples em uma nova página do OneNote QuickNotes](https://developer.microsoft.com/pt-br/graph/docs/api-reference/beta/api/notes_post_pages)
-	Páginas de consulta e pesquisa:
	-	[OBTER uma lista de todas as páginas paginadas no OneNote](https://developer.microsoft.com/pt-br/graph/docs/api-reference/beta/api/notes_list_pages)
-	Gerenciar com blocos de anotações e seções:
	-	[OBTER uma lista de todos os blocos de anotações](https://developer.microsoft.com/pt-br/graph/docs/api-reference/beta/api/notes_list_notebooks)
	-	[OBTER uma lista de todas as seções](https://developer.microsoft.com/pt-br/graph/docs/api-reference/beta/api/notes_list_sections)

#### Observação

Como exemplo, e para simplificação, este exemplo não segue as práticas recomendadas para um aplicativo em Produção. Se você pretende enviar esse código, recomendamos fazer o seguinte:

-	Nunca faça check-in dos segredos do aplicativo no repositório
-	Exigir HTTPS em todo o site
-	Não armazenar tokens de atualização sem criptografia em cookies

-	**Pacotes NuGet** usados no exemplo. Eles são tratados usando o gerenciador de pacotes, conforme descrito nas instruções de instalação. Esses devem ser atualizados automaticamente no momento da compilação. caso contrário, certifique-se de que o gerenciador de pacotes do NuGet está atualizado. Você pode saber mais sobre os pacotes que usamos, nos links abaixo.

	-	[O pacote Newtonsoft Json.NET](http://newtonsoft.com/) fornece utilitários de análise de Json.
	-	Outros pacotes NuGet da Microsoft, listados no project.json

### Informações de Versão

| Data | Alterar |
|------------|--------------------------------------------------------------------------------|
| Maio de 2017 | Atualizado para usar o URL básica do Microsoft Graph v1.0 para recursos do OneNote |
| Março de 2017 | Atualizado para utilizar os pontos de extremidade de API do Microsoft Graph. |
| Janeiro de 2017 | Versão pública inicial deste exemplo de código. |

### Saiba mais

-	Visite o Centro de Desenvolvimento do[dev.onenote.com](http://dev.onenote.com)
-	Fale conosco na [StackOverflow (marcado OneNote)](http://go.microsoft.com/fwlink/?LinkID=390182)
-	Siga-nos em [@onenotedev Twitter](http://www.twitter.com/onenotedev)
-	Leia nosso blog [OneNote Developer](http://go.microsoft.com/fwlink/?LinkID=390183)
-	Explore as API usando o [Explorador do Graph](https://developer.microsoft.com/pt-br/graph/graph-explorer)
-	Documentação de [referência da API](https://developer.microsoft.com/pt-br/graph/docs/api-reference/beta/resources/notes)
-	[Problemas conhecidos](https://developer.microsoft.com/pt-br/graph/docs/overview/release_notes)
-	[Introdução](https://developer.microsoft.com/pt-br/graph/docs/get-started/get-started) com a API do Microsoft Graph

Este projeto adotou o [Código de conduta do código-fonte da Microsoft Open](https://opensource.microsoft.com/codeofconduct/). Para saber mais, confira as [Perguntas frequentes sobre o Código de Conduta](https://opensource.microsoft.com/codeofconduct/faq/) ou entre em contato pelo [opencode@microsoft.com](mailto:opencode@microsoft.com) se tiver outras dúvidas ou comentários.

Exemple de service OneNote via API ASP.NET
---------------------------------------

Créé par Microsoft Corporation, 2017. Fourni en l’état sans garantie. Les marques mentionnées ici sont la propriété de leurs propriétaires.

DÉMONSTRATION : https://onenoteapisamplegraph.azurewebsites.net

### Introduction

-	Il s’agit d’un court exemple indiquant comment utiliser les ressources OneNote d’accès via l’API Microsoft Graph à partir d’un serveur ASP.NET.

### Conditions préalables

**Outils et bibliothèques** vous devrez télécharger, installer et configurer pour votre environnement de développement

* [Visual Studio 2015 Mise à jour 3](https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs) 
  1. Cliquez sur « Comment installer une version spécifique de Visual Studio » : 
  
  ![Télécharger une version antérieure de Visual Studio](./images/HowToInstall.png)

  2. Cliquez sur « My.VisualStudio.com » : 
  
  ![Click on "My.VisualStudio.com"](./images/InstallingEarlierReleases.png)

  3. [Télécharger Visual Studio Enterprise 2015 avec la Mise à jour 3](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) (connecté avec un compte MSFT) 
  
  ![Installer des versions antérieures](./images/VisualStudioEnterpriseSearch.png)

* [ASP.NET Core SDK (pour .NET Core 1,0)](https://www.microsoft.com/net/download/core)

* [Outils Visual Studio 2015](https://www.microsoft.com/net/download/core)
  
  ![Installation des outils Visual Studio](./images/VisualStudioToolsInstall.png)

### Utilisation de l’exemple

Après avoir configuré vos outils de développement et installé les prérequis mentionnés ci-dessus...

1.	Téléchargez ce référentiel sous la forme d’un fichier ZIP sur votre ordinateur, puis extrayez les fichiers. Vous pouvez également cloner le référentiel dans une copie locale de Git.
2.	Ouvrez le projet (fichier .sln) dans Visual Studio.
3.	Nous vous recommandons vivement de vous procurer votre propre ID client, clé secrète et URI de redirection et des les copier dans [Config.cs](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/src/OneNoteApiSample/Config.cs#L9). Vous pouvez vous procurer votre appID, la clé secrète de l’application et l’URI de redirection [ici](http://developer.microsoft.com/fr-fr/graph/docs/authorization/auth_register_app_v2)
4.	Pour le développement local, l’exemple utilise http://localhost:5001/msgraphoauthcallback comme URI de redirection. Pour la production, vous devez modifier ce protocole pour qu'il pointe vers votre domaine d'application. >Remarque : Chrome et Firefox n'autorisent pas l'installation de cookies sur localhost. De ce fait, l'authentification ne fonctionne pas sur ces navigateurs pendant le développement si vous choisissez de vous rediriger vers localhost.
5.	Vérifiez que vous avez sélectionné la configuration « OneNoteApiSample » lors du lancement de l’application en local. Afficher la [capture d’écran](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/images/OneNoteApiSampleConfiguration.PNG).
6.	Génération et exécution de l’application (F5)

### Contenu

Vous trouverez des informations supplémentaires via les liens ci-dessous.

-	Créer des pages :
	-	[PUBLIER du simple HTML dans une nouvelle page OneNote QuickNotes](https://developer.microsoft.com/fr-fr/graph/docs/api-reference/beta/api/notes_post_pages)
-	Pages de requête et de recherche :
	-	[OBTENIR la liste paginée de toutes les pages dans OneNote](https://developer.microsoft.com/fr-fr/graph/docs/api-reference/beta/api/notes_list_pages)
-	Gérer les blocs-notes et les sections :
	-	[OBTENIR la liste de tous les blocs-notes](https://developer.microsoft.com/fr-fr/graph/docs/api-reference/beta/api/notes_list_notebooks)
	-	[OBTENIR la liste de toutes les sections](https://developer.microsoft.com/fr-fr/graph/docs/api-reference/beta/api/notes_list_sections)

#### Remarque

Pour des raisons de simplification, cet exemple ne respecte pas les pratiques recommandées pour une application en Production. Si vous voulez expédier ce code, nous vous recommandons d’effectuer les opérations suivantes :

-	Ne jamais enregistrer les clés secrètes des applications dans votre référentiel
-	Exiger le HTTPS sur votre site
-	Ne pas stocker les jetons d’actualisation non chiffrés dans les cookies

-	**Packages NuGet** utilisés dans l’exemple. Ils sont gérés à l’aide du gestionnaire de package, comme décrit dans les instructions d’installation. Cela devrait être mis à jour automatiquement au moment de la création. Si ce n’est pas le cas, assurez-vous que votre gestionnaire de package NuGet est à jour. Vous pouvez en savoir plus sur les packages que nous avons utilisés avec les liens ci-dessous.

	-	[Newtonsoft Json.NET package](http://newtonsoft.com/) fournit des utilitaires d’analyse JSON.
	-	Autres packages NuGet de Microsoft, répertoriés dans project.json

### Informations sur la version

| Date | Modifier |
|--------------|--------------------------------------------------------------------------------|
| Mai 2017 | Mise à jour pour utiliser l'URL de base de Microsoft Graph – Graphique v1.0 pour les ressources OneNote |
| Mars 2017 | Mise à jour pour utiliser les points de terminaison de l'API de Microsoft Graph. |
| Janvier 2017 | Version publique initiale de cet exemple de code. |

### En savoir plus

-	Visitez le centre de développement [dev.onenote.com](http://dev.onenote.com)
-	Contactez-nous sur [StackOverflow (avec la balise OneNote)](http://go.microsoft.com/fwlink/?LinkID=390182)
-	Suivez-nous sur [Twitter @onenotedev](http://www.twitter.com/onenotedev)
-	Lisez notre [blog de OneNote pour les développeurs](http://go.microsoft.com/fwlink/?LinkID=390183)
-	Explorez l’API à l’aide de l’[Afficheur Graph – Graphique](https://developer.microsoft.com/fr-fr/graph/graph-explorer)
-	Documentation de [référence d’API](https://developer.microsoft.com/fr-fr/graph/docs/api-reference/beta/resources/notes)
-	[Problèmes connus](https://developer.microsoft.com/fr-fr/graph/docs/overview/release_notes)
-	[Prise en main](https://developer.microsoft.com/fr-fr/graph/docs/get-started/get-started) de l’API Microsoft Graph

Ce projet a adopté le [code de conduite Open Source de Microsoft](https://opensource.microsoft.com/codeofconduct/). Pour en savoir plus, reportez-vous à la [FAQ relative au code de conduite](https://opensource.microsoft.com/codeofconduct/faq/) ou contactez [opencode@microsoft.com](mailto:opencode@microsoft.com) pour toute question ou tout commentaire.

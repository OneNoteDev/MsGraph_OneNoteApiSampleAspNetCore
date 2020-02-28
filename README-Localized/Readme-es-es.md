Ejemplo de API del servicio de OneNote para ASP.NET Core
---------------------------------------

Creado por Microsoft Corporation, 2017. Se proporciona tal cual sin garantía. Las marcas comerciales que se mencionan aquí pertenecen a sus propietarios.

DEMO: https://onenoteapisamplegraph.azurewebsites.net

### Introducción

-	Este es un pequeño ejemplo que muestra cómo acceder a los recursos de OneNote a través de la API de Microsoft Graph desde un servidor ASP.NET.

### Requisitos previos

**Herramientas y bibliotecas** que tendrá que descargar, instalar y configurar en el entorno de desarrollo

* [Visual Studio 2015 Actualización 3](https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs) 
  1. Haga clic en "Cómo instalar una versión específica de Visual Studio": 
  
  ![Descargar una versión anterior de Visual Studio](./images/HowToInstall.png)

  2. Haga clic en "My.VisualStudio.com": 
  
  ![Haga clic en "My.VisualStudio.com"](./images/InstallingEarlierReleases.png)

  3. [Descargar Visual Studio Enterprise 2015 con la actualización 3](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) (debe iniciar sesión con una cuenta MSFT) 
  
  ![Instalar versiones anteriores](./images/VisualStudioEnterpriseSearch.png)

* [SDK de ASP.NET Core (para .NET Core 1.0)](https://www.microsoft.com/net/download/core)

* [Visual Studio Tools 2015](https://www.microsoft.com/net/download/core)
  
  ![Instalación de Visual Studio Tools](./images/VisualStudioToolsInstall.png)

### Uso del ejemplo

Una vez que haya configurado las herramientas de desarrollo e instalado los requisitos previos indicados anteriormente,...

1.	Descargue el repositorio como archivo ZIP en el equipo local y extraiga los archivos. O bien, clone el repositorio en una copia local de Git.
2.	Abra el proyecto (archivo .sln) en Visual Studio.
3.	Es altamente recomendado que obtenga su propio Id. de cliente, secreto de cliente y URI de redireccionamiento y los copie en [Config.cs.](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/src/OneNoteApiSample/Config.cs#L9) Puede obtener su propio Id. de aplicación, secreto de aplicación y URI de redireccionamiento [aquí](http://developer.microsoft.com/es-es/graph/docs/authorization/auth_register_app_v2)
4.	Para el desarrollo local, el ejemplo usa http://localhost:5001/msgraphoauthcallback como URI de redireccionamiento. Para producción, debe cambiar esta para indicar el dominio de la aplicación. > Nota: Chrome y Firefox no permiten establecer cookies en localhost y, por lo tanto, la autenticación no funcionará en estos navegadores durante el desarrollo si decide redirigir a localhost.
5.	Asegúrese de haber seleccionado la configuración "OneNoteApiSample" al iniciar la aplicación de forma local. Vea [Captura de pantalla](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/images/OneNoteApiSampleConfiguration.PNG).
6.	Compile y ejecute la aplicación (F5)

### Contenido

Puede encontrar documentación adicional en los siguientes vínculos.

-	Páginas de creación:
	-	[Publicar una página HTML simple en una nueva página de notas rápidas de OneNote](https://developer.microsoft.com/es-es/graph/docs/api-reference/beta/api/notes_post_pages)
-	Páginas de consultas y búsquedas:
	-	[Obtener una lista paginada de todas las páginas en OneNote](https://developer.microsoft.com/es-es/graph/docs/api-reference/beta/api/notes_list_pages)
-	Administrar blocs de notas y secciones:
	-	[Obtener una lista de todos los blocs de notas](https://developer.microsoft.com/es-es/graph/docs/api-reference/beta/api/notes_list_notebooks)
	-	[Obtener una lista de todas las secciones](https://developer.microsoft.com/es-es/graph/docs/api-reference/beta/api/notes_list_sections)

#### Nota

Como ejemplo, y para mayor simplicidad, este ejemplo no sigue las prácticas recomendadas para una aplicación en producción. Si su intención es enviar este código, le recomendamos que haga lo siguiente:

-	Nunca inserte los secretos de aplicaciones en su repositorio
-	Solicite HTTPS en todo el sitio
-	No almacene tokens de actualización sin cifrar en las cookies

-	**Paquetes NuGet** usados en el ejemplo. Estos se controlan con el administrador de paquetes, como se indica en las instrucciones de configuración. Los mismos deben actualizarse automáticamente al momento de la compilación; de no ser así, asegúrese de que el administrador de paquetes NuGet esté al día. Puede obtener más información sobre los paquetes que usamos en los siguientes vínculos.

	-	El [Paquete Newtonsoft Json.NET](http://newtonsoft.com/) proporciona servicios
	-	Otros paquetes NuGet de Microsoft, enumerados en project.json

### Información de versión

| Fecha | Modificación |
|--------------|--------------------------------------------------------------------------------|
| Mayo 2017 | Actualizado para usar la dirección URL base de Microsoft Graph v1.0 para los recursos de OneNote |
| Marzo 2017 | Actualizado para usar los extremos de la API de Microsoft Graph. |
| Enero 2017 | Versión pública inicial para este ejemplo de código. |

### Más información

-	Visite el centro para desarrolladores [dev.onenote.com](http://dev.onenote.com)
-	Póngase en contacto con nosotros en [StackOverflow (OneNote etiquetado)](http://go.microsoft.com/fwlink/?LinkID=390182)
-	Síganos en [Twitter @onenotedev](http://www.twitter.com/onenotedev)
-	Lea nuestro [Blog para desarrolladores de OneNote](http://go.microsoft.com/fwlink/?LinkID=390183)
-	Pruebe la API usando el [Probador de Graph](https://developer.microsoft.com/es-es/graph/graph-explorer)
-	Documentación de [referencia de API](https://developer.microsoft.com/es-es/graph/docs/api-reference/beta/resources/notes)
-	[Problemas conocidos](https://developer.microsoft.com/es-es/graph/docs/overview/release_notes)
-	[Introducción](https://developer.microsoft.com/es-es/graph/docs/get-started/get-started) a la API de Microsoft Graph

Este proyecto ha adoptado el [Código de conducta de código abierto de Microsoft](https://opensource.microsoft.com/codeofconduct/). Para obtener más información, vea [Preguntas frecuentes sobre el código de conducta](https://opensource.microsoft.com/codeofconduct/faq/) o póngase en contacto con [opencode@microsoft.com](mailto:opencode@microsoft.com) si tiene otras preguntas o comentarios.

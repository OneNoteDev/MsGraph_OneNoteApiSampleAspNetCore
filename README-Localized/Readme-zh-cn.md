OneNote 服务 API ASP.NET 核心示例
---------------------------------------

由 Microsoft Corporation 创建，2017。按原样提供，不做保证。此处提及的商标是其所有者的财产。

演示：https://onenoteapisamplegraph.azurewebsites.net

### 简介

-	这是一个小示例，展示如何通过 Microsoft Graph API 从 ASP.NET 服务器访问 OneNote 资源。

### 先决条件

针对开发环境，需要下载、安装并配置**工具和库**

* [Visual Studio 2015 更新 3](https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs) 
  1. 单击“如何安装指定版本的 Visual Studio”： 
  
  ![下载早期版本的 Visual Studio](./images/HowToInstall.png)

  2. 单击“My.VisualStudio.com”： 
  
  ![单击“My.VisualStudio.com”](./images/InstallingEarlierReleases.png)

  3. [下载有更新 3 的 Visual Studio Enterprise 2015](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015)（使用 MSFT 账户登录） 
  
  ![安装早期版本](./images/VisualStudioEnterpriseSearch.png)

* [ASP.NET Core SDK （适用于 .NET Core 1.0）](https://www.microsoft.com/net/download/core)

* [Visual Studio 2015 工具](https://www.microsoft.com/net/download/core)
  
  ![Visual Studio 工具安装](./images/VisualStudioToolsInstall.png)

### 使用示例

设置完开发工具、安装上述先决条件后，...

1.	将此存储库以 ZIP 文件格式下载到本地计算机，并解压缩文件。或者将存储库克隆至 Git 的本地副本中。
2.	在 Visual Studio 中打开项目（.sln 文件）。
3.	强烈建议获取自己的客户端 ID、密码和重新向 URL 并复制至 [Config.cs](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/src/OneNoteApiSample/Config.cs#L9)中。你可[点击这里](http://developer.microsoft.com/zh-cn/graph/docs/authorization/auth_register_app_v2)获取自己的客户端 ID、密码和重新向 URL。
4.	对于本地开发，示例使用 http://localhost:5001/msgraphoauthcallback 作为重定向 URI。对于生产，应将其更改为指向应用程序域。>注意：Chrome 和 Firefox 不允许对 localhost 设置 cookie，因此如果选择重定向到 localhost，则在开发过程中无法对这些浏览器进行身份验证。
5.	确保本地启动应用时，已选定“OneNoteApiSample”配置。参见“[截屏](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/images/OneNoteApiSampleConfiguration.PNG)”。
6.	构建并运行应用程序（F5）

### 内容

可在下面链接中找到附加文档。

-	创建页面：
	-	[向新 OneNote QuickNotes 页面发布简单的 HTML](https://developer.microsoft.com/zh-cn/graph/docs/api-reference/beta/api/notes_post_pages)
-	查询和搜索页面：
	-	[获取 OneNote 所有页面的分页列表](https://developer.microsoft.com/zh-cn/graph/docs/api-reference/beta/api/notes_list_pages)
-	管理笔记本和分区：
	-	[获取所有笔记本的列表](https://developer.microsoft.com/zh-cn/graph/docs/api-reference/beta/api/notes_list_notebooks)
	-	[获取所有分区的列表](https://developer.microsoft.com/zh-cn/graph/docs/api-reference/beta/api/notes_list_sections)

#### 备注

作为示例，并且为了简单起见，此示例并未遵循生产中应用程序的最佳做法。如果想要发布此代码，建议执行以下操作：

-	请勿签入应用程序密码至存储库
-	网站需要 HTTPS
-	请勿存储未加密的刷新令牌至 cookie 中

-	示例中使用的**NuGet 包**。这些使用程序包管理器进行处理，详见“安装说明”。它们应在生成时自动更新，确保 NuGet 程序包管理器为最新版。可详细了解我们在以下链接使用的程序包。

	-	[Newtonsoft Json.NET 程序包](http://newtonsoft.com/) 提供 Json 解析实用工具。
	-	其他 Nuget 程序包，在 project.json 中列出

### 版本信息

|日期 |更改 |
|--------------|--------------------------------------------------------------------------------|
| 2017年5月 | 更新以利用适用于 OneNote 资源的 Microsoft Graph v 1.0 基准 URL |
| 2017 年 3 月 | 更新以利用 Microsoft Graph API 端点。|
| 2017 年 1 月| 此代码示例的初始公共发布。|

### 了解更多内容

-	访问 [dev.onenote.com](http://dev.onenote.com) 开发中心
-	访问 [StackOverflow（已标记的 OneNote）](http://go.microsoft.com/fwlink/?LinkID=390182)联系我们
-	在 [Twitter @onenotedev](http://www.twitter.com/onenotedev) 中关注我们
-	阅读我们的 [OneNote 开发者博客](http://go.microsoft.com/fwlink/?LinkID=390183)
-	请在 [Graph 浏览器](https://developer.microsoft.com/zh-cn/graph/graph-explorer)中探索 API
-	[API 参考](https://developer.microsoft.com/zh-cn/graph/docs/api-reference/beta/resources/notes)文档
-	[已知问题](https://developer.microsoft.com/zh-cn/graph/docs/overview/release_notes)
-	Microsoft Graph API [入门](https://developer.microsoft.com/zh-cn/graph/docs/get-started/get-started)

此项目已采用 [Microsoft 开放源代码行为准则](https://opensource.microsoft.com/codeofconduct/)。有关详细信息，请参阅[行为准则常见问题解答](https://opensource.microsoft.com/codeofconduct/faq/)。如有其他任何问题或意见，也可联系 [opencode@microsoft.com](mailto:opencode@microsoft.com)。

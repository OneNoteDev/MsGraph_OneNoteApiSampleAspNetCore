OneNote サービス API ASP.NET コア サンプル
---------------------------------------

作成: Microsoft Corporation、2017。現状のまま提供され、保証はいたしません。ここに記載される商標は、商標の所有者の所有物です。

デモ: https://onenoteapisamplegraph.azurewebsites.net

### はじめに

-	これは、ASP.NET サーバーの Microsoft Graph API 経由で OneNote のリソースを使用する方法を説明する簡単なサンプルです。

### 必要条件

ダウンロードしてインストールし、開発環境に合わせて構成する必要がある**ツールおよびライブラリ**

* [Visual Studio 2015 Update 3](https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs) 
  1. 「Visual Studio の特定のリリースをインストールする方法」 をクリックします。 
  
  ![Visual Studio の以前のリリースをダウンロードする](./images/HowToInstall.png)

  2. 「My.VisualStudio.com」 をクリックします。 
  
  ![「My.VisualStudio.com」 をクリックする](./images/InstallingEarlierReleases.png)

  3. [Visual Studio Enterprise 2015 Update 3 をダウンロード](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) (MSFT アカウントを使用してログインします) 
  
  ![以前のリリースをインストールする](./images/VisualStudioEnterpriseSearch.png)

* [ASP.NET Core SDK (.NET Core 1.0 用)](https://www.microsoft.com/net/download/core)

* [Visual Studio 2015 Tools](https://www.microsoft.com/net/download/core)
  
  ![Visual Studio Tools インストール](./images/VisualStudioToolsInstall.png)

### サンプルの使用

開発ツールをセットアップし、上記の必要条件をインストールしたら、

1.	リポジトリを ZIP ファイルとしてローカル コンピューターにダウンロードし、ファイルを抽出します。または、Git のローカル コピーにリポジトリを複製します。
2.	プロジェクトの .sln ファイルを Visual Studio で開きます。
3.	独自のクライアント ID、シークレット、リダイレクト URI を取得し、[Config.cs](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/src/OneNoteApiSample/Config.cs#L9) にコピーすることを強くお勧めします。独自の AppID、アプリ シークレット、リダイレクト URI は [こちら](http://developer.microsoft.com/ja-jp/graph/docs/authorization/auth_register_app_v2)から取得できます。
4.	ローカルで開発する場合は、サンプルではリダイレクト URI として http://localhost:5001/msgraphoauthcallback が使用されます。運用環境では、アプリケーションのドメインをポイントするように URI を変更する必要があります。>注意:Chrome と Firefox では Cookie を Localhost に設定できないため、Localhost にリダイレクトするように設定した場合、開発中はこれらのブラウザーでは認証が機能しません。
5.	アプリをローカルで起動するときに、「OneNoteApiSample」 構成が選択されていることを確認します。[スクリーンショット](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/images/OneNoteApiSampleConfiguration.PNG)を参照してください。
6.	アプリケーションをビルドして実行します (F5)。

### コンテンツ

その他の資料については、以下のリンクを参照してください。

-	ページの作成
	-	[シンプルな HTML ページを新しい OneNote クイックノート ページに投稿する](https://developer.microsoft.com/ja-jp/graph/docs/api-reference/beta/api/notes_post_pages)
-	ページのクエリおよび検索の実行
	-	[OneNote のページ分割されたすべてのリストを取得する](https://developer.microsoft.com/ja-jp/graph/docs/api-reference/beta/api/notes_list_pages)
-	ノートブックとセクションの管理
	-	[すべてのノートブックの一覧を取得する](https://developer.microsoft.com/ja-jp/graph/docs/api-reference/beta/api/notes_list_notebooks)
	-	[すべてのセクションの一覧を取得する](https://developer.microsoft.com/ja-jp/graph/docs/api-reference/beta/api/notes_list_sections)

#### 注意

簡単にするため、このサンプルは運用中のアプリケーションのベスト プラクティスに準拠することはありません。このコードを発送する場合は、次の操作を行うことをお勧めします。

-	アプリ シークレットをリポジトリにチェックインしない
-	サイト全体で HTTPS を要求する
-	暗号化されていない更新トークンを Cookie に保存しない

-	サンプルで使用されている **NuGet パッケージ**。これらは、セットアップ手順に記載されているとおりに、パッケージ マネージャーを使用して処理されます。これらは、ビルド時に自動的に更新されます。更新されない場合は、NuGet パッケージ マネージャーが最新であることを確認します。以下のリンクから使用しているパッケージの詳細については、こちらを参照してください。

	-	[Newtonsoft Json.NET パッケージ](http://newtonsoft.com/) は Json 解析ユーティリティを提供します。
	-	Microsoft のその他の Nuget パッケージは、project. json に記載されています。

### バージョン情報

| 日付 | 変更点 |
|--------------|--------------------------------------------------------------------------------|
| 2017 年 5 月 | OneNote リソース用に Microsoft Graph v1.0 ベース URL を利用するように更新。 |
| 2017 年 3 月 | Microsoft Graph API エンドポイントを利用するように更新。 |
| 2017 年 1 月 | 本コード サンプルの最初のパブリック リリース。 |

### その他のリソース

-	[dev.onenote.com](http://dev.onenote.com) デベロッパー センターをご覧ください
-	[StackOverflow (tagged OneNote)](http://go.microsoft.com/fwlink/?LinkID=390182) でご質問を受け付けています
-	Twitter でフォローしてください ([@onenotedev](http://www.twitter.com/onenotedev))
-	[OneNote の開発者ブログ](http://go.microsoft.com/fwlink/?LinkID=390183)をご覧ください
-	[Graph エクスプローラー](https://developer.microsoft.com/ja-jp/graph/graph-explorer)を使用して API をより深く知ってください
-	[API リファレンス](https://developer.microsoft.com/ja-jp/graph/docs/api-reference/beta/resources/notes) ドキュメント
-	[既知の問題](https://developer.microsoft.com/ja-jp/graph/docs/overview/release_notes)
-	Microsoft Graph API の[使用を開始する](https://developer.microsoft.com/ja-jp/graph/docs/get-started/get-started)

このプロジェクトでは、[Microsoft Open Source Code of Conduct (Microsoft オープン ソース倫理規定)](https://opensource.microsoft.com/codeofconduct/) が採用されています。詳細については、「[Code of Conduct の FAQ (倫理規定の FAQ)](https://opensource.microsoft.com/codeofconduct/faq/)」を参照してください。また、その他の質問やコメントがあれば、[opencode@microsoft.com](mailto:opencode@microsoft.com) までお問い合わせください。

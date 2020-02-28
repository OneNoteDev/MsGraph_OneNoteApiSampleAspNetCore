Пример использования API OneNote для ASP.NET Core
---------------------------------------

Создано Microsoft Corporation, 2017. Предоставляется как есть без гарантии. Товарные знаки, упомянутые в этой статье, являются собственностью их владельцев.

Демоверсия: https://onenoteapisamplegraph.azurewebsites.net

### Введение

-	В этом небольшом примере показано, как использовать доступ к ресурсам OneNote через API Microsoft Graph с сервера ASP.NET.

### Необходимые компоненты

**Инструменты и библиотеки**, которые требуется скачать, установить и настроить для среды разработки

* [Обновление 3 для Visual Studio 2015](https://www.visualstudio.com/en-us/news/releasenotes/vs2015-update3-vs) 
  1. Выберите "Установка специального выпуска Visual Studio": 
  
  ![Скачайте более раннюю версию Visual Studio](./images/HowToInstall.png)

  2. Выберите "My.VisualStudio.com": 
  
  ![Выберите "My.VisualStudio.com"](./images/InstallingEarlierReleases.png)

  3. [Скачать Visual Studio Enterprise 2015 с обновлением 3](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015) (вход в с помощью учетной записи MSFT) 
  
  ![Установка более ранних выпусков](./images/VisualStudioEnterpriseSearch.png)

* [Пакет SDK для ASP.NET Core (для .NET Core 1.0)](https://www.microsoft.com/net/download/core)

* [Инструменты Visual Studio 2015](https://www.microsoft.com/net/download/core)
  
  ![Установка инструментов Visual Studio](./images/VisualStudioToolsInstall.png)

### Использование примера

После настройки инструментов разработки и установки описанных выше необходимых компонентов…

1.	Скачайте репозиторий в виде ZIP-архива на локальный компьютер и извлеките из него файлы. Вы также можете клонировать репозиторий в локальную копию GIT.
2.	Откройте проект (SLN-файл) в Visual Studio.
3.	Настоятельно рекомендуется получить собственный идентификатор клиента, секрет и URI перенаправления и скопировать их в [Config.cs](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/src/OneNoteApiSample/Config.cs#L9). Вы можете получить собственный идентификатор приложения, секрет и URI перенаправления [здесь](http://developer.microsoft.com/ru-ru/graph/docs/authorization/auth_register_app_v2)
4.	Для локальной разработки в примере используется URI перенаправления http://localhost:5001/msgraphoauthcallback. Для рабочей среды этот адрес должен указывать на домен вашего приложения. >Примечание. Chrome и Firefox не позволяют устанавливать файлы cookie на localhost. Если вы решите перенаправить на localhost, проверка подлинности не будет выполняться в этих браузерах во время разработки.
5.	При локальном запуске приложения убедитесь, что выбрана конфигурация "OneNoteApiSample". См. [снимок экрана](https://github.com/OneNoteDev/OneNoteApiSampleAspNetCore/blob/master/images/OneNoteApiSampleConfiguration.PNG).
6.	Выполните сборку и запуск приложения (F5)

### Содержимое

Дополнительные сведения можно найти по ссылкам ниже.

-	Создание страниц:
	-	[Поместить простой HTML на новую страницу быстрых заметок OneNote](https://developer.microsoft.com/ru-ru/graph/docs/api-reference/beta/api/notes_post_pages)
-	Страницы запросов и поиска:
	-	[Получить список всех страниц в OneNote с разбивкой на страницы](https://developer.microsoft.com/ru-ru/graph/docs/api-reference/beta/api/notes_list_pages)
-	Управление записными книжками и разделами:
	-	[Получить список всех записных книжек](https://developer.microsoft.com/ru-ru/graph/docs/api-reference/beta/api/notes_list_notebooks)
	-	[Получить список всех разделов](https://developer.microsoft.com/ru-ru/graph/docs/api-reference/beta/api/notes_list_sections)

#### Примечание

Для простоты в этом примере не учитываются рекомендации по использованию приложения в рабочей среде. Если вы планируете предоставить этот код клиентам, рекомендуется сделать следующее:

-	Никогда не записывайте секреты приложения в репозиторий после изменения
-	Требуйте протокол HTTPS на сайте
-	Не храните незашифрованные маркеры обновления в файлах cookie

-	В примере используются **пакеты NuGet**. Они обрабатываются с помощью диспетчера пакетов, как описано в инструкциях по настройке. Пакеты должны обновляться автоматически во время построения; в противном случае убедитесь, что диспетчер пакетов NuGet обновлен. Дополнительные сведения об использованных пакетах см. по ссылкам ниже.

	-	[Пакет Newtonsoft Json.NET](http://newtonsoft.com/) предоставляет служебные программы синтаксического анализа Json.
	-	Другие пакеты NuGet от Майкрософт, перечисленные в файле project.json

### Сведения о версии

| Дата | Изменить |
| -------------- | ---------------------------------- ---------------------------------------------- |
| Май 2017 г. | Обновлена для использования базового URL-адреса Microsoft Graph версии 1.0 для ресурсов OneNote |
| Март 2017 г. | Обновлена для использования конечных точек API Microsoft Graph. |
| Январь 2017 г. | Начальный общедоступный выпуск для этого примера кода. |

### Дополнительные учебные материалы

-	Посетить центр разработчиков [dev.onenote.com](http://dev.onenote.com)
-	Свяжитесь с нами на сайте [StackOverflow (тег OneNote)](http://go.microsoft.com/fwlink/?LinkID=390182)
-	Подпишитесь на нас в [Twitter @onenotedev](http://www.twitter.com/onenotedev)
-	Читайте наш [блог для разработчиков OneNote](http://go.microsoft.com/fwlink/?LinkID=390183)
-	Исследуйте API с помощью [Graph Explorer](https://developer.microsoft.com/ru-ru/graph/graph-explorer)
-	[Справочная документация по API](https://developer.microsoft.com/ru-ru/graph/docs/api-reference/beta/resources/notes)
-	[Известные проблемы](https://developer.microsoft.com/ru-ru/graph/docs/overview/release_notes)
-	[Начало работы](https://developer.microsoft.com/ru-ru/graph/docs/get-started/get-started) с Microsoft Graph API

Этот проект соответствует [Правилам поведения разработчиков открытого кода Майкрософт](https://opensource.microsoft.com/codeofconduct/). Дополнительные сведения см. в разделе [часто задаваемых вопросов о правилах поведения](https://opensource.microsoft.com/codeofconduct/faq/). Если у вас возникли вопросы или замечания, напишите нам по адресу [opencode@microsoft.com](mailto:opencode@microsoft.com).

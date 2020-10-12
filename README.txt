This game is made with MVC, Razor and SignalR.
You can look beautiful work of SignalR on MainGame, when you have started a game with your opponent.
To see SignalR working, open 2 web browsers and open MainGame. So click "Ready" in one of these web browsers and you see on the other web browser that overall stats top of the page, your bases stats and notification changes without manually refreshing the site!



It's designed for MySQL, but it can be modified for Microsoft SQL Server too.

TO START THE APPLICATION:

1. On row 3 on appsettings.json put right data for your database

2. Write in Package Manager Console: dotnet ef database update --context WebGameContext

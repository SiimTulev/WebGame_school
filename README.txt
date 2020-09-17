This game is made with MVC, Razor and SignalR.
You can look beautiful work of SignalR on MainGame, when you have started a game with your opponent.
To see SignalR working, open 2 web browsers and open MainGame. So click "Ready" and you see that overall stats top of the page, your bases stats and notification changes without refreshing the site!



It works with MySQL for sure, I am not sure about other databases.

TO START THE APPLICATION:

1. On row 3 on appsettings.json put right data for your database

2. Write in Package Manager Console: dotnet ef database update --context WebGameContext

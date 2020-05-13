Needed programs to start WebGame: MySql Workbench, Visual Studio 2019

Steps to make it work in your visual studio:

Open program by clicking on WebGame.csproj
1.1 Right click on "Solution 'WebGame' on "Solution Explorer"

1.2 Click "Restore NuGet Packages"

Open appsettings.json. Make "WebGame" string suitable for your MySql Workbench.

Open "Models/WebGame/webgameContext.cs"

3.1 Change row 46 exactly same as you changed "appsettings.json" string.

Open "Package Manager Console" 4.1 Write "dotnet ef database update --context webgameContext"

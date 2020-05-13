Needed programs to start WebGame: MySql Workbench 8.0, Visual Studio 2019

Steps to make it work in your visual studio:

1. Open program by clicking on WebGame.csproj

1.1 Right click on "Solution 'WebGame' on "Solution Explorer"

1.2 Click "Restore NuGet Packages"

2. Open appsettings.json. Make "WebGame" string suitable for your MySql Workbench.

3. Open "Models/WebGame/webgameContext.cs"

3.1 Change row 46 exactly same as you changed string on "appsettings.json".

4. Open "Package Manager Console" 

4.1 Write "dotnet ef database update --context webgameContext"

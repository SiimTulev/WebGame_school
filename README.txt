See mäng on tehtud MVC, Razor'i ja SignalR'iga.

Põhiline Razor'i, Blazor'i ja SignalR'i töö käib MainGameRazor'i vaates.

Et näha, kuidas SignalR'i dünaamilisus töötab, ava 2 erinevat brauserit ja mängi kahe kasutajaga ühes maailmas üksteise vastu.
Kui vajutad "Ready", siis näed, et andmed liiguvad kohe edasi ilma manuaalset värskendamist tegemata.

See mäng on disainitud MySQL andmebaasile, kuigi on võimalik muuta ka mõnede koodide muutmistega MS SQL'ile sobivaks.

ET ALUSTADA PROGRAMMI:

1.  Võta lahti fail appsettings.json ja kirjuta sinna kolmandale reale oma andmed. Näide on ka toodud rida 4-le. Kustuta rida 4 ära.

2. Kirjuta Package Manager Console sisse "dotnet ef database update --context WebGameContext".

3. Alusta programmi vajutades "WebGame", MITTE "IIS Express".

4. Kasuta Chrome, et sujuvamat veebilehe tööd näha. 

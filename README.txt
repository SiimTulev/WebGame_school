See m�ng on tehtud MVC, Razor'i ja SignalR'iga.

P�hiline Razor'i ja SignalR'i t�� k�ib MainGameRazor'i vaates.

Et n�ha, kuidas SignalR'i d�naamilisus t��tab, ava 2 erinevat brauserit ja m�ngi kahe kasutajaga �hes maailmas �ksteise vastu.
Kui vajutad "Ready", siis n�ed, et andmed liiguvad kohe edasi ilma manuaalset v�rskendamist tegemata.

See m�ng on disainitud MySQL andmebaasile, kuigi on v�imalik muuta ka m�nede koodide muutmistega MS SQL'ile sobivaks.

ET ALUSTADA PROGRAMMI:

1.  V�ta lahti fail appsettings.json ja kirjuta sinna kolmandale reale oma andmed. N�ide on ka toodud rida 4-le. Kustuta rida 4 �ra.

2. Kirjuta Package Manager Console sisse "dotnet ef database update --context WebGameContext".

3. Alusta programmi vajutades "WebGame", MITTE "IIS Express".

4. Kasuta Chrome, et sujuvamat veebilehe t��d n�ha. 

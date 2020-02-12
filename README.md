# Travel Manager

Aplikacja Travel Manager służy do udostępniania jak i przeglądania planów podróży użytkowników portalu.
Główną ideą za tą aplikacją jest inspirowanie innych podróżników.

## Jak korzystać?

Aby korzystać z aplikacji użytkownicy rejestrują swoje konto w serwisie, później po zalogowaniu się mogą przeglądać posty innych użytkowników i sami je dodawać.

Użytkownicy rejestrują się, logują się i dodają posty za pomocą formualarzy, które zapisują dane w tabelach bazy danych


### Wymagania

* Visual Studio 2019/2017/2015 (Projekt wykonany za pomocą VS 2019)
* Microsoft .NET Core SDK 3.1.101
* NodeJS
* Dowolna przeglądarka internetowa, w której uruchomi się projekt

### Uruchomienie projektu

Aby uruchomic projekt na swojej maszynie należy pobrać paczkę zip z projektem i otworzyć plik z solucją w Visual Studio.
Alternatywnie można sklonować projekt bezpośrednio w Visual Studio.

Następnie należy połączyć się z bazą danych, hostowaną na platformie Microsoft Azure.
Aby to zrobić należy w Visual Studio wybrać:

```
Tools > Connect to Database
```

Następnie w okienku, które się okaże należy wybrać i uzupełnić pola tekstowe:

```
Data source: Microsoft SQL Server (SqlClient)

Server name: azuresv.database.windows.net
```
W sekcji Log on to the server:

```
Authentication: SQL Server Authentication
User name: ServerAdmin
Password: Travel2020
```
Możemy zaznaczyć pole Save my password, aby w przyszłości nie było konieczne ponowne wpisywanie hasła.

W sekcji Connect to a database:

```
Select or enter a database name: TravelManagerDB
```

## Wykonano za pomocą

* [Microsoft .NET Core MVC](https://docs.microsoft.com/pl-pl/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio)
* [Microsoft Azure](https://azure.microsoft.com/pl-pl/) - Serwis chmury

## Autorzy

* **Artur Guśpiel**
* **Krzysztof Pietrasik**
* **Piotr Barć**

## KUDOS

* Dokumentacja .NET Core
* Tutoriale internetowe
* Trip Advisor za inspirację

![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
# JWA Data Hub

Egy modern, sötét témájú ASP.NET MVC webalkalmazás, amely a *Jurassic World Alive* játék lényeit jeleníti meg egy interaktív, könnyen áttekinthető adatbázisban.

---

## Előnézet

![Preview](jwParsed_WebView/wwwroot/src.png)

---

## Funkciók

* Lények listázása táblázatos formában
* Sorbarendezés Header szerint
* Modern dark UI (Bootstrap + egyedi CSS)
* Részletes statok:

  * HP
  * Damage
  * Speed
  * Armor
  * Crit
* Ritkaság szerinti jelölések (Common → Apex → Omega)
* Gyors és letisztult megjelenítés

---

## Technológiák

* ASP.NET MVC
* C#
* Razor Views
* Bootstrap
* Egyedi CSS (Dark Theme)

---

## Projekt struktúra

```
/Controllers
/Models
/Views
    /Home
        Index.cshtml
/wwwroot
```

---

## Telepítés

1. Klónozd a repository-t:

```
git clone https://github.com/nmmiklos/jwalive_webview_mvc_datahub.git
```

2. Nyisd meg Visual Studio-ban

3. Hozz létre egy "jw" nevű adatbázist a kezelődben (xampp - phpmyadmin-hoz terveztem)

4. Importáld a wwwroot/data/creatures.sql fájlt az adatbázisba

5. Futtasd a projektet:

```
Ctrl + F5
```

---

## Adatmodell

A `Creature` modell tartalmazza:

```csharp
public class Creature
{
    public string Name { get; set; }
    public string Rarity { get; set; }
    public string Class { get; set; }
    public int? Health { get; set; }
    public int? Damage { get; set; }
    public int? Speed { get; set; }
    public int? Armor { get; set; }
    public int? Crit { get; set; }
    public string Version { get; set; }
}
```

---

## UI

A felület egy egyedi dark theme-et használ:

* Mély sötét háttér
* Kontrasztos stat színek
* Minimalista badge-ek
* Bootstrap override-ok

---

## Licenc

Ez a projekt szabadon felhasználható tanulási célokra.

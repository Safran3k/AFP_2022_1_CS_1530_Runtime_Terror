# Rendszerterv

## 1. Rendszer
A rendszer egy olyan alkalmazás, amely lehetővé teszi a felhasználók számára, hogy az 5-ös, 6-os, illetve a skandináv lottó szelvényeit fel tudják adni.

## 2. Terv
Az alkalmazás Windows Forms típusú. A fő ablak tartalmaz 3 gombot, amelyek külön-külön elvezetnek egy új ablakhoz. Ha a felhasználó rákattint az egyik gombra, a megfelelő játék ablaka fog megjelenni, és a főablak eltűnik. Ezek az ablakok fogják tartalmazni a játékokat. Az ablak, attól függően, hogy melyik játékot választotta ki, annyi checkbox-ot fog tartalmazni (pl.: ha a játékos az 5-ös lottót választja ki, akkor 90 db számozott checkbox fog megjelenni neki, amelyből kiválaszthat 5-öt). A játékosnak kötelezően ki kell választania azt a mennyiségű számot, amennyit a játék előír. Se kevesebbet, se többet nem választhat. A játék ablakában található ezentúl még egy “Szelvény leadása gomb”, aminek a megnyomásával élesedik a szelvénye. Ekkor a program random generálja az X mennyiségű nyertes számot, és a felhasználónak visszajelzi hogy melyek azok a számok amiket eltalált, és melyek azok amiket nem. Ezen kívül még található egy “Kilépés” gomb amivel a játékos a kezdőképernyőre tud navigálni (ahol kiválasztja melyik játékot akarja játszani).

## 3. Időpont
Az alkalmazás fejlesztése nagyjából 3 hetet vesz igénybe, azaz 2022.09.15-től 2022.10.06-ig tart.

## 4. Erőforrások
A projektet, a Visual Studio 2022-vel lesz megírva, C# nyelven .NET5.0 keretrendszerben.

## 5. Projektterv
Fontosabb szerepkörök:

Scrum master: Sárosi Gábor

Megrendelő: Szerencsejáték Zrt.

Backend: Futó Richárd, Huszka Dániel, Biesz Dávid

Frontend:Futó Richárd, Huszka Dániel, Biesz Dávid

## 6. Követelménylista

- A megrendelő szeretné ha az alkalmazás könnyen érthető és használható legyen.
- Illetve hogy többfajta lottószelvény kitöltésére legyen lehetőség.
- A megrendelő szeretné még ha az alkalmazásban lévő szelvények ugyanazokat az adatokat tartalmazzák, amelyek a papíralapú szelvényen vannak.

(lásd a követelményspecifikációban)

# Rendszerterv

## 1. Rendszer
A rendszer egy olyan alkalmazás, amely lehetővé teszi a felhasználók számára, hogy az 5-ös, 6-os, illetve a skandináv lottó szelvényeit fel tudják adni.

## 2. Terv
Az alkalmazás Windows Forms típusú. A fő ablak tartalmaz 3 gombot, amelyek külön-külön elvezetnek egy új ablakhoz. Ha a felhasználó rákattint az egyik gombra, a megfelelő játék ablaka fog megjelenni, és a főablak eltűnik. Ezek az ablakok fogják tartalmazni a játékokat. Az ablak, attól függően, hogy melyik játékot választotta ki, annyi checkbox-ot fog tartalmazni (pl.: ha a játékos az 5-ös lottót választja ki, akkor 90 db számozott checkbox fog megjelenni neki, amelyből kiválaszthat 5-öt). A játékosnak kötelezően ki kell választania azt a mennyiségű számot, amennyit a játék előír. Se kevesebbet, se többet nem választhat. A játék ablakában található ezentúl még egy “Szelvény leadása gomb”, aminek a megnyomásával élesedik a szelvénye. Ekkor a program random generálja az X mennyiségű nyertes számot, és a felhasználónak visszajelzi hogy melyek azok a számok amiket eltalált, és melyek azok amiket nem. Ezen kívül még található egy “Kilépés” gomb amivel a játékos a kezdőképernyőre tud navigálni (ahol kiválasztja melyik játékot akarja játszani).

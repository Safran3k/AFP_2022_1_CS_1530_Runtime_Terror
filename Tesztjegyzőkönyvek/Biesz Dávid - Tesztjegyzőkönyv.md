# Ezeket a teszteseteket végrehajtani a legtöbb kombinációval

**Tesztelő:** Biesz Dávid
**Operációs rendszer:** Windows 10  
**Tesztelés dátuma:** 2022.október.12.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Minden játék esetében a minimumnál kevesebb számot jelöltünk be, és úgy megpróbálni sorsolni | Művelet nem hajtódik végre. Egy message box felugrik, és tájékoztatja a felhasználót, hogy nem jelölt be elég számot. | Művelet nem hajtódik végre. Egy message box felugrik, és tájékoztatja a felhasználót, hogy nem jelölt be elég számot. | Nem találtam problémát.   |
| Teszt #02 | Új játék gomb megnyomása | Az előző nyertes, és választott számok eltűnnek, a felhasználó tudja használni a számgombokat | Az előző nyertes, és választott számok eltűnnek, a felhasználó tudja használni a számgombokat  | Nem találtam problémát. |
| Teszt #03 | Sorsolás gomb megnyomása | A kiválaszott számok kék, a sorsolt számok piros, és amelyeket eltaláta a felhasználó zöld színre vált. | A kiválaszott számok kék, a sorsolt számok piros, és amelyeket eltaláta a felhasználó zöld színre vált. | Nem találtam problémát.|
| Teszt #04 | Random számok generálása | A sorsolt számok mindegyike különbözik a másiktól | A művelet megfelelően végrehajtódott, tesztelésünk során nem fordult elő, hogy egynél többször sorsolta ugyanazt a számot egy játékon belül. | Nem találtam problémát |
| Teszt #05 | Címkék ellenőrzése | Sorsolás gomb megnyomása után a nyertes, és kiválasztott számokat helyesen jelenítse meg a megfelelő címkében | A művelet megfelelően működik. | Nem találtam problémát. |

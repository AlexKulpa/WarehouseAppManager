# WarehouseAppManager

Rozwiązanie pozwala pomóc zarządzać magazynem poprzez przechowywanie ile i jakich produktów jest w danym magazynie i na jakim regale, ułatwiając pracownikom komplementowanie zamówień klientów jak i pracownikom którzy muszą rozmieścić produkty w magazynie.

Poniżej został przedstawiony model relacyjny bazy danych. 

![](/4.jpg?raw=true)

Aplikacja posiada okno główne, na którym wyświetlany jest cały towar znajdujący się w wybranym aktualnie magazynie. Pierwszą kontrolką od lewej strony jest przycisk “Dodaj”, który otwiera nam okienko dodawania nowego lub istniejącego już towaru do bazy danych. Dalej znajdują się dwie listy rozwijane, jedna wyświetlająca wszystkie dostępne magazyny, natomiast druga produkty, które zostały dodane do “koszyka”. Po listach rozwijanych znajduje się kolejny przycisk, usuwający z bazy danych wszystkie towary, które znalazły się w “koszyku”. 

![](/1.jpg?raw=true)
![](/2.jpg?raw=true)
![](/3.jpg?raw=true)

Aplikacja rozdzielona jest na wiele klas, znajdujących się w odpowiednich warstwach. Wzorcem projektowym jest tutaj MVVM, przez co pierwszymi warstwami są kolejno: Model, View oraz ViewModel. Ostatnią warstwą jest DAL odpowiadająca za połączenie z bazą danych.

Warstwa DAL podzielona jest kolejno na podfoldery "Encje" oraz "Repozytoria", w których odpowiednie tabele z bazy danych mają swoje odwzorowania. Utworzony został tutaj również klasa "DBConnection", która odpowiada za wykonanie połączenia z bazą danych. Wszystkie informacje pokroju adresu IP, nazwy bazy danych oraz danych logowania znajdują się w pliku "Settings.settings". W encjach znajdują się zdefiniowane klasy, na przykład "Towar.cs", gdzie atrybuty odpowiadają kolumnom z tabeli "Towar" z bazy danych. Repozytoria natomiast odpowiadają za CRUD odpowiednich tabel z bazy danych. Zawarte w aplikacji encje jak i repozytoria odpowiadają kolejno tabelom: Magazyn, Operacja, Produkt, Towar.

Klasa modelu przechowuje w zmiennych rekordy pobrane z bazy danych (towarów i magazynów na przykład). Klasa ta jest również pośrednikiem pomiędzy ViewModel-em, a warstwą DAL, przez co zawiera odpowiednie metody do dodawania nowego towaru, aktualizowania ilości oraz usuwania produktów znajdujących się w "koszyku" korzystając z metod znajdujących się w odpowiednich repozytoriach.

Folder "View" zawiera odpowiednio pliki XML okna głównego aplikacji, okna dodawania produktu, które otwiera się w nowym oknie, oraz kontrolki użytkownika pola tekstowego przeznaczonego do wprowadzania jedynie liczb całkowitych.

W folderze "ViewModel" znajdują się katalog BaseClass potrzebny do wzorca MVVM. Odpowiednio okno główne aplikacji, jak i okno dodawania produktu posiadają swoje viewmodel-e, które zawierają logikę działania aplikacji, łącząc widoki z modelem. ViewModel-e zawierają również wszystkie polecenia, które są wywoływane poprzez elementy interfejsu aplikacji. Utworzona w tym folderze została także klasa Converter, zamieniająca wartości liczbowe na ciąg znaków i odwrotnie. Klasa ta wykorzystywana jest przez kontrolkę użytkownika pola liczbowego typu textbox.

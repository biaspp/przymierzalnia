# Przebieralnia
Ten kod to implementacja prostej aplikacji w języku C# z użyciem Windows Forms. Aplikacja ta pozwala na wybór rodzaju ubrania z listy rozwijanej i przymierzenie go na wirtualnej sylwetce. Użytkownik może wybrać spośród pięciu rodzajów ubrań: koszulki, bluzy, sukienki, spodnie i buty.
Główna klasa to Form1, która dziedziczy po klasie Form. W konstruktorze klasy dodawane są opcje do listy rozwijanej ComboBox. Po wybraniu opcji i kliknięciu przycisku "Przymierz", tworzony jest obiekt reprezentujący wybrane ubranie i wyświetlany jest na wirtualnej sylwetce. Każdy rodzaj ubrania ma swoją własną klasę, która dziedziczy po klasie Ubranie.
Klasa Form1 zawiera również obsługę zdarzeń dla przycisków i paneli, pozwalając użytkownikowi na przesuwanie okna aplikacji za pomocą przeciągania myszą. Zdarzenie MouseDown ustawia flagę isDragging na true, co oznacza, że okno jest przeciągane. Następnie pozycja kursora i okna są zapisywane, aby móc przesuwać okno o odpowiednią wartość w zdarzeniu MouseMove. Zdarzenie MouseUp resetuje flagę isDragging.
W celu umożliwienia wyświetlania obrazków reprezentujących poszczególne rodzaje ubrań, aplikacja używa kontrolki PictureBox. Obrazki są ładowane z plików z dysku twardego i wyświetlane w kontrolce po wybraniu odpowiedniego rodzaju ubrania.
W projekcie znajduje się także plik Projektowanie.cs, który zawiera definicję interfejsu IPrzymierzalny oraz klas reprezentujących poszczególne rodzaje ubrań i ich właściwości.
składa się z kilku klas, które reprezentują różne rodzaje ubrań: Koszulka, Spodnie, Sukienka, Buty i Bluza.

Każda klasa dziedziczy po klasie bazowej Ubranie, która zawiera pola Nazwa, Rozmiar, Kolor i Material, a także metody WyswietlInformacje i Przymierz. Metoda Przymierz w każdej z klas została zaimplementowana w sposób specyficzny dla danego rodzaju ubrania.

Klasa Koszulka zawiera dodatkowe pole DlugiRękaw, które informuje, czy dana koszulka jest z długim rękawem, oraz pole textBox, które umożliwia wyświetlenie informacji o przymierzanej koszulce w formularzu aplikacji.
Klasa Spodnie zawiera dodatkowe pola Kroj i Kieszenie, które informują o kroju i o tym, czy spodnie posiadają kieszenie, a także pole textBox, które umożliwia wyświetlenie informacji o przymierzanych spodniach w formularzu aplikacji.

Klasa Sukienka zawiera dodatkowe pola Wzor, Dlugosc i Dekolt, które informują o wzorze, długości i tym, czy sukienka ma dekolt, a także pole textBox, które umożliwia wyświetlenie informacji o przymierzanej sukience w formularzu aplikacji.

Klasa Buty zawiera pole textBox, które umożliwia wyświetlenie informacji o przymierzanych butach w formularzu aplikacji, a także metodę ZakladajSkarpety, która wyświetla informację o zakładaniu skarpet do butów.
Klasa Bluza zawiera dodatkowe pole Podkoszulek, które informuje o tym, jaka koszulka jest pod bluzą, pole Kaptur, które informuje, czy bluza posiada kaptur, a także pole textBox, które umożliwia wyświetlenie informacji o przymierzanej bluzie w formularzu aplikacji.

Wszystkie klasy są wewnętrzne i znajdują się w klasie Projektowanie. Aplikacja wykorzystuje też przestrzeń nazw System.Collections.Generic oraz System.Windows.Forms, aby móc korzystać z kolekcji generycznych i elementów interfejsu użytkownika, takich jak TextBox.

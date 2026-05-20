<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <title>Zestawy Komputerowe</title>
    <style>
        .zestaw {
            border: 2px solid #333;
            padding: 15px;
            margin: 10px;
            width: 300px;
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            display: inline-block;
            vertical-align: top;
        }
        .zestaw h2 {
            margin-top: 0;
            color: #0056b3;
        }
        .cena {
            font-weight: bold;
            color: green;
            font-size: 1.2em;
        }
    </style>
</head>
<body>

    <h1>Moje Zestawy Komputerowe</h1>

    <?php
    // Definicja danych dla pierwszego zestawu
    $zestaw1 = [
        "procesor" => "Intel Core i5-13400F",
        "dysk" => "SSD 1TB NVMe",
        "ram" => "16GB DDR4 3200MHz",
        "grafika" => "NVIDIA RTX 3060",
        "plyta" => "Gigabyte B760M",
        "monitor" => "iiyama G-Master 24\"",
        "cena" => "3456 zł"
    ];

    // Definicja danych dla drugiego zestawu
    $zestaw2 = [
        "procesor" => "AMD Ryzen 5 5600",
        "dysk" => "SSD 1TB Kingston",
        "ram" => "16GB DDR4 3600MHz",
        "grafika" => "AMD Radeon RX 6700 XT",
        "plyta" => "MSI B550-A PRO",
        "monitor" => "AOC Gaming 24\"",
        "cena" => "3456 zł"
    ];

    // Funkcja do wyświetlania bloku div (zagnieżdżony kod HTML w PHP)
    function wyswietlZestaw($dane, $numer) {
        echo "<div class='zestaw'>";
        echo "<h2>Zestaw nr $numer</h2>";
        echo "<p><strong>Procesor:</strong> " . $dane['procesor'] . "</p>";
        echo "<p><strong>Dysk:</strong> " . $dane['dysk'] . "</p>";
        echo "<p><strong>RAM:</strong> " . $dane['ram'] . "</p>";
        echo "<p><strong>Karta graficzna:</strong> " . $dane['grafika'] . "</p>";
        echo "<p><strong>Płyta główna:</strong> " . $dane['plyta'] . "</p>";
        echo "<p><strong>Monitor:</strong> " . $dane['monitor'] . "</p>";
        echo "<p class='cena'>Cena: " . $dane['cena'] . "</p>";
        echo "</div>";
    }

    // Wywołanie funkcji dla obu zestawów
    wyswietlZestaw($zestaw1, 1);
    wyswietlZestaw($zestaw2, 2);
    ?>

</body>
</html>
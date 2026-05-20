<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Program 1 - Dane użytkownika</title>
    <style>
        body { font-family: Arial, sans-serif; margin: 20px; line-height: 1.6; }
        .dane { font-weight: bold; color: #2c3e50; }
    </style>
</head>
<body>

    <h1>Informacje o autorze</h1>

    <?php
        // Definiowanie zmiennych z danymi
        $imieNazwisko = "Jan Kowalski";
        $adres = "ul. Programistów 15, 00-001 Warszawa";

        // Wyświetlanie danych za pomocą PHP
        echo "<p>Imię i nazwisko: <span class='dane'>$imieNazwisko</span></p>";
        echo "<p>Adres: <span class='dane'>$adres</span></p>";
    ?>

</body>
</html>
/*
Imię i Nazwisko: Dawid Kowalski
Numer albumu: s227811
Aktualny rok akademicki: 2
Numer grupy: 1
Treść projektu: Program oblicza przybliżenie liczby pi metodą szeregu Leibniza przy użyciu jednostki FPU.
*/

#include <stdio.h>

extern float oblicz_pi(long long iteracje);

int main() {
    long long iteracje;
    int precyzja;
    int kontynuuj = 1;

    while (kontynuuj) {
        printf("====================================================\n");
        printf("Student: Dawid Kowalski | Album: s227811\n");
        printf("Rok: 2 | Grupa: 1\n");
        printf("Projekt: Obliczanie przyblizenia liczby PI\n");
        printf("====================================================\n\n");

        printf("INSTRUKCJA UZYTKOWANIA:\n");
        printf("1. Program oblicza liczbe PI korzystajac z szeregu Leibniza.\n");
        printf("2. Nalezy podac liczbe iteracji (zalecane min. 1 000 000).\n");
        printf("3. Nalezy podac liczbe miejsc po przecinku (0-10).\n");
        printf("4. Wpisanie 0 jako liczby iteracji konczy program.\n\n");

        printf("Podaj liczbe iteracji (lub 0 aby wyjsc): ");
        if (scanf("%lld", &iteracje) != 1) {
            printf("Blad: Niepoprawny format.\n");
            while (getchar() != '\n');
            continue;
        }

        if (iteracje <= 0) break;

        printf("Do ilu miejsc po przecinku zaokraglic wynik? (0-10): ");
        if (scanf("%d", &precyzja) != 1) {
            printf("Blad: Niepoprawny format.\n");
            while (getchar() != '\n');
            continue;
        }

        if (precyzja < 0) precyzja = 0;
        if (precyzja > 10) precyzja = 10;

        float wynik = oblicz_pi(iteracje);

        printf("\n>>> Obliczony wynik PI: %.*f\n", precyzja, wynik);
        printf(">>> Wartosc float (pelna): %f\n", wynik);

        printf("\nCzy chcesz wykonac kolejne obliczenie? (1-Tak, 0-Nie): ");
        if (scanf("%d", &kontynuuj) != 1) kontynuuj = 0;
        printf("\n\n");
    }

    return 0;
}
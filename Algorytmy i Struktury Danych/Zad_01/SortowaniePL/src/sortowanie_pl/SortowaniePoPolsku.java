/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sortowanie_pl;

/**
 * Sortowanie po polsku - właściwe sortowanie
 * @author Piotr Wrzeciono
 */
public class SortowaniePoPolsku
{
    private final static int LITERY_RÓWNE = 0;
    private final static int LITERA_A_WIĘKSZA = 1;
    private final static int LITERA_A_MNIEJSZA = -1;
    
    private final static int TEKSTY_TAKIE_SAME = 0;
    private final static int TEKST1_WIĘKSZY = 1;
    private final static int TEKST1_MNIEJSZY = -1;

    /**
    * Metoda porównująca ze sobą dwa znaki char
    * @param LiteraA Litera A
    * @param LiteraB Litera B
    * @return Rezultat porównania<br/>Gdy LiteraA = LiteraB, zwraca wartość LITERY_RÓWNE,
    * gdy LiteraA jest większa niż LiteraB, zwraca wartość LITERA_A_WIĘKSZA,
    * gdy LiteraA jest mniejsza od LiteraB,zwraca wartość LITERA_A_MNIEJSZA.
    */
    private static int PorównajLitery(char LiteraA, char LiteraB)
    {
        double ZnakA;
        double ZnakB;
        int wynik;

        ZnakA = KodZnakuPL(LiteraA);
        ZnakB = KodZnakuPL(LiteraB);
        wynik = LITERY_RÓWNE;

        if(ZnakA > ZnakB) wynik = LITERA_A_WIĘKSZA;
        if(ZnakA < ZnakB) wynik = LITERA_A_MNIEJSZA;

        return wynik;

    }//Koniec metody porównującej


    /**
     * Kodowanie polskich znaków diakrytycznych za pomocą zmiennej double
     * @param Znak Znak w UNICODE.
     * @return Kod znaku polskiego
     */
    private static double KodZnakuPL(char Znak)
    {
        double kod;

        kod = (double)Znak;

            //Korekcja wartości kodów dla polskich znaków diakrytycznych
            //(jedna z wielu możliwości!)
            if(Znak == 'Ą') kod = 0.5 + (double)'A';
            if(Znak == 'ą') kod = 0.5 + (double)'a';
            if(Znak == 'Ć') kod = 0.5 + (double)'C';
            if(Znak == 'ć') kod = 0.5 + (double)'c';
            if(Znak == 'Ę') kod = 0.5 + (double)'E';
            if(Znak == 'ę') kod = 0.5 + (double)'e';
            if(Znak == 'Ł') kod = 0.5 + (double)'L';
            if(Znak == 'ł') kod = 0.5 + (double)'l';
            if(Znak == 'Ń') kod = 0.5 + (double)'N';
            if(Znak == 'ń') kod = 0.5 + (double)'n';
            if(Znak == 'Ó') kod = 0.5 + (double)'O';
            if(Znak == 'ó') kod = 0.5 + (double)'o';
            if(Znak == 'Ś') kod = 0.5 + (double)'S';
            if(Znak == 'ś') kod = 0.5 + (double)'s';
            if(Znak == 'Ź') kod = 0.25 + (double)'Z';
            if(Znak == 'ź') kod = 0.25 + (double)'z';
            if(Znak == 'Ż') kod = 0.75 + (double)'Z';
            if(Znak == 'ż') kod = 0.75 + (double)'z';
        
        return kod;
    }//Koniec metody zwracającej kod znaku PL

    /**
    * Metoda porównująca ze sobą dwa teksty.
    * @param Tekst1 Tekst1
    * @param Tekst2 Tekst2
    * @return Wartość TEKSTY_TAKIE_SAME, gdy teksty są równe. Gdy Tekst1 jest większy, to zwraca 
    * wartość TEKST1_WIĘKSZY, a gdy Tekst1 jest mniejszy, otrzymujemy wartość TEKST1_MNIEJSZY.
    */
    private static int PorównajDwaTeksty(String Tekst1, String Tekst2)
    {
        char[] TablicaTekstu1;
        char[] TablicaTekstu2;
        int rezultat;
        int i;
        int LiczbaLiter;
        int RezultatPorównaniaZnaków;

        TablicaTekstu1 = Tekst1.toCharArray();
        TablicaTekstu2 = Tekst2.toCharArray();
        rezultat = TEKSTY_TAKIE_SAME;
        i = 0;

        if(TablicaTekstu1.length <= TablicaTekstu2.length)
        {
            LiczbaLiter = TablicaTekstu1.length;
        }else
        {
            LiczbaLiter = TablicaTekstu2.length;
        }//end if

        while((i < LiczbaLiter) && (rezultat == TEKSTY_TAKIE_SAME))
        {
            RezultatPorównaniaZnaków = PorównajLitery(TablicaTekstu1[i],TablicaTekstu2[i]);

            if(RezultatPorównaniaZnaków != LITERY_RÓWNE)
            {
                if(RezultatPorównaniaZnaków == LITERA_A_WIĘKSZA) rezultat = TEKST1_WIĘKSZY;
                if(RezultatPorównaniaZnaków == LITERA_A_MNIEJSZA) rezultat = TEKST1_MNIEJSZY;
            }//end if

            i++;

        }//koniec pętli while

        if(rezultat == TEKSTY_TAKIE_SAME)
        {
            if(TablicaTekstu1.length > TablicaTekstu2.length) rezultat = TEKST1_WIĘKSZY;
            if(TablicaTekstu1.length < TablicaTekstu2.length) rezultat = TEKST1_MNIEJSZY;
        }//end if

        return rezultat;

    }//Koniec metody porównującej dwa teksty


    /**
     * Sortowanie tablicy tekstów.
     * @param TablicaTekstów Tablica tekstów do posortowania. Po wywołaniu tej metody,
     * tablica wejściowa jest posortowana według porządku języka polskiego.
     */
    public static void SortowanieWyrazówPL(String[] TablicaTekstów)
    {
        int i;
        int j;
        int rezultat;
        String ZmiennaPomocnicza;


        for(i = 0; i < TablicaTekstów.length - 1; i++)
        {
            for(j = i + 1; j < TablicaTekstów.length; j++)
            {
                rezultat = PorównajDwaTeksty(TablicaTekstów[i],TablicaTekstów[j]);

                if(rezultat == TEKST1_WIĘKSZY)
                {
                    ZmiennaPomocnicza = TablicaTekstów[i];
                    TablicaTekstów[i] = TablicaTekstów[j];
                    TablicaTekstów[j] = ZmiennaPomocnicza;
                }//end if
            }//next j
        }//next i

    }//Koniec sortowania tablicy tekstowej
                
}//Koniec klasy sortującej

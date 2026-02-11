import java.io.*;

public class testFib
{
    public static String getTekst(String zachęta)
    {
        Console konsola;
        String tekst;

        konsola = System.console();

        System.out.print(zachęta);
        tekst = konsola.readLine();

        return tekst.trim();
    }//Koniec getTekst

    public static long getLong(String zachęta)
    {
        long wynik;

        wynik = Long.decode(getTekst(zachęta));

        return wynik;
    }//Koniec getLong

    public static void main(String arghh[])
    {
        fibonacci fib;
        long n;
        long wynik;
        double wynik_d;

        fib = new fibonacci();

        System.out.println();

        n = getLong("Podaj wartość n ........ ");

        System.out.println("---------------------------");
        System.out.println("Rekurencja:");
        wynik = fib.rekurencja(n);
        System.out.println("Maks zagłębień ......... " + fib.getMaksimum());
        System.out.println("Wynik .................. " + wynik);
        System.out.println("Liczba \"push\" ........ " + fib.getIlePush());

        System.out.println("---------------------------");
        System.out.println("Iteracja:");
        fib.UsuńLicznik();
        wynik = fib.iteracja(n);
        System.out.println("Liczba iteracji ........ " + fib.getMaksimum());
        System.out.println("Wynik .................. " + wynik);

        System.out.println("---------------------------");
        System.out.println("Wzór Bineta:");
        fib.UsuńLicznik();
        wynik_d = fib.binet(n);
        System.out.println("Liczba iteracji ........ " + fib.getMaksimum());
        System.out.println("Wynik .................. " + wynik_d);

    }//Koniec main

}//Koniec klasy

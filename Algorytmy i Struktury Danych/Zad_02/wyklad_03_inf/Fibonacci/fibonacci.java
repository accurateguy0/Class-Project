public class fibonacci
{
    private Obciazenie licznik;

    public fibonacci()
    {
        licznik = null;
    }//Koniec konstruktora

    public int getMaksimum()
    {
        int wynik;

        wynik = 0;

        if(licznik == null)
        {
            wynik = -1;
        }else
        {
            wynik = licznik.getMaksimum();
        }//end if

        return wynik;

    }//koniec getMaksimum

    public long rekurencja(long n)
    {
        long wynik;

        wynik = 0;

        //Pomiar obciążenia
        if(licznik == null)
        {
            licznik = new Obciazenie();
        }else
        {
            licznik.push();
        }//end if

        if(n <= 0)
        {
            wynik = 0;
        }else if(n == 1)
        {
            wynik = 1;
        }else
        {
            wynik = rekurencja(n-1) + rekurencja(n-2);
        }//end if

        licznik.pop(); //Powrót z rekurencji

        return wynik;


    }//Koniec implementacji rekurencji

    public void UsuńLicznik()
    {
        licznik = null;
    }

    public long iteracja(long n)
    {
        long wynik;
        long rodzice;
        long dziadkowie;

        wynik = 0;

        if(licznik == null)
        {
            licznik = new Obciazenie();
        }//end if

        if(n <= 0)
        {
            wynik = 0;
            licznik.push();
        }else if(n == 1)
        {
            wynik = 1;
            licznik.push();
        }else
        {
            dziadkowie = 0;
            rodzice = 1;
            licznik.push();

            while(n > 1)
            {
                wynik = rodzice + dziadkowie;

                dziadkowie = rodzice;
                rodzice = wynik;

                n--;
                licznik.push();
            }//end while

        }//end if

        return wynik;
    }//Koniec implementacji iteracyjnej

    public double binet(long n)
    {
        double sqr5;
        double sqr5_plus;
        double sqr5_minus;
        double wynik;

        wynik = -1;

        if(licznik == null) licznik = new Obciazenie();

        licznik.push();

        sqr5 = Math.sqrt(5.0);

        sqr5_plus = (1.0 + sqr5)/2;
        sqr5_minus = (1.0 - sqr5)/2;

        if(n >= 0)
        {

            wynik = (1/sqr5)*(Math.pow(sqr5_plus,(double)n) - Math.pow(sqr5_minus,(double)n));

        }//end if

        return wynik;
    }//Koniec metody binet

    public int getIlePush()
    {
        if(licznik == null)
        {
            return -1;
        }else
        {
            return licznik.getIlePush();
        }
    }

}//Koniec klasy

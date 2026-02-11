public class Obciazenie
{
    private int BieżącaLiczbaPoziomów;
    private int MaksymalnaLiczbaPoziomów;

    private int LicznikPush;

    public Obciazenie()
    {
        BieżącaLiczbaPoziomów = 0;
        MaksymalnaLiczbaPoziomów = 0;
        LicznikPush = 0;
    } //Koniec konstruktora

    public int getBieżącąLiczbęPoziomów()
    {
        return BieżącaLiczbaPoziomów;
    }

    public int getMaksimum()
    {
        return MaksymalnaLiczbaPoziomów;
    }

    public void push()
    {
        BieżącaLiczbaPoziomów++;

        if(MaksymalnaLiczbaPoziomów < BieżącaLiczbaPoziomów)
        {
            MaksymalnaLiczbaPoziomów = BieżącaLiczbaPoziomów;
        }

        LicznikPush++;

    }//Koniec metody push


    public int getIlePush()
    {
        return LicznikPush;
    }

    public void pop()
    {
        BieżącaLiczbaPoziomów--;
    }//Koniec metody pop

} //Koniec klasy

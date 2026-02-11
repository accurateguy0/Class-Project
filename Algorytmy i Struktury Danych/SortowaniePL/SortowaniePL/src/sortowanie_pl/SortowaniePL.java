/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sortowanie_pl;

/**
 * Sortowanie polskich wyrazów - UNICODE
 * @author Piotr Wrzeciono
 */
public class SortowaniePL {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        //Tablica do posortowania
	String[] Tablica = {"mający", "mieć", "ma", "macie", "mają", "mając", "mająca", "mającą", "mające", "mającego", "mającej", "mającemu", "mających", "mającym", "mającymi", "mam", "mamy", "masz", "miał", "miała", "miałaby", "miałabym", "miałabyś", "miałam", "miałaś", "miałby", "miałbym", "miałbyś", "miałem", "miałeś", "miało", "miałoby", "miały", "miałyby", "miałybyście", "miałybyśmy", "miałyście", "miałyśmy", "miana", "mianą", "miane", "mianego", "mianej", "mianemu", "miani", "miano", "miany", "mianych", "mianym", "mianymi", "miej", "miejcie", "miejcież", "miejmy", "miejmyż", "miejże", "mieli", "mieliby", "mielibyście", "mielibyśmy", "mieliście", "mieliśmy", "mienia", "mieniach", "mieniami", "mienie", "mieniem", "mieniom", "mieniu", "mień", "niemająca", "niemającą", "niemające", "niemającego", "niemającej", "niemającemu", "niemający", "niemających", "niemającym", "niemającymi", "niemiana", "niemianą", "niemiane", "niemianego", "niemianej", "niemianemu", "niemiani", "niemiany", "niemianych", "niemianym", "niemianymi", "niemienia", "niemieniach", "niemieniami", "niemienie", "niemieniem", "niemieniom", "niemieniu", "niemień"};

	System.out.println("-----------Tablica przed sortowaniem-----------");
	PokażTablicę(Tablica);

	SortowaniePoPolsku.SortowanieWyrazówPL(Tablica);

	System.out.println("------------Tablica po posortowaniu-----------");
	PokażTablicę(Tablica);
        
    }//Koniec metody main
    
    private static void PokażTablicę(String[] Tablica)
    {
        int i;

	for(i = 0; i < Tablica.length; i++)
	{
            System.out.println("Tablica[" + i + "] = '" + Tablica[i] + "'");
	}//next i

    }//Koniec metody PokażTablicę
    
}//Koniec klasy

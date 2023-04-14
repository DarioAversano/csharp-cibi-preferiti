// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

/*

La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Il vostro cibo top (prima posizione della classifica
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Cercate per ogni richiesta che viene fatta di preparare le rispettive funzioni  e di usarle nel vostro programma principale!
Le modalità di consegna sono le solite: repo GitHub, commit e push
BONUS
Chiedere all'utente quanti cibi preferiti ha, e farglieli inserite da input della Console nell'array.
Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Potrebbe essere interessante creare una funzione 
chiamata indiciMedianaArray(int lunghezzaArray) che vi restituisce l'indice della posizione mediana (che restituisca gli indici delle eventuali posizioni mediani)
   e poi fare una funzione (StampaArrayMediana) che si occupa di fare tutto il lavoro con  la funzione precedente e richiedendo direttamente l'intero array. 
   Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica. 

   */

// Cibi preferiti.
string[] favoriteFood = { "Pizza", "Sushi", "Pollo", "Spaghetti", "Salmone" };

// Lunghezza Array
Console.WriteLine("La lunghezza dell'array è di: " + favoriteFood.Length);

// Cibo preferito first
Console.WriteLine("Il primo preferito è: " + favoriteFood[0]);

// cibo preferito last
Console.WriteLine("l'ultimo preferito è: " + favoriteFood[4]);

// Elenco dei cibi
Console.WriteLine("Elenco cibi preferiti:");



PrintArrayString(favoriteFood);

void PrintArrayString(string[] arrayString)
{
    for (int i = 0; i < arrayString.Length; i++)
    {
    Console.WriteLine((i + 1) + " " + arrayString[i]);  
            }
        }




 
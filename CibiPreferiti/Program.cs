// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = {"Cioccolata", "Pizza", "Bagnacauda", "Pasta", "Pesce"};

Console.WriteLine("Esercizio 1");

var lunghezza = cibiPreferiti.Length;

// lunghezza della stringa
Console.WriteLine("La stringa è lunga " + lunghezza);

//elenco della lista
for (int i = 0; i < lunghezza; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

//first class
var firstClass = cibiPreferiti[0];
Console.WriteLine("In prima posizione abbiamo " + firstClass);

//last class
var lastClass = cibiPreferiti[lunghezza-1];
Console.WriteLine("In ultima posizione abbiamo " + lastClass);

//

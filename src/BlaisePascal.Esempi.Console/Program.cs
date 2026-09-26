public class Program // questa è una classe 
{
    // metodo di entrata per esecuzione del codice 
    public static void Main()
    {
   
        Console.WriteLine("Benvenuto nella libreria Easy Class 3E!");


        Console.WriteLine("Inserisci il nome del cliente"); // stampo a video il messaggio per chiedere il nome del cliente
        
        // Console.Read<Line() mi permette di leggere l'input
        string nomeCliente = Console.ReadLine(); // dichiarazione + assegnazione
        Console.WriteLine($"Benvenuto {nomeCliente} nella easy class 3E");


        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione

        int numeroPacchiComprati = Console.Read();

        Console.WriteLine("Inserisci il tipo di spedizione");
        string tipoConsegna = Console.ReadLine(); // dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;


        // $ è il carattere speciale per l'interpolazione delle stringhe
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo tatale è: {costoTotale} ");
    }
}
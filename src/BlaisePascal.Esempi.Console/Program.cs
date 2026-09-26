public class Program // questa è una classe 
{
    // metodo di entrata per esecuzione del codice 
    public static void Main()
    {
   
        Console.WriteLine("Benvenuto nella libreria Easy Library 3E!");

        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione
        costoSpedizioneSingoloPacco = 10; // assegnazione

        int numeroPacchiComprati = 2;
        
        string tipoConsegna = "Standard"; // dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;


        // $ è il carattere speciale per l'interpolazione delle stringhe
        Console.WriteLine($"Il tipo di consegna selezionato è: {tipoConsegna} e il costo tatale è: {costoTotale} ");
    }
}
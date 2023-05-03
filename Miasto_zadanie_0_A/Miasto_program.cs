using Miasto_Zadanie_0_A;

internal class Miasto_program
{
    static void Main(string[] args)
    {
        List<Miasto> miasta = new List<Miasto>
    {
        new Miasto("Gdynia", 243770, 130.79),
        new Miasto("Gdańsk", 486022, 263.44),
        new Miasto("Sopot", 32474, 17.28)
    };

        foreach (Miasto miasto in miasta)
        {
            Console.WriteLine("Gęstość zaludnienia miasta {0} wynosi {1} os/km2", miasto.Nazwa, miasto.GestoscZaludnienia);
        }
    }
}
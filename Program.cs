// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Int32 number1 = 5;                                     
        Int32 number2 = 10;

        Console.WriteLine($"Sumą 2+2 jest {2 + 2}");                                        //Wyświetlenie wyniku dodawania dwóch liczb w konsoli
        Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");
        
        
        number1 = Int32.Parse(args[0]);                                                     //Parsowanie (konwersja) wartości przekazanej jako argument w linii poleceń na typ Int32
        number2 = Int32.Parse(args[1]);                                                     //Parsowanie (konwersja) wartości przekazanej jako argument w linii poleceń na typ Int32
        Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");          //Wyświetlenie wyniku dodawania dwóch liczb w konsoli
        
        
        
        
        // Console.WriteLine("TROLORLOR");
        // Console.WriteLine("Witam w mojej aplikacji!");
        // Console.WriteLine($"Mariusz jest {args[0]}");                                        //$"Tekst {args[0]}") Wyświetla tekst z wartością przekazaną jako argument w linii poleceń = Tekst + wartość argumentu

        // Console.WriteLine($"Sumą 32+24 jest {32+24}");                                       //Wywołanie funkcji Sum i wyświetlenie wyniku w konsoli - int32 informuje o typie danych liczby całkowitej
        // Console.WriteLine($"Sumą {number1} + {number2} jest {number1 + number2}");           //Wyświetlenie wyniku dodawania dwóch liczb w konsoli
    }
}
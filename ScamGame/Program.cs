using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Witaj, jak masz na imię?");
        string name = Console.ReadLine();
        Console.WriteLine(name + ", masz ochotę na krótką grę? (Tak/Nie)");
        string odp = Console.ReadLine();

        if (odp == "Tak")
        {
            Console.WriteLine("Zasady: Zostaną wygenerowane 3 liczby od 0 do 10.");
            Console.WriteLine("Jeżeli suma tych liczb będzie wynosić więcej niż 20, wiszę Ci dychę.");
            Console.WriteLine("Jeżeli po ich zsumowaniu wyjdzie 20 lub mniej, Ty wisisz mi dychę.");
            Console.WriteLine("Zrozumiano? (Tak/Nie)");
            string odp2 = Console.ReadLine();

            if (odp2 == "Tak")
            {
                Console.WriteLine("Oto twój wynik:");

                Random ran = new Random();

                int num1 = ran.Next(0, 10);
                int num2 = ran.Next(0, 10);
                int num3 = ran.Next(0, 10);

                int numsum = num1 + num2 + num3;

                if (numsum > 20)
                {
                    numsum -= 10;
                }

                Console.WriteLine(numsum);

                if (numsum > 20)
                {
                    Console.WriteLine("Wygrałeś, cholera...");
                }
                else if (numsum <= 20)
                {
                    Console.WriteLine("Przegrałeś, dawaj kasę!");
                }
            }
            else if (odp2 == "Nie")
            {
                Console.WriteLine("Z debilami nie gram!");
            }
        }
        else if (odp == "Nie")
        {
            Console.WriteLine("Spierdalaj!");
        }
        
        Console.ReadKey();
    }
}
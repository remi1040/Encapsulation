using Encapsulation;

class Program
{
    public static void Main(string[] args)
    {
        float number1;
        int number2;
        int number3;

        while (true)
        {
            Console.WriteLine("Entrez une quatité de biere en litres: ");
            float.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Entrez un nombre de bouteilles de biere disponible : ");
            int.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Entrez un nombre de capsule de biere disponible : ");
            int.TryParse(Console.ReadLine(), out number3);

            if (number1 > 0.33f && number2 > 0 && number3 > 0)
            {
                break;
            }

            
        }

        BeerEncapsulator b1 = new BeerEncapsulator(number1, number2, number3);
        Console.WriteLine(b1.ProduceEncapsulatedBeerBottles(5));

    }
}
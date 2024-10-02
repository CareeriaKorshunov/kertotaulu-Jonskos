namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args) {
            int luku;
            Console.Write("Anna luku: ");
            while(!int.TryParse(Console.ReadLine(), out luku)) {
                Console.Write("Anna luku: ");
            }

            Console.WriteLine();
            Console.WriteLine($"Antamasi luvun ({luku}) kertotaulu:");
            for (int i = 1; i < 11; i++) {
                Console.WriteLine($"{luku} * {i} = {luku * i}");
            }

        }

    }
    }


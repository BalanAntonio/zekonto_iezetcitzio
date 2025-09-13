namespace zekonto_iezetcitzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrei;
            int inp,    cambi = 0;
            bool giaFatto = false;

            do
            {
                if(giaFatto) { Console.WriteLine("Errore: inserire di nuovo il numero di elementi: "); }
                else { giaFatto = true; Console.WriteLine("Inserire il numero di elementi: "); }
                    
                int.TryParse(Console.ReadLine(), out inp);

            } while (inp <= 0);

            arrei = new int[inp];

            Console.WriteLine("Inserire gli elementi");

            while (!int.TryParse(Console.ReadLine(), out arrei[0]))
            {
                Console.WriteLine("Errore: inserire di nuovo l'elemento");
            }


            for (int i = 1; i < inp; i++)
            {
                while(!int.TryParse(Console.ReadLine(),out arrei[i]))
                {
                    Console.WriteLine("Errore: inserire di nuovo l'elemento");
                }

                int test = arrei[i] * arrei[i-1];   //
                if (test < 0) { cambi++; }
            }
            Console.WriteLine($"Numero di cambi totali: {cambi}");
        }
    }
}

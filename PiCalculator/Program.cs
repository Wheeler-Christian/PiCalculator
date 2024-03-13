namespace PiCalculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // PI calculator using the Nilakantha Series
            // PI =  3 + 4/(2*3*4) - 4/(4*5*6) + 4/(6*7*8) - 4/(8*9*10)
            Console.WriteLine("PI Calculator");

            decimal sum = 3;

            for(int i = 2; i < 1000; i += 2) { 
                decimal term = (decimal)4/(i*(i+1)*(i+2));
                if(i % 4 == 0)
                {
                    sum -= term;
                }
                else
                {
                    sum += term;
                }

                Console.WriteLine(sum);
            }

            Console.WriteLine("PI is approximately = " + sum);
        }
    }
}

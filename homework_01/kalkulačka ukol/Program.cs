using System;

namespace CalculatorApp
{
    class CalculatorContext
    {
        IOperation opStrategy;
        public int executeStrategy()
        {
            return opStrategy.execute(a , b);
        }
        int a;
        int b;
        public CalculatorContext(int a ,int b, IOperation opStrategy)
        {
            
            this.a = a;
            this.b = b;
            this.opStrategy = opStrategy;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Vyberte operaci:");
                Console.WriteLine("1 - Sčítání");
                Console.WriteLine("2 - Odčítání");
                Console.WriteLine("3 - Dělení");
                Console.WriteLine("0 - Konec");

                int volba = Convert.ToInt32(Console.ReadLine());

                if (volba == 0)
                    break;

                Console.Write("Zadejte první číslo: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Zadejte druhé číslo: ");
                int b = Convert.ToInt32(Console.ReadLine());

                double vysledek = 0;
                IOperation operace;
                switch (volba)
                {
                    case 1:
                        operace = new OpAdd();
                        break;
                    case 2:
                        operace = new OpSub();
                        break;
                    case 3:
                        operace = new OpMagic();
                        break;
                    default:
                        Console.WriteLine("Neplatná volba.");
                        continue;
                        break;
                }
                CalculatorContext context = new CalculatorContext(a, b, operace);

                Console.WriteLine("Výsledek: " + context.executeStrategy());
            }
        }



    }
    interface IOperation
    {
        int execute(int a, int b);

    }
    class OpAdd : IOperation
    {

        int IOperation.execute(int a, int b)
        {
           return a + b;
        }
    }
    class OpSub : IOperation
    {
        int IOperation.execute(int a, int b)
        {
            return a - b;
        }

    }
    class OpMagic : IOperation
    {

        int IOperation.execute(int a, int b)
        {

            return a / b;
        }
    }
}
using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           
            //int p;
            //float a;

            Console.WriteLine("Digite seu Peso");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua Altura");
            //float a = Convert.ToInt32(Console.ReadLine());
            float a;
            if (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Not a valid float");
            }
            else
            {
                Console.WriteLine(a);
            }
            //var IMC = new Tuple<int,float>(p,a);

            // USA-SE PONTO COMO FLOAT EM C#
            float x = p / (a * a);

            Console.WriteLine("\nIMC = " + x);
            Console.WriteLine("\nClassificação");
            if (x < 18.5)
            {
                Console.WriteLine("Peso Baixo, recomenda-se ir a um nutricionista para mais informações");

            }

            else if (x >= 18.5 && x <= 24.9)
            {
                Console.WriteLine("Peso Normal, continue com a boa dieta e pratica de esportes");
            }

            else if (x >= 25 && x <= 29.9)
            {
                Console.WriteLine("Sobrepeso, sempre fique atento a sua saude, consulte seu médico ou nutricionista");
            }

            else if (x >= 30 && x <= 34.9)
            {
                Console.WriteLine("Obesidade Grau1, procure um medico o quanto antes");
            }

            else if (x >= 35 && x <= 39.9)
            {
                Console.WriteLine("Obesidade Severa Grau 2, procure um medico o quanto antes");
            }

            else if (x >= 40)
            {
                Console.WriteLine("Obesidade Mórbida Grau 3, continue com a boa dieta e pratica de esportes");
            }

        }


       
    }
}

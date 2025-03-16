using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos_c_sharp.Introducao
{
    class Var_and_Const_Values
    {

        static void Main(string[] args)
        {
            // Char - Um único caractere alfanumérico:
            Console.WriteLine('G');

            char userOption = 'S'; // Declaração e atribuição de valor à variável
            Console.WriteLine(userOption);

            // String - Grupo de caracteres:
            Console.WriteLine("Grupo");

            string firstName = "Clara"; // Declaração e atribuição de valor à variável
            Console.WriteLine(firstName);

            // Int - Números inteiros:
            Console.WriteLine(123); 

            int gameScore = 93; // Declaração e atribuição de valor à variável
            Console.WriteLine(gameScore); 

            // Float, double, decimal - Números decimais:
            Console.WriteLine(0.233F); //Sufixo F/f - Número float
            Console.WriteLine(2.6354); //Sem sufixo - Número double
            Console.WriteLine(2.150m); //Sufixo M/m - Número decimal

            double particlesPerMillion = 1.6; // Declaração e atribuição de valor à variável
            Console.WriteLine(particlesPerMillion);

            //Bool - Booleanos (Verdadeiro ou Falso):
            Console.WriteLine(true);
            Console.WriteLine(false);

            bool processedCustomer = false; // Declaração e atribuição de valor à variável
            Console.WriteLine(processedCustomer);


            // Variáveis locais de tipo implicito:
            var implicitoStr = "ABCDE";

            var implicitoInt = 12345;

            Console.WriteLine("String implicita = " + implicitoStr + "\nInt implicito = " + implicitoInt);

        }
    }
}

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

            // String - Grupo de caracteres:
            Console.WriteLine("Grupo");

            // Int - Números inteiros:
            Console.WriteLine(123);

            // Float, double, decimal - Números decimais:
            Console.WriteLine(0.233F); //Sufixo F/f - Número float
            Console.WriteLine(2.6354); //Sem sufixo - Número double
            Console.WriteLine(2.150m); //Sufixo M/m - Número decimal

            //Bool - Booleanos (Verdadeiro ou Falso):
            Console.WriteLine(true);
            Console.WriteLine(false);
        }
    }
}

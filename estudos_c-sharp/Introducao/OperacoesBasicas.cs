using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos_c_sharp.Introducao
{
    class OperacoesBasicas
    {
        public void operacoes()
        {

            //ADIÇÃO (+):

            int sum = 7 + 5;
            Console.WriteLine("Sum: " + sum);

            int firstNumber = 12;
            int secondNumber = 5;
            Console.WriteLine(firstNumber + secondNumber);

            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + "widgets.");

            //SUBTRAÇÃO (-):

            int difference = 7 - 5;
            Console.WriteLine("Difference: " + difference);

            //MULTIPLICAÇÃO (*):

            int product = 7 * 5;
            Console.WriteLine("Product: " + product);

            //DIVISÃO (/):

            decimal quotient1 = 7.0m / 5;
            decimal quotient2 = 7 / 5.0m;
            decimal quotient3 = 7.0m / 5.0m;
            Console.WriteLine($"Quotient 1: {quotient1}\nQuotient 2: {quotient2}\nQuotient 3: {quotient3}");

            int first = 7;
            int second = 5;
            decimal convertQuotient = (decimal)first / (decimal)second; // Convertendo int em decimal
            Console.WriteLine(convertQuotient);

            //RESTO DA DIVISÃO (%):

            Console.WriteLine($"Modulos of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulos of 7 / 5 : {7 % 5}");

            //INCREMENTAR VALORES:

            int value = 0;       //Valor = 0
            value = value + 5;   //Valor = 5
            value += 5;          //Valor = 10
            value++;             //Valor = 11

            //DECREMENTAR VALORES:

            int valueSub = 0;          //Valor = 0
            valueSub = valueSub - 5;   //Valor = -5
            valueSub -= 5;             //Valor = -10
            valueSub--;                //Valor = -11
        }
    }
}

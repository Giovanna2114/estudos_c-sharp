using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos_c_sharp.Introducao
{
    class FormatacaoCaracteres
    {

        static void main(string[] args)
        {
            Console.WriteLine("Hello\nWorld"); // Adiciona uma quebra de linha.
            Console.WriteLine("Hello\tWorld"); // Adiciona um espaçamento entre as palavras.

            Console.WriteLine("Hello \"World\""); // O caractere de escape '\' permite adicionar aspas ao texto. 

            Console.WriteLine(@"    c:source\repos
                    (this is where code goes)"); // O caractere '@' adicionado antes do texto faz com que tudo o que seja
                                                 // escrito seja interpretado literalmente, sem necessidade do uso de '\'.

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // Os caracteres unicode '\u' são utilizados para adicionar simbolos.

            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            // Concatenação e interpolação:
            string firstName = "Bob";
            string greeting = "Hello";

            // Concatenando variáveis:
            Console.WriteLine(greeting + " " + firstName + "!");

            // Interpolando variáveis:
            Console.WriteLine($"{greeting} {firstName}");


            // Combinando literais textuais e interpolação de variáveis:
            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            

        }
    }
}

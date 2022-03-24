using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Oito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Favor, digite o seu nome: ");  
                var nome = Console.ReadLine().ToLower();

                for (int i = 0; i < nome.Length; i++)
                {
                    Console.WriteLine(nome[i]);
                }

                //op = char.Parse(Console.ReadLine());
                //if (op != '+' || op != '-' || op != '*' || op != '/')
                //{
                //    throw new Exception("Informe uma operação matemática de verdade entre [" +
                //        " + | - | * | / ]");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                Console.ReadLine();
            }
        }
    }
}

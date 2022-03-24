using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Sete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine($"Favor, informar seu nome: ");
            var nome = Console.ReadLine();
            
            Console.WriteLine($"\nFavor, informar sua data de nascimento: ");
            var dataNascimento = DateTime.Parse(Console.ReadLine());

            
            Console.WriteLine(ObterMensagemFaixaEtaria(nome, dataNascimento));
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } 
            finally
            {
                Console.ReadLine();
            }
        }

        private static string ObterMensagemFaixaEtaria(string nome, DateTime dataNascimento)
        {
            var idade = DateTime.Today.Year - dataNascimento.Year;
            if (idade >= 60)
                return $"\n{nome}, você é Idoso!";
            else if (idade >= 20 && idade <= 59)
                return $"\n{nome}, você é Adulto!";
           
            return $"\n{nome}, você é Jovem!";
        }
    }
}

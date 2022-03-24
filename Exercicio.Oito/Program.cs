﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Oito
{
    internal class Program
    {
        private static readonly char[] _vogais = new char[5] {'a','e','i','o','u'};
        
        //private const char _a = 'a';
        //private const char _e = 'e';
        //private const char _i = 'i';
        //private const char _o = 'o';
        //private const char _u = 'u';

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Favor, digite o seu nome: ");
                var nome = Console.ReadLine().ToLower();
                var count = 0;

                for (int i = 0; i < nome.Length; i++)
                {
                    var letra = nome[i];
                    //    if (!_a.Equals(letra)
                    //        && !_e.Equals(letra)
                    //        && !_i.Equals(letra)
                    //        && !_o.Equals(letra)
                    //        && !_u.Equals(letra))
                    //        count++;
                    if (!_vogais.Contains(letra))
                    {
                        count++;
                    }
                }

                Console.WriteLine($"\nO nome ({nome}) possui {count} consoantes!");
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

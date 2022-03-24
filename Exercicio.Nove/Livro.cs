using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Nove
{
    internal struct Livro
    {

       // private string teste;

        public string Titulo { get; private set; } 

        public string Autor { get; private set; }

        public decimal Valor { get; private set; }

        public Livro(string titulo, string autor, decimal valor)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
            Valor = valor;
            //this.teste = teste;
        }

        public override string ToString() => $"Autor: {Autor} \n Livro: {Titulo} \n Valor: {Valor}";
    }
}

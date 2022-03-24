using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Nove
{
    internal struct Livro
    {
        public string Titulo { get; private set; } 

        public string Autor { get; private set; }

        public decimal Valor { get; private set; }

        public Livro(string titulo, string autor, decimal valor)
        {
            Titulo = titulo;
            Autor = autor;
            Valor = valor;
        }
    }
}

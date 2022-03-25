using System;

namespace Exercicio.Nove
{
    internal struct Livro
    {
            public string Titulo { get; private set; }
            public string Autor { get; private set; }
            public decimal Valor { get; private set; }

        public Livro(string titulo, string autor, decimal valor)
        {
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
            Valor = valor;
           
        }
        public override string ToString()
        {
            return $"Autor: {Autor}  \n Titulo: {Titulo} \n Valor: {Valor} ";
        }
    }
}

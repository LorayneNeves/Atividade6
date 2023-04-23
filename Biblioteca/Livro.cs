using BibliotecaLivros;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaLivros
{
    public class Livro
    {
        public string NomeLivro { get; set; }
        public string Idioma { get; set; }
        public string Edicao { get; set; }
        public DateTime DataLacamento { get; set; }
        public string ISBN { get; set; }

        public Autor autor { get; set; }
    }
}


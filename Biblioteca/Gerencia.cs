using BibliotecaLivros;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaLivros
{
    public class Gerencia : Biblioteca
    {
        public void MenuGerencia()
        {
            Autor autor = new Autor();
            Biblioteca biblioteca1 = new Biblioteca();
            Gerencia gerencia = new Gerencia();
            Livro livro = new Livro();
            int menu;

        #region
            menu:
            Console.WriteLine("Escolha uma opção para continuar...");
            Console.WriteLine("Opção 1: adicionar livro");
            Console.WriteLine("Opção 2: pesquisar livros");
            Console.WriteLine("Opção 3: listar livros");
            Console.WriteLine("Opção 4: Remove");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    biblioteca1.AdicionarLivro();
                    goto menu;
                case 2:
                    biblioteca1.PesquisarPorTitulo();
                    goto menu;
                case 3:
                    Console.Clear();
                    biblioteca1.ListarLivros();
                    goto menu;
                case 4:
                    biblioteca1.RemoverLivro();
                    break;
                default:
                    break;
            }
            #endregion
        }
    }
}

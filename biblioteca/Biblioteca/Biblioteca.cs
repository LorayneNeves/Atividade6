using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
namespace BibliotecaLivros
{
    public class Biblioteca
    {
        List<Livro> ListaLivro = new List<Livro>();
        public void AdicionarLivro()
        {
            Autor autor = new Autor();
            Livro livro = new Livro();

            #region livro
            Console.WriteLine("Digite nome do livro: ");
            livro.NomeLivro = Console.ReadLine();

            Console.WriteLine("Digite ISBN do livro: ");
            livro.ISBN = Console.ReadLine();

            Console.WriteLine("Digite data de lançamento livro: ");
            livro.DataLacamento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite ediçao do livro: ");
            livro.Edicao = Console.ReadLine();

            Console.WriteLine("Digite idioma do livro: ");
            livro.Idioma = Console.ReadLine();
            #endregion
            #region autor
            Console.WriteLine("Digite nome do autor: ");
            autor.Nome = Console.ReadLine();

            Console.WriteLine("Digite data nascimento do autor: ");
            autor.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite pais de origem do autor: ");
            autor.PaisOrigem = Console.ReadLine();


            Console.WriteLine("Digite idioma do autor: ");
            autor.IdiomaNativo = Console.ReadLine();
            #endregion
            livro.autor = autor;
            ListaLivro.Add(livro);
        }
        public void PesquisarPorTitulo()
        {
            string nomeLivro;
            Console.WriteLine("Digite o nome do livro para pesquisar: ");
            nomeLivro = Console.ReadLine();
            var livro = ListaLivro.FirstOrDefault(livro => livro.NomeLivro == nomeLivro);

            foreach (Livro item in ListaLivro)
            {
                if (item.NomeLivro == nomeLivro)
                {
                    #region dados livro
                    Console.WriteLine($"Livro '{item.NomeLivro}' encontrado. Dados do livro:");
                    Console.WriteLine($"Nome autor: {item.autor.Nome}");
                    Console.WriteLine($"Edição do livro: {item.Edicao}");
                    Console.WriteLine($"ISBN: {item.ISBN}");
                    Console.WriteLine($"Data de lançamento: {item.DataLacamento}");
                    Console.WriteLine();

                    #endregion

                    #region dados autor
                    Console.WriteLine("gostaria de ver informações do autor? s/n");
                    char a = char.Parse(Console.ReadLine());

                    if (a == 's')
                    {
                        Console.WriteLine("livro: " + item.NomeLivro);
                        Console.WriteLine("nome autor: " + item.autor.Nome);
                        Console.WriteLine("idioma nativo: " + item.autor.IdiomaNativo);
                        Console.WriteLine("data de nascimento: " + item.autor.DataNascimento);
                        Console.WriteLine("pais de origem: " + item.autor.PaisOrigem);
                        Console.WriteLine();
                    }
                    else if(a == 'n')
                    {                       
                        Console.WriteLine();
                    }
                    #endregion
                }
            }
        }
        public void ListarLivros()
        {
            Console.WriteLine($"Existem {ListaLivro.Count} livros na sua biblioteca");
            foreach (Livro item in ListaLivro)
            {
                Console.WriteLine($"Livro: {item.NomeLivro} edição {item.Edicao} | Autor: {item.autor.Nome} | Data de lançamento: {item.DataLacamento} | Idioma: {item.Idioma} | ISBN: {item.ISBN}");
                
            }
            #region dados autor
            Console.WriteLine("gostaria de ver informações do autor? s/n");
            char a = char.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (Livro item in ListaLivro)
            {
                if (a == 's')
                {
                    Console.WriteLine("livro: " + item.NomeLivro);
                    Console.WriteLine("nome do autor: " + item.autor.Nome);
                    Console.WriteLine("idioma nativo: " + item.autor.IdiomaNativo);
                    Console.WriteLine("data nascimento : " + item.autor.DataNascimento);
                    Console.WriteLine("pais de origem : " + item.autor.PaisOrigem);
                    Console.WriteLine();
                }
                else if (a == 'n')
                {
                    Console.WriteLine();
                }
            }
            #endregion
            Console.WriteLine();
        }
        public void RemoverLivro()
        {
            string ISBN;
            Console.WriteLine("Qual livro deseja remover, informar por ISBN : ");
            ISBN = Console.ReadLine();
            var livro = ListaLivro.FirstOrDefault(livro => livro.ISBN == ISBN);
            if (ISBN != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Livro {livro.NomeLivro}, ISBN: {ISBN} foi removido !");
                ListaLivro.Remove(livro);
                Console.WriteLine();
                Console.WriteLine(ListaLivro.Count + " livros disponiveis na biblioteca:");
                foreach (var item in ListaLivro)
                {
                    Console.WriteLine(item.NomeLivro);
                }
            }
            else
            {
                Console.WriteLine($"Livro ISBN {livro.ISBN} , {livro.NomeLivro} nao encontrado!");
            }
        }
    } 
}

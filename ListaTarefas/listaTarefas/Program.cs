using listaTarefas;

List<tarefas> l = new List<tarefas>();
char e = 's';
int menu;
//Apresentação do menu
MENU:
Console.WriteLine("Bem vindo ao criador de tarefas!");
Console.WriteLine("1 add tarefa");
Console.WriteLine("2 marcar tarefa como feita");
Console.WriteLine("3 remover tarefa");
Console.WriteLine("4 Imprimir");

tarefas t2 = new tarefas();

Console.Write("Qual case vc deseja entrar ?: ");
menu = int.Parse(Console.ReadLine());



switch (menu)
{

    case 1:
        do
        {
            Console.WriteLine("Você deseja adicionar uma tarefa nova ? s/n");
            e = char.Parse(Console.ReadLine());
            if (ConvertBooleano(e)) //if(E==true)
            {

                Console.WriteLine("Qual o nome da sua nova tarefa: ");
                string nomeNovaTarefa = Console.ReadLine();
                var resultadoBusca = l.Where(tarefa => tarefa.nome == nomeNovaTarefa);

                // sintaxe .Where(variavel(variavel que sera criada dentro do where) (representa os itens da lista) => condicao);
                if (resultadoBusca.Any() == true)
                {
                    Console.WriteLine("Tarefa não criada, pois ja existe outra com este nome; ");
                }
                else
                {
                    Console.WriteLine("Qual o esforço da sua nova tarefa: ");
                    int esforco = Convert.ToInt32(Console.ReadLine());

                    tarefas t = new tarefas();
                    t2 = t;
                    t.gerarTarefa(nomeNovaTarefa, esforco);
                    l.Add(t);
                    imprimirTarefas(l);
                }

            }
            else
            {
                Console.WriteLine(" Nenhuma tarefa será adicionada! ");
            }
            Console.WriteLine("Você deseja interromper ? s/n");
            e = char.Parse(Console.ReadLine());
        } while (!ConvertBooleano(e));

        goto MENU;



    case 2:
        Console.WriteLine("Qual tarefa você deseja marcar como feita?");
        string nomeNovaTarefa2 = Console.ReadLine();

        var resultadoBusca2 = l.Where(tarefa => tarefa.nome == nomeNovaTarefa2);

        if (resultadoBusca2.Any() == true)
        {
            resultadoBusca2.First().finalizado = true;
            Console.WriteLine($"Tarefa {nomeNovaTarefa2} marcada como feita");
            foreach (tarefas tete in l)
            {
                if (tete.finalizado == true)
                {
                    Console.WriteLine("tarefa finalizada");
                    tete.finalizado = true;
                    Console.WriteLine(tete.finalizado);
                }
            }

        }
        else
        {
            Console.WriteLine("Não existe tarefa com esse nome!");
        }
        goto MENU;




    case 3:
        Console.WriteLine("Qual tarefa voce deseja remover ?: ");
        string nomeNovaTarefa3 = Console.ReadLine();
        var resultadoBusca3 = l.FirstOrDefault(tarefa => tarefa.nome == nomeNovaTarefa3);
        if (resultadoBusca3 != null)
        {
            Console.WriteLine($"Tarefa {nomeNovaTarefa3} foi removida !");
            l.Remove(resultadoBusca3);
            foreach (var item in l)
            {
                Console.WriteLine(item.nome);
            }
        }
        else
        {
            Console.WriteLine($"Tarefa {nomeNovaTarefa3} nao encontrada!");
        }
        goto MENU;

    case 4:

        Console.WriteLine("Você deseja imprimir de qual forma?");
        Console.WriteLine("a ordem alfabetica");
        Console.WriteLine("b ordem crescente pelo esforço");
        Console.WriteLine("c ordem descrescente pelo esfoço");

        char meenu = char.Parse(Console.ReadLine());
        switch (meenu)
        {
            case 'a':
                foreach (tarefas tt in l)
                {
                    if (tt.finalizado == false)
                    {

                        Console.WriteLine($"Todas as tarefas pendentes: {tt.nome}");
                      List<tarefas> sortedNumbers = l.OrderBy(tarefapendente => tarefapendente).ToList();

                        foreach (tarefas tarefapendente in sortedNumbers)
                        {
                            Console.WriteLine(tarefapendente);
                        }

                    }
                }
                break;
        }
        goto MENU;
}




void imprimirTarefas(List<tarefas> lista)
{
    Console.WriteLine("Todas as suas tarefas: ");
    foreach (var item in lista)
    {
        Console.WriteLine($"Nome = {item.nome} Esforço = {item.esforco} (horas)");
    }
}

bool ConvertBooleano(char c)
{
    //if ternario condicao ? true : false;
    // return char.ToUpper(c) == 'S' ? true : false;

    /// ou  
    if (char.ToUpper(c) == 'S')
    {
        return true;
    }
    else
    {
        return false;
    }



}
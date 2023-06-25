using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class RelatorioAtividades_API
    {
        public async Task Atividades()
        {
        menuAtividades:
            Console.WriteLine("Digite uma das opções");
            Console.WriteLine("1- Cadastrar atividade");
            Console.WriteLine("2 - Remover atividade");
            Console.WriteLine("3 - Listar atividade");
            Console.WriteLine("4 - Sair");
            int menu = int.Parse(Console.ReadLine());
            AdmRelatorio relatoriosAtt = new AdmRelatorio();
            switch (menu)
            {
                case 1:
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            Console.WriteLine("Digite titulo, descrição e periodo para cadastrar: ");
                            var data = new { titulo = Console.ReadLine(), descricao = Console.ReadLine(), periodo = int.Parse(Console.ReadLine()) };

                            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                            HttpResponseMessage response = await client.PostAsync("http://localhost:3000/atividades", content);

                            if (response.IsSuccessStatusCode)
                            {
                                string responseBody = await response.Content.ReadAsStringAsync();

                                Console.WriteLine(responseBody);
                            }
                            else
                            {
                                Console.WriteLine("A requisição não foi bem-sucedida. Código de status: " + response.StatusCode);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ocorreu um erro: " + ex.Message);
                        }
                    }
                    goto menuAtividades;
                case 2:
                    Console.WriteLine("Digite o id do produto para deletar:");
                    relatoriosAtt.recebeid = int.Parse(Console.ReadLine());
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            string url = $"http://localhost:3000/atividades/{relatoriosAtt.recebeid}";

                            HttpResponseMessage response = await client.DeleteAsync(url);

                            response.EnsureSuccessStatusCode();

                            string responseBody = await response.Content.ReadAsStringAsync();

                            RelatorioAtividades_API root = Newtonsoft.Json.JsonConvert.DeserializeObject<RelatorioAtividades_API>(responseBody);

                            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(url);


                            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                        }
                        catch (HttpRequestException ex)
                        {
                            Console.WriteLine($"Ocorreu um erro ao fazer a requisição HTTP: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                        }
                    }
                    goto menuAtividades;
                    case 3:
                    using (HttpClient client = new HttpClient())
                    {
                        try
                        {
                            string url = "http://localhost:3000/atividades";

                            HttpResponseMessage response = await client.GetAsync(url); response.EnsureSuccessStatusCode();

                            response.EnsureSuccessStatusCode();

                            string responseBody = await response.Content.ReadAsStringAsync();

                            List<RelatorioAtividades_API> root1 = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RelatorioAtividades_API>>(responseBody);

                           
                            Console.WriteLine(responseBody);
                        }

                        catch (HttpRequestException ex)

                        {
                            Console.WriteLine($"Ocorreu um erro ao fazer a requisição HTTP: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                        }
                    }
                    goto menuAtividades;
                    case 4:                   
                    MenuPrincipal voltarmenu = new MenuPrincipal();
                    voltarmenu.MenuGerencia();
                    break;
            }
        
        }
    }
}

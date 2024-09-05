using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace ParkingSystem;

class Program
{
    static void Main(string[] args)
    {

        string nome, modelo, marca, placa, tipoVeiculo;
        int id, ano, quantidade, op;
        Estacionamento veiculo;

        Dictionary<int, Estacionamento> registrosVeiculos = new Dictionary<int, Estacionamento>();

        Console.WriteLine("[1]-Cadastrar veículo(os)");
        Console.WriteLine("[2]-Filtrar veículo");
        Console.WriteLine("[3]-Listar veículos");
        Console.WriteLine("[4]-Remover veículo");
        Console.WriteLine("[5]-Sair do sistema");
        Console.Write("\nDigite um numero de acordo com as opções acima: ");
        op = int.Parse(Console.ReadLine());

        while (op != 5)
        {
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Digite quantos veiculos deseja cadastrar: ");
                    quantidade = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= quantidade; i++)
                    {
                        Console.Write("\n\nDigite o tipo do veiculo: ");
                        tipoVeiculo = Console.ReadLine();
                        Console.Write("Digite a marca do veiculo: ");
                        marca = Console.ReadLine();
                        Console.Write("Digite o modelo do veiculo: ");
                        modelo = Console.ReadLine();
                        Console.Write("Digite o ano do veiculo: ");
                        ano = int.Parse(Console.ReadLine());
                        Console.Write("Digite a placa do veiculo: ");
                        placa = Console.ReadLine();

                        veiculo = new Estacionamento(tipoVeiculo, marca, modelo, ano, placa);

                        registrosVeiculos.Add(i, veiculo);
                    }
                    break;
                case 2:
                    Console.Clear();

                    Console.Write("Digite o id do veículo estacionado: ");
                    id = int.Parse(Console.ReadLine());

                    if (registrosVeiculos.ContainsKey(id))
                    {
                        veiculo = registrosVeiculos[id];
                        Console.WriteLine("\nId: " + id);
                        Console.WriteLine("Tipo veículo: " + veiculo.TipoVeiculo);
                        Console.WriteLine("Marca: " + veiculo.Marca);
                        Console.WriteLine("Modelo: " + veiculo.Modelo);
                        Console.WriteLine("Ano: " + veiculo.Ano);
                        Console.WriteLine("Placa: " + veiculo.Placa);
                    }
                    break;
                case 3:
                    Console.Clear();

                    foreach (var v in registrosVeiculos)
                    {
                        Console.WriteLine("\nId: " + v.Key);
                        Console.WriteLine("Tipo veículo: " + v.Value.TipoVeiculo);
                        Console.WriteLine("Marca: " + v.Value.Marca);
                        Console.WriteLine("Modelo: " + v.Value.Modelo);
                        Console.WriteLine("Ano: " + v.Value.Ano);
                        Console.WriteLine("Placa: " + v.Value.Placa);
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Digite o id do veiculo estacionado: ");
                    id = int.Parse(Console.ReadLine());
                    if (registrosVeiculos.Remove(id))
                    {
                        Console.WriteLine("O registro foi excluído com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Registro não encontrado");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("[1]-Cadastrar veiculo(os)");
            Console.WriteLine("[2]-Filtrar veículo");
            Console.WriteLine("[3]-Listar veiculo(os)");
            Console.WriteLine("[4]-Remover veiculo(os)");
            Console.WriteLine("[5]-Sair do sistema");
            Console.Write("\nDigite um numero de acordo com as opções acima: ");
            op = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n\nSistema encerrado.");
    }

    /*
    string modelo, marca;
    double preco;
    int ano, quantidade, op;

    List<string> listaVeiculos = new List<string>();

    Console.WriteLine("[1]-Cadastrar veiculo(os)");
    Console.WriteLine("[2]-Listar veiculo(os)");
    Console.WriteLine("[3]-Remover veiculo(os)");
    Console.WriteLine("[4]-Sair do sistema");
    Console.Write("\nDigite um numero de acordo com as opções acima:");
    op = int.Parse(Console.ReadLine());

    while(op != 4)
    {
        switch(op)
        {
            case 1:
                Console.Write("Digite quantos carros deseja cadastrar: ");
                quantidade = int.Parse(Console.ReadLine());

                for(int i = 1; i <= quantidade; i++)
                {
                    Console.Write("\nDigite a marca do carro: ");
                    marca = Console.ReadLine();
                    Console.Write("Digite o modelo do carro: ");
                    modelo = Console.ReadLine();
                    Console.Write("Digite o ano do carro: ");
                    ano = int.Parse(Console.ReadLine());
                    Console.Write("Digite o preco do carro: ");
                    preco = double.Parse(Console.ReadLine());

                    listaVeiculos.Add(modelo);
                    listaVeiculos.Add(marca);
                    listaVeiculos.Add(ano.ToString());
                    listaVeiculos.Add(preco.ToString("F2"));
                }
            break;
            case 2:
                int id = 0;

                foreach(var veiculo in listaVeiculos)
                {
                    id += 1;
                    Console.WriteLine("Id: " + id);
                    Console.WriteLine(listaVeiculos);
                    Console.WriteLine("\n");
                }
            break;
            case 3:
                Console.Write("Digite a quantidade de veículos que deseja remover: ");
                quantidade = int.Parse(Console.ReadLine());

                for(int i = 1; i <= quantidade; i++)
                {
                    Console.Write("\nDigite a marca do carro: ");
                    marca = Console.ReadLine();
                    Console.Write("Digite o modelo do carro: ");
                    modelo = Console.ReadLine();
                    Console.Write("Digite o ano do carro: ");
                    ano = int.Parse(Console.ReadLine());
                    Console.Write("Digite o preco do carro: ");
                    preco = double.Parse(Console.ReadLine());

                    listaVeiculos.Remove(modelo);
                    listaVeiculos.Remove(marca);
                    listaVeiculos.Remove(ano.ToString());
                    listaVeiculos.Remove(preco.ToString("F2"));
                }
            break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    */
}

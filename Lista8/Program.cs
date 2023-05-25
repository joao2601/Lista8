using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8
{
    internal class Program
    {
        public static void Exercicio1()
        {

            double precototal = 0.0;
            int qtd;
            double preco;
            int totalItems = 0;

            Console.WriteLine("**TABELA DE PREÇOS**");
            Console.WriteLine("------------//--------//---------//-------");
            Console.WriteLine("Peixe = R$2,00");
            Console.WriteLine("Carne = R$10,00");
            Console.WriteLine("Rfrigerante = R$4,00");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Insira a quantidade : ");
            qtd = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Insira o valor do(s) produtos: ");
                preco = double.Parse(Console.ReadLine());

                precototal += (qtd * preco);

                totalItems += qtd;

                Console.WriteLine("A quantidade de produtos é: " + totalItems);
                Console.WriteLine("O valor dos produtos é: " + precototal);
            }
            while (qtd > 0);
            Console.ReadKey();
        }

        public static void Exercicio2()
        {
            string nomeProduto, nomeMaior, nomeMenor;
            int numItens;
            float preco, maiorValor, menorValor;
            int parada = 0;

            maiorValor = float.MaxValue;
            menorValor = float.MinValue;

            do
            {
                Console.WriteLine("Informe o nome do produto: ");
                nomeProduto = Console.ReadLine();

                Console.WriteLine("Insira a quantidade: ");
                numItens = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o preço unitario: ");
                preco = float.Parse(Console.ReadLine());

                float total = numItens + preco;

                if (total > maiorValor)
                {
                    maiorValor = total;
                    nomeMaior = nomeProduto;
                }
                if (total < menorValor)
                {
                    maiorValor = total;
                    nomeMenor = nomeProduto;
                }
                Console.WriteLine("Digite 1 para sair ou 2 para continuar");

                parada = int.Parse(Console.ReadLine());
            } while (parada != 1);
            Console.WriteLine("Maior qtd investida {0} no produto {1}: ", maiorValor);
            Console.WriteLine("Menor qtd investida {0} no produto {1}: ", menorValor);

            Console.ReadKey();
        }

        public static void Exercicio3()
        {
            Console.WriteLine("****Cadastro de Pesos das Avaliações****");

            Console.WriteLine("Digite o número de avaliações planejadas para o bimestre:");
            int numeroAvaliacoes = int.Parse(Console.ReadLine());

            double somaPesos = 0;
            int contadorAvaliacoes = 1;

            do
            {
                Console.WriteLine($"Digite o peso da avaliação {contadorAvaliacoes}:");
                double peso = double.Parse(Console.ReadLine());

                somaPesos += peso;
                contadorAvaliacoes++;
            } while (contadorAvaliacoes <= numeroAvaliacoes);

            Console.WriteLine("-------------------------------------");
            if (somaPesos < 100)
            {
                Console.WriteLine($"A soma total dos pesos é insuficiente. Total: {somaPesos}%");
            }
            else if (somaPesos > 100)
            {
                Console.WriteLine($"A soma total dos pesos é excedente. Total: {somaPesos}%");
            }
            else
            {
                Console.WriteLine($"A soma total dos pesos é adequada. Total: {somaPesos}%");
            }
        }

        public static void Exercicio4()
        {

            //    // ****exercicio 4
            {
                Console.WriteLine("informe a sigla do estado: ");
                string sigla = Console.ReadLine();
                {
                    string nomeestado;
                    switch (sigla)
                    {
                        case "ac":
                            nomeestado = "acre";
                            break;
                        case "al":
                            nomeestado = "alagoas";
                            break;
                        case "ap":
                            nomeestado = "amapá";
                            break;
                        case "am":
                            nomeestado = "amazonas";
                            break;
                        case "ba":
                            nomeestado = "bahia";
                            break;
                        case "ce":
                            nomeestado = "ceará";
                            break;
                        case "df":
                            nomeestado = "distrito federal";
                            break;
                        case "es":
                            nomeestado = "espírito santo";
                            break;
                        case "go":
                            nomeestado = "goiás";
                            break;
                        case "ma":
                            nomeestado = "maranhão";
                            break;
                        case "mt":
                            nomeestado = "mato grosso";
                            break;
                        case "ms":
                            nomeestado = "mato grosso do sul";
                            break;
                        case "mg":
                            nomeestado = "minas gerais";
                            break;
                        case "pa":
                            nomeestado = "pará";
                            break;
                        case "pb":
                            nomeestado = "paraíba";
                            break;
                        case "pr":
                            nomeestado = "paraná";
                            break;
                        case "pe":
                            nomeestado = "pernambuco";
                            break;
                        case "pi":
                            nomeestado = "piauí";
                            break;
                        case "rj":
                            nomeestado = "rio de janeiro";
                            break;
                        case "rn":
                            nomeestado = "rio grande do norte";
                            break;
                        case "rs":
                            nomeestado = "rio grande do sul";
                            break;
                        case "ro":
                            nomeestado = "rondônia";
                            break;
                        case "rr":
                            nomeestado = "roraima";
                            break;
                        case "sc":
                            nomeestado = "santa catarina";
                            break;
                        case "sp":
                            nomeestado = "são paulo";
                            break;
                        case "se":
                            nomeestado = "sergipe";
                            break;
                        case "to":
                            nomeestado = "tocantins";
                            break;
                        default:
                            Console.WriteLine("erro: sigla inválida.");
                            return;
                    }

                    Console.WriteLine("estado: " + nomeestado);
                }
            }
        }

        public static void Exercicio5()
        {

            bool continuar = true;

            do
            {
                Console.WriteLine("=== Verificação da Estação do Ano ===");
                Console.Write("Digite um número inteiro entre 1 e 12: ");
                int mes = int.Parse(Console.ReadLine());

                string estacao;

                switch (mes)
                {
                    case 12:
                    case 1:
                    case 2:
                        estacao = "Verão";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        estacao = "Outono";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        estacao = "Inverno";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        estacao = "Primavera";
                        break;
                    default:
                        Console.WriteLine("Mês inválido.");
                        continue;
                }

                if ((mes == 3 || mes == 9) && estacao == "Primavera" || (mes == 6 || mes == 12) && estacao == "Inverno")
                {
                    Console.WriteLine("Há duas estações possíveis para esse mês.");
                    Console.Write("Informe '1' para considerar a estação anterior ou '2' para considerar a estação posterior: ");
                    int escolha = int.Parse(Console.ReadLine());

                    if (escolha == 1)
                    {
                        if (mes == 3)
                        {
                            estacao = "Outono";
                        }
                        else if (mes == 6)
                        {
                            estacao = "Verão";
                        }
                    }
                    else if (escolha == 2)
                    {
                        if (mes == 3)
                        {
                            estacao = "Primavera";
                        }
                        else if (mes == 6)
                        {
                            estacao = "Inverno";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Estação definida como a padrão.");
                    }
                }

                Console.WriteLine($"A estação correspondente ao mês {mes} é: {estacao}");

                Console.WriteLine("Deseja verificar outra estação? (s/n)");
                string opcao = Console.ReadLine();

                if (opcao != "s")
                {
                    continuar = false;
                }

                Console.WriteLine();
            } while (continuar);
        }

        public static void Exercicio6()
        {
            bool continuar = true;

            do
            {
                Console.WriteLine("=== Cálculo do IMC ===");
                Console.Write("Informe o peso (em kg): ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Informe a altura (em metros): ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                Console.WriteLine($"Seu IMC: {imc:F2}");

                Console.WriteLine("=== Faixa de Peso ===");

                if (imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    Console.WriteLine("Peso normal");
                }
                else if (imc >= 25.0 && imc <= 29.9)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else if (imc >= 30.0 && imc <= 34.9)
                {
                    Console.WriteLine("Obesidade grau 1");
                }
                else if (imc >= 35.0 && imc <= 39.9)
                {
                    Console.WriteLine("Obesidade grau 2");
                }
                else
                {
                    Console.WriteLine("Obesidade grau 3 (mórbida)");
                }

                Console.WriteLine("Deseja calcular o IMC novamente? (s/n)");
                string opcao = Console.ReadLine();

                if (opcao != "s")
                {
                    continuar = false;
                }

                Console.WriteLine();
            } while (continuar);

        }




        static void Main(string[] args)
        {

            {
                {

                   
                    {
                        int opcao;

                        do
                        {
                            Console.WriteLine("digite 1 para executar o exercicio 1");

                            Console.WriteLine("digite 2 para executar o exercicio 2");
                            ;

                            Console.WriteLine("digite 3 para executar o exercicio 3");

                            Console.WriteLine("digite 4 para executar o exercicio 4");

                            Console.WriteLine("digite 5 para executar o exercicio 5");
                            opcao = int.Parse(Console.ReadLine());

                            switch (opcao)
                            {
                                case 0:
                                    Console.WriteLine("o programa foi encerrado");
                                    break;

                                case 1:
                                    Exercicio1();
                                    break;

                                case 2:
                                    Exercicio2();
                                    break;

                                case 3:
                                    Exercicio3();
                                    break;

                                case 4:
                                    Exercicio4();
                                    break;

                                case 5:
                                    Exercicio5();
                                    break;
                                case 6:
                                    Exercicio6();
                                    break;

                                default:
                                    Console.WriteLine("numero invalido");
                                    break;
                            }

                        } while (opcao != 0);
                    }
                }





            }
        }

    }
}

    

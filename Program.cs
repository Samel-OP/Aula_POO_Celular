using System;

namespace CelularMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            Celular smartphone = new Celular();
            smartphone.modelo = "\nXiaomi";
            smartphone.cor = "Dark Blue";
            smartphone.tamanho = 6.3;
            smartphone.os = "Android 11 e MIUI 12";
            smartphone.processador = "Snapdragon 660";
            smartphone.ram = "4Gb de ram";
            smartphone.rom = "64Gb de espaço interno";

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Deseja ligar o Celular? (S) se 'sim' ou qualquer digito para 'não'");
                string ligar = Console.ReadLine().ToLower();

                switch (ligar)
                {
                    case "s":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nLigando Celular...");

                        bool refazer = false;

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($@"
 _____________________________
|| {DateTime.Now} - 85% ||
||     -----------------     ||                                  
||     |      Apps     |     ||
||     -----------------     ||
||                           ||
||                           ||
||  T - Telefone             ||
||                           ||
||                           ||
||  M - Mensagem             ||
||                           ||              
||                           ||  
||  S - Settings             ||      
||                           ||              
||                           ||  
||  D - Desligar             ||
||                           ||
||___________________________||");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nEscreva uma das opções acima:");
                            opcao = Console.ReadLine().ToUpper();

                            if (opcao == "T")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($@"
 _____________________________
|| {DateTime.Now} - 85% ||
||     -----------------     ||                                  
||     |   Contatos    |     ||
||     -----------------     ||
||                           ||
||                           ||
||  Ordilei            →     ||
||                           ||
||                           ||
||  Thiago             →     ||
||                           ||              
||                           ||  
||  Samuel             →     ||      
||                           ||              
||                           ||  
||  Bob                →     ||
||                           ||
||___________________________||");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nDeseja Ligar para qual dos seus contatos?");
                                string contatoL = Console.ReadLine().ToLower();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($@"
 _____________________________
|| {DateTime.Now} - 85% ||
||     -----------------     ||                                  
||     |    Perfil     |     ||
||     -----------------     ||
||                           ||
||                           ||
|| {contatoL}                ||
||                           ||
|| {smartphone.Ligacao()}                ||
||                           ||
||                           ||              
||                           ||  
||                           ||      
||                           ||              
||                           ||  
||                           ||
||                           ||
||___________________________||");

                            }

                            else if (opcao == "M")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($@"
 _____________________________
|| {DateTime.Now} - 85% ||
||     -----------------     ||                                  
||     |   Contatos    |     ||
||     -----------------     ||
||                           ||
||                           ||
||  Ordilei            →     ||
||                           ||
||                           ||
||  Thiago             →     ||
||                           ||              
||                           ||  
||  Samuel             →     ||      
||                           ||              
||                           ||  
||  Bob                →     ||
||                           ||
||                           ||
||___________________________||");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nDeseja mandar mensagem para qual dos seus contatos?");
                                //Pode ser qualquer pessoa, no css de console está alguns que são contato
                                string contatoM = Console.ReadLine().ToLower();

                                Console.WriteLine("\nDigite a mensagem a ser enviada:");
                                string escrevaMensagem = Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($@"
 _____________________________
|| {DateTime.Now} - 85% ||
||     -----------------     ||                                  
||     |    Perfil     |     ||
||     -----------------     ||
||                           ||
||                           ||
|| {contatoM}                ||
||                           ||
|| {escrevaMensagem}         ||
||                           ||
|| {smartphone.Mensagem()}         ||              
||                           ||  
||                           ||      
||                           ||              
||                           ||  
||                           ||
||                           ||
||___________________________||");
                            }

                            else if (opcao == "S")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n- - - CONFIGURAÇÕES - - -");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(smartphone.modelo);
                                Console.WriteLine(smartphone.cor);
                                Console.WriteLine(smartphone.tamanho + " Polegadas");
                                Console.WriteLine(smartphone.os);
                                Console.WriteLine(smartphone.processador);
                                Console.WriteLine(smartphone.ram);
                                Console.WriteLine(smartphone.rom);
                                refazer = false;
                            }

                            else if (opcao == "D")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nDesligando...\n");
                                smartphone.Desligar();
                                refazer = true;
                            }

                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nOpção inválida!");
                                refazer = false;
                            }

                        } while (refazer == false);

                        smartphone.Ligar();
                        break;

                    case "n":
                        smartphone.Desligar();
                        break;

                    default:
                        smartphone.Desligar();
                        break;
                }
            } while (smartphone.Ligar() && smartphone.Desligar());
        }
    }
}

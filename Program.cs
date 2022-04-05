using System;

namespace PraticaAula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Exercícios Práticos da Aula 02:");
            Console.WriteLine("-------------------------------\n\r");

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Prática 01:");
            Console.WriteLine("-------------------------------\n\r");

            string letraMusica = "Shaken out of liquid dreams you're under\r\n" +
                                 "The hellfire-red, insane nightmares\r\n" +
                                 "Is coming back inside\r\n" +
                                 "Patiently you walk again\r\n" +
                                 "Through the lane of a sadman's pain\r\n" +
                                 "Inner urge, tough beliefs\r\n" +
                                 "Is the way to a land of free ...";

            Console.WriteLine("Letra da Música:\n\r");
            Console.WriteLine(letraMusica);

            Console.WriteLine("");

            Console.WriteLine("-------------------------------\n\r");
            Console.WriteLine("Esta música se chama 'Scream Your Heart Out?'\n\r");

            //Comparação de Palavras Ignorando Case Sensitive:
            bool validacaoPalavra = letraMusica.Contains("Hellfire-Red", System.StringComparison.CurrentCultureIgnoreCase);
            if (validacaoPalavra)
            {
                Console.WriteLine("Sim, pois ela possui a palavra 'hellfire-red'.\n\r");
            }
            Console.WriteLine("-------------------------------\n\r");

            Console.WriteLine("Este trecho da música possui '...' no final?\n\r");

            //Verificar se termina com reticências:
            bool validacaoReticencias = letraMusica.EndsWith("...", System.StringComparison.CurrentCultureIgnoreCase);
            if (validacaoReticencias)
            {
                Console.WriteLine("Sim!\n\r");
            }
            else
            {
                Console.WriteLine("Não!\n\r");
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Prática 02:");
            Console.WriteLine("-------------------------------\n\r");

            //Criar variáveis e atribuir valores a elas:
            char inical = 'h';
            string nome = "hygor";
            short idade = 20;
            double nota1 = 10.0;
            decimal nota2 = 10;
            int contaCorrente = 999999999;

            //Criar variáveis com nomes errados:

            // string Console = "Tá errado mané!";
            // short WriteLine = "Declarou errado de novo!?";
            // int decimal = "Vish, esquece programação. vai ser padeiro.";

            //Criar variáveis com valores errados e mostrar erros indicados pelo VS:

            //char primeiroNome = 'Hygor';
            //ERRO: Número excessivo de caracteres no literal de caractere.

            //double ultimoNome = "Braga";
            //ERRO: Não é possivel converter implicitamente tipo "String em "Double".

            //decimal nota = 8.5;
            //ERRO: Literal do tipo double não pode ser convertido implicitamente no tipo "decimal"; use um sufixo "M" para criar um literal desse tipo.

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Prática 03:");
            Console.WriteLine("-------------------------------\n\r");

            Console.WriteLine("Agora que você viu a instrução if e as construções de loop na linguagem C#, verifique se você pode escrever o código C#\n\r" +
                              "para encontrar a soma de todos os inteiros de 1 a 20 divisíveis por 3.\n\r");


            for (int numero = 1; numero < 21; numero++)
            {
                if(numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
                
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine("FIM :)");
            Console.WriteLine("-------------------------------\n\r");
        }
    }
}
using System;
namespace projetosⅠ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int ano = 1945;
            Console.WriteLine("foi no vrão de "+ano+" que seu vô virou gay");*/

            /*OPERAÇÕES MATEMÁTICAS
            int numero1 = 1; 
            int numero2 = 2;
            int numero3 = 3;
            int numero4 = 4;

            int soma = numero1 + numero2 + numero3 + numero4;
            int subtracao = numero1 - numero2 - numero3 - numero4;
            int divisao = numero2 / numero4;
            int multiplicacao = numero1 * numero2 * numero3 * numero4 *;

            double salario = 1500.86;
            Console.WriteLine(salario);*/

            //atividade da professora juliana

            int salario = 35 * 8;
            Console.WriteLine(salario);

            int bonbons = 27 * 16;
            Console.WriteLine(bonbons);

            int programa1 = 11;
            int programa2 = 9;
            int programa = programa1 + programa2;
            Console.WriteLine("a soma do dia 11 com o mês 9 de 2001 é " + programa);

            int garrafas = 15;
            Console.WriteLine("eles usaram " + garrafas + " caixas de garrafas");

            double instalacao = 300.00;
            double limpeza = 150.00;
            double manutencao = 499.99;
            int descontao = -50;
            int descontaco = -150;
            double total = instalacao + limpeza + manutencao;
            double totalComDescontao = instalacao + limpeza + manutencao + descontao;
            double totalSemdescontaoMasComDescontaco = instalacao + limpeza + manutencao + descontaco;
            Console.WriteLine("o total é "+ total +"porém com o desconto de 50 réis fica "+ totalComDescontao +"porém pode ser também"+ totalSemdescontaoMasComDescontaco +"se o desconto for em cada serviço por novo cliente");
        }
    }
}

using System;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {

            var _operacao = new Operacoes();

            Console.WriteLine("Somar: " + String.Format("Resultado da Soma: {0} " , _operacao.Somar(8, 2).ToString()));
            Console.WriteLine("Diminuir: " + String.Format("Resultado da Soma: {0} ", _operacao.Diminuir(8, 2).ToString()));
            Console.WriteLine("Dividir: " + String.Format("Resultado da Soma: {0} ", _operacao.Dividir(8, 2).ToString()));
            Console.WriteLine("Multiplicar: " + String.Format("Resultado da Soma: {0} ", _operacao.Multiplicar(8, 2).ToString()));

            Console.WriteLine("Pressione ENTER para Fechar...");
            Console.ReadLine();
        }
    }
}

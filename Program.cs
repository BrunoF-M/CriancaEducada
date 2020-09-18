using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string texto;

            Console.WriteLine("Olá digite uma frase");
            texto = Console.ReadLine();

            string texto2 = texto.Replace("chato","#@$%*").Replace("chata","#$%@*").Replace("boboca","!@#$%@").Replace("bobo","@$%").Replace("boba","!@%%").Replace("feio","&¨&*").Replace("feia","!@$%").Replace("bocó","!$!$").Replace("tonto","#@$%&").Replace("palerma","!@*#$@!").Replace("tonta","!@#$#").Replace("paspalho","@#$$#@@#").Replace("paspalha","@#$$#").Replace("tantã","%#@¨@$").Replace("panaca","!@#%!#").Replace("pentelho","!#@$%@").Replace("pentelha","!@#$!").Replace("burro","!@#$@").Replace("burra","!@#$@!").Replace("besta","!@#!@");

            Console.WriteLine($"Resultado: {texto2}");
            Console.WriteLine("Aperte para Finalizar...");
            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {                            
                char vogal;
                bool vogalOuConsoante = false;
                string[] vogais = new string[] { "a", "e", "i", "o", "u" };
                Console.Write("Informe um caracter: ");
                while (!char.TryParse(Console.ReadLine(), out vogal) || (!char.IsLetter(vogal)))
                {
                    Console.Write("Opção invalida. Insira uma opção válida: ");
                }
                vogal = char.ToLower(vogal);
                Console.Clear();
                Console.WriteLine(string.Format("Caracter informado: {0} ", vogal));
                for (int i = 0; i < vogais.Length; i++)
                {
                    if (vogais[i] == vogal.ToString())
                    {
                        vogalOuConsoante = true;
                    }
                }
                if (vogalOuConsoante)
                {
                    Console.WriteLine();
                    Console.WriteLine("O caracter informado é uma vogal");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("O caracter informado é um consoante");
                }
            }
        }
    }
}

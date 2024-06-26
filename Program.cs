using System;
using System.ComponentModel.Design;
using System.IO;

namespace TextEditor // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("O que gostaria de abrir? ");
            Console.WriteLine("1 ----- ABRIR ARQUIVO");
            Console.WriteLine("2 ----- EDITAR ARQUIVO");
            Console.WriteLine("0 ----- SAIR");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;

            }

        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para Sair)");
            Console.WriteLine("----");

            string text = "";

            do
            {
                // Pega tudo que o usuario escreveu mais o que ele adicionar
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Onde gostaria de salvar seu arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} Salvo com Sucesso!");
            Console.ReadLine();
            Menu();
        }
    }

}
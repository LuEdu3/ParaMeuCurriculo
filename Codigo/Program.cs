using System.Numerics;
using System.Reflection.PortableExecutable;

using System.ComponentModel;
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("=".PadLeft(28, '='));
Console.WriteLine("     Lista de Contatos");
Console.WriteLine("=".PadLeft(28, '='));
Console.ResetColor();

Console.Write("\nQuantos contatos deseja inserir: ");
int quantidade = int.Parse(Console.ReadLine());

string[] nomes = new string[quantidade];

for (int i = 0; i < quantidade; i++)
{
    Console.Write($"\nDigite o contato {i + 1}: ");
    nomes[i] = Console.ReadLine().ToLower();
}

List<string> lista = new List<string>(nomes);

Console.Write("\nQuer remover algum contato?: ");
string segue = Console.ReadLine().ToLower();

if (segue == "sim".ToLower() || segue == "s".ToLower())
{

    Console.Write("\nDigite o nome do contato que deseja remover: ");
    string valorRemover = Console.ReadLine().ToLower();

    if (lista.Remove(valorRemover))
    {
        Console.WriteLine($"\n{valorRemover} foi removido com sucesso");
    }
    else
    {
        Console.WriteLine($"\n{valorRemover} não foi encontrado");
    }

    nomes = lista.ToArray();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("=".PadLeft(32, '='));
   Console.WriteLine("\nLista de contatos após remoção: ");
    Console.WriteLine("=".PadLeft(32, '='));
    
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
         Console.WriteLine("-".PadLeft(10, '-'));
    }
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("=".PadLeft(32, '='));
    Console.WriteLine("\nAgenda de Contatos Salvos\n");
    Console.WriteLine("=".PadLeft(32, '='));
    foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
        Console.WriteLine("-".PadLeft(10, '-'));
        
    }
}
Console.ResetColor();


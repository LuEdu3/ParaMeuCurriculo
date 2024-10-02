using System.Numerics;
using System.Reflection.PortableExecutable;

using System.ComponentModel;
Console.Clear(); //Limpa qualquer mensagem de erro ou aviso antes do código começar

Console.ForegroundColor = ConsoleColor.DarkGreen; //Pinta uma parte do código para verde escuro
Console.WriteLine("=".PadLeft(28, '=')); //Cria um cabeçalho
Console.WriteLine("     Lista de Contatos"); //Escreve na tela 
Console.WriteLine("=".PadLeft(28, '=')); //Cria um cabeçalho
Console.ResetColor(); //Reseta a cor criada 

Console.Write("\nQuantos contatos deseja inserir: "); // Escreve uma mensagem na tela para o usuário inserir a quantidade de contatos
int quantidade = int.Parse(Console.ReadLine()); //Inseri a quantidade convertendo para número

string[] nomes = new string[quantidade]; //Cria um array de nomes para a quantidade digitada

for (int i = 0; i < quantidade; i++) //Estrutura de repetição para a quantidade de numeros nao passar a variavel contabil
{
    Console.Write($"\nDigite o contato {i + 1}: "); // Vai aumentando o número de Contatos sem ultrapassar a informada pelo usuário
    nomes[i] = Console.ReadLine().ToLower(); //Lê a entrada do usuário e armazena no array nomes
}

List<string> lista = new List<string>(nomes); //Converte o array para uma lista para poder remover algum valor dentro do array

Console.Write("\nQuer remover algum contato?: "); //Pergunta se o usuário quer remover algum contato
string segue = Console.ReadLine().ToLower(); //Usuário informa com sim ou não se quer remover algum contato

if (segue == "sim".ToLower() || segue == "s".ToLower()) //Se for inserido "sim" ou "s" entra no bloco de código
{

    Console.Write("\nDigite o nome do contato que deseja remover: "); //Pede para o usuário inserir o nome do contato que deseja remover
    string valorRemover = Console.ReadLine().ToLower(); //Usuário informa o nome do contato

    if (lista.Remove(valorRemover)) //Remove o valor da lista
    {
        Console.WriteLine($"\n{valorRemover} foi removido com sucesso");
    }
    else // senão existe o nome ele nao é encontrado
    {
        Console.WriteLine($"\n{valorRemover} não foi encontrado");
    }

    nomes = lista.ToArray(); //Trasnforma a lista em array novamente

    Console.ForegroundColor = ConsoleColor.Green; //Pinta uma parte do código para verde
    Console.WriteLine("=".PadLeft(32, '=')); //Cria um cabeçalho
    Console.WriteLine("\nLista de contatos após remoção: "); 
    Console.WriteLine("=".PadLeft(32, '=')); //Cria um cabeçalho

    foreach (string nome in nomes) //Estrutura de repetição, procura nome dentro de nomes
    {
        Console.WriteLine(nome); //Escreve a lista de nome
        Console.WriteLine("-".PadLeft(10, '-')); //Cria um cabeçalho
    }
    Console.ResetColor(); //Reseta a cor
}
else
{
    Console.ForegroundColor = ConsoleColor.Green; //Pinta uma parte do código para verde
    Console.WriteLine("=".PadLeft(32, '=')); //Cria um cabeçalho
    Console.WriteLine("\nAgenda de Contatos Salvos\n");
    Console.WriteLine("=".PadLeft(32, '='));  //Cria um cabeçalho
    foreach (string nome in nomes) //Estrutura de repetição, procura nome dentro de nomes
    {
        Console.WriteLine(nome); //Escreve a lista de nome
        Console.WriteLine("-".PadLeft(10, '-')); //Cria um cabeçalho

    }
}
Console.ResetColor(); //Reseta a cor


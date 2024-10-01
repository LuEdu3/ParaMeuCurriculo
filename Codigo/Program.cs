using System.Numerics;
using System.Reflection.PortableExecutable;

Console.WriteLine("Insira a palavra: ");
string palavra = Console.ReadLine();

Console.WriteLine("Insira a letra a ser contada: ");
char letra = char.Parse(Console.ReadLine());

int total =0;
for(int i = 0; letra < palavra[i]; i++)
{
    total++;
}
Console.WriteLine($"A letra {letra} foi contada {total} vezes.");


// if(int.TryParse(Console.ReadLine(),out int Teste))
// {

// }
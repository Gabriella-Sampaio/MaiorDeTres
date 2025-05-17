Console.Clear();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine(@"   Digite 3 números e vou te   
 dizer qual o maior entre eles 
");
Console.ResetColor();

Console.Write("Vamos lá, 1° número  : ");
string priNumString = Console.ReadLine()!;
int priNum;
int.TryParse(priNumString, out priNum); //praticando o TryParse

Console.Write("Agora o 2° número    : ");
string segNumString = Console.ReadLine()!;
int segNum;
int.TryParse(segNumString, out segNum);

Console.Write("Por fim, o 3° número : ");
string terNumString = Console.ReadLine()!;
int terNum;
int.TryParse(terNumString, out terNum);
Console.WriteLine();

if (priNum == 0 || segNum == 0 || terNum == 0) //int letra == 0
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Insira um número");
}

else if (priNum > segNum && priNum> terNum)
{
    Console.Write($"O maior número é: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{priNum}");
}

else if (segNum > priNum && segNum > terNum)
{
    Console.Write($"O maior número é: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{segNum}");
}

else if (terNum > priNum && terNum > segNum)
{
    Console.Write($"O maior número é: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{terNum}");
}

else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Os numeros são iguais");
}
Console.ResetColor();
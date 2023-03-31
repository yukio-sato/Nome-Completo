void amogus(string frase, int fun)
{
    if (fun == 0)
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (fun == 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
        else if (fun == 2)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
for (int i = 0; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(75);
}
}

Console.Clear();
amogus("Primeiramente escreva seu nome: ",1);
string nome = Console.ReadLine()!;
Console.Clear();
amogus("Agora escreva seu sobrenome: ",1);
string sobrenome = Console.ReadLine()!;
Console.Clear();
string nomecompleto = nome + " " + sobrenome;
amogus($"Bom dia ",2);
amogus(nomecompleto,0);
amogus($", seu nome foi juntado :)\n",2);
amogus(sobrenome.ToUpper(),0);
amogus(" é seu sobrenome enquanto seu nome é ",2);
amogus(nome,0);
amogus(" :)",2);
Console.ResetColor();
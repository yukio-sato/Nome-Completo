string teste = @"############";
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkGreen;
for (int i = 0; i < 32; i++)
{
Console.Write("Primeiramente escreva seu nome: "[i]);
Console.Beep(1550, 45);    
}
string nome = Console.ReadLine()!;
Console.Clear();
for (int i = 0; i < 29; i++)
{
Console.Write("Agora escreva seu sobrenome: "[i]);
Console.Beep(1550, 45);    
}
string sobrenome = Console.ReadLine()!;
Console.Clear();
string nomecompleto = nome + " " + sobrenome; // ou string nomecompleto2 = $"{nome} {sobrenome}";
Console.WriteLine($"Bom dia {nomecompleto}, seu nome foi pegado :)"); // nomecompleto.ToUpper() É a palavra em maiusculo e nomecompleto.ToLower() o oposto
Thread.Sleep(1750);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"Bom dia {nomecompleto}, seu nome foi pegado :)");
Thread.Sleep(750);
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"Bom dia {nomecompleto.Replace(nomecompleto , teste)}, seu nome foi pegado :)");
Console.ResetColor();

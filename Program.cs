Console.WriteLine("*** Pet Hotel Check-in ***\n");

Console.Write("linhagem do seu pet: ");
string linhagem = Console.ReadLine()!;

Console.Write("Raça do seu pet: ");
string raca = Console.ReadLine()!;

Console.Write("Nome do seu pet: ");
string nome = Console.ReadLine()!;

Console.Write("Idade (anos): ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/cor do seu pet: ");
string pelagemCor = Console.ReadLine()!;

Console.Write("Porte (P,M ou G): ");
string porte = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Pet Hotel \"Bom pra Cachorro\"");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("            |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("| linhagem: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(linhagem.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("|");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("| Atende pelo nome de: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(nome.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("    |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkGray;

Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");

Console.Write("|Porte:");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(porte.ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                            |");


Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");

Console.ResetColor();
Console.Clear();

String segredo;
String letra;
string letracheck;
bool temounem;

Console.WriteLine("--- Forca ---");
Console.WriteLine(" ");
Console.WriteLine("Escreva a palavra secreta: ");
segredo = Console.ReadLine().ToLower();

Console.WriteLine("Escreva uma letra: ");
letra = Console.ReadLine();

letracheck = letra.ToLower();

temounem = segredo.Contains(letracheck);
Console.WriteLine($"A letra '{letra}' existe na palavra secreta?");
Console.WriteLine(temounem);

Console.Clear();

String segredo;
String letra;
bool temounem;

Console.WriteLine("--- Forca ---");
Console.WriteLine(" ");
Console.WriteLine("Escreva a palavra secreta: ");
segredo = Console.ReadLine();

Console.WriteLine("Escreva uma letra: ");
letra = Console.ReadLine();

temounem = segredo.Contains(letra);
Console.WriteLine($"A letra '{letra}' existe na palavra secreta?");
Console.WriteLine(temounem);

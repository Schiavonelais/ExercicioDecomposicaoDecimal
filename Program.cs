int numeroDigitado,centenas,dezenas,unidade;  
Console.Write("Digite um número inteiro...:"); 
numeroDigitado = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O número digitado é {numeroDigitado}");

centenas=numeroDigitado / 100;
dezenas= (numeroDigitado) % 100 / 10;
unidade= (numeroDigitado) % 100 % 10;
Console.WriteLine($"O numero possui {centenas} centena (s)");
Console.WriteLine($"{dezenas,17} dezena (s)");
Console.Write($"{unidade,17} unidade (s)");
int numero;
Console.WriteLine("------ Bem-vindo(a) ao programa Par & Impar ------");

Console.Write("Digite um número para conferir se ele é par ou impar: ");

while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
{
    Console.Write("Digite um número inteiro ou maior que 0. Digite novamente: ");
}

if (numero % 2 == 0){
    Console.WriteLine($"O número que você digitou é {numero} e é par");
}else{
    Console.WriteLine($"O número que você digitou é {numero} e é impar");
}

Console.Write("Digite qualquer tecla para finalizar o programa!");
Console.ReadKey();
Console.Clear();
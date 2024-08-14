
// int x = 10;
// double pi = 3.14;
// char letra = 'M';
// bool isTrue = true;
// string texto = "Uma linda mensagem";

// double outroValor;

// outroValor = x;

// int valorInteiro = (int) pi;

// Console.WriteLine(valorInteiro);

// int y = Convert.ToInt32(texto);

// int numero;
// Console.WriteLine("Digite um numero: ");
// numero = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numero);
// Console.WriteLine($"O dobro do numero e: {numero * 2}");


int n1, n2, soma, sub, mult;
double div;

Console.WriteLine("Digite o primeiro numero: ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
n2 = Convert.ToInt32(Console.ReadLine());

soma = n1 + n2;
sub = n1 - n2;
mult = n1 * n2;
div = (double) n1 / n2;

Console.WriteLine("A soma dos dois numeros e: " + soma);
Console.WriteLine($"A subtração do primeiro numero pelo segundo é: {sub}");
Console.WriteLine("A multiplicação e: {0}", mult);
Console.WriteLine("A divisao e: {0}", div);







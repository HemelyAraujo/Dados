using System.Security.Cryptography;

Console.WriteLine("--- Jogar o Dado ---\n");

Console.Write("Quantas lados ");
int lados = Convert.ToInt32(Console.ReadLine());
int jogada = RandomNumberGenerator.GetInt32(1, lados + 1);

Console.WriteLine($"\nJogada: {jogada}");

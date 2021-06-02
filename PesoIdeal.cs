using System;

namespace PesoIdeal
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Altura;
			double Peso;
			string Feminino;
			string Masculino;
			string Sexo;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Calculadora de peso ideal");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.Write("Digite sua altura em m: ");
			Altura = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira seu sexo (F para Feminino e M para Masculino): ");
			Sexo = Console.ReadLine();
			Console.WriteLine();
			
			Masculino = "M";
			Feminino = "F";
			
			if (Sexo == Masculino)
			{
				Peso = Altura * 72.7 - 58.0;
				Console.WriteLine($"Seu peso ideal é de {Peso:N2}Kg.");
			}
			else if (Sexo == Feminino)
			{
				Peso = Altura * 62.1 - 44.7;
				Console.WriteLine($"Seu peso ideal é de {Peso:N2}Kg.");
			}
			else
			{
				Console.WriteLine("Insira um caractere válido (F ou M)");
			}
        }
    }
}
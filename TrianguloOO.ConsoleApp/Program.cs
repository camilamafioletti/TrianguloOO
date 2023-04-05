namespace TrianguloOO.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();  

            Console.WriteLine("Insira o valor do comprimento dos lados do triângulo ");

            Console.Write("Lado 1: ");
            triangulo.lado1 = double.Parse(Console.ReadLine());

            Console.Write("Lado 2: ");
            triangulo.lado2 = double.Parse(Console.ReadLine());

            Console.Write("Lado 3: ");
            triangulo.lado3 = double.Parse(Console.ReadLine());

            triangulo.CalcularTriangulo();  
        }
    }
}
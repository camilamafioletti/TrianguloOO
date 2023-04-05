namespace TrianguloOO.ConsoleApp
{
    internal class Triangulo
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }

        public void CalcularTriangulo()
        {
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("\nÉ um triângulo equilátero");
                }
                else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("\nÉ um triângulo escaleno");
                }
                else
                {
                    Console.WriteLine("\nÉ um triângulo isósceles");
                }
            }
            else
            {
                Console.WriteLine("\nNão é um triângulo");
            }
        }
    }
}

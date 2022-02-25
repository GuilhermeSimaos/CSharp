using System;

class Program{
    public static void Main(string[] args)
    {
        Ponto p1 = new Ponto();
        Ponto p2 = new Ponto(0,3);
        Ponto p3 = new Ponto();
        p3.setXY(4,0);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n---------\tAtividade 02\t---------\n");
        Console.ResetColor();
        Console.Write("Digite o valor X do primeiro ponto: ");
        p1.setX(int.Parse(Console.ReadLine()));
        Console.Write("Digite o valor Y do primeiro ponto: ");
        p1.setY(int.Parse(Console.ReadLine()));

        CalcularAreaTriangulo(p1, p2, p3);
    }
    public static void CalcularAreaTriangulo(Ponto p1, Ponto p2, Ponto p3){
        Ponto auxPonto = new Ponto();
        double lado1,lado2,lado3, semiPerimetro, area;
        lado1 = auxPonto.Distancia(p1, p2);
        lado2 = auxPonto.Distancia(p2, p3);
        lado3 = auxPonto.Distancia(p3, p1);

        semiPerimetro = (lado1 + lado2 + lado3)/2;
        area = Math.Sqrt(semiPerimetro*(semiPerimetro-lado1)*(semiPerimetro-lado2)*(semiPerimetro-lado3));

        Console.WriteLine($"\nPonto1{"("+p1.getX(),15},{p1.getY()})\nPonto2{"("+p2.getX(),15},{p2.getY()})\nPonto3{"("+p3.getX(),15},{p3.getY()})\n");
        Console.WriteLine($"Lado1{lado1,19:F3}\nLado2{lado2,19:F3}\nLado3{lado3,19:F3}\n");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Semiperímetro{semiPerimetro,11:F3}\nArea Triângulo{area,10:F3}\n");
        Console.ResetColor();
    }
}
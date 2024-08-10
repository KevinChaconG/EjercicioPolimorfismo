
using EjercicioPolimorfismo;

Console.Write("---Calculadora de Areas---");
Console.WriteLine("Gracias por usar nuestra calculadora de Areas");

int opcion = 0;

do
{
    Menu();
    opcion = Convert.ToInt16(Console.ReadLine());
    switch (opcion)

    {
        case 1:
            AreaCuadrado areaCuadrado = new AreaCuadrado();
            Console.WriteLine();
            Console.WriteLine("Area de Cuadrado");
            Console.WriteLine("Ingrese el valor de los lados");
            areaCuadrado.s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El area del cuadrado es: {areaCuadrado.ImprimirArea()}mts2");
            break;

        case 2:
            AreaRectangulo areaRectangulo = new AreaRectangulo();
            Console.WriteLine();
            Console.WriteLine("Area de Rectangulo");
            Console.WriteLine("Ingrese el valor de la altura");
            areaRectangulo.h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la base");
            areaRectangulo.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El area del rectangulo es: {areaRectangulo.ImprimirArea()}mts2");
            break;

        case 3:
            AreaTriangulo areaTriangulo = new AreaTriangulo();
            Console.WriteLine();
            Console.WriteLine("Area de Triangulo");
            Console.WriteLine("Ingrese el valor de la altura");
            areaTriangulo.h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la base");
            areaTriangulo.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El area del triangulo es: {areaTriangulo.ImprimirArea()}mts2");
            break;

        default:
            Console.WriteLine("Opción Invalida");
            break;
    }

} while (opcion != 9);

Console.WriteLine("Gracias por utilizar nuestra calculadora");

Console.ReadLine();

static void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Ingrese una opción: ");
    Console.WriteLine("1. Calcular Area de Cuadrado");
    Console.WriteLine("2. Calcular Area de Rectangulo");
    Console.WriteLine("3. Calcular Area de Triangulo");
    Console.WriteLine("9. Salir");
}
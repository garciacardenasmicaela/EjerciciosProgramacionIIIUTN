using Practico1ProgramacionIII;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elegí ejercicio (1-5): ");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio1.Ejecutar();
                break;
            case 2:
                Ejercicio2.Ejecutar();
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}
namespace Practico1ProgramacionIII
{
    class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("DE REGISTRO DE USUARIO");

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            double estatura = double.Parse(Console.ReadLine());

            Console.Write("Ingresa tu DNI: ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu numero de telefono: ");
            int telefono = int.Parse(Console.ReadLine());

            Console.WriteLine("PERFIL CREADO");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad el proximo año: " + (edad + 1));
            Console.WriteLine("Estatura: " + estatura + " metros");
            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Numero de contacto: " + telefono);
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
        }
    }
}

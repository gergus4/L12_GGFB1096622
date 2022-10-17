internal class Program
{
    static void Main()
    {
        int[] notas = new int[14];
        
        Console.WriteLine("LABORATORIO 19; NOTAS Y PROMEDIO");
        
        double suma = 0;
        double prom = 0;

        for(int i = 0; i<14; i++)
        {
            Console.WriteLine("Ingrese la nota:");
            notas[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i<14; i++)
        {
            suma = suma+notas[i];
        }

        prom = suma / 15;
        Console.WriteLine("El promedio de las notas es: "+prom);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime cumpleaños = new DateTime(2023,7,25);
        DateTime fecha = new DateTime (2023, 6, 7);
        int cuotas = 6;
        DateTime fecha2 = new DateTime (2023, 11, 4);
        Console.WriteLine(CuandoEsMiCumple(cumpleaños));
        ObtenerFechaDePago(fecha, cuotas);
        ObtenerMesesEntre(fecha, fecha2);
        List<int> numeros = new List<int>();
        int numero;
        do {
            Console.Write("Ingresa un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
            if (numero != 0) 
            {
                numeros.Add(numero);
            }
        } while (numero != 0);
        int[] resultados = CalcularDatosDeLista(numeros);
        Console.WriteLine("Máximo: " + resultados[0]);
        Console.WriteLine("Mínimo: " + resultados[1]);
        Console.WriteLine("Suma: " + resultados[2]);
        Console.WriteLine("Promedio: " + resultados[3]);
        Console.WriteLine("Cantidad de elementos: " + resultados[4]);

    }
    public static string CuandoEsMiCumple(DateTime cumpleaños)
    {
        DateTime actual = DateTime.Today;
        if (cumpleaños.Month == actual.Month && cumpleaños.Day == actual.Day)
        {
            return "feliz cumpleaños";
        }
        else if (cumpleaños < actual)
        {
            TimeSpan tiempoPasado = actual - cumpleaños;
            return $"han pasado " + tiempoPasado.TotalDays + " dias desde el ultimo cumpleaños";
        }
        else 
        {
            TimeSpan tiempoRestante = cumpleaños - actual;
            return $"Faltan " + tiempoRestante.TotalDays + " para tu proximo cumpleaños";
        }
    }
    public static void ObtenerFechaDePago(DateTime fecha, int cuotas)
    {
        
        if (cuotas > 0)
        {
            for (int i = 0; i < cuotas;i++)
            {
                Console.WriteLine(fecha.AddMonths(i));
            }
        }
        else 
        {
            Console.WriteLine("no tiene ni una cuota");
        }
    }
    public static void ObtenerMesesEntre(DateTime fecha, DateTime fecha2)
    {
        string [] meses = {"enero", "febrero", "marzo", "abril" , "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"};
        if(fecha <= fecha2)
        {
              for(int i = fecha.Month-1; i <= fecha2.Month-1; i++ )
              {
                Console.WriteLine(meses[i]);
              }
        }
        else
        {
            Console.WriteLine("la primera fecha es mayo que la segunda");
        }
    }
    static int[] CalcularDatosDeLista(List<int> numeros) {
        int maximo = int.MinValue;
        int minimo = int.MaxValue;
        int suma = 0;
        
        foreach (int numero in numeros) {
            if (numero > maximo) {
                maximo = numero;
            }
            if (numero < minimo) {
                minimo = numero;
            }
            suma += numero;
        }
        int cantidad = numeros.Count;
        int promedio = cantidad == 0 ? 0 : suma / cantidad;
        return new int[] { maximo, minimo, suma, promedio, cantidad };
    }
}

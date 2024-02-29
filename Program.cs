internal class Program
{
    private static void Main(string[] args)
    {
        int i;//Definimos a "i" como entero

        for(i=1; i<=100;i++) //generamos un ciclo for de 1 a 100
        {
            if (i % 3 == 0 & i % 5 == 0)// Analisamos si el numero es divisible entre 3 y 5
            {
                Console.WriteLine("FizzBuzz");// imprimimos FizzBuzz si el numero es divisible entre 3 y 5

            } else if (i % 5 == 0)// analisamos si el numero es divsible entre 5 
            {
                Console.WriteLine("Buzz");// escribimos Buzz si es divisible entre 5
            }else if (i % 3 == 0) // analisamos si es divisible entre 3
            {
                Console.WriteLine("Fizz");// escribimos Fizz si es divisible entre 3
            }else
            {
                Console.WriteLine(i);// de lo contrario se escribe el numero 
            }
        }

    }
}
using System;
using System.Collections;


namespace ejercicio9
{

    public class ejercicio9
    {
        public static void Main()
        {
            int palabra;
            Stack Pila = new Stack();
            Queue miCola = new Queue();  
            Queue miCola2 = new Queue();
            

            miCola.Enqueue(7);
            miCola.Enqueue(4);
            miCola.Enqueue(5);
            miCola.Enqueue(2);
            miCola.Enqueue(4);
            miCola.Enqueue(9);
            miCola.Enqueue(7);
           
            for (byte i = 0; i < 3; i++)
            {
                palabra = (int)miCola.Dequeue();  
                Console.WriteLine(palabra);
            }
            Console.ReadKey();
            while (miCola.Count > 0)
            {
                
                int Co = 0;
                Co = (int)miCola.Dequeue();
                Console.WriteLine($"  Cola: {Co}");
                Pila.Push(Co);
            }
            // pantalla la pila
            Console.WriteLine("La pila creada: ");
            while (Pila.Count > 0)
            {
                Console.WriteLine($"  Pila: {Pila.Pop()}");
            }

           
            while (miCola2.Count > 0)
            {
                miCola2.Enqueue(Pila);
                int cola;
                cola = (int)miCola2.Dequeue();
                Console.WriteLine(cola);
            }
        }

    }
}
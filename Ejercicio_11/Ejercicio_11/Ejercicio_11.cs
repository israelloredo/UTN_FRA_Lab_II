using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Commons;

namespace Ejercicio_11
{
    class Ejercicio_11
    {
        int minimo, maximo, total = 0;
        bool flag = true;
        const int MAXIMO = 100, MINIMO = -100, CANTIDAD = 10;

        public Ejercicio_11()
        {
            this.inicializar();
        }

        static void Main(string[] args)
        {
            Ejercicio_11 instance = new Ejercicio_11();
            instance.Mostrar();
        }

        private float obtenerPromedio()
        {
            return total / CANTIDAD;
        }

        private void calcular(int numero)
        {
            if (!flag)
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }
            }
            else
            {
                minimo = numero;
                maximo = numero;
                flag = false;
            }
        }

        private void inicializar()
        {
            int i = 0;
            while (i < CANTIDAD)
            {
                int numero = Input.numberInt(
                    string.Format("Ingrese un numero - {0}",i ),
                    "Error - no es un valor valido");

                if (Validacion.Validar(numero, MAXIMO, MINIMO))
                {
                    calcular(numero);
                    i++;
                    total += numero;
                }
                else
                {
                    Console.WriteLine("El valor a ingresar debe estar dentro de un rango de entre {0} y {1}", MAXIMO, MINIMO);
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("El maximo es {0}", maximo);
            Console.WriteLine("El minimo es {0}", minimo);
            Console.WriteLine("El promedio es {0}", obtenerPromedio());
            Console.ReadKey();
        }
    }
}

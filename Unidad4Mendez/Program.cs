using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad4Mendez
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ejercicio1();
            //Ejercicio2();
           // Ejercicio3();
            Ejercicio4();
        }
        static void Ejercicio1()
        {
            int cantidad = 0;
            int n = 0;
            string valor = "";

            Console.WriteLine("Dame la cantidad de empleados");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            int[] empleados = new int[cantidad];

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Dame el sueldo del empleado " + n);
                valor = Console.ReadLine();
                empleados[n] = Convert.ToInt32(valor);

            }

            Console.WriteLine(Environment.NewLine+"Salario de los empleados: " + Environment.NewLine);
            Imprime(empleados);
            Console.WriteLine(Environment.NewLine+"Salario actualizado con un aumento del 10%" + Environment.NewLine);
            AumentoSalario(empleados);
        }
        
        static void AumentoSalario(int[] arreglo)
        {
            int n;
            int Aumento;
            int NuevoSueldo;
            for (n = 0; n < arreglo.Length; n++)
            {
                Aumento = (arreglo[n] * 10) / 100;
                NuevoSueldo = Aumento + arreglo[n];
                Console.WriteLine("Empleado N° "+ n + " : " + NuevoSueldo);
            }
        }
        
        static void Imprime(int[] arreglo)
        {
            int n;

            for (n = 0; n < arreglo.Length; n++)
            {
                Console.WriteLine("Empleado N° "+ n +" : " + arreglo[n]);
            }
            

        }
        static void Ejercicio2()
        {
            
            ArrayList calif = new ArrayList();
            Agregar(calif);
           // Imprime(calif);
            Promedio(calif);

        }
        static void Agregar(ArrayList arreglo)
        {
            int cantidad;
            string valor;
            //float calif;
            Console.WriteLine("Dame la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            ArrayList calif = new ArrayList(3);
            for (int i = 0; i < calif.Count; i++)
            {
                Console.WriteLine("Dame la calificación del alumno");
                valor=Console.ReadLine();
                calif[i] = Convert.ToSingle(valor);
                arreglo.Add(calif[i]);
            }
            
        }
        static void Promedio(ArrayList arreglo)
        {
            
            float suma = 0.0f;
            float prom=0.0f;
            foreach (int n in arreglo)
            {
                suma =suma + n;
            }
             prom = suma / arreglo.Count ;
           Console.WriteLine("El promedio es {0}",prom);
        }
        static void CalifMax(ArrayList arreglo)
        { 
            float maxima=0.0f;
            for (int i = 0; i < arreglo.Count; i++)
            {
                if (arreglo.IndexOf(i) > maxima)
                    maxima = arreglo.IndexOf(i);
            }
        }
        static void CalifMin(ArrayList arreglo)
        {
            float minima = 10.0f;
           for(int i=0; i < arreglo.Count; i++)
            {
                if (arreglo.IndexOf(i) < minima)
                    minima = arreglo.IndexOf(i);
            }
        }

        static void Imprime(ArrayList arreglo)
        {
            foreach(int j in arreglo)
            {
                Console.WriteLine(" Datos "+j);
            }
        }

        static void Ejercicio3()
        {
            Hashtable diccionario = new Hashtable();
            diccionario.Add("Abrtration","Prpiedad y/o técnica de software que oculta los detalles de la implemetnación");
            diccionario.Add("Algoritmo","Método que describe cómo se resuelve un problema en término de las acciones que se ejecutan y especifica el orden en que se ejecutan estas acciones.");
            diccionario.Add("Array","Objeto contenedor que almacena una secuencia indexada de los mismos tipos de datos");
            diccionario.Add("Binario","Representación numérica en base 2. En esta base sólo se utilizan los digitos 0 y 1");
            diccionario.Add("", "");
            Console.WriteLine("Diccionario de Programación");
            foreach (DictionaryEntry elem in diccionario)
            {
                
                Console.WriteLine(elem.Key + ": " + elem.Value);
            }

        }
        
        static void Ejercicio4()
        {
            int cantidad = 5;
            string valor = "";
            Console.WriteLine("Dame 5 cadenas de texto");
            ArrayList cadena = new ArrayList();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Dame la cadena N° " + i);
                valor = Console.ReadLine();
               
                cadena.Add(valor);
                Console.WriteLine(cadena[i]);
              

            }
            for(int i =0; i<cadena.Count;i++)
            {
                cadena.Sort();
                Console.WriteLine(cadena[i]);
            }

            
            


            
        }
    }
}

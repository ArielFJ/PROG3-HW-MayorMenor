using System;

namespace MayorMenor{
    
    class Program{

        static void Main(string[] args){
            Console.WriteLine("Introduzca 10 números, pulse ENTER luego de introducir cada uno.\n" + 
                                "Si no introduce un número válido, ese espacio será considerado como un 0. ");
            int[] numeros = ObtenerNumeros();
            Console.WriteLine("\nEl número mayor es " + ObtenerMayor(numeros));
            Console.WriteLine("\nEl número menor es " + ObtenerMenor(numeros));
        }

        static int[] ObtenerNumeros(){
            int[] numeros = new int[10];
            for(int i = 0; i < numeros.Length; i++){
                int.TryParse(Console.ReadLine(), out numeros[i]);
            }
            return numeros;
        }

        static int ObtenerMayor(int[] numeros){
            int mayor = int.MinValue;
            foreach(int numero in numeros)
                if(numero > mayor)
                    mayor = numero;
            return mayor;
        }

        static int ObtenerMenor(int[] numeros){
            int menor = int.MaxValue;
            foreach(int numero in numeros)
                if(numero < menor)
                    menor = numero;
            return menor;
        }

    }
}
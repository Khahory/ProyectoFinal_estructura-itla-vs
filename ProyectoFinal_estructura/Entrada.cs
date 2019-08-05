using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal_estructura
{
    class Entrada
    {
        List<Int32> numeros;

        public Entrada()
        {
            numeros = new List<Int32>();
            PedirNumeros();
            MostrarNumerosOriginales();
            MostrarNumerosDecendentes();
            MostrarNumerosAcendentes();
        }

        private void PedirNumeros()
        {
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("Digite el numero que estara en el registro # " +i.ToString());
                numeros.Add(int.Parse(Console.ReadLine()));
            }
        }

        private void MostrarNumerosOriginales()
        {
            Console.WriteLine("Aqui se muestran los numeros en orden como se registraron");
            foreach (var item in numeros)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("###########################################################################");
            Console.ReadKey();
        }

        private void MostrarNumerosDecendentes()
        {
            numeros.Sort();
            numeros.Reverse();
            Console.WriteLine("Aqui se muestran los numeros en orden decendentes");
            foreach (var item in numeros)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("###########################################################################");
            Console.ReadKey();
        }

        private void MostrarNumerosAcendentes()
        {
            numeros.Sort();
            Console.WriteLine("Aqui se muestran los numeros en orden acendente");
            foreach (var item in numeros)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("###########################################################################");
            Console.ReadKey();
        }
    }
}

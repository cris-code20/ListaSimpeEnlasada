using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimpeEnlasada
{

    public class Nodo
    {
        public int Datos;
        public Nodo siguiente;

        public Nodo(int dato)
        {
            this.Datos = dato;
            this.siguiente = null; 
        }
    }


    public class SimpleLists
    {

        private Nodo inicio;

        public SimpleLists()
        {
            inicio = null;
        }

        public void Add (int data)
        {
            Nodo newNodo = new Nodo(data);

            if(inicio == null)
            {
                inicio = newNodo;
            }else
            {
                Nodo recorrido = inicio;
                while(recorrido.siguiente != null)
                {
                    recorrido = recorrido.siguiente;
                }

                recorrido.siguiente = newNodo;
            }
        }

        public void ListarDatos()
        {

            if(inicio == null)
            {
                Console.WriteLine("Lista vacia");
                return;
            }

            Nodo recorrido = inicio;
            Console.WriteLine("elementos de la listas");
            while(recorrido != null)
            {
                Console.WriteLine(recorrido.Datos + "->");
                recorrido = recorrido.siguiente;
                
            }
            Console.WriteLine("vacio");

        }

        public void Eliminar(int data)
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vacia");
                return;
            }

            if (inicio.Datos == data)
            {
                inicio = inicio.siguiente;
                return;
            }

            Nodo recorrido = inicio;
            Nodo nodoPrevio = null;

            while (recorrido != null && recorrido.Datos != data)
            {
                nodoPrevio = recorrido;
                recorrido = recorrido.siguiente;
            }

            if (recorrido == null)
            {
                Console.WriteLine("la info no esta en la lista");
                return;
            }

            nodoPrevio.siguiente = recorrido.siguiente;
        }

    }
}

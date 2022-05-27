using System;
using System.Drawing;

namespace culebrita
{
    internal class ColaLineal
    {
        public Nodo primero;
        public Nodo ultimoN;
        public int n;

        public ColaLineal()
        {
            primero = ultimoN = null;
        }

        public void insetar(Point elemento)
        {
            Nodo nuevo = new Nodo(elemento);
            if (!colaVacia())
            {
                ultimoN.siguiente = nuevo;
            }
            else
            {
                primero = nuevo;
            }
            ultimoN = nuevo;
            n++;
        }
        public Object quitar()
        {
            Object aux;
            if (!colaVacia())
            {
                aux = primero.elemento;
                primero = primero.siguiente;
                n--;
            }
            else
            {
                throw new Exception("Cola vacía");
            }
            return aux;
        }

        public Object ultimo()
        {
            if (!colaVacia())
            { 
                return ultimoN.elemento;
            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }
        public int count()
        {
            int cantidad;
            Nodo  aux = primero;
            if (!colaVacia())
            {
                cantidad = 1;
                while(aux != ultimoN)
                {
                    aux = aux.siguiente;
                    cantidad++;
                }
            }
            else
            {
                cantidad = 0;
            }
            return cantidad;
        }

        //Acceso a la cola 
        public Object frenteCola()
        {
            if (!colaVacia())
            { //Valida si la cola no está vacía
                return primero.elemento;
            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }
        public bool colaVacia()
        {
            return primero == null;
        }
    }
}

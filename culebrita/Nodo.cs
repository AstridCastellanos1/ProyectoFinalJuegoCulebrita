using System;

namespace culebrita
{
    internal class Nodo
    {
        public Object elemento;
        public Nodo siguiente;

        public Nodo(Object x)
        {
            elemento = x;
            siguiente = null;
        }
    }
}

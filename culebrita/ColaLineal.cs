using System;
using System.Drawing;

namespace culebrita
{
    internal class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 2000;
        protected int frente;
        protected Object[] listaCola;
        public int nFin;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[MAXTAMQ];
        }

        public void insetar(Point elemento)
        {
            if (!colaLlena())
            {
                nFin++;
                listaCola[++fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        }
        public Object quitar()
        {
            if (!colaVacia())
            {
                nFin--;

                return listaCola[frente++];

            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }

        public Object ultimo()
        {
            return listaCola[fin];
        }

        public int count()
        {
            return nFin;
        }

        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //Acceso a la cola 
        public Object frenteCola()
        {
            if (!colaVacia())
            { //Valida si la cola no está vacía
                return listaCola[frente++];
            }
            else
            {
                throw new Exception("Cola vacía");
            }
        }
        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }
    }
}

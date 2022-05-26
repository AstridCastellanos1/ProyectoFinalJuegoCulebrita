using System;
using System.Drawing;
using System.Collections;

namespace culebrita
{
    internal class ColaLineal
    {
        protected int fin;
        protected int frente;
        protected ArrayList listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new ArrayList();
        }

        public void insetar(Point elemento)
        {
            listaCola.Add(elemento);
            ++fin;
        }


        public Object quitar()
        {
            if (!colaVacia())
            {
                Object aux = listaCola[frente];
                listaCola.RemoveAt(frente);
                fin--;
                return aux;
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
            return listaCola.Count;
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

    }
}

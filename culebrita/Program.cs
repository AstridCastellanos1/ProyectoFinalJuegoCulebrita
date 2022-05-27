using System;
using System.Drawing;
using System.Threading;

namespace culebrita
{
    class Program
    {   //convertirlo en un programa orietado a objetos 
        //emitir beep cuando coma la comida 
        //incrementar la velocidad conforme vaya avanzando
        //modificar el uso de queue y reemplazarlo con la estructura de cola vista en clase
        //colalinal arreglo
        //cola arraylist
        //cola lista enlazada
        // explicar qué pasa al alterar cada una de las lineas marcadas con las preguntas
        // se aprecia si pueden cambiar las reglas del juego o si le agrega cosas extra

        static void Main()
        {

            String texto;

            do
            {
                var punteo = 0;
                var velocidad = 100; //modificar estos valores y ver qué pasa
                var posiciónComida = Point.Empty;
                var tamañoPantalla = new Size(60, 20);
                var culebrita = new ColaLineal();
                var longitudCulebra = 3; //modificar estos valores y ver qué pasa
                var posiciónActual = new Point(0, 9); //modificar estos valores y ver qué pasa
                culebrita.insetar(posiciónActual);
                var dirección = Direccion.Direction.Derecha; //modificar estos valores y ver qué pasa

                Diseño.DibujaPantalla(tamañoPantalla);
                Diseño.MuestraPunteo(punteo);

                while (Direccion.MoverLaCulebrita(culebrita, posiciónActual, longitudCulebra, tamañoPantalla))
                {
                    Thread.Sleep(velocidad);
                    dirección = Direccion.ObtieneDireccion(dirección);
                    posiciónActual = Direccion.ObtieneSiguienteDireccion(dirección, posiciónActual);

                    if (posiciónActual.Equals(posiciónComida))
                    {
                        Diseño.Sonidos(@"../../../EfectosDeSonido/Comer1.wav");
                        posiciónComida = Point.Empty;
                        longitudCulebra++; //modificar estos valores y ver qué pasa
                        punteo += 10; //modificar estos valores y ver qué pasa
                        Diseño.MuestraPunteo(punteo);
                        velocidad -= 5;
                    }

                    if (posiciónComida == Point.Empty) //entender qué hace esta linea
                    {
                        posiciónComida = Diseño.MostrarComida(tamañoPantalla, culebrita);
                    }
                }

                Console.ResetColor();
                Console.SetCursorPosition(tamañoPantalla.Width / 2 - 4, tamañoPantalla.Height / 2);
                Diseño.Sonidos(@"../../../EfectosDeSonido/gameNegative3.wav");
                Console.Write("Fin del Juego\n");
                Thread.Sleep(1200);
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n");
                Console.Write("                        Nuevo juego? s/n:  ");
                texto = Console.ReadLine();
                

            } while (texto.Equals("s"));

        }
    }//end class
}














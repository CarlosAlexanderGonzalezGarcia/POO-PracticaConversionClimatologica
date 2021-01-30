using System;

namespace Conversion {

    //Cambio el nombre de class Program que se crea por defecto a class Temp
    class Temp {

        //Creo los atributos que nesecitare en esta clase
        private float fahrenheit, kelvin, celsius;

        //Creo mi primer metodo, el cual capturara la temperatura en Celsius
        public void Captura() {

            //Pido por teclado el dato que requiero
            Console.Write("Ingresa la temperatura en Celsius: ");
            //Lo guardo en el atributo celsius
            celsius = float.Parse(Console.ReadLine());
        }

        //Creo mi segundo metodo el cual realizara la conversion de celsius a fahrenheit y kelvin, por ultimo imprimira el resultado
        public void Operacion() {

            //Inicio mi atributo fahrenheit dentro de mi metodo Operacion
            fahrenheit = 32.00F;
            //Inicio mi atributo kelvin dentro de mi metodo Operacion
            kelvin = 273.15F;
            //Realizo la conversiona a fahrenheit
            fahrenheit += (celsius * 9 / 5);
            //Realizo la conversion a kelvin
            kelvin += celsius;
            //Imprimo el resultado
            Console.Write("\n" + celsius + "° Celsius es igual a: " + fahrenheit + "°" + "F" + "\n" + "\n" +
                                 celsius + "° Celsius es igual a: " + kelvin + "°" + "K" + "\n" + "\n");
        }

        //Por ultimo en mi funcion principal llamo a mis metodos creados
        static void Main(string[] args) {

            //Creo mi instancia la cual llamara a mis metodos
            Temp fin = new Temp();
            //Hago que fin llame al metodo captura
            fin.Captura();
            //Hago que fin llame al metodo OperacionFarenheint
            fin.Operacion();

            //Salgo del programa
            Console.Write("Oprime cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
    //fin de mi clase Temp
}

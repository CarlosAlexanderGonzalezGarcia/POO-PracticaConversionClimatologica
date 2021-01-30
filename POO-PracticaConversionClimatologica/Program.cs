using System;

namespace Conversion
{
    //Cambio el nombre de class Program que se crea por defecto a class Temp
    class Temp
    {
        //Creo los atributos que nesecitare en esta clase
        private int celsius;
        private float fahrenheit, kelvin;

        //Creo mi primer metodo, el cual capturara la temperatura en Celsius
        public void Captura()
        {
            //Pido por teclado el dato que requiero
            Console.Write("Ingresa la temperatura en Celcius: ");
            //Lo guardo en el atributo celsius
            celsius = int.Parse(Console.ReadLine());
        }
        //Creo mi segundo metodo el cual realizara la conversion de celsius a fahrenheit eh imprimira el resultado
        public void OperacionFarenheint()
        {
            //Inicio mi atributo fahrenheit dentro de este metodo
            fahrenheit = 32.00F;
            //Realizo la conversion
            fahrenheit *= celsius;
            //Imprimo el resultado
            Console.Write("\n" + celsius + "° Celsius es igual a: " + fahrenheit + "°" + " Fahrenheit" + "\n" + "\n");
        }
        //Creo mi tercer metodo el cual realizara la conversion de celsius a kelvin eh imprimira el resultado
        public void OperacionKelvin()
        {
            //Inicio mi atributo kelvin dentro de este metodo
            kelvin = 274.15F;
            //Realizo la conversion
            kelvin *= celsius;
            //Imprimo el resultado
            Console.Write(celsius + "° Celsius es igual a: " + kelvin + "°" + " Kelvin" + "\n" + "\n");
        }
        //Por ultimo en mi funcion principal llamo a mis metodos creados
        static void Main(string[] args)
        {
            //Creo mi instancia la cual llamara a mis metodos
            Temp fin = new Temp();
            //Hago que fin llame al metodo captura
            fin.Captura();
            //Hago que fin llame al metodo OperacionFarenheint
            fin.OperacionFarenheint();
            //Hago que fin llame al metodo OperacionKelvin
            fin.OperacionKelvin();

            //fin

            //Salgo del programa
            Console.Write("Oprime cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}

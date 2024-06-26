﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Omar Bazar

/*Se viola el principio de responsabilidad única (SRP)
Se viola el principio de abierto/cerrado (OCP)
Se viola el principio de inversión de dependencias (DIP)
De esta forma Las clases Tren y Avion ya no dependen directamente de 
la clase TransporteRepository, sino que dependen de la interfaz ITransporte*/

namespace ProyectoSolucion
{
    public class Program
    {

        static void Main(string[] args)
        {

            List<ITransporte> transportes = new List<ITransporte>();

            Avion avion1 = new Avion();
            avion1._nombre = "AVION 01";
            avion1._velocidadActual = 0;
            avion1._velocidadMaxima = 100;
            avion1._alturaActual = 0;
            avion1._alturaMaxima = 100;
            transportes.Add(avion1);

            Avion avion2 = new Avion();
            avion2._nombre = "AVION 02";
            avion2._velocidadActual = 0;
            avion2._velocidadMaxima = 100;
            avion2._alturaActual = 0;
            avion2._alturaMaxima = 100;
            transportes.Add(avion2);

            Tren tren1 = new Tren();
            tren1._nombre = "TREN 01";
            tren1._velocidadActual = 0;
            tren1._velocidadMaxima = 100;
            transportes.Add(tren1);

            Console.WriteLine("Inicio del viaje :)");

            foreach (ITransporte transporte in transportes)
            {
                if (transporte is Avion)
                {
                    transporte.Volar(10);
                }
                else
                {
                    transporte.Acelerar(10);
                }
            }

            Console.WriteLine("Fin del viaje :)");
        }
    }
}


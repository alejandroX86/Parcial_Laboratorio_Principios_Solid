using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSolucion
{
    public class TransporteRepository
    {
        public void Guardar(ITransporte transporte)
        {
            // Implementación del código para guardar el transporte en la base de datos
            List<ITransporte> transportes = new List<ITransporte>();

            Avion avion1 = new Avion(0, 100, 0, 100);
            avion1._nombre = "AVION 01";
            transportes.Add(avion1);

            Avion avion2 = new Avion(0, 100, 0, 100);
            avion2._nombre = "AVION 02";
            transportes.Add(avion2);

            Tren tren1 = new Tren(0, 100);
            tren1._nombre = "TREN 01";
            transportes.Add(tren1);

            TransporteRepository repository = new TransporteRepository();

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

                repository.Guardar(transporte);
            }

            Console.WriteLine("Fin del viaje :)");


        }

    }
}

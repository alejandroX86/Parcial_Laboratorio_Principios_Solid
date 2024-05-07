using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSolucion
{
    public class Avion : ITransporte
    {

        public int _velocidadActual;
        public int _velocidadMaxima;
        public int _alturaActual;
        public int _alturaMaxima;
        internal string _nombre;

        public Avion()
        {
        }

        public Avion(int velocidadActual, int velocidadMaxima, int alturaActual, int alturaMaxima)
        {
            this._velocidadActual = velocidadActual;
            this._velocidadMaxima = velocidadMaxima;
            this._alturaActual = alturaActual;
            this._alturaMaxima = alturaMaxima;
        }

        public void Acelerar(int velocidad)
        {
            // Implementación del método Acelerar
        }

        public void Desacelerar(int velocidad)
        {
            // Implementación del método Desacelerar
        }

        public void guardarEnBD()
        {
            throw new NotImplementedException();
        }

        public void Volar(int altitud)
        {
            // Implementación del método Volar
        }
    }
}

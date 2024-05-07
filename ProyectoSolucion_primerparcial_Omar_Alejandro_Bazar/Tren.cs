using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSolucion
{
    public class Tren: ITransporte
    {
    
    public int _velocidadActual;
        public int _velocidadMaxima;
        internal string _nombre;

        public Tren()
        {
        }

        public Tren(int velocidadActual, int velocidadMaxima)
        {
            this._velocidadActual = velocidadActual;
            this._velocidadMaxima = velocidadMaxima;
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

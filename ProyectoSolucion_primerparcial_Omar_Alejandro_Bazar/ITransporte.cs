﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSolucion
{
    public interface ITransporte
    {

        void Acelerar(int velocidad);
        void Desacelerar(int velocidad);
        void Volar(int altitud);
        void guardarEnBD();
    }
}

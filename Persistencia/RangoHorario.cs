﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Persistencia
{
    class RangoHorario : IEquatable<RangoHorario>
    {
        [Key]
        public int Codigo { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        /// <summary>
        /// Determina si dos Rango Horarios son iguales por código
        /// </summary>
        /// <param name="other">Otro Rango Horario</param>
        /// <returns>Tipo de dato booleano que representa si dos intancias son iguales o no</returns>
        public bool Equals(RangoHorario other)
        {
            return this.Codigo == other.Codigo;
        }
    }
}

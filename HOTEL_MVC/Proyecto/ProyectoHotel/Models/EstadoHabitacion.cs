﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoHotel.Models
{
    // tình trạng phòng
    public class EstadoHabitacion
    {
        public int IdEstadoHabitacion { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
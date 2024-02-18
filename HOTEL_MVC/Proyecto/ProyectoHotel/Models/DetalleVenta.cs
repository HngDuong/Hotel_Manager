using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoHotel.Models
{
    // Chi tiết bán hàng
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public Producto oProducto { get; set; }
        public int IdVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
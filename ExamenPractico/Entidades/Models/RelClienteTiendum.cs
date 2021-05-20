﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Datos.Models.Models
{
    public partial class RelClienteTiendum
    {
        public int? IdCliente { get; set; }
        public int? IdTienda { get; set; }
        public int? Monto { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Tiendum IdTiendaNavigation { get; set; }
    }
}

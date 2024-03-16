﻿using System;

namespace SalesSystem.Models
{
    public class TFactura
    {
        public string CodigoArticulo { set; get; }
        public int UsuarioFactura { set; get; }
        public int CantidadArticulo { set; get; }
        public int ConsecutivoFactura { set; get; }
        public DateTime FechaFactura { set; get; }
        public string DetallesFactura { set; get; }
    }
}

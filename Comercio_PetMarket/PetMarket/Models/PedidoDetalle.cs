//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetMarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PedidoDetalle
    {
        public int PedidoDetalle1 { get; set; }
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

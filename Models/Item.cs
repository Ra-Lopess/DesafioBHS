using System;
using System.Collections.Generic;

#nullable disable

namespace ToBuy.Models
{
    public partial class Item
    {
        public int Codigo { get; set; }
        public int Codigopedido { get; set; }
        public string Descricao { get; set; }
        public decimal Valoritem { get; set; } = 0;

        // FK
        public virtual Pedido PedidoFK { get; set; }
    }
}

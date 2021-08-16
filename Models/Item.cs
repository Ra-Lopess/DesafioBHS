using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ToBuy.Models
{
    public partial class Item
    {
        public int Codigo { get; set; }
        public int Codigopedido { get; set; }

        [MaxLength (50)]
        public string Descricao { get; set; }
        public decimal Valoritem { get; set; } = 0;

        // FK
        public virtual Pedido PedidoFK { get; set; }
    }
}

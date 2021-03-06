using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ToBuy.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Itens = new HashSet<Item>();
        }

        public int Codigo { get; set; }

        [MaxLength (40)]
        public string Descricao { get; set; }
        public DateTime Datapedido { get; set; } = DateTime.Now;
        public decimal Valorpedido { get; set; }
        public string Status { get; set; } = "A";

        public virtual ICollection<Item> Itens { get; set; }
    }
}

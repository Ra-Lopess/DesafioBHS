using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ToBuy.Models;

namespace ToBuy.Data {
    public partial class DataContext : DbContext {
        public DataContext() {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public virtual DbSet<Item> Itens { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Item>(entity => {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("ITENS");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Codigopedido).HasColumnName("CODIGOPEDIDO");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Valoritem)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VALORITEM");

                entity.HasOne(d => d.PedidoFK)
                    .WithMany(p => p.Itens)
                    .HasForeignKey(d => d.Codigopedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITENS_PEDIDOS");
            });

            modelBuilder.Entity<Pedido>(entity => {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("PEDIDOS");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Datapedido)
                    .HasColumnType("datetime")
                    .HasColumnName("DATAPEDIDO");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength(true);

                entity.Property(e => e.Valorpedido)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("VALORPEDIDO");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public void CargaInicial() {
            if (!Itens.AnyAsync().Result && !Pedidos.AnyAsync().Result) {
                Txt();
            }
        }

        private void Txt() {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Desafio.txt");

            List<string> readText = File.ReadAllLines(path).ToList();

            foreach (string txt in readText) {

                if (txt.StartsWith("1")) {

                    string strCodigo = txt.Substring(1, 5);
                    int.TryParse(strCodigo, out int codigo);
                    //Thor
                    int fimStrDescricao = txt.IndexOf("itens") - 1;
                    string descricao = txt.Substring(6, 40);
                    string strDataPedido = txt.Substring(fimStrDescricao + 6, 14);
                    DateTime dataPedido = DateTime.ParseExact(strDataPedido, "yyyyMMddHHmmss", null);
                    string strValorPedido = txt.Substring(fimStrDescricao + 20, 10);
                    decimal valorPedido = decimal.Parse(strValorPedido);
                    string status = txt.Substring(fimStrDescricao + 30, 1);


                    Pedidos.Add(new Pedido {
                        Codigo = codigo,
                        Descricao = descricao.ToLower(),
                        Datapedido = dataPedido,
                        Valorpedido = valorPedido,
                        Status = status
                    });
                }
                else {

                    string codigo = txt.Substring(1, 5);
                    string codigoPedido = txt.Substring(6, 5);
                    string descricao = txt.Substring(11, 50);
                    string valorItem = txt.Substring(61, 10);

                    Itens.Add(new Item {
                        Codigo = int.Parse(codigo),
                        Codigopedido = int.Parse(codigoPedido),
                        Descricao = descricao,
                        Valoritem = decimal.Parse(valorItem)
                    });
                }
            }
            this.SaveChanges();
        }


    }
}

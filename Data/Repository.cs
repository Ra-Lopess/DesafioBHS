using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToBuy.Models;

namespace ToBuy.Data {
    public class Repository : IRepository {
        private readonly DataContext _context;

        public Repository(DataContext context) {
            _context = context;
        }

        public void Add<T>(T entity) where T : class {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class {
            _context.Update(entity);
        }
        public List<Pedido> Search(string search) {
            IQueryable<Pedido> query = _context.Pedidos;
            List<Pedido> Find = new List<Pedido>();

            foreach (var item in query) {
                if (item.Descricao.ToLower().Contains(search.ToLower()))
                    Find.Add(item);
            }

            return Find.OrderBy(p => p.Codigo).ToList();
        }

        public bool SaveChanges() {
            return (_context.SaveChanges() > 0);

        }
        public IQueryable<Pedido> GetAllPedidos() {
            IQueryable<Pedido> query = _context.Pedidos;

            query = query.AsNoTracking().Include(i => i.Itens).OrderBy(p => p.Codigo).Reverse();

            return query;
        }

        public Pedido GetPedidoByCod(int codigo) {
            var pedido = _context.Pedidos.FirstOrDefault(p => p.Codigo == codigo);

            return pedido;
        }

        public int GetPedidoLastCod() // pegar o ultimo id 
        {
            IQueryable<Pedido> query = _context.Pedidos;
            query = query.OrderBy(p => p.Codigo);

            if (!query.Any()) {
                return 0;
            }
            return query.Last().Codigo;
        }

        public IQueryable<Pedido> GetAllPedidosByFilter(int filter)
        {
            IQueryable<Pedido> query = _context.Pedidos;
            
            var result = filter switch{
                1 => query = query.AsNoTracking().Include(i => i.Itens).OrderBy(p => p.Codigo).Reverse(),
                2 => query = query.AsNoTracking().Include(i => i.Itens).OrderBy(p => p.Codigo),
                3 => query = query.AsNoTracking().Include(i => i.Itens).OrderBy(p => p.Status),
                4 => query = query.AsNoTracking().Include(i => i.Itens).OrderBy(p => p.Status).Reverse()
            };

            return query;
        }
    }
}
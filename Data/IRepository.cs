using System.Collections.Generic;
using System.Linq;
using ToBuy.Models;

namespace ToBuy.Data {
    public interface IRepository {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        List<Pedido> Search(string search);
        bool SaveChanges();
        IQueryable<Pedido> GetAllPedidos();
        Pedido GetPedidoByCod(int codigo);
        int GetPedidoLastCod();

        IQueryable<Pedido> GetAllPedidosByFilter(int filter);
    }
}
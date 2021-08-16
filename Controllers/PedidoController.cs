using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToBuy.Data;
using ToBuy.Models;

namespace ToBuy.Controllers
{
    public class PedidoController : Controller
    {
        public readonly IRepository _repo;

        public PedidoController(IRepository repo) {
            _repo = repo;
        }
        public async Task<IActionResult> Pedido(int pageNumber=1)
        {
            var pedidos = _repo.GetAllPedidos();
            
            return View(await Paginacao<Pedido>.CreateAsync(pedidos, pageNumber, 10));
        }

        public IActionResult PedidoRemove(int codigo)
        {
            var pedido = _repo.GetPedidoByCod(codigo);

            if(pedido == null)
                return NotFound();
            
            
            pedido.Status = "E";
            _repo.Update(pedido);
            if(_repo.SaveChanges())
                return RedirectToAction("Pedido");
            
            return NotFound();
        }

        public IActionResult PedidoRestore(int codigo)
        {
            var pedido = _repo.GetPedidoByCod(codigo);

            if(pedido == null)
                return NotFound();
            
            
            pedido.Status = "A";
            _repo.Update(pedido);
            if(_repo.SaveChanges())
                return RedirectToAction("Pedido");

            return NotFound();
        }

        public IActionResult PedidoAdd(){
            return View();
        }

        [HttpPost]

        public IActionResult PedidoAdd(Pedido pedido){
            pedido.Codigo = _repo.GetPedidoLastCod() + 1;
            _repo.Add(pedido);

            if(_repo.SaveChanges())
                return RedirectToAction("Pedido");

            return NotFound();

        }

        public IActionResult PedidoSearch(string search){
            var result = _repo.Search(search);

            return View(result);

        }public async Task<IActionResult> PedidoFilter(int filter, int pageNumber=1){
            var pedidos = _repo.GetAllPedidosByFilter(filter);
            
            return View(await Paginacao<Pedido>.CreateAsync(pedidos, pageNumber, 10));

        }
    }
}
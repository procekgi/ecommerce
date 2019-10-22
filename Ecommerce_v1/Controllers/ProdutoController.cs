using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce_v1.DAO;
using Ecommerce_v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_v1.Controllers
{
    public class ProdutoController : Controller
    {

        public ProdutoDAO _produtoDAO; 
        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto p)
        {
            _produtoDAO.CadastrarProduto(p);            
            return RedirectToAction("Index");            
        }

        public IActionResult Index()
        {
           
            ViewBag.DataHora = DateTime.Now;
            return View(_produtoDAO.ListarProdutos());
        }

        public IActionResult Remover(int id)
        {
            _produtoDAO.RemoverProduto(id);
          return RedirectToAction("Index");
        }

        public IActionResult Alterar(Produto p)
        {
        //    Produto p = _produtoDAO.BuscarProdutosPorId(Convert.ToInt32(txtId));
        //    p.Nome = txtNome;
        //    p.Descricao = txtDescricao;
        //    p.Quantidade = txtQuantidade;
        //    p.Preco = txtPreco;

            _produtoDAO.Alterar(p);
            return RedirectToAction("Index");
        }
    }
}
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

        public ProdutoDAO ProdutoDAO { get; }
        public ProdutoController(ProdutoDAO _produtoDAO)
        {
            _produtoDAO = ProdutoDAO;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string txtNome, string txtDescricao,
            string txtPreco, string txtQuantidade)
        {
            Produto p = new Produto
            {
                Nome = txtNome,
                Descricao = txtDescricao,
                Preco = Convert.ToDouble(txtPreco),
                Quantidade = Convert.ToInt32(txtQuantidade)
                
            };
            ProdutoDAO.CadastrarProduto(p);
            return RedirectToAction("Index");
            
        }

        public IActionResult Index()
        {
            ViewBag.Produtos = ProdutoDAO.ListarProdutos();
            ViewBag.DataHora = DateTime.Now;
            return View();
        }

        public IActionResult Remover(int id)
        {
            ProdutoDAO.RemoverProduto(id);
          return RedirectToAction("Index");
        }

        public IActionResult Alterar(string  txtId, string txtNome, string txtDescricao, int txtQuantidade, double txtPreco)
        {
            Produto p = ProdutoDAO.BuscarProdutosPorId(Convert.ToInt32(txtId));
            p.Nome = txtNome;
            p.Descricao = txtDescricao;
            p.Quantidade = txtQuantidade;
            p.Preco = txtPreco;

            ProdutoDAO.Alterar(p);
            return RedirectToAction("Index");
        }
    }
}
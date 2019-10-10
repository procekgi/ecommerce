using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_v1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string txtNome, string txtDescricao,
            string txtPreco, string txtQuantidade)
        {
            return View();
        }
    }
}
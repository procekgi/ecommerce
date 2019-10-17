using Ecommerce_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_v1.DAO
{
    public class ProdutoDAO
    {
        private readonly Context _context;

        public ProdutoDAO(Context context)
        {
            _context = context;
        }
      //  Context context = new Context(options);
        public void CadastrarProduto(Produto p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }
        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.ToList();
        }

        public void RemoverProduto(int id)
        {
            _context.Produtos.Remove(BuscarProdutosPorId(id));
            _context.SaveChanges();
        }

        public Produto BuscarProdutosPorId(int id)
        {
            return _context.Produtos.Find(id);
        }

        public void Alterar(Produto p)
        {
            _context.Update(p);
            _context.SaveChanges();
        }
    }
}

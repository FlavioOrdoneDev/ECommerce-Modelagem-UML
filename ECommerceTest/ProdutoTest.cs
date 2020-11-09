using ECommerce_Modelagem_UML.Models.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ECommerceTest
{
    [TestClass]
    public class ProdutoTest
    {
        Produto produto;
        public ProdutoTest()
        {
            produto = new Produto(1, "Mouse", 40.00M);
        }

        [TestMethod]
        public void AdicionandoCategoriaTeste()
        {
            Categoria categoria = new Categoria(1, "Tecnologia");
            Categoria categoria2 = new Categoria(1, "Informática");

            produto.AdicionarCategoria(categoria);
            produto.AdicionarCategoria(categoria2);

            Assert.AreEqual(2, produto.ObterCategorias().Count);
        }
    }
}

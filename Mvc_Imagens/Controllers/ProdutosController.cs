using Mvc_Imagens.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web.Mvc;


namespace Mvc_Imagens.Controllers
{
    public class ProdutosController : Controller
    {
        ClassProdutoDbContext db;
        public ProdutosController()
        {
            db = new ClassProdutoDbContext();
        }
        // GET: Produtos
        public ActionResult Index()
        {
            var produtos = db.Produtos.ToList();
            return View(produtos);
        }


        public ActionResult Create()
        {
            ViewBag.Categorias = db.Categorias;
            var model = new ClassProdutoViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClassProdutoViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                var produto = new ClassProduto();
                produto.Empresa = model.Empresa;
                produto.CNPJ = model.CNPJ;
                produto.Quantidade = model.Quantidade;
                produto.Produto = model.Produto;
                produto.CategoriaId = model.CategoriaId;
                produto.Preco = model.Preco;
                db.Produtos.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            // Se ocorrer um erro retorna para pagina
            ViewBag.Categories = db.Categorias;
            return View(model);

        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassProduto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.Categorias = db.Categorias;
            return View(produto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProdutoId,Empresa,CNPJ,Quantidade,Produto,CategoriaId,Preco")] ClassProduto model)
        {
            if (ModelState.IsValid)
            {
                var produto = db.Produtos.Find(model.ProdutoId);
                if (produto == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                produto.Empresa = model.Empresa;
                produto.CNPJ = model.CNPJ;
                produto.Quantidade = model.Quantidade;
                produto.Produto = model.Produto;
                produto.CategoriaId = model.CategoriaId;
                produto.Preco = model.Preco;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categorias = db.Categorias;
            return View(model);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            ClassProduto produto = db.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.Categoria = db.Categorias.Find(produto.CategoriaId).CategoriaNome;
            return View(produto);
        }
        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClassProduto produto = db.Produtos.Find(id);
            db.Produtos.Remove(produto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
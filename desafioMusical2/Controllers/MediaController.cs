using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicalChallenge.Models;

namespace desafioMusical2.Controllers
{
    public class MediaController : Controller
    {
        private MediaDBContext db = new MediaDBContext();      

        // GET: Media
        public ActionResult Index()
        {
            return View(db.Medias.ToList());
        }

        public ActionResult Contextual(string titulo, string categoria, string descricao, string autoria)
        {
            var tituloLst = new List<string>();     //Listas para os campos de string que receberam as opcoes para 
            var AutoriaLst = new List<string>();    //o display da dropdown lista
            var CategoriaLst = new List<string>();
            var DescricaoLst = new List<string>();

            var DescricaoQry = from d in db.Medias     //Armazenando as possibilidades de valores por campo(copluna)
                            orderby d.Descricao        //(ainda com repeticao)
                            select d.Descricao;

            var AutoriaQry = from d in db.Medias
                           orderby d.Autoria
                           select d.Autoria;

            var categoriaQry = from d in db.Medias
                               orderby d.Categoria
                               select d.Categoria;

            var tituloQry = from d in db.Medias
                               orderby d.Titulo
                               select d.Titulo;


            tituloLst.AddRange(tituloQry.Distinct());    //Populando as listas criadas com valores nao repetidos
            AutoriaLst.AddRange(AutoriaQry.Distinct());
            CategoriaLst.AddRange(categoriaQry.Distinct());
            DescricaoLst.AddRange(DescricaoQry.Distinct());

            ViewBag.descricao = new SelectList(DescricaoLst);    //Passando as informacoes da ultima lista para o view Contextual
            ViewBag.autoria = new SelectList(AutoriaLst);       //e crinado lista de selecao para dropdownl lista
            ViewBag.categoria = new SelectList(CategoriaLst);
            ViewBag.titulo = new SelectList(tituloLst);

            var medias = from m in db.Medias       //A selecao propriamente dita
                         select m;

            if (!string.IsNullOrEmpty(descricao))      //Checa se foi dada alguma opcao
            {
                medias = medias.Where(x => x.Descricao == descricao);  //compara com o parametro passado p control atraves da view
            }

            if (!string.IsNullOrEmpty(autoria))
            {
                medias = medias.Where(x => x.Autoria == autoria);
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                medias = medias.Where(x => x.Categoria == categoria);

            }
            if (!string.IsNullOrEmpty(titulo))
            {
                medias = medias.Where(x => x.Titulo == titulo);

            }



            return View(medias);
        }

        public ActionResult Nominal(string pattern)
        {
            var medias = from m in db.Medias
                         select m;

            if (!String.IsNullOrEmpty(pattern))
            {
                medias = medias.Where(s => s.Titulo.Contains(pattern)
                                              || s.Descricao.Contains(pattern)
                                              || s.Codigo.ToString().Contains(pattern)
                                              || s.Autoria.Contains(pattern)
                                              || s.Data.ToString().Contains(pattern)
                                              || s.Categoria.Contains(pattern)
                );
            }

            return View(medias);
        }





        // GET: Media/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // GET: Media/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Media/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Codigo,Titulo,Categoria,Data,Descricao,Autoria")] Media media)
        {
            if (ModelState.IsValid)
            {
                db.Medias.Add(media);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(media);
        }

        // GET: Media/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // POST: Media/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Codigo,Titulo,Categoria,Data,Descricao,Autoria")] Media media)
        {
            if (ModelState.IsValid)
            {
                db.Entry(media).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(media);
        }

        // GET: Media/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // POST: Media/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Media media = db.Medias.Find(id);
            db.Medias.Remove(media);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

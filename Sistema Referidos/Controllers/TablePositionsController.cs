using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sistema_Referidos.Context;
using Sistema_Referidos.Models;

namespace Sistema_Referidos.Controllers
{
    public class TablePositionsController : Controller
    {
        private ReferidosContext db = new ReferidosContext();

        // GET: TablePositions
        public ActionResult Index()
        {
            var tablePositions = db.TablePositions.Include(t => t.Customer).Include(t => t.Table);
            return View(tablePositions.ToList());
        }

        // GET: TablePositions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TablePosition tablePosition = db.TablePositions.Find(id);
            if (tablePosition == null)
            {
                return HttpNotFound();
            }
            return View(tablePosition);
        }

        // GET: TablePositions/Create
        public ActionResult Create()
        {
            ViewBag.IdCustomer = new SelectList(db.Customers, "IdCustomer", "CustomerName");
            ViewBag.IdTable = new SelectList(db.Tables, "IdTable", "TableDescription");
            return View();
        }

        // POST: TablePositions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTablePosition,IdCustomer,IdTable")] TablePosition tablePosition)
        {
            if (ModelState.IsValid)
            {
                db.TablePositions.Add(tablePosition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCustomer = new SelectList(db.Customers, "IdCustomer", "CustomerName", tablePosition.IdCustomer);
            ViewBag.IdTable = new SelectList(db.Tables, "IdTable", "TableDescription", tablePosition.IdTable);
            return View(tablePosition);
        }

        // GET: TablePositions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TablePosition tablePosition = db.TablePositions.Find(id);
            if (tablePosition == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCustomer = new SelectList(db.Customers, "IdCustomer", "CustomerName", tablePosition.IdCustomer);
            ViewBag.IdTable = new SelectList(db.Tables, "IdTable", "TableDescription", tablePosition.IdTable);
            return View(tablePosition);
        }

        // POST: TablePositions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTablePosition,IdCustomer,IdTable")] TablePosition tablePosition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tablePosition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCustomer = new SelectList(db.Customers, "IdCustomer", "CustomerName", tablePosition.IdCustomer);
            ViewBag.IdTable = new SelectList(db.Tables, "IdTable", "TableDescription", tablePosition.IdTable);
            return View(tablePosition);
        }

        // GET: TablePositions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TablePosition tablePosition = db.TablePositions.Find(id);
            if (tablePosition == null)
            {
                return HttpNotFound();
            }
            return View(tablePosition);
        }

        // POST: TablePositions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TablePosition tablePosition = db.TablePositions.Find(id);
            db.TablePositions.Remove(tablePosition);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThpKTGiuaKi.Models;

namespace ThpKTGiuaKi.Controllers
{
    public class thpSinhViensController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: thpSinhViens
        public ActionResult ThpIndex()
        {
            var thpSinhViens = db.thpSinhViens.Include(t => t.thpKhoa);
            return View(thpSinhViens.ToList());
        }

        // GET: thpSinhViens/Details/5
        public ActionResult ThpDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            thpSinhVien thpSinhVien = db.thpSinhViens.Find(id);
            if (thpSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(thpSinhVien);
        }

        // GET: thpSinhViens/Create
        public ActionResult ThpCreate()
        {
            ViewBag.ThpMaKH = new SelectList(db.thpKhoas, "ThpMaKH", "ThpTenKH");
            return View();
        }

        // POST: thpSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThpCreate([Bind(Include = "ThpMaSV,ThpHoSV,ThpTenSV,ThpNgaySinh,ThpPhai,ThpPhone,ThpEmail,ThpMaKH")] thpSinhVien thpSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.thpSinhViens.Add(thpSinhVien);
                db.SaveChanges();
                return RedirectToAction("ThpIndex");
            }

            ViewBag.ThpMaKH = new SelectList(db.thpKhoas, "ThpMaKH", "ThpTenKH", thpSinhVien.ThpMaKH);
            return View(thpSinhVien);
        }

        // GET: thpSinhViens/Edit/5
        public ActionResult ThpEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            thpSinhVien thpSinhVien = db.thpSinhViens.Find(id);
            if (thpSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.ThpMaKH = new SelectList(db.thpKhoas, "ThpMaKH", "ThpTenKH", thpSinhVien.ThpMaKH);
            return View(thpSinhVien);
        }

        // POST: thpSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThpEdit([Bind(Include = "ThpMaSV,ThpHoSV,ThpTenSV,ThpNgaySinh,ThpPhai,ThpPhone,ThpEmail,ThpMaKH")] thpSinhVien thpSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thpSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ThpIndex");
            }
            ViewBag.ThpMaKH = new SelectList(db.thpKhoas, "ThpMaKH", "ThpTenKH", thpSinhVien.ThpMaKH);
            return View(thpSinhVien);
        }

        // GET: thpSinhViens/Delete/5
        public ActionResult ThpDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            thpSinhVien thpSinhVien = db.thpSinhViens.Find(id);
            if (thpSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(thpSinhVien);
        }

        // POST: thpSinhViens/Delete/5
        [HttpPost, ActionName("ThpDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            thpSinhVien thpSinhVien = db.thpSinhViens.Find(id);
            db.thpSinhViens.Remove(thpSinhVien);
            db.SaveChanges();
            return RedirectToAction("ThpIndex");
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

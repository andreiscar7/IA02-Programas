using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WenEnvios.Models;


namespace WenEnvios.Controllers
{
    public class ClienteController : Controller
    {
        public EntityState EntityEstate { get; private set; }

        // GET: Cliente
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Cliente.ToList());
            }
                
        }

       

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
                using (DbModels context = new DbModels())
                {
                    return View(context.Cliente.Where(x => x.IDCliente == id));
                }
            
         
        }

        // GET: Cliente/Create
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Cliente.Where(x => x.IDCliente == id).FirstOrDefault());
            }
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels context = new DbModels())
                {
                    context.Entry(cliente).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Cliente.Where(x => x.IDCliente == id).FirstOrDefault());
            }
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Cliente cliente = context.Cliente.Where(x => x.IDCliente == id).FirstOrDefault();
                    context.Cliente.Remove(cliente);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

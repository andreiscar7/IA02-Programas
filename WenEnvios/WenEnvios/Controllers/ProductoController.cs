using System.Data;
using System.Linq;
using System.Web.Mvc;
using WenEnvios.Models;

namespace WenEnvios.Controllers
{
    public class ProductoController : Controller
    {
       
        // GET: Producto
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Producto.ToList());
            }
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Producto.Where(x => x.IDProducto == id));
            }

        }

        // GET: Producto/Create
        public ActionResult Create(Producto producto)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Producto.Add(producto);
                    context.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // POST: Producto/Create
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

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Producto.Where(x => x.IDProducto == id).FirstOrDefault());
            }
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Producto producto)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels context = new DbModels())
                {
                    context.Entry(producto).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            using(DbModels context = new DbModels())
            {
                return View(context.Producto.Where(x => x.IDProducto == id).FirstOrDefault());
            }
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Producto producto = context.Producto.Where(x => x.IDProducto == id).FirstOrDefault();
                    context.Producto.Remove(producto);
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

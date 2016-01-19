using CadastrarFrota.Context;
using CadastrarFrota.Domain;
using System.Linq;
using System.Web.Mvc;

namespace CadastrarFrota.Controllers
{
    public class CadastroFrotaController : Controller
    {
        CadastroFrotaDataContext _db = new CadastroFrotaDataContext();

        // GET: Default
        public ActionResult Index()
        {
            return View(_db.Cars);
        }

        // GET: Default/Details/5
        public ActionResult Details(int id)
        {
            return View(_db.Cars.Single(x => x.IdCar == id));
        }

        // GET: Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        public ActionResult Create(Car car)
        {
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _db.Cars.Add(car);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_db.Cars.Single(x => x.IdCar == id));
        }

        // POST: Default/Edit/5
        [HttpPost]
        public ActionResult Edit(Car car)
        {
            // TODO: Add update logic here
            if (ModelState.IsValid)
            {
                _db.Cars.Attach(car);
                _db.Entry<Car>(car).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_db.Cars.Single(x => x.IdCar == id));
        }

        // POST: Default/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            // TODO: Add delete logic here
            _db.Cars.Remove(_db.Cars.Single(x => x.IdCar == id));
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

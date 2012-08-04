using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NextCart.Front.Mvc.Controllers
{
    public class StructureController : Controller
    {
		public NextCart.Contract.Adnsf.IStructureStore StructureStore
		{ get; protected set; }

		public StructureController()
		{
			StructureStore = DependencyResolver.Current.GetService<NextCart.Contract.Adnsf.IStructureStore>();
		}

        public ActionResult Index()
        {
			var model = StructureStore.GetRootStructureItems();
            return View(model);
        }

        //
        // GET: /Structure/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Structure/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Structure/Create

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

        //
        // GET: /Structure/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Structure/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Structure/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Structure/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

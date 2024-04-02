using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Tables.ToList());
        }


        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }



        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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

        public static void Main(string[] args)
        {
            // Base monthly quote
            double monthlyTotal = 50;

            // Age of the user
            int age = 22; // Example age, you can change this according to user input

            // Car details
            int carYear = 2010; // Example car year, you can change this according to user input
            string carMake = "Porsche"; // Example car make, you can change this according to user input
            string carModel = "911 Carrera"; // Example car model, you can change this according to user input

            // Number of speeding tickets
            int speedingTickets = 2; // Example number of speeding tickets, you can change this according to user input

            // DUI flag
            bool hasDUI = false; // Example, you can change this according to user input

            // Full coverage flag
            bool fullCoverage = true; // Example, you can change this according to user input

            // Adjustments based on age
            if (age <= 18)
                monthlyTotal += 100;
            else if (age >= 19 && age <= 25)
                monthlyTotal += 50;
            else
                monthlyTotal += 25;

            // Adjustments based on car's year
            if (carYear < 2000)
                monthlyTotal += 25;
            else if (carYear > 2015)
                monthlyTotal += 25;

            // Adjustments based on car's make
            if (carMake == "Porsche")
            {
                monthlyTotal += 25;
                if (carModel == "911 Carrera")
                    monthlyTotal += 25;
            }

            // Adjustments based on speeding tickets
            monthlyTotal += speedingTickets * 10;

            // Adjustments based on DUI
            if (hasDUI)
                monthlyTotal *= 1.25;

            // Adjustments based on full coverage
            if (fullCoverage)
                monthlyTotal *= 1.5;

            Console.WriteLine("Your monthly insurance quote is: $" + monthlyTotal);
        }


    }

}

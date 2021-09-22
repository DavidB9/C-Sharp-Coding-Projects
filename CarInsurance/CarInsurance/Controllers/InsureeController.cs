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
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                //set the quote
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                //set the quote
                insuree.Quote = CalculateQuote(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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


        public decimal CalculateQuote(Insuree insuree)
        {
            //calculate the monthly quote
            //calculate the age of the insuree
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;

            //base of 50
            decimal monthlyQuote = 50;

            //If the user is 18 and under, add $100 to the monthly total.
            if (age <= 18)
            {
                monthlyQuote += 100;
            }

            //If the user is between 19 and 25, add $50 to the monthly total.
            else if (age >= 19 && age <= 25)
            {
                monthlyQuote += 50;
            }


            //If the user is over 25, add $25 to the monthly total.
            else
            {
                monthlyQuote += 25;
            }
            //If the car's year is before 2000, add $25 to the monthly total.
            if (insuree.CarYear < 2000)
            {
                monthlyQuote += 25;
            }

            //If the car's year is after 2015, add $25 to the monthly total.
            if (insuree.CarYear > 2015)
            {
                monthlyQuote += 25;
            }

            //If the car's Make is a Porsche, add $25 to the price.
            if (insuree.CarMake == "Porsche")
            {
                monthlyQuote += 25;
            }
            //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                monthlyQuote += 25;
            }

            //Add $10 to the monthly total for every speeding ticket the user has.
            monthlyQuote = monthlyQuote + (10 * insuree.SpeedingTickets);

            //If the user has ever had a DUI, add 25 % to the total.
            if (insuree.DUI == true)
            {
                decimal percent = monthlyQuote * 25 / 100;
                monthlyQuote = monthlyQuote + percent;
            }
            //If it's full coverage, add 50% to the total.
            if (insuree.CoverageType == true)
            {
                decimal percent = monthlyQuote * 50 / 100;
                monthlyQuote = monthlyQuote + percent;
            }

            return monthlyQuote;
        }
    }
}

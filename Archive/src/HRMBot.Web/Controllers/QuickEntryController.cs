using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HRMBot.Models;
using HRMBot.Repository;

namespace HRMBot.Web.Controllers
{
    public class QuickEntryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: QuickEntry
        public ActionResult Index()
        {
            return View(db.UserInfos.ToList());
        }

        // GET: QuickEntry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfo userInfo = db.UserInfos.Find(id);
            if (userInfo == null)
            {
                return HttpNotFound();
            }
            return View(userInfo);
        }

        // GET: QuickEntry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuickEntry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuickEntryVM quickEntryVM)
        {
            if (ModelState.IsValid)
            {
                UserInfo userInfo = new UserInfo();
                userInfo.MobileNo = quickEntryVM.MobileNo;

                Employee employee = new Employee();
                employee.FullName = quickEntryVM.EmployeeName;
                employee.UserInfo = userInfo;

                Random random = new Random();
                //int rInt = r.Next(0, 100); //for ints

                LeaveBalance leaveBalance = new LeaveBalance();
                leaveBalance.TotalAnnualLeave = 20;
                leaveBalance.TotalCasualLeave = 10;
                leaveBalance.TotalSickLeave = 13;
                leaveBalance.AvailedAnnualLeave = random.Next(0,20); //Generate random int value in a range
                leaveBalance.AvailedCasualLeave = random.Next(0,10);
                leaveBalance.AvailedSickLeave = random.Next(0,13);
                leaveBalance.Employee = employee;

                //db.UserInfos.Add(userInfo);
                db.LeaveBalances.Add(leaveBalance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quickEntryVM);
        }

        // GET: QuickEntry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfo userInfo = db.UserInfos.Find(id);
            if (userInfo == null)
            {
                return HttpNotFound();
            }
            return View(userInfo);
        }

        // POST: QuickEntry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MobileNo,FacebookId,FacebookOTP,SkypeId,SkypeOTP,SlackId,SlackOTP,WebOTP")] UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userInfo);
        }

        // GET: QuickEntry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserInfo userInfo = db.UserInfos.Find(id);
            if (userInfo == null)
            {
                return HttpNotFound();
            }
            return View(userInfo);
        }

        // POST: QuickEntry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserInfo userInfo = db.UserInfos.Find(id);
            db.UserInfos.Remove(userInfo);
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

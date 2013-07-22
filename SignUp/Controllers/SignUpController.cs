using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using SignUp.Models;
using System.Security.Cryptography;

namespace SignUp.Controllers
{
  public class SignUpController : Controller
  {
    private SignUpEntities db = new SignUpEntities();

    //
    // GET: /SignUp/
    public ActionResult Index()
    {
      return View(db.SignUps.ToList());
    }

    //
    // GET: /SignUp/Details/5
    public ActionResult Details(int id = 0)
    {
      var signup = db.SignUps.Find(id);
      if (signup == null)
      {
        return HttpNotFound();
      }
      return View(signup);
    }

    //
    // GET: /SignUp/Create

    public ActionResult Create()
    {
      return View();
    }

    //
    // POST: /SignUp/Create

    [HttpPost]
    public ActionResult Create(Models.SignUp signup)
    {
      if (ModelState.IsValid)
      {
        var encryptObj = new EncryptPassword();
        signup.Password = signup.ConfirmPassword = encryptObj.Encrypt(signup.Password);
        db.SignUps.Add(signup);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      return View(signup);
    }

    //
    // GET: /SignUp/Edit/5

    public ActionResult Edit(int id = 0)
    {
      var signup = db.SignUps.Find(id);
      if (signup == null)
      {
        return HttpNotFound();
      }
      return View(signup);
    }

    //
    // POST: /SignUp/Edit/5

    [HttpPost]
    public ActionResult Edit(Models.SignUp signup)
    {
      if (ModelState.IsValid)
      {
        db.Entry(signup).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(signup);
    }

    //
    // GET: /SignUp/Delete/5

    public ActionResult Delete(int id = 0)
    {
      var signup = db.SignUps.Find(id);
      if (signup == null)
      {
        return HttpNotFound();
      }
      return View(signup);
    }

    //
    // POST: /SignUp/Delete/5

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var signup = db.SignUps.Find(id);
      db.SignUps.Remove(signup);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
      db.Dispose();
      base.Dispose(disposing);
    }
  }
}
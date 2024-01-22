using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UIKT_App.Controllers
{
    public class PrijavnoOknoController : Controller
    {
        [AllowAnonymous] 
        public ActionResult PrijavnoOkno() 
        { 
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult PrijavnoOkno(UsersModel usersModel)
        {
            TempData["username"] = usersModel.username;
            TempData["password"] = usersModel.password;

            if(usersModel.username == "uporK" && usersModel.password == "gesloK")
            {
                if (ModelState.IsValid)
                {
                    
                    return RedirectToAction("Kandidat", "Kandidat");
                }
            }
            if (usersModel.username == "uporMKGP" && usersModel.password == "gesloMKGP")
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("MKGP", "MKGP");
                }
            }
            if (usersModel.username == "uporVet" && usersModel.password == "gesloVet")
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Vet", "Vet");
                }
            }
            else
                TempData["msg"] = "<script>alert('Napačni prijavni podatki!');</script>";
            return View();

        }
    }
}

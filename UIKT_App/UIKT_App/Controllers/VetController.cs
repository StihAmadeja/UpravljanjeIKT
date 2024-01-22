using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UIKT_App.Models;

namespace UIKT_App.Controllers
{
    public class VetController : Controller
    {
        [AllowAnonymous]
        public IActionResult Vet()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Vet(VetModel vetModel)
        {
            TempData["kandidat"] = vetModel.Kandidat;
            TempData["mnenje"] = vetModel.Mnenje;
            TempData["jeOpravil"] = vetModel.JeOpravil;

            if (vetModel.Kandidat == null || vetModel.Mnenje == null || vetModel.JeOpravil == false)
            {
                TempData["msg"] = "<script>alert('Izpolnite vsa polja!');</script>";
            }

            if (!ModelState.IsValid)
            {
                string fullPath = "C:\\Users\\amade\\OneDrive\\Documents\\FERI\\LETNIK 3\\UPRAVLJANJE IKT\\7. Naloga\\Mnenje.txt";
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine("MNJENJE");
                    writer.WriteLine("Kandidat: " + vetModel.Kandidat);
                    writer.WriteLine("Mnjenje: " + vetModel.Mnenje);
                    writer.WriteLine("Ali je opravil usposabljanje: " + vetModel.JeOpravil);
                }
                return RedirectToAction("PrijavnoOkno", "PrijavnoOkno");
            }
            return View();
        }
    }
}

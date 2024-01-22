using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UIKT_App.Models;

namespace UIKT_App.Controllers
{
    public class MKGPController : Controller
    {
        [AllowAnonymous]
        public IActionResult MKGP()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult MKGP(MKGPModel mKGPModel)
        {
            TempData["kandidat"] = mKGPModel.Kandidat;
            TempData["vloga"] = mKGPModel.OdpriVlogo;
            TempData["mnenje"] = mKGPModel.OdpriMnenje;
            TempData["jeopravil"] = mKGPModel.JeOdobrenaVloga;

            if(mKGPModel.Kandidat == null || mKGPModel.OdpriMnenje == null || mKGPModel.OdpriVlogo == null || mKGPModel.JeOdobrenaVloga)
            {
                TempData["msg"] = "<script>alert('Izpolnite vsa polja!');</script>";
            }
            if (!ModelState.IsValid)
            {
                if (mKGPModel.JeOdobrenaVloga == false)
                    TempData["msg"] = "<script>alert('Vloga ni odobrena!');</script>";
                else if (mKGPModel.JeOdobrenaVloga == true)
                {
                    TempData["msg"] = "<script>alert('Vloga je odobrena!');</script>";
                    return RedirectToAction("PrijavnoOkno", "PrijavnoOkno");
                }

            }
            return View();
        }
    }
}

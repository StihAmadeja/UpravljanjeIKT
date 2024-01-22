using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using UIKT_App.Models;

namespace UIKT_App.Controllers
{
    public class KandidatController : Controller
    {
        [AllowAnonymous]
        public IActionResult Kandidat()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Kandidat(ObrazecModel obrazecModel)
        {
            TempData["ime"] = obrazecModel.Ime;
            TempData["priimek"] = obrazecModel.Priimek;
            TempData["datumrojstva"] = obrazecModel.DatumRojstva;
            TempData["krajrojstva"] = obrazecModel.KrajRojstva;
            TempData["drzavljanstvo"] = obrazecModel.Drzavljanstvo;
            TempData["osebnidokument"] = obrazecModel.OsebniDokument;
            TempData["stevilodokumenta"] = obrazecModel.StevilkaDokumenta;
            TempData["krajizdajedokumenta"] = obrazecModel.KrajIzdajeDokumenta;
            TempData["datumizdajedokumenta"] = obrazecModel.DatumIzdajeDokumenta;
            TempData["prebivaliscetujina"] = obrazecModel.PrebivalisceTujina;
            TempData["prebivalisceSLO"] = obrazecModel.PrebivalisceSLO;
            TempData["telefonska"] = obrazecModel.TelefonskaStevilka;
            TempData["enaslov"] = obrazecModel.Enaslov;
            TempData["nacinobvescanja"] = obrazecModel.NacinObvescanje;
            TempData["poklic"] = obrazecModel.Poklic;
            TempData["jekvalificiran"] = obrazecModel.JeKvalificiran;
            TempData["imeustanove"] = obrazecModel.ImeUstanove;
            TempData["naslovustanove"] = obrazecModel.NaslovUstanove;
            TempData["drzavaustanove"] = obrazecModel.DrzavaUstanove;
            TempData["priloga"] = obrazecModel.Priloga;
            TempData["dokazilo"] = obrazecModel.Dokazilo;
            TempData["datumoddajevloge"] = obrazecModel.DatumOddajeVloge;

            if(obrazecModel.Ime == null || obrazecModel.Priimek == null || obrazecModel.DatumRojstva == null || obrazecModel.KrajRojstva == null ||
                obrazecModel.Drzavljanstvo == null || obrazecModel.OsebniDokument == null || obrazecModel.StevilkaDokumenta == null || 
                obrazecModel.KrajIzdajeDokumenta == null || obrazecModel.DatumIzdajeDokumenta == null || obrazecModel.PrebivalisceTujina == null ||
                obrazecModel.PrebivalisceSLO == null || obrazecModel.TelefonskaStevilka == null || obrazecModel.Enaslov == null || obrazecModel.NacinObvescanje == null ||
                obrazecModel.Poklic == null || obrazecModel.JeKvalificiran == null || obrazecModel.ImeUstanove == null || obrazecModel.NaslovUstanove == null ||
                obrazecModel.DrzavaUstanove == null || obrazecModel.Priloga == null || obrazecModel.Dokazilo == null || obrazecModel.DatumOddajeVloge == null)
            {
                TempData["msg"] = "<script>alert('Vnesite vse podatke!');</script>";
            }
            if(obrazecModel.JeKvalificiran == "NE")
            {
                TempData["msg"] = "<script>alert('Niste kvalificirani!');</script>";
            }
            if (ModelState.IsValid)
            {
                string fullPath = "C:\\Users\\amade\\OneDrive\\Documents\\FERI\\LETNIK 3\\UPRAVLJANJE IKT\\7. Naloga\\Vloga.txt";
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine("VLOGA");
                    writer.WriteLine("Ime: " + obrazecModel.Ime);
                    writer.WriteLine("Priimek: " + obrazecModel.Priimek);
                    writer.WriteLine("Datum rojstva: " + obrazecModel.DatumRojstva);
                    writer.WriteLine("Kraj: " + obrazecModel.KrajRojstva);
                    writer.WriteLine("Drzavljanstvo: " + obrazecModel.Drzavljanstvo);
                    writer.WriteLine("Vrsta dokumenta: " + obrazecModel.OsebniDokument);
                    writer.WriteLine("Stevilka: " + obrazecModel.StevilkaDokumenta);
                    writer.WriteLine("Kje je bil dokument izdan: " + obrazecModel.KrajIzdajeDokumenta);
                    writer.WriteLine("Kdaj je bil dokument izdan: " + obrazecModel.DatumIzdajeDokumenta);
                    writer.WriteLine("Do kdaj velja dokument: " + obrazecModel.DatumVeljavnostiDokumenta);
                    writer.WriteLine("Naslov prebivalisca v tujini: " + obrazecModel.PrebivalisceTujina);
                    writer.WriteLine("Naslov prebivalisca v Sloveniji: " + obrazecModel.PrebivalisceSLO);
                    writer.WriteLine("Nacin obvescanja: " + obrazecModel.NacinObvescanje);
                    writer.WriteLine("Poklic/Dejavnost: " + obrazecModel.Poklic);
                    writer.WriteLine("Kvalificiran: " + obrazecModel.JeKvalificiran);
                    writer.WriteLine("Izobrazevalna ustanova: " + obrazecModel.ImeUstanove);
                    writer.WriteLine("Naslov ustanove: " + obrazecModel.NaslovUstanove);
                    writer.WriteLine("Drzava ustanove: " + obrazecModel.DrzavaUstanove);
                    writer.WriteLine("Dodana priloga: " + obrazecModel.Priloga);
                    writer.WriteLine("Dodano dokazilo o placilu: " + obrazecModel.Dokazilo);
                }
                return RedirectToAction("PrijavnoOkno", "PrijavnoOkno");
            }
            return View();
        }
    }
}

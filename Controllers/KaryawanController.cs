namespace DataPribadiApp.Models;

using Microsoft.AspNetCore.Mvc;

public class KaryawanController : Controller
{
    private readonly AppDbContext _db;
    public KaryawanController(AppDbContext db) { _db = db; }

    // Index monitoring dan search
    public IActionResult Index(string nik, string nama)
    {
        var data = _db.Karyawans.AsQueryable();
        if (!string.IsNullOrEmpty(nik))
            data = data.Where(k => k.NIK.ToString().Contains(nik));
        if (!string.IsNullOrEmpty(nama))
            data = data.Where(k => k.NamaLengkap.Contains(nama));
        return View(data.ToList());
    }

    // Create
    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Karyawan model)
    {

        if (_db.Karyawans.Any(k => k.NIK == model.NIK))
            ModelState.AddModelError("NIK", "NIK sudah terdaftar.");
        if (!ModelState.IsValid) return View(model);
        _db.Karyawans.Add(model);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    //Detail
    public IActionResult Detail(long id)
    {
        var data = _db.Karyawans.Find(id);
        if (data == null) return NotFound();
        return View(data);
    }

    // Edit
    public IActionResult Edit(long id)
    {
        var data = _db.Karyawans.Find(id);
        if (data == null) return NotFound();
        return View(data);
    }

    [HttpPost]
    public IActionResult Edit(Karyawan model)
    {
        if (!ModelState.IsValid) return View(model);
        _db.Karyawans.Update(model);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }


    //Delete
    [HttpPost]
    public IActionResult Delete(long id)
    {
        var data = _db.Karyawans.Find(id);
        if (data != null) { _db.Karyawans.Remove(data); _db.SaveChanges(); }
        return RedirectToAction("Index");
    }
}

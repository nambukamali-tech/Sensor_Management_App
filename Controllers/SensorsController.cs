using Microsoft.AspNetCore.Mvc;
using Snape_Lite.Data;
using Microsoft.EntityFrameworkCore;
using Snape_Lite.Models;
using System.Threading.Tasks;

namespace Snape_Lite.Controllers
{
    public class SensorsController : Controller
    {
        public readonly ApplicationDbContext _context;
        public SensorsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sensors = await _context.Sensors.ToListAsync();
            return View(sensors);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Sensors sensor)
        {
            if(ModelState.IsValid)
            {
                _context.Sensors.Add(sensor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sensor);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var sensor = await _context.Sensors.FindAsync(id);
            if(sensor == null)
            {
                return NotFound();
            }
            return View(sensor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Sensors sensor)
        {
            if(ModelState.IsValid)
            {
                _context.Sensors.Update(sensor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sensor);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var sensor = await _context.Sensors.FindAsync(id);
            if (sensor == null)
            {
                return NotFound();
            }
            return View(sensor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sensor = await _context.Sensors.FindAsync(id);
            if(sensor != null)
            {
                _context.Sensors.Remove(sensor);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));

        }

    }
}

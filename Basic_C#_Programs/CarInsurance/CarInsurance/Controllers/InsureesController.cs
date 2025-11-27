using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;
using Microsoft.AspNetCore.Authorization;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsuredContext _context;

        public InsureesController(InsuredContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insuree.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

      
        public async Task<IActionResult> Admin()
        {
            var insurees = await _context.Insuree.AsNoTracking().ToListAsync();
            return View(insurees);
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    insuree.Quote = CalculateQuote(insuree);
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insuree
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuree = await _context.Insuree.FindAsync(id);
            if (insuree != null)
            {
                _context.Insuree.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(int id)
        {
            return _context.Insuree.Any(e => e.Id == id);
        }

        //Quote Calculation Method
        private decimal CalculateQuote(Insuree insuree)
        {
            const decimal baseQuote = 50m;
            const decimal ifUnder18 = 100m;
            const decimal ifBetween19And25 = 50m;
            const decimal ifOver26 = 25m;
            const decimal carYearBefore2000 = 25m;
            const decimal carYearAfter2015 = 25m;
            const decimal carMakePorsche = 25m;
            const decimal carModel911Carrera = 50m;
            const decimal perSpeedingTicket = 10m;
            const decimal duiIncreaseRate = 0.25m;
            const decimal fullCoverage = 0.50m;

            var today = DateTime.Today;
            int age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth > today.AddYears(-age)) age--;

            decimal quote = baseQuote;
            //Age-based adjustments
            if (age < 18)
            {
                quote += ifUnder18;
            }
            else if (age >= 19 && age <= 25)
            {
                quote += ifBetween19And25;
            }
            else
            {
                quote += ifOver26;
            }
            //Car year adjustments
            if (insuree.CarYear < 2000)
            {
                quote += carYearBefore2000;
            }
            else if (insuree.CarYear > 2015)
            {
                quote += carYearAfter2015;
            }
            //Car make and model adjustments
            if (insuree.CarMake != null && insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
            {
                quote += carMakePorsche;
                
                if (insuree.CarModel != null && insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
                {
                    quote += carModel911Carrera;
                }
            }
            //Speeding tickets adjustment
            quote += insuree.SpeedingTickets * perSpeedingTicket;

            //DUI adjustment
            if (insuree.DUI)
            {
                quote += quote * duiIncreaseRate;
            }
            //Coverage type adjustment
            if (insuree.CoverageType != null && insuree.CoverageType.Equals("Full", StringComparison.OrdinalIgnoreCase))
            {
                quote += quote * fullCoverage;
            }
            return quote;
        }
    }
}

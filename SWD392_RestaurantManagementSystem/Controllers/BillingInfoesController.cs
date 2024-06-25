using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWD392_RestaurantManagementSystem.Models;

namespace SWD392_RestaurantManagementSystem.Controllers
{
    public class BillingInfoesController : Controller
    {
        private readonly RestaurantManagementContext _context;

        public BillingInfoesController(RestaurantManagementContext context)
        {
            _context = context;
        }

        // GET: BillingInfoes
        public async Task<IActionResult> Index()
        {
            var restaurantManagementContext = _context.BillingInfos.Include(b => b.Cashier).Include(b => b.Order);
            return View(await restaurantManagementContext.ToListAsync());
        }

        // GET: BillingInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billingInfo = await _context.BillingInfos
                .Include(b => b.Cashier)
                .Include(b => b.Order)
                .FirstOrDefaultAsync(m => m.BillingId == id);
            if (billingInfo == null)
            {
                return NotFound();
            }

            return View(billingInfo);
        }

        // GET: BillingInfoes/Create
        public IActionResult Create()
        {
            ViewData["CashierId"] = new SelectList(_context.Users, "UserId", "UserId");
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId");
            return View();
        }

        // POST: BillingInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BillingId,OrderId,CashierId,BillingDate,Amount,PaymentMethod")] BillingInfo billingInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(billingInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CashierId"] = new SelectList(_context.Users, "UserId", "UserId", billingInfo.CashierId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", billingInfo.OrderId);
            return View(billingInfo);
        }

        // GET: BillingInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billingInfo = await _context.BillingInfos.FindAsync(id);
            if (billingInfo == null)
            {
                return NotFound();
            }
            ViewData["CashierId"] = new SelectList(_context.Users, "UserId", "UserId", billingInfo.CashierId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", billingInfo.OrderId);
            return View(billingInfo);
        }

        // POST: BillingInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BillingId,OrderId,CashierId,BillingDate,Amount,PaymentMethod")] BillingInfo billingInfo)
        {
            if (id != billingInfo.BillingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(billingInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BillingInfoExists(billingInfo.BillingId))
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
            ViewData["CashierId"] = new SelectList(_context.Users, "UserId", "UserId", billingInfo.CashierId);
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", billingInfo.OrderId);
            return View(billingInfo);
        }

        // GET: BillingInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var billingInfo = await _context.BillingInfos
                .Include(b => b.Cashier)
                .Include(b => b.Order)
                .FirstOrDefaultAsync(m => m.BillingId == id);
            if (billingInfo == null)
            {
                return NotFound();
            }

            return View(billingInfo);
        }

        // POST: BillingInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var billingInfo = await _context.BillingInfos.FindAsync(id);
            if (billingInfo != null)
            {
                _context.BillingInfos.Remove(billingInfo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BillingInfoExists(int id)
        {
            return _context.BillingInfos.Any(e => e.BillingId == id);
        }
    }
}

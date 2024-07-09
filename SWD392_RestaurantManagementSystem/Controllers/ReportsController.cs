using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using SWD392_RestaurantManagementSystem.Models;
using SWD392_RestaurantManagementSystem.Services;

namespace SWD392_RestaurantManagementSystem.Controllers
{
    public class ReportsController : Controller
    {
        private readonly RestaurantManagementContext _context;

        public ReportsController(RestaurantManagementContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult BillingReport(DateOnly? startDate, DateOnly? endDate)
        {
            if (startDate == null || endDate == null)
            {
                ViewBag.ErrorMessage = "Please provide both start and end dates.";
                return View();
            }

            var totalCost = _context.BillingInfos
                .Where(b => b.BillingDate >= startDate && b.BillingDate <= endDate)
                .Sum(b => b.Amount);

            ViewBag.TotalCost = totalCost;
            return View();
        }
        [HttpGet]
        public IActionResult ReservationReport(DateOnly? startDate, DateOnly? endDate)
        {
            if (startDate == null || endDate == null)
            {
                ViewBag.ErrorMessage = "Please provide both start and end dates.";
                return View();
            }

            var reservations = _context.Reservations
                .Where(r => r.ReservationDate >= startDate && r.ReservationDate <= endDate)
                .ToList();

            ViewBag.TotalReservations = reservations.Count;
            return View();
        }
    }
}

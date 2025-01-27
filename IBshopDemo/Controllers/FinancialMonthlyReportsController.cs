﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IBshopDemo.Models;
using IBshopDemo.ActionFilters;
using IBshopDemo.Enums;

namespace IBshopDemo.Controllers
{
    public class FinancialMonthlyReportsController : Controller
    {
        private readonly TestHadadianContext _context;

        public FinancialMonthlyReportsController(TestHadadianContext context)
        {
            _context = context;
        }

        // GET: FinancialMonthlyReports
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Index()
        {
            return _context.FinancialMonthlyReports != null ? 
                          View(await _context.FinancialMonthlyReports.ToListAsync()) :
                          Problem("Entity set 'TestHadadianContext.FinancialMonthlyReports'  is null.");
        }

        // GET: FinancialMonthlyReports/Details/5
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FinancialMonthlyReports == null)
            {
                return NotFound();
            }

            var financialMonthlyReport = await _context.FinancialMonthlyReports
                .FirstOrDefaultAsync(m => m.FinancialMonthlyReportId == id);
            if (financialMonthlyReport == null)
            {
                return NotFound();
            }

            return View(financialMonthlyReport);
        }

        // GET: FinancialMonthlyReports/Create
      //  [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: FinancialMonthlyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Create(FinancialMonthlyReport financialMonthlyReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(financialMonthlyReport);
                await _context.SaveChangesAsync();
                ViewBag.SuccessMsg = "با موفقیت اضافه شد.";
                //return RedirectToAction(nameof(Index));
                return View(nameof(Index), await _context.FinancialMonthlyReports.ToListAsync());
            }
            return View(financialMonthlyReport);
        }

        // GET: FinancialMonthlyReports/Edit/5
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FinancialMonthlyReports == null)
            {
                return NotFound();
            }

            var financialMonthlyReport = await _context.FinancialMonthlyReports.FindAsync(id);
            if (financialMonthlyReport == null)
            {
                return NotFound();
            }
            return View(financialMonthlyReport);
        }

        // POST: FinancialMonthlyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       // [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Edit(int id, [Bind("FinancialMonthlyReportId,Year,Month,MonthNumber,PersonnelSetQty,CheckedfundQty,ContQty,TreasuryBillsQty,Recivedgaurantee,RestaxinstallmentQty,ResFundInstallmenQty,TaminInstallmentQty,TaminPenaltyVol,TranCommissionQty,TaminInstallmentDelay,TaxInstallmentDelay,PrpReqQty,MtnprpQty,ColPrpQty,LblPrpQty")] FinancialMonthlyReport financialMonthlyReport)
        {
            if (id != financialMonthlyReport.FinancialMonthlyReportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(financialMonthlyReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinancialMonthlyReportExists(financialMonthlyReport.FinancialMonthlyReportId))
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
            return View(financialMonthlyReport);
        }

        // GET: FinancialMonthlyReports/Delete/5
     //   [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FinancialMonthlyReports == null)
            {
                return NotFound();
            }

            var financialMonthlyReport = await _context.FinancialMonthlyReports
                .FirstOrDefaultAsync(m => m.FinancialMonthlyReportId == id);
            if (financialMonthlyReport == null)
            {
                return NotFound();
            }

            return View(financialMonthlyReport);
        }

        // POST: FinancialMonthlyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
     //   [Authorization((int)Roles.ادمین)]
        [Authorization((int)Roles.مدیر_امور_مالی)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FinancialMonthlyReports == null)
            {
                return Problem("Entity set 'TestHadadianContext.FinancialMonthlyReports'  is null.");
            }
            var financialMonthlyReport = await _context.FinancialMonthlyReports.FindAsync(id);
            if (financialMonthlyReport != null)
            {
                _context.FinancialMonthlyReports.Remove(financialMonthlyReport);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinancialMonthlyReportExists(int id)
        {
          return (_context.FinancialMonthlyReports?.Any(e => e.FinancialMonthlyReportId == id)).GetValueOrDefault();
        }
    }
}

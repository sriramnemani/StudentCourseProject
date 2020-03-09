using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudCurRegistration;

namespace StudentCourseRegisterationUI.Controllers
{
    [Authorize]
    public class studInfoesController : Controller
    {
        private readonly SchoolContext _context;

        public studInfoesController(SchoolContext context)
        {
            _context = context;
        }

        // GET: studInfoes
        public async Task<IActionResult> Index()
        {
            return View(School.GetAllstudentsByEmailAddress(HttpContext.User.Identity.Name));
        }

        // GET: studInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
                        
            var studInfo = School.GetStudentId(id.Value);
            if (studInfo == null)
            {
                return NotFound();
            }

            return View(studInfo);
        }

        // GET: studInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: studInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("StudFirstName,StudGender,StudEmailAdd,StudAddress,StudphNum")] 
              studInfo studInfo)
        {
            if (ModelState.IsValid)
            {
                School.createNewStudEnroll(studInfo.StudFirstName,studInfo.StudEmailAdd,studInfo.StudAddress,studInfo.StudphNum,studInfo.StudGender);
                return RedirectToAction(nameof(Index));
            }
            return View(studInfo);
        }

        // GET: studInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studInfo = School.GetStudentId(id.Value);
            if (studInfo == null)
            {
                return NotFound();
            }
            return View(studInfo);
        }

        // POST: studInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,StudPassword,StudFirstName,StudStartDate,StudGender,StudEmailAdd,StudAddress,StudphNum,StudEnrollFee")] studInfo studInfo)
        {
            if (id != studInfo.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!studInfoExists(studInfo.StudentId))
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
            return View(studInfo);
        }

        // GET: studInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studInfo = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studInfo == null)
            {
                return NotFound();
            }

            return View(studInfo);
        }

        // POST: studInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studInfo = await _context.Students.FindAsync(id);
            _context.Students.Remove(studInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool studInfoExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}

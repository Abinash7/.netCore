using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCapp.Models;

namespace MVCapp.Controllers
{
    public class UserInfoesController : Controller
    {
        private readonly UserRepo _context;

        public UserInfoesController(UserRepo context)
        {
            _context = context;
        }

   
        public async Task<IActionResult> Index()
        {
            return View(await _context.users.ToListAsync());
        }

        // GET: UserInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FullName,Address,Email,PhoneNumber,Password")] UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UserInformation));
            }
            return View(userInfo);
        }
        private bool UserInfoExists(int id)
        {
            return _context.users.Any(e => e.ID == id);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerViewModel = await _context.users.FindAsync(id);
            if (registerViewModel == null)
            {
                return NotFound();
            }
            return View(registerViewModel);
        }

        // POST: Register/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FullName,Address,Email,PhoneNumber,Password")] UserInfo uf)
        {
            if (id != uf.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserInfoExists(uf.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(UserInformation));
            }
            return View(uf);
        }

        // GET: Register/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerViewModel = await _context.users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registerViewModel == null)
            {
                return NotFound();
            }

            return View(registerViewModel);
        }

        // POST: Register/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registerViewModel = await _context.users.FindAsync(id);
            _context.users.Remove(registerViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(UserInformation));
        }

        public async Task<IActionResult> UserInformation()
        {
            return View(await _context.users.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registerViewModel = await _context.users
                .FirstOrDefaultAsync(m => m.ID == id);
            if (registerViewModel == null)
            {
                return NotFound();
            }

            return View(registerViewModel);
        }
    }
}

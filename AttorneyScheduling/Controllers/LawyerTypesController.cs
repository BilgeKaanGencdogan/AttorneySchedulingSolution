﻿#nullable disable
using Business.Model;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

//Generated from Custom Template.
namespace AttorneyScheduling.Controllers
{
    public class LawyerTypesController : Controller
    {
        // TODO: Add service injections here
        private readonly ILawyerTypeService _lawyerTypeService;

        public LawyerTypesController(ILawyerTypeService lawyerTypeService)
        {
            _lawyerTypeService = lawyerTypeService;
        }

        // GET: LawyerTypes
        public IActionResult Index()
        {
            List<LawyerTypeModel> lawyerTypeList = _lawyerTypeService.Query().ToList(); // TODO: Add get collection service logic here
            return View(lawyerTypeList);
        }

        // GET: LawyerTypes/Details/5
        public IActionResult Details(int id)
        {
            LawyerTypeModel lawyerType = null; // TODO: Add get item service logic here
            if (lawyerType == null)
            {
                return NotFound();
            }
            return View(lawyerType);
        }

        // GET: LawyerTypes/Create
        public IActionResult Create()
        {
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View();
        }

        // POST: LawyerTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LawyerTypeModel lawyerType)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add insert service logic here
                return RedirectToAction(nameof(Index));
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(lawyerType);
        }

        // GET: LawyerTypes/Edit/5
        public IActionResult Edit(int id)
        {
            LawyerTypeModel lawyerType = null; // TODO: Add get item service logic here
            if (lawyerType == null)
            {
                return NotFound();
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(lawyerType);
        }

        // POST: LawyerTypes/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LawyerTypeModel lawyerType)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add update service logic here
                return RedirectToAction(nameof(Index));
            }
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(lawyerType);
        }

        // GET: LawyerTypes/Delete/5
        public IActionResult Delete(int id)
        {
            LawyerTypeModel lawyerType = null; // TODO: Add get item service logic here
            if (lawyerType == null)
            {
                return NotFound();
            }
            return View(lawyerType);
        }

        // POST: LawyerTypes/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            // TODO: Add delete service logic here
            return RedirectToAction(nameof(Index));
        }
    }
}

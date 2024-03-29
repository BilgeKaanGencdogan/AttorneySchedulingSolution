﻿#nullable disable
using Business.Model;
using Business.Services;
using Core.Results.Bases;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

//Generated from Custom Template.
namespace AttorneyScheduling.Controllers
{
    public class LawyerTypesController : Controller
    {
        // TODO: Add service injections here
        private readonly ILawyerTypeService _lawyerTypeService;
        private readonly IValidator<LawyerTypeModel> _validator;

        public LawyerTypesController(ILawyerTypeService lawyerTypeService, IValidator<LawyerTypeModel> validator)
        {
            _lawyerTypeService = lawyerTypeService;
            _validator = validator;
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
        public async Task<IActionResult> Create(LawyerTypeModel lawyerType)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(lawyerType);

            //if (ModelState.IsValid)
            //{
            //    // TODO: Add insert service logic here
            //    return RedirectToAction(nameof(Index));
            //}

            if (validationResult.IsValid)
            {

                Result result = _lawyerTypeService.Add(lawyerType);
                if (result.IsSuccessful)
                {
                    TempData["success"] = result.Message;


                    return RedirectToAction(nameof(Index));
                }
                TempData["error"] = result.Message;
                ModelState.AddModelError("", result.Message);

            }

            //ViewBag.ValidationErrors = validationResult.Errors;

            validationResult.AddToModelState(this.ModelState);

            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(lawyerType);
        }

        // GET: LawyerTypes/Edit/5
        public IActionResult Edit(int id)
        {
            LawyerTypeModel lawyerType = _lawyerTypeService.Query().SingleOrDefault(lawyertypemodel => lawyertypemodel.Id == id);
            // TODO: Add get item service logic here
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
        public async Task<IActionResult> EditAsync(LawyerTypeModel lawyerType)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(lawyerType);
            if (validationResult.IsValid)
            {
                Result result = _lawyerTypeService.Update(lawyerType);
                if (result.IsSuccessful)
                {
                    TempData["success"] = result.Message;
                    return RedirectToAction(nameof(Index));
                }
                // TODO: Add update service logic here
                TempData["error"] = result.Message;
                ModelState.AddModelError("", result.Message);
            }
            validationResult.AddToModelState(this.ModelState);
            // TODO: Add get related items service logic here to set ViewData if necessary
            return View(lawyerType);
        }

        // GET: LawyerTypes/Delete/5
        public IActionResult Delete(int id)
        {
            LawyerTypeModel lawyerType = _lawyerTypeService.Query().SingleOrDefault(lawyertype => lawyertype.Id == id); // TODO: Add get item service logic here
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
            Result result = _lawyerTypeService.Delete(id);
            if (result.IsSuccessful)
            {
                TempData["success"] = result.Message;
            }
            else
            {
                TempData["error"] = result.Message;
            }
            ModelState.AddModelError("", result.Message);

            return RedirectToAction(nameof(Index));
        }
    }
}

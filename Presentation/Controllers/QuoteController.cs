using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Data.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Items;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class QuoteController : Controller
    {
	    private readonly IMapper _mapper;
	    private readonly IAboutYouRepository<AboutYou> _aboutYouRepo;
	    private readonly IRiderDetailsRepository<RiderDetails> _riderDetailsRepo;

	    public QuoteController(IMapper mapper, IAboutYouRepository<AboutYou> aboutYouRepo, IRiderDetailsRepository<RiderDetails> riderDetailsRepo)
	    {
		    _mapper = mapper;
		    _aboutYouRepo = aboutYouRepo;
		    _riderDetailsRepo = riderDetailsRepo;
	    }

	    [HttpGet]
	    public async Task<IActionResult> PersonalInformation1()
	    {
		    if (!HttpContext.Session.Keys.Contains("QuoteId"))
		    {
			    return View("PersonalInformation1");
		    }

		    var id = HttpContext.Session.GetString("QuoteId");
		    var entity = await _aboutYouRepo.GetById(Guid.Parse(id));
		    var model = _mapper.Map<AboutYouModel>(entity);
		    return View("PersonalInformation1", model);
	    }

	    [HttpPost]
	    public IActionResult PersonalInformation1(AboutYouModel model)
	    {
		    if (!ModelState.IsValid)
		    {
			    return View("PersonalInformation1");
		    }

		    

		    var entity = _mapper.Map<AboutYou>(model);
		    entity.Id = Guid.NewGuid();
			HttpContext.Session.SetString("QuoteId", entity.Id.ToString());

		    try
		    {
			    _aboutYouRepo.Create(entity);
		    }
		    catch
		    {
			    return View("Error");
		    }
		    return RedirectToAction("PersonalInformation2");
	    }

		[HttpGet]
	    public async Task<IActionResult> PersonalInformation2()
	    {
		    if (!HttpContext.Session.Keys.Contains("QuoteId2"))
		    {
			    return View("PersonalInformation2");
		    }

		    var id = HttpContext.Session.GetString("QuoteId2");
		    var entity = await _riderDetailsRepo.GetById(Guid.Parse(id));
		    var model = _mapper.Map<RiderDetailsModel>(entity);
			return View("PersonalInformation2", model);
	    }

	    [HttpPost]
	    public IActionResult PersonalInformation2(RiderDetailsModel model)
	    {
		    if (!ModelState.IsValid)
		    {
			    return View("PersonalInformation2");
		    }



		    var entity = _mapper.Map<RiderDetails>(model);
		    entity.Id = Guid.NewGuid();
		    HttpContext.Session.SetString("QuoteId2", entity.Id.ToString());

		    try
		    {
			    _riderDetailsRepo.Create(entity);
		    }
		    catch
		    {
			    return View("Error");
		    }
		    return RedirectToAction("TheEnd");
	    }

	    public IActionResult TheEnd()
	    {
		    return View("Yuss");
	    }
    }
}
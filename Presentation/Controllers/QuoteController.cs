using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Data.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers
{
    [Produces("application/json")]
    [Route("api/Quote")]
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

	    [HttpGet("all_about_you")]
	    public async Task<IActionResult> GetAllAbtYou()
	    {
		    var all = await _aboutYouRepo.GetAll();
		    return Ok(all);
	    }

	    [HttpGet("all_rider_details")]
	    public async Task<IActionResult> GetAllRiderDetails()
	    {
		    var all = await _riderDetailsRepo.GetAll();
		    return Ok(all);
	    }

		[HttpPost("add_about_you")]
	    public async Task<IActionResult> AddAboutYouForm([FromBody] AboutYouModel model)
	    {
		    if (!ModelState.IsValid)
		    {
			    return BadRequest();
		    }

		    var entity = _mapper.Map<AboutYou>(model);
		    if (await _aboutYouRepo.Create(entity))
		    {
			    return Ok();
		    }
		    return BadRequest();
	    }

		[HttpGet("about_you_form/{id}")]
		public async Task<IActionResult> GetAboutYouForm([FromRoute] Guid id)
	    {
		    if (!ModelState.IsValid)
		    {
			    return BadRequest();
		    }

		    if (!await _aboutYouRepo.Exists(id))
		    {
			    return BadRequest();
		    }

		    var entity = await _aboutYouRepo.GetById(id);
		    var model = _mapper.Map<AboutYouModel>(entity);
		    return Ok(model);
	    }

	    [HttpPost("add_rider_details")]
	    public async Task<IActionResult> AddRiderDetailsForm([FromBody] RiderDetailsModel model)
	    {
		    if (!ModelState.IsValid)
		    {
			    return BadRequest();
		    }

		    var entity = _mapper.Map<RiderDetails>(model);
		    entity.Id = Guid.NewGuid();
		    if (await _riderDetailsRepo.Create(entity))
		    {
			    return Ok();
		    }
		    return BadRequest();
	    }

	    [HttpGet("rider_details_form/{id}")]
	    public async Task<IActionResult> GetRiderDetailsForm([FromRoute] Guid id)
	    {
		    if (!ModelState.IsValid)
		    {
			    return BadRequest();
		    }

		    if (!await _riderDetailsRepo.Exists(id))
		    {
			    return BadRequest();
		    }

		    var entity = await _riderDetailsRepo.GetById(id);
		    var model = _mapper.Map<RiderDetailsModel>(entity);
		    return Ok(model);
	    }

	}
}
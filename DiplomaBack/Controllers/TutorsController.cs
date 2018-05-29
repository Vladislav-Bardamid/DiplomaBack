using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiplomaBack.DAL.Entities;
using DiplomaBack.DAL.EntityFrameworkCore;
using DiplomaBack.Helpers;
using DiplomaBack.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace DiplomaBack.Controllers
{
  [Produces("application/json")]
  [Route("api/Tutors")]
  public class TutorsController : Controller
  {
    private readonly DataBaseContext _context;
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;

    public TutorsController(UserManager<User> userManager, IMapper mapper, DataBaseContext context)
    {
      _userManager = userManager;
      _mapper = mapper;
      _context = context;
    }

    // GET: api/Tutors
    [HttpGet]
    public IEnumerable<Tutor> GetTutors()
    {
      return _context.Tutors;
    }

    // GET: api/Tutors/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTutor([FromRoute] int id)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var tutor = await _context.Tutors.SingleOrDefaultAsync(m => m.Id == id);

      if (tutor == null)
      {
        return NotFound();
      }

      return Ok(tutor);
    }

    // POST: api/Tutors
    [HttpPost]
    public async Task<IActionResult> PostTutor([FromBody]RegistrationViewModel model)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var userIdentity = _mapper.Map<User>(model);

      var result = await _userManager.CreateAsync(userIdentity, model.Password);

      if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

      await _context.Tutors.AddAsync(new Tutor() { IdentityId = userIdentity.Id });
      await _context.SaveChangesAsync();

      return new OkObjectResult("Account created");
    }
  }
}
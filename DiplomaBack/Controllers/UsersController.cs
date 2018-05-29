using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DiplomaBack.DAL.Entities;
using DiplomaBack.DAL.EntityFrameworkCore;
using DiplomaBack.Helpers;
using DiplomaBack.Models;
using DiplomaBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DiplomaBack.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
      private readonly DataBaseContext _dataBaseContext;
      private readonly UserManager<User> _userManager;
      private readonly IMapper _mapper;

      public UsersController(UserManager<User> userManager, IMapper mapper, DataBaseContext dataBaseContext)
      {
        _userManager = userManager;
        _mapper = mapper;
        _dataBaseContext = dataBaseContext;
      }

      // POST api/accounts
      [HttpPost]
      public async Task<IActionResult> PostUser([FromBody]RegistrationViewModel model)
      {
        if (!ModelState.IsValid)
        {
          return BadRequest(ModelState);
        }

        var userIdentity = _mapper.Map<User>(model);

        var result = await _userManager.CreateAsync(userIdentity, model.Password);

        if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

        //await _dataBaseContext.Users.AddAsync(new User());
        //await _dataBaseContext.SaveChangesAsync();

        return new OkObjectResult("Account created");
      }
  }
}
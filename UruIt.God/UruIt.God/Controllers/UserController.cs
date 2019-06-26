using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using UruIt.God.Domain.Entities;
using UruIt.God.Services.Abstractions;
using UruIt.God.ViewModels;

namespace UruIt.God.Controllers
{
    [Route("api/[controller]")]
    public class UserController: BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets All the users from the database
        /// </summary>
        /// <returns>All the users</returns>
        [HttpGet]
        public ActionResult<IEnumerable<UserViewModel>> GetAll() {
            IEnumerable<User> allUsers = _userService.GetAll();
            return Ok(_mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(allUsers));
        }

        
        [HttpPost("create/{userName}")]
        [EnableCors("AllowAll")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult Create(string userName) {

            if (userName == null || userName == "")
                return BadRequest("the name of the user cannot be null");
            UserViewModel user = new UserViewModel
            {
                Name = userName
            };

            //All right lets create the user
            _userService.Add(_mapper.Map<UserViewModel, User>(user));
            return Ok();
        }

        [HttpGet("scores")]
        [EnableCors("AllowAll")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult Scores()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var scores = _userService.UsersScores();
            return Ok(scores);
        }


    }
}

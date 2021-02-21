using System;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using DatingApp.API.Models.SendModels;
using System.Collections.Generic;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDatingRepository _repo;
        private readonly IMapper _mapp;


        public UsersController(IDatingRepository repo,IMapper mapp)
        {
            _repo = repo;
            _mapp = mapp;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers() 
        {
            var users =await _repo.GetAllUsers();
            var allUsers = _mapp.Map<IEnumerable<UserListSend>>(users);

            return Ok(allUsers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id) 
        {
            var users =await _repo.GetUser(id);
            var getUser = _mapp.Map<UserDetailsSend>(users);
            return Ok(getUser);
        }

    }
}
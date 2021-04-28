﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BaseCore.BusinessLogic;
using Microsoft.Extensions.Configuration;

namespace BaseCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IConfiguration _config;

        public UserController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        [Route("add")]
        public JsonResultModel CreateUser(string s)
        {
            var jwt = new JWTServices(_config);
            var token = jwt.GenerateSecurityToken(DateTime.Now.ToString());
            return new JsonResultModel(1, "thành công", token);
        }
    }
}

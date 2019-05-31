﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieBlend.Models;
using MovieBlend.Services;
using PusherServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using MovieBlend.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MovieBlend.Controllers
{
    [Authorize]
    public class PostDetailController : Controller
    {
        
        
        //private readonly ICommentDataService _commentdataServices;
        private readonly IMovieDataService _movieDataService;
        private readonly ITvDataService _tvDataService;
        private static MovieData maindata;
        private readonly UserManager<IdentityUser> _usermanger;
        public PostDetailController(IMovieDataService movieData, ITvDataService tvData, UserManager<IdentityUser> usermanager)
        {
           // _commentdataServices=commentdataService;
            _usermanger = usermanager;
            _movieDataService = movieData;
            _tvDataService = tvData;
        }
        
        public IActionResult Index(string data)
        {
            maindata = new MovieData();
            var datax = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(data);
            var arr = _movieDataService.Getdatabyid(datax);
            maindata = arr;
            if (arr.Id.ToString() == datax) return View(maindata);
            else
            {
                maindata = arr;
                arr = _tvDataService.Getdatabyid(datax);
                return View(arr);
            }
        }
    }
}
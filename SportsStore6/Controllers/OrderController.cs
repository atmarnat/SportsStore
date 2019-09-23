using System;
using System.Collections.Generic;
using System.Linq;
using SportsStore6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SportsStore6.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}

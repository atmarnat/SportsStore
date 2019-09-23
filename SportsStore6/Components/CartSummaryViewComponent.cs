﻿using System;
using System.Collections.Generic;
using System.Linq;
using SportsStore6.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SportsStore6.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService) {
            cart = cartService;
        }
        public IViewComponentResult Invoke() {
            return View(cart);
        }
    }
}

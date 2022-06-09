using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspnetRunBasics.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetRunBasics
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService _orderService;

        public OrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IEnumerable<Models.OrderResponseModel> Orders { get; set; } = new List<Models.OrderResponseModel>();

        public async Task<IActionResult> OnGetAsync()
        {
            Orders = await _orderService.GetOrdersByUserName("swn");

            return Page();
        }       
    }
}
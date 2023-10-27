using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROG3050.Data;
using PROG3050.Models;

namespace PROG3050.Controllers
{
    [Authorize]
    public class ProvincesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProvincesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Orders
        public JsonResult GetProvinces(int countryId)
        {
            var provinces = _context.Province.Where(p => p.CountryId == countryId).ToList();
            return new JsonResult(provinces);
        }
    }
}

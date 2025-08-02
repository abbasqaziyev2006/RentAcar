using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentaCarMvc.DataContext;
using System;

public class CarsController : Controller
{
    private readonly AppDbContext _context;

    public CarsController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var cars = _context.Cars
        .Include(c => c.Brand)
        .Include(c => c.Model)
        .Include(c => c.CarImages)
        .ToList();

        return View(cars);
    }

    public IActionResult Category(int id)
    {
        var cars = _context.Cars.Where(c => c.CategoryId == id).ToList();
        return View(cars);
    }

    public IActionResult LoadMore(int page)
    {
        int pageSize = 4;
        var cars = _context.Cars
            .Include(c => c.Brand)
            .Include(c => c.Model)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return PartialView("_CarPartial", cars);
    }
}
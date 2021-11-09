using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrivateSale.DataContext;
using PrivateSale.Models;
using PrivateSale.ViewModels;

namespace PrivateSale.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductLineController : ControllerBase
    {
        private readonly PrivateSaleContext _context;

        public ProductLineController(PrivateSaleContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> SaveProductLine(ProductLineViewModel viewModel)
        {
            Brand brand = await _context.Brands
                .Include(x => x.Sales)
                .ThenInclude(sale => sale.ProductLines)
                .FirstOrDefaultAsync(x => x.Name == viewModel.BrandName);

            if (brand == null)
            {
                brand = Brand.NewBrand(viewModel.BrandName, viewModel.BrandLogoUrl);
            }

            // Sale sale = brand.Sales.FirstOrDefault(x => x.StartAt.Date == viewModel.StartAt.Date && x.EndAt.Date == viewModel.EndAt.Date);

            // if (sale == null)
            // {
            //     sale = Sale.NewSale(viewModel.StartAt, viewModel.EndAt, brand);
            // }

            // ProductLine productLine = _context.ProductInformations.FirstOrDefaultAsync(x => x.)

            ProductLine productLine = new ProductLine
            {
                
            };

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductLine), new { id = productLine.Id }, productLine);
        }

        [HttpGet]
        public async Task<IActionResult> GetProductLine(Guid id)
        {
            ProductLine productLine = await _context.ProductLines.FindAsync(id);

            return Ok(productLine);
        }
    }
}
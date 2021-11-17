using System;
using System.Collections.Generic;
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

            Sale sale = brand.Sales.FirstOrDefault(x => x.SalePeriod.StartAt.Date == viewModel.StartAt.Date && x.SalePeriod.EndAt.Date == viewModel.EndAt.Date);

            if (sale == null)
            {
                sale = Sale.NewSale(viewModel.StartAt, viewModel.EndAt, brand, new List<ProductLine> {
                    ProductLine.NewProductLine(
                        viewModel.Name,
                        viewModel.OriginalPrice,
                        viewModel.FinalPrice,
                        viewModel.Discount,
                        viewModel.Selections.Select(x => new ProductSelection(x.Option, x.Quantity, x.StockStatus)).ToList(),
                        viewModel.ImageUrls
                    )
                });
            }

            ProductLine productLine = sale.ProductLines.FirstOrDefault(x => x.Name == viewModel.Name);

            if (productLine == null)
            {
                sale.AddProductLine(ProductLine.NewProductLine(
                    viewModel.Name,
                    viewModel.OriginalPrice,
                    viewModel.FinalPrice,
                    viewModel.Discount,
                    viewModel.Selections.Select(x => new ProductSelection(x.Option, x.Quantity, x.StockStatus)).ToList(),
                    viewModel.ImageUrls
                ));
            }

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
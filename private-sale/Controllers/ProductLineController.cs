using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrivateSale.ViewModels;

namespace PrivateSale.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductLineController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SaveProductLine(ProductLineViewModel viewModel)
        {
            await Task.FromResult(true);
            return Ok();
        }
    }
}
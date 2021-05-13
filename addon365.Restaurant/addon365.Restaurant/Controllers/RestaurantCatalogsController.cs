using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using addon365.Restaurant.Data;
using addon365.Restaurant.Models;
using addon365.Restaurant.Services;
using addon365.Restaurant.ViewModels.Catalog;

namespace addon365.Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantCatalogsController : ControllerBase
    {
        private readonly ICatalogService _catalogService;

        public RestaurantCatalogsController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        // GET: api/RestaurantCatalogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisplayCatalogViewModel>>> GetRestaurantCatalogs()
        {
            return Ok(await _catalogService.GetCatalogsAsync());
        }

        // GET: api/RestaurantCatalogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DisplayCatalogViewModel>> GetRestaurantCatalog(Guid id)
        {
            var restaurantCatalog = await _catalogService.GetCatalogAsync(id);

            if (restaurantCatalog == null)
            {
                return NotFound();
            }

            return restaurantCatalog;
        }

        // PUT: api/RestaurantCatalogs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurantCatalog(Guid id, UpdateCatalogViewModel model)
        {
            if (id != model.CatalogId)
            {
                return BadRequest();
            }

            
            try
            {
                await _catalogService.UpdateCatalogAsync(id, model);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _catalogService.IsCatalogExistsAsync(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RestaurantCatalogs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DisplayCatalogViewModel>> PostRestaurantCatalog(CreateCatalogViewModel model)
        {
            return await _catalogService.AddAsync(model); 
        }

        // DELETE: api/RestaurantCatalogs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DisplayCatalogViewModel>> DeleteRestaurantCatalog(Guid id)
        {
            await _catalogService.DeleteCatalogAsync(id);

            return Ok(await _catalogService.GetCatalogAsync(id));
        }

      
    }
}

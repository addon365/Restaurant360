using addon365.Restaurant.Data;
using addon365.Restaurant.Models;
using addon365.Restaurant.ViewModels.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addon365.Restaurant.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly RestaurantContext _context;

        public CatalogService(RestaurantContext context)
        {
            _context = context;
        }

        public async Task<IList<DisplayCatalogViewModel>> GetCatalogsAsync()
        {
            var lst = await _context.RestaurantCatalogs.ToListAsync();
            List<DisplayCatalogViewModel> lstNew = new List<DisplayCatalogViewModel>();
            foreach (var item in lst)
            {
                lstNew.Add(new DisplayCatalogViewModel { CatalogId = item.CatalogId });
            }
            return lstNew;
        }

        public async Task<DisplayCatalogViewModel> GetCatalogAsync(Guid id)
        {
            var restaurantCatalog = await _context.RestaurantCatalogs.FindAsync(id);
            var viewModel = new DisplayCatalogViewModel { CatalogId = restaurantCatalog.CatalogId };
            return viewModel;
        }


        public async Task<DisplayCatalogViewModel> UpdateCatalogAsync(Guid id, UpdateCatalogViewModel model)
        {

            var restaurantCatalog = await _context.RestaurantCatalogs.FindAsync(id);

            _context.Entry(restaurantCatalog).State = EntityState.Modified;


            await _context.SaveChangesAsync();
            return await GetCatalogAsync(restaurantCatalog.CatalogId);



        }


        public async Task<DisplayCatalogViewModel> AddAsync(CreateCatalogViewModel model)
        {
            RestaurantCatalog catalog = new RestaurantCatalog { CatalogId = Guid.NewGuid(), ItemNameSearch = model.ItemNameSearch, ItemNamePrint = model.ItemNamePrint, ItemNameShort = model.ItemNameShort, CatalogCategoryId = model.CatalogCategoryId, Price = model.Price, Description = model.Description, IsVeg = model.IsVeg };
            _context.RestaurantCatalogs.Add(catalog);
            await _context.SaveChangesAsync();

            return await GetCatalogAsync(catalog.CatalogId);
        }

        public async Task<DisplayCatalogViewModel> DeleteCatalogAsync(Guid id)
        {
            var catalog = await _context.RestaurantCatalogs.FindAsync(id);

            _context.RestaurantCatalogs.Remove(catalog);
            await _context.SaveChangesAsync();

            return await GetCatalogAsync(catalog.CatalogId);
        }

        public async Task<bool> IsCatalogExistsAsync(Guid id)
        {
            return await _context.RestaurantCatalogs.AnyAsync(e => e.CatalogId == id);
        }
    }
}

using addon365.Restaurant.Models;
using addon365.Restaurant.ViewModels.Catalog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace addon365.Restaurant.Services
{
    public interface ICatalogService
    {
        Task<DisplayCatalogViewModel> AddAsync(CreateCatalogViewModel model);
        Task<DisplayCatalogViewModel> DeleteCatalogAsync(Guid id);
        Task<DisplayCatalogViewModel> GetCatalogAsync(Guid id);
        Task<IList<DisplayCatalogViewModel>> GetCatalogsAsync();
        Task<DisplayCatalogViewModel> UpdateCatalogAsync(Guid id, UpdateCatalogViewModel model);
        Task<bool> IsCatalogExistsAsync(Guid id);
    }
}
using Catalog.Api.Dtos;
using Catalog.Api.Entities;

namespace Catalog.Api
{
    public static class Extensions{
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto(item.Id, item.Name, item.Price, item.InStock, item.Description, item.CreatedDate);
        }
    }
}
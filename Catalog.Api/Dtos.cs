using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Api.Dtos
{
    public record ItemDto(Guid Id, string Name, decimal Price, Boolean InStock, string Description, DateTimeOffset CreatedDate);
    public record CreateItemDto([Required] string Name, [Range(1,5000)] decimal Price, [Required] Boolean InStock, string Description);
    public record UpdateItemDto([Required] string Name, [Range(1,5000)] decimal Price, [Required] Boolean InStock, string Description);
}
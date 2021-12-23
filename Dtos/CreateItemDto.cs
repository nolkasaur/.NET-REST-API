using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        [Range(1, 20000)]
        public decimal Price { get; init; }

        [Required]
        public Boolean InStock { get; init; }
    }
}
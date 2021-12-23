using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{

    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "RTX 3060", Price = 1650, CreatedDate = DateTimeOffset.UtcNow, InStock = true },
            new Item { Id = Guid.NewGuid(), Name = "RTX 3070", Price = 2399, CreatedDate = DateTimeOffset.UtcNow, InStock = true },
            new Item { Id = Guid.NewGuid(), Name = "RTX 3090", Price = 4599, CreatedDate = DateTimeOffset.UtcNow, InStock = false }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void Updateitem(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);
        }
    }
}
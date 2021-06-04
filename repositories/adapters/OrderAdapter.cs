using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GlassProject.models.domain_models;
using GlassProject.repositories.adapters.interfaces;
using GlassProject.repositories.contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GlassProject.repositories.adapters
{
    public class OrderAdapter : IOrderAdapter
    {
        private readonly ApplicationDbContext Context;

        public OrderAdapter(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task<bool> CreateOrder(string name, string userId, string productType, string structure,
            string purpose, string requirements, string description)
        {
            var order = new Order()
            {
                Name = name,
                ProductType = productType,
                UserId = userId,
                Description = description,
                Requirements = requirements,
                Purpose = purpose,
                Structure = structure
            };

            await Context.Orders.AddAsync(order);
            await Context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Order>> GetOrdersByUser(string userId)
        {
            var result = Context.Orders.Where(x => x.UserId == userId).ToList();
            return result;
        }

        public bool IsOrderNameUniq(string name, string userId)
        {
            return !Context.Orders.Where(x => x.UserId == userId).Any(x => x.Name == name);
        }
    }
}
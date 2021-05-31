using System;
using System.Collections.Generic;
using System.Linq;
using GlassProject.models.domain_models;
using GlassProject.repositories.adapters.interfaces;
using GlassProject.repositories.contexts;
using Microsoft.EntityFrameworkCore;

namespace GlassProject.repositories.adapters
{
    public class OrderAdapter : IOrderAdapter
    {

        private ApplicationDbContext Context;
        public OrderAdapter(ApplicationDbContext context )
        {
            Context = context;
        }
        public void CreateOrder(string name, string userId, string productType, string structure, string purpose, string requirements, string description)
        {
            using (Context)
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

                Context.Orders.Add(order);
                Context.SaveChanges();
            }
        }

        public List<Order> GetOrdersByUser(string userId)
        {
            using (Context)
            {
                return Context.Orders.Where(x => x.User.Id == userId).ToList();
            }
        }

        public bool IsOrderNameUniq(string name, string userId)
        {
            using (Context)
            {
                return !Context.Orders.Where(x => x.UserId == userId).Any(x => x.Name == name);
            }
        }
    }
}
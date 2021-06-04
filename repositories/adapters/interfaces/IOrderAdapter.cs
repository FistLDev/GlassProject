using System.Collections.Generic;
using System.Threading.Tasks;
using GlassProject.models.domain_models;
using GlassProject.repositories.contexts;

namespace GlassProject.repositories.adapters.interfaces
{
    public interface IOrderAdapter
    {
        Task<bool> CreateOrder(string name, string userId, string productType, string structure, string purpose, string requirements, string description);
        Task<List<Order>> GetOrdersByUser(string userId);

        bool IsOrderNameUniq(string name, string userId);
    }
}
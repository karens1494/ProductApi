using ChallengeDevDir.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDevDir.Core.Interfaces
{
    public interface IRepository
    {
        Task<IEnumerable<Producto>> GetProducts();
        Task<Producto> GetProduct(int id);
        Task InsertProduct(Producto product);
        Task<bool> UpdateProduct(Producto product);
        Task<bool> DeleteProduct(int id);
    }
}

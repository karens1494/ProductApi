using ChallengeDevDir.Core.Entities;
using ChallengeDevDir.Core.Interfaces;
using ChallengeDevDir.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeDevDir.Infrastructure.Repositories
{
    public class Repository : IRepository
    {
        private readonly DB_InventarioContext _context;
        public Repository(DB_InventarioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetProducts()
        {
            var products = await _context.Producto.ToListAsync();
            return products;
        }

        public async Task<Producto> GetProduct(int id)
        {
            var product = await _context.Producto.FirstOrDefaultAsync(x=>x.IdProducto==id);
            return product;
        }

        public async Task InsertProduct(Producto product)
        {
            _context.Producto.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateProduct(Producto product)
        {
            var currentProduct = await GetProduct(product.IdProducto);
            currentProduct.Codigo = product.Codigo;
            currentProduct.DescripcionProducto = product.DescripcionProducto;
            currentProduct.Precio = product.Precio;
            currentProduct.Stock = product.Stock;
            currentProduct.Iva = product.Iva;
            currentProduct.Peso = product.Peso;
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var currentProduct = await GetProduct(id);
            _context.Producto.Remove(currentProduct);
            int rows=await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}

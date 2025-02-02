using Microsoft.EntityFrameworkCore;
using Reboot.DDD.Demo.Domain.Entities;
using Reboot.DDD.Demo.Domain.Repositories;
using Reboot.DDD.Demo.Infrastructure.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reboot.DDD.Demo.Infrastructure.Repositories;
internal class OrderRepository(DemoDbContext context) : IOrderRepository
{
    private readonly DemoDbContext _context = context;

    public async Task<Order> GetByIdAsync(int id)
    {
        return await _context.Set<Order>().FirstAsync(o => o.Id == id);
    }

    public async Task<IEnumerable<Order>> GetAllAsync()
    {
        return await _context.Set<Order>().ToListAsync();
    }

    public async Task AddAsync(Order order)
    {
        await _context.Set<Order>().AddAsync(order);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Order order)
    {
        _context.Set<Order>().Update(order);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var order = await _context.Set<Order>().FindAsync(id);
        if (order != null)
        {
            _context.Set<Order>().Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}

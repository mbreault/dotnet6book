using Microsoft.EntityFrameworkCore.ChangeTracking; // EntityEntry<T>
using Packt.Shared; // Customer
using System.Collections.Concurrent; // ConcurrentDictionary
namespace Northwind.WebApi.Repositories;
public class CustomerRepository : ICustomerRepository
{
    private readonly NorthwindContext _context;
    private readonly ConcurrentDictionary<string, Customer> _customers;
    public CustomerRepository(NorthwindContext context)
    {
        _context = context;
        _customers = new ConcurrentDictionary<string, Customer>();
    }
    public async Task<Customer?> CreateAsync(Customer c)
    {
        _customers[c.CustomerId] = c;
        await _context.Customers.AddAsync(c);
        await _context.SaveChangesAsync();
        return c;
    }
    public async Task<IEnumerable<Customer>> RetrieveAllAsync()
    {
        // for performance, get from cache
        return await Task.FromResult(_customers is null ? Enumerable.Empty<Customer>() : _customers.Values);
    }
    public async Task<Customer?> RetrieveAsync(string id)
    {
        return await _context.Customers.FindAsync(id);
    }
    public async Task<Customer?> UpdateAsync(string id, Customer c)
    {
        _customers[c.CustomerId] = c;
        _context.Customers.Update(c);
        await _context.SaveChangesAsync();
        return c;
    }
    public async Task<bool?> DeleteAsync(string id)
    {
        if (!_customers.TryRemove(id, out Customer c))
        {
            return null;
        }
        _context.Customers.Remove(c);
        await _context.SaveChangesAsync();
        return true;
    }
}
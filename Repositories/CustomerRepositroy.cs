using Data.Contexts;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class CustomerRepository : BaseRepository<CustomerEntity>
{
    public CustomerRepository(DataContext context) : base(context)
    {
        
    }
}









// public class CustomerRepository(DataContext context)
// {
//     private readonly DataContext _context = context;

//     // CREATE
//     public async Task<Customer> CreateAsync(Customer customer)
//     {
//         _context.Customers.Add(customer);
//         await _context.SaveChangesAsync();
//         return customer;
//     }

//     // READ
//     public async Task<List<Customer>> GetAllAsync()
//     {
//         return await _context.Customers.ToListAsync();
//     }

//     public async Task<Customer> GetByIdAsync(int id)
//     {
//         return await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
//     }

//     //UPDATE
//     public async Task<bool> UpdateAsync(Customer customer)
//     {
//         var existingCustomer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == customer.Id);
//         if (existingCustomer != null)
//         {
//             existingCustomer.Name = customer.Name;
//             existingCustomer.LastName = customer.LastName;
//             existingCustomer.Email = customer.Email;

//             await _context.SaveChangesAsync();
//             return true;
//         }

//         return false;
//     }

//     // DELETE
//     public async Task<bool> DeleteAsync(int id)
//     {
//         var entity = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
//         if (entity != null)
//         {
//             _context.Customers.Remove(entity);
//             await _context.SaveChangesAsync();
//             return true;
//         }

//         return false;
//     }
// }

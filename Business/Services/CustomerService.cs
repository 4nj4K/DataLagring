using Data.Entities;
using Data.Repositories;
using Business.Models;
using System.Collections.Generic;
using Business.Factories;

namespace Business.Services;

public class CustomerService
{
    private readonly CustomerRepository _customerRepository;

    public CustomerService(CustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }


    public async Task CreateCustomerAsync(CustomerRegistrationForm form) 
    {
        // var CustomerEntity = new CustomerEntity
        // {
        //     CustomerName = form.CustomerName,
        // };

        var customerEntity = CustomerFactory.Create(form);
        await _customerRepository.AddAsync(customerEntity!);
    }


    public async Task<IEnumerable<Customer>> GetCustomersAsync() 
    {
        var customerEntities = await _customerRepository.GetAsync();

        // var customers = new List<customer>();
        // foreach (var entity in customerEntities)
        //     customers.Add(new Customer
        //     {
        //         Id = entity.Id,
        //         CustomerName  = entity.CustomerName
        //     })

        return customerEntities.Select(CustomerFactory.Create);
    }
    public async Task<Customer?> GetCustomerByIdAync(int Id) 
    {
        var customerEntity = await _customerRepository.GetAsync(x => x.Id == id);
        return CustomerFactory.Create(customerEntity!);
    }
    public async Task<Customer?> GetCustomerByCustomerNameAync(string customerName) 
    {
        var customerEntity = await _customerRepository.GetAsync(x => x.CustomerName == customerName);
        return CustomerFactory.Create(customerEntity!);
    }
    public async Task<bool> UpdateCustomerAsync(Customer customer) 
    {
        if (customer == null)
            return false;

        var existingCustomer = await _customerRepository.GetAsync(x => x.Id == customer.Id);
        if (existingCustomer == null)
            ret

        _context.Customers.Update(customer);
        await _context.SaveChangesAsync();
    }
    public async Task<bool> DeleteCustomerAsync(int id) { }
}
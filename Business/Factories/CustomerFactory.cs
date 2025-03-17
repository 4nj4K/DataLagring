using Business.Models;
using Data.Entities;

namespace Business.Factories;

public static class CustomerFactory
{
    public static CustomerEntity? Create(CustomerRegistrationForm form)
    {
        if (form == null)
            return null;

        return new CustomerEntity
        {
            CustomerName = form.CustomerName,
        };
    }
}
//     public static CustomerEntity Create(CustomerRegistrationForm form) 
//     {
//         if (form == null)
//             return null;

//         return new CustomerEntity
//         {
//             // Id = entity.Id,
//             CustomerName = form.CustomerName,

//         };
//     }

// }

using Otel.Entites.Concrete;
using System.Collections.Generic;


namespace Otel.Business.Abstract
{
    public interface ICustomerService
    {
        void Add(Customer Customer);
        void Update(Customer Customer);
        List<Customer> List();
        Customer Get(string name);
        Customer Get(int Id);
    }
}

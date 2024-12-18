using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Domain.UseCases
{
    public  interface IRepository<T> where T : class
    {

        Task<T> Add(T entity);
    }
}

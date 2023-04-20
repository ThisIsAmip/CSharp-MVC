﻿using CSharp_MVC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductService
    {
        //thêm, sửa, xóa, get all, ...
        Task CreateAsync(Product product);
        Task DeleteAsync(Product product);

        Task UpdateAsync(Product product);
        Task DeleteById(int id);

        IEnumerable<Product> GetAll();
        Product GetByProductId(int product);
    }
}
using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications
{
    public class ProductsFilterSpecification : BaseSpecification<Product>
    {
        public ProductsFilterSpecification(int? categoryId, int? brandId)
        {
            AddCriteria(x => (!categoryId.HasValue || x.CategoryId == categoryId) && (!brandId.HasValue || x.BrandId == brandId));
        }
    }
}

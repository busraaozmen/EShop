using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Specifications
{
    public class ProductsFilterPaginationSpecification : BaseSpecification<Product>
    {
        public ProductsFilterPaginationSpecification(int skip, int take, int? categoryId, int? brandId)
        {
            AddCriteria(x => (!categoryId.HasValue || x.CategoryId == categoryId) && (!brandId.HasValue || x.BrandId == brandId));
            ApplyPaging(skip, take);
        }
    }
}

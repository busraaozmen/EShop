using ApplicationCore.Entities;
using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class BasketWithItemsSpecification : BaseSpecification<Basket>
    {
        public BasketWithItemsSpecification(int basketId) : base(x => x.Id == basketId)
        {
            
            AddInclude(x => x.Items);
        }
        public BasketWithItemsSpecification(string buyerId) : base(x => x.BuyerId == buyerId)
        {
            AddInclude(x => x.Items);
        }


    }
}

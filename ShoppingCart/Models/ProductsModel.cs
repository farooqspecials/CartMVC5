using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Models
{
    public class ProductsModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PaginationModel Pagination { get; set; }

        public int CategoryId { get; set; }

        public String SearchString { get; set; }

        public SelectList Categories()
        {
            ISkillsEntities db = new ISkillsEntities();
            var categories = from c in db.Categories
                             orderby c.CategoryName
                             select new
                             {
                                 c.CategoryId,
                                 c.CategoryName,
                             };
            return new SelectList(categories, "CategoryId", "CategoryName");
        }
    }
}
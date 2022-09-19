using KzShop.DataAccess.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KzShop.DataAccess
{
    internal class ProductRepository :Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }
    }
}

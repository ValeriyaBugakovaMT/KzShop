using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KzShop.DataAccess.DataContext
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateLib
{
    public class EasterEgg
    {
        public int ProductNo { get; set; }
        public string ChocolateType { get; set; }
        public int Price { get; set; }
        public int InStock { get; set; }

        public EasterEgg(int productNo, string? chocolateType, int price, int inStock)
        {
            ProductNo = productNo;
            ChocolateType = chocolateType;
            Price = price;
            InStock = inStock;
        }

        public EasterEgg()
        {
            
        }

        public override string ToString()
        {
            return $"{{{nameof(ProductNo)}={ProductNo.ToString()}, {nameof(ChocolateType)}={ChocolateType}, {nameof(Price)}={Price.ToString()}, {nameof(InStock)}={InStock.ToString()}}}";
        }
    }
}

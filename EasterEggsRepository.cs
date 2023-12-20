using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateLib
{
    public class EasterEggsRepository
    {
        private List<EasterEgg> _easterEgg;
        public EasterEggsRepository()
        {
            _easterEgg = new()
            {
                new EasterEgg(8011, "mørk", 28, 5012),
                new EasterEgg(8012, "mørk", 32, 3420),
                new EasterEgg(8013, "mørk", 46, 1180)
            };
        }
        public IEnumerable<EasterEgg> Get()
        {
            IEnumerable<EasterEgg> result = new List<EasterEgg>();
            return result;
        }

        public EasterEgg? GetByProductNo(int productNo)
        {
            if(productNo == null)
            {
                throw new ArgumentOutOfRangeException(nameof(productNo), "The product number does not exist");
            }
            return _easterEgg.Find(easterEgg => easterEgg.ProductNo == productNo);
        }

        public IEnumerable<EasterEgg> GetLowStock(int stockLevel) 
        {
               return _easterEgg.Where(s => s.InStock <= stockLevel);
        }

        public EasterEgg? Update(int productNo, EasterEgg easterEgg)
        {
            EasterEgg? result = GetByProductNo(productNo);
            if(result == null)
            {
                throw new ArgumentNullException(nameof(result), "The Easteregg does not exist");
            }
            result.ProductNo = easterEgg.ProductNo;
            result.Price = easterEgg.Price;
            return result;
        }
    }
}

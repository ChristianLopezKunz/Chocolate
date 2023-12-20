using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateLib
{
    public interface IEasterEggRepo
    {
        IEnumerable<EasterEgg> Get();
        EasterEgg? GetByProductNo(int productNo);
        IEnumerable<EasterEgg> GetLowStock(int stockLevel);
        EasterEgg? Update(int productNo, EasterEgg easterEgg);
    }
}

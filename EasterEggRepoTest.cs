using ChocolateLib;
using static System.Reflection.Metadata.BlobBuilder;

namespace EasterEggsRepositoryTest
{
    [TestClass]
    public class EasterEggTest
    {
        private EasterEggsRepository _repo; 

        [TestInitialize]
        public void Init()
        {
            _repo = new EasterEggsRepository();
        }

        [TestMethod()]
        public void TestGet()
        {
            IEnumerable<EasterEgg> eastereggs = _repo.Get();
            Assert.AreEqual(4, eastereggs.Count());
            Assert.AreNotEqual(5, eastereggs.Count());
            Assert.AreEqual(eastereggs.First().ChocolateType, "mørk");
        }

        [TestMethod()]
        public void TestGetByProductNo()
        {
            EasterEgg? eastereggs = _repo.GetByProductNo(8012);
            Assert.IsNotNull(_repo.GetByProductNo(1));
            Assert.IsNull(_repo.GetByProductNo(100));
        }

        [TestMethod()]
        public void TestGetLowStock()
        {
            Assert.IsNotNull(_repo.GetLowStock(1000));
            Assert.IsNull (_repo.GetLowStock(100));
        }
    }
}
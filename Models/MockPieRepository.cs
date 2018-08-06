using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies==null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie{Id = 1, Name = "Chole Puri", Price=20, ShortDescription="Our famous apple pies",LongDescription ="It is very tasty and delicious there are many type of pie are available" },
                new Pie{Id = 2, Name = "Rajma Chawal", Price=30, ShortDescription="Our famous apple Cherry",LongDescription ="It is very tasty and delicious there are many type of cake are available" },
                new Pie{Id = 3, Name = "Chole Kulche", Price=10, ShortDescription="Our famous apple Cheese",LongDescription ="It is very tasty and delicious there are many type of cheese are available" },
                new Pie{Id = 4, Name = "Chole chawal", Price=25, ShortDescription="Our famous apple Cherry Pie",LongDescription ="It is very tasty and delicious there are many type of Cherry Pie are available" }
             };
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieByID(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}

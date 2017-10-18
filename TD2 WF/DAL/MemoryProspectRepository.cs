using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class MemoryProspectRepository : IProspectRepository
    {
        private List<Prospect> prospectList;

        public List<Prospect> GetAll()
        {
            return prospectList;
        }

        public void Add(Prospect prospect)
        {
            prospectList.Add(prospect);
        }

        public MemoryProspectRepository()
        {
            prospectList = new List<Prospect>();
            Prospect predefini1;
            DateTime dt1 = new DateTime(2016, 9, 1);
            predefini1 = new Prospect("Dupont", "Jacques", "jacques@dupont.com", dt1, "Rappel urgent");
            Prospect predefini2;
            DateTime dt2 = new DateTime(2017, 9, 11);
            predefini2 = new Prospect("Leblanc", "Jean", "jlb@gmail.com", dt2);
            Prospect predefini3;
            predefini3 = new Prospect();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Data.Lists
{
    public class ObjectA
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ObjectB
    {
        public int NewId { get; set; }
        public string Description { get; set; }

    }

    public class ObjectC
    {
        public int Counter { get; set; }
        public string PartNumber { get; set; }

        public List<ObjectA> TonsOfA { get; set; }
    }

    public class ObjectD
    {
        public List<ObjectB> TonsOfB { get; set; }
        public List<ObjectC> TonsOfC { get; set; }
    }
}

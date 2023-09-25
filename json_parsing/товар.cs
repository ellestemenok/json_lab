using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_parsing
{
    [System.Runtime.Serialization.DataContract]
    class товар
    {
        [System.Runtime.Serialization.DataMember]
        public int код;
        [System.Runtime.Serialization.DataMember]
        public string наименование;
        [System.Runtime.Serialization.DataMember]
        public double цена;

        public товар(int kod, string naimen, double cena)
        {
            this.код = kod;
            this.наименование = naimen;
            this.цена = cena;
        }
    }
}

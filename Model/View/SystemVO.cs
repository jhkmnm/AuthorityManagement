using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.View
{
    public class SystemVO : ViewObjectBase
    {
        public int SystemID
        { get; set; }

        public string SystemName
        { get; set; }

        public string SystemDescription
        { get; set; }
    }
}

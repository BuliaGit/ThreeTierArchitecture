using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntity
{
    public class ProfessionInfoEntity
    {
        public ProfessionInfoEntity()
        {
            this.ProfessionID = 0;
            this.ProfessionName = string.Empty;
        }
        public int ProfessionID { get; set; }
        public string ProfessionName { get; set; }
    }
}

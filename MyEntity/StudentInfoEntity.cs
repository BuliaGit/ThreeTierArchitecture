using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntity
{
    public class StudentInfoEntity
    {
        public StudentInfoEntity()
        {
            this.StuID = string.Empty;
            this.StuName = string.Empty;
            this.StuAge = 0;
            this.StuSex = string.Empty;
            this.StuHobby = string.Empty;
            this.ProfessionID = 0;
            this.ProfessionName = string.Empty;
        }
        public string StuID { get; set; }
        public string StuName { get; set; }
        public int StuAge { get; set; }
        public string StuSex { get; set; }
        public string StuHobby { get; set; }
        public int ProfessionID { get; set; }
        public string ProfessionName { get; set; }
    }
}

using MyEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IStudentInfoBLL
    {
        int Add(StudentInfoEntity entity);
        int Delete(string id);
        List<StudentInfoEntity> List();
        int Update(StudentInfoEntity entity);
        StudentInfoEntity Detail(int id);
        List<StudentInfoEntity> SearchList(StudentInfoEntity searchObj);
    }
}

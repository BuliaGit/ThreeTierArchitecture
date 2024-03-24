using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAL;
using MyDAL;
using MyEntity;

namespace MyBLL
{
    public class StudentInfoBLL:IStudentInfoBLL
    {
        IStudentInfoDAL dal = new StudentInfoDAL();
        //新增
        public int Add(StudentInfoEntity entity)
        {
            return dal.Add(entity);
        }
        //删除
        public int Delete(string id)
        {
            return dal.Delete(id);
        }
        //列表
        public List<StudentInfoEntity> List()
        {
            return dal.List();
        }
        //修改
        public int Update(StudentInfoEntity entity)
        {
            return dal.Update(entity);
        }
        //详情
        public StudentInfoEntity Detail(int id)
        {
            return dal.Detail(id);
        }

        //搜索查询
        public List<StudentInfoEntity> SearchList(StudentInfoEntity searchObj)
        {
            return dal.SearchList(searchObj);
        }
    }
}

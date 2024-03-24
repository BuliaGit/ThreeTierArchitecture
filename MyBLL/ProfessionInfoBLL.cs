using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDAL;
using MyEntity;

namespace MyBLL
{
    public class ProfessionInfoBLL
    {
         ProfessionInfoDAL dal = new ProfessionInfoDAL();
        //新增
        public int Add(ProfessionInfoEntity entity)
        {
            return dal.Add(entity);
        }
        //删除
        public int Delete(int id)
        {
            return dal.Delete(id);
        }
        //列表
        public List<ProfessionInfoEntity> List()
        {
            return dal.List();
        }
        //修改
        public int Update(ProfessionInfoEntity entity)
        {
            return dal.Update(entity);
        }
        //详情
        public ProfessionInfoEntity Detail(int id)
        {
            return dal.Detail(id);
        }

    }
}

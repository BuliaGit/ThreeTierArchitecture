using MyEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL
{
    public class ProfessionInfoDAL
    {
        //新增
        public int Add(ProfessionInfoEntity entity)
        {
            string sql = "insert into ProfessionInfo(ProfessionName) values(@ProfessionName)";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("ProfessionName", entity.ProfessionName);
            return DBHelper.ExecuteNonQuery();
        }
        //删除
        public int Delete(int id)
        {
            string sql = "delete from ProfessionInfo where ProfessionID = @ProfessionID";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("ProfessionID", id);
            return DBHelper.ExecuteNonQuery();
        }
        //列表
        public List<ProfessionInfoEntity> List()
        {
            DataTable dt = new DataTable();
            string sql = "select * from ProfessionInfo";
            DBHelper.InitSql(sql);
            dt = DBHelper.ExecuteQuery();
            List<ProfessionInfoEntity> list = new List<ProfessionInfoEntity>();
            foreach (DataRow item in dt.Rows)
            {
                ProfessionInfoEntity entity = new ProfessionInfoEntity() { ProfessionID = int.Parse(item["ProfessionID"].ToString()), ProfessionName = item["ProfessionName"].ToString() };
                list.Add(entity);
            }
            return list;
        }
        //修改
        public int Update(ProfessionInfoEntity entity)
        {
            string sql = "update ProfessionInfo set ProfessionName = @ProfessionName where ProfessionID = @ProfessionID";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("ProfessionName", entity.ProfessionName);
            DBHelper.SetParameter("ProfessionID", entity.ProfessionID);
            return DBHelper.ExecuteNonQuery();
        }
        //详情
        public ProfessionInfoEntity Detail(int id)
        {
            DataTable dt = new DataTable();
            string sql = "select * from ProfessionInfo where ProfessionID = @ProfessionID";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("ProfessionID", id);
            dt = DBHelper.ExecuteQuery();
            if (dt.Rows.Count == 0)
                return null;
            return new ProfessionInfoEntity() { ProfessionID = int.Parse(dt.Rows[0].ToString()), ProfessionName = dt.Rows[1].ToString() };
        }
    }
}

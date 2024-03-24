using IDAL;
using MyEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyDAL
{
    public class StudentInfoDAL:IStudentInfoDAL
    {
        //新增
        public int Add(StudentInfoEntity entity)
        {
            string sql = "insert into StudentInfo(StuID,StuName,StuAge,StuSex,StuHobby,ProfessionID) values(@StuID,@StuName,@StuAge,@StuSex,@StuHobby,@ProfessionID)";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("StuID", entity.StuID);
            DBHelper.SetParameter("StuName", entity.StuName);
            DBHelper.SetParameter("StuAge", entity.StuAge);
            DBHelper.SetParameter("StuSex", entity.StuSex);
            DBHelper.SetParameter("StuHobby", entity.StuHobby);
            DBHelper.SetParameter("ProfessionID", entity.ProfessionID);
            return DBHelper.ExecuteNonQuery();
        }
        //删除
        public int Delete(string id)
        {
            string sql = "delete from StudentInfo where StuID = @StuID";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("StuID", id);
            return DBHelper.ExecuteNonQuery();
        }
        //列表
        public List<StudentInfoEntity> List()
        {
            DataTable dt = new DataTable();
            string sql = "select * from StudentInfo";
            DBHelper.InitSql(sql);
            dt = DBHelper.ExecuteQuery();
            List<StudentInfoEntity> list = new List<StudentInfoEntity>();
            foreach (DataRow item in dt.Rows)
            {
                StudentInfoEntity entity = new StudentInfoEntity();
                entity.StuID = item[0].ToString();
                entity.StuName = item[1].ToString();
                entity.StuAge = int.Parse(item[2].ToString());
                entity.StuSex = item[3].ToString();
                entity.StuHobby = item[4].ToString();
                entity.ProfessionID = int.Parse(item[5].ToString());
                list.Add(entity);
            }
            return list;
        }
        //修改
        public int Update(StudentInfoEntity entity)
        {
            string sql = "update StudentInfo set StuName = @StuName,StuAge=@StuAge,StuSex=@StuSex,StuHobby=@StuHobby,ProfessionID=@ProfessionID where StuID = @StuID";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("StuName", entity.StuName);
            DBHelper.SetParameter("StuAge", entity.StuAge);
            DBHelper.SetParameter("StuSex", entity.StuSex);
            DBHelper.SetParameter("StuHobby", entity.StuHobby);
            DBHelper.SetParameter("ProfessionID", entity.ProfessionID);
            DBHelper.SetParameter("StuID", entity.StuID);
            return DBHelper.ExecuteNonQuery();
        }
        //详情
        public StudentInfoEntity Detail(int id)
        {
            DataTable dt = new DataTable();
            string sql = "select * from StudentInfoEntity where StuID = @StuID";
            DBHelper.InitSql(sql);
            DBHelper.SetParameter("StuID", id);
            dt = DBHelper.ExecuteQuery();
            if (dt.Rows.Count == 0)
                return null;
            StudentInfoEntity entity = new StudentInfoEntity
            {
                StuID = dt.Rows[0].ToString(),
                StuName = dt.Rows[1].ToString(),
                StuAge = int.Parse(dt.Rows[2].ToString()),
                StuSex = dt.Rows[3].ToString(),
                StuHobby = dt.Rows[4].ToString(),
                ProfessionID = int.Parse(dt.Rows[5].ToString())
            };
            return entity;
        }

        //----------------------------------------------------------------------
        /// <summary>
        /// 搜索查询学生列表
        /// </summary>
        /// <param name="searchObj"></param>
        /// <returns></returns>
        public List<StudentInfoEntity> SearchList(StudentInfoEntity searchObj)
        {
            DataTable dt = new DataTable();
            string sql = "select * from StudentInfo inner join ProfessionInfo on StudentInfo.ProfessionID=ProfessionInfo.ProfessionID where 1=1";
            if (searchObj.ProfessionID != 0)
                sql += " and StudentInfo.ProfessionID = "+searchObj.ProfessionID;
            if(!string.IsNullOrEmpty(searchObj.StuName))
                sql += " and StuName like '%"+searchObj.StuName+"%'";
            DBHelper.InitSql(sql);

            dt = DBHelper.ExecuteQuery();
            List<StudentInfoEntity> list = new List<StudentInfoEntity>();
            foreach (DataRow item in dt.Rows)
            {
                StudentInfoEntity entity = new StudentInfoEntity();
                entity.StuID = item[0].ToString();
                entity.StuName = item[1].ToString();
                entity.StuAge = int.Parse(item[2].ToString());
                entity.StuSex = item[3].ToString();
                entity.StuHobby = item[4].ToString();
                entity.ProfessionID = int.Parse(item[5].ToString());
                entity.ProfessionName = item[7].ToString();
                list.Add(entity);
            }
            return list;
        }
    }
}

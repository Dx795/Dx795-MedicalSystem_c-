using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemDAL
{
    public class ReadInfoRmationService
    {
        #region 人力资源管理
        //根据头像 查询人物信息
        public static SqlDataReader ReadInfo(string photo)
        {
            string sqlstr = "select * from T_Hairpin where Photo='" + photo + "';";
            return DBHelper.ReadInfo(sqlstr);
        }
        #endregion

        #region 医生工作台
        public static SqlDataReader ReadPatientInfo(int id)
        {
            string sqlstr = "select * from T_Patient where id='" + id + "';";
            return DBHelper.ReadInfo(sqlstr);
        }
        #endregion

        #region 护士工作台
        //读取药品
        public static SqlDataReader ReadDrugsInfo(string DrugNo)
        {
            string sqlstr = "select * from T_Drugs where DrugNo='" + DrugNo + "';";
            return DBHelper.ReadInfo(sqlstr);
        }
        public static SqlDataReader ReadDrugsInfo1()
        {
            string sqlstr = "select * from T_Drugs;";
            return DBHelper.ReadInfo(sqlstr);
        }
        //读取护士信息
        public static SqlDataReader ReadNurseInfo(string NurseName)
        {
            string sqlstr = "select * from T_Nurse where NurseName='" + NurseName + "';";
            return DBHelper.ReadInfo(sqlstr);
        }
        #endregion

        #region 龙写--- 病人 
        // 主界面下面的 查询病人性别--病人表
        public static DataSet SelectGender(string PatientName)
        {
            string sqlstr = "select * from T_Patient where PatientName=@PatientName";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@PatientName", System.Data.SqlDbType.NVarChar);
            paras[0].Value = PatientName;
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }

        //病人挂号读卡 查病人信息---病人表
        public static DataSet SelectPatient(string PatientNumber)
        {
            string sqlstr = "select * from T_Patient where PatientNumber=@PatientNumber";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@PatientNumber", System.Data.SqlDbType.NVarChar);
            paras[0].Value = PatientNumber;
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }

        //病人挂号确认挂号  查科室类别---医生表
        public static DataSet SelectDepartment()
        {
            string sqlstr = "select * from T_Doctor";
            return DBHelper.ExcuteDataSet(sqlstr);
        }

        //病人挂号确认挂号  查医生名字 根据科室类别-- 医生表
        public static DataSet SelectDoctorName(string Department)
        {
            string sqlstr = "select * from T_Doctor where Department=@Department";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Department", System.Data.SqlDbType.NVarChar);
            paras[0].Value = Department;
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }
        //病人挂号确认挂号  查询空病房  根据科室类别 和空的-- 病房表
        public static DataSet SelectInpatientWard(string Department)
        {
            string sqlstr = "select * from T_InpatientWard where DepartmentNo=@DepartmentNo and PatientNumber=@PatientNumber";
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@DepartmentNo", System.Data.SqlDbType.NVarChar);
            paras[0].Value = Department;
            paras[1] = new SqlParameter("@PatientNumber", System.Data.SqlDbType.NVarChar);
            paras[1].Value = "Null";
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }
        
        //病人挂号确认挂号  查医生照片 根据医生名字 --医生表
        public static DataSet SelectImage(string DoctorName)
        {
            string sqlstr = "select * from T_Doctor where DoctorName=@DoctorName";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@DoctorName", System.Data.SqlDbType.NVarChar);
            paras[0].Value = DoctorName;
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }


        //挂号表 挂号查询是否有数据 
        public static DataSet SelectRegist(string PatientNumber)
        {
            string sqlstr = "select * from T_Register where PatientNumber=@PatientNumber";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@PatientNumber", System.Data.SqlDbType.NVarChar);
            paras[0].Value = PatientNumber;
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }
        //菜品表 
        public static DataSet ReadCaiPing()
        {
            string sqlstr = "select * from T_CaiPing;";
            return DBHelper.ExcuteDataSet(sqlstr);
        }
        //菜品表 精确查找
        public static DataSet ReadCaiPingJQ(string caiName)
        {
            string sqlstr = "select * from T_CaiPing where caiName=@caiName;";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@caiName", System.Data.SqlDbType.NVarChar);
            paras[0].Value = caiName;
            return DBHelper.ExcuteDataSet(sqlstr,paras);
        }        
        //购物车表
        public static DataSet ReadSpingCart(string name)
        {
            string sqlstr = "select * from T_SpingCart where Name=@Name;";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);
            paras[0].Value = name;
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }

        //购物车表
        public static DataSet ReadSpingCart(string name,string caiName)
        {
            string sqlstr = "select * from T_SpingCart where Name=@Name and caiName=@caiName;";
            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);
            paras[0].Value = name;
            paras[1] = new SqlParameter("@caiName", System.Data.SqlDbType.NVarChar);
            paras[1].Value = caiName;
            return DBHelper.ExcuteDataSet(sqlstr, paras);
        }
        #endregion
    }
}

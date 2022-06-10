using MedicalSystemDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemBLL
{
    public class ReadInfoRmationManager
    {
        #region 人力资源管理
        public static SqlDataReader Readinfo(string photo)
        {
            return ReadInfoRmationService.ReadInfo(photo);
        }
        #endregion

        #region 医生工作台
        public static SqlDataReader ReadPatientInfo(int id)
        {
            return ReadInfoRmationService.ReadPatientInfo(id);
        }
        #endregion

        #region 护士工作台
        //读取药品信息
        public static SqlDataReader ReadDrugsInfo(string DrugNO)
        {
            return ReadInfoRmationService.ReadDrugsInfo(DrugNO);
        }
        public static SqlDataReader ReadDrugsInfo1()
        {
            return ReadInfoRmationService.ReadDrugsInfo1();
        }
        //读取护士信息
        public static SqlDataReader ReadNurseInfo(string NurseName)
        {
            return ReadInfoRmationService.ReadNurseInfo(NurseName);
        }
        #endregion

        #region 小龙写 病人 
        //查询病人性别
        public static DataSet SelectGender(string PatientName)
        {
            return ReadInfoRmationService.SelectGender(PatientName);
        }
        //病人挂号读卡 查病人信息
        public static DataSet SelectPatient(string PatientNumber)
        {
            return ReadInfoRmationService.SelectPatient(PatientNumber);
        }
        //病人挂号确认挂号  查科室类别
        public static DataSet SelectDepartment()
        {
            return ReadInfoRmationService.SelectDepartment();
        }

        //病人挂号确认挂号  查医生名字 根据科室类别
        public static DataSet SelectDoctorName(string Department)
        {
            return ReadInfoRmationService.SelectDoctorName(Department);
        }

        //病人挂号确认挂号  查医生照片 根据医生名字
        public static DataSet SelectImage(string DoctorName)
        {
            return ReadInfoRmationService.SelectImage(DoctorName);
        }
        public static DataSet SelectRegist(string PatientNumber)
        {
            return ReadInfoRmationService.SelectRegist(PatientNumber);
        }
        public static DataSet SelectInpatientWard(string Department)
        {
            return ReadInfoRmationService.SelectInpatientWard(Department);
        }
        //读取菜品信息----菜品表
        public static DataSet ReadCaiPing()
        {
            return ReadInfoRmationService.ReadCaiPing();
        }
        //读取菜品信息----菜品表 精确查询
        public static DataSet ReadCaiPingJQ(string caiName)
        {
            return ReadInfoRmationService.ReadCaiPingJQ(caiName);
        }
        //读取----购物表
        public static DataSet ReadSpingCart(string name)
        {
            return ReadInfoRmationService.ReadSpingCart(name);
        }
        //读取----购物表 精确
        public static DataSet ReadSpingCart(string name, string caiName)
        {
            return ReadInfoRmationService.ReadSpingCart(name, caiName);
        }
        #endregion
    }
}

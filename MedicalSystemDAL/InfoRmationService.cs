using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemDAL
{
    public class InfoRmationService
    {
        #region 人力资源管理
        //插入信息到医生表
        public static int InsertInfoRmation(string DoctorNo, string DoctorName, string DoctorAge, string Gender, string DateBirth, string Title, DateTime AdmissionTime, string Pwd, string Phone, string Photo)
        {
            string sql = "insert into T_Doctor(DoctorNo,DoctorName,DoctorAge,Gender,DateBirth,Title,AdmissionTime,Pwd,Phone,Photo) values('" + DoctorNo + "','" + DoctorName + "','" + DoctorAge + "','" + Gender + "','" + DateBirth + "','" + Title + "','" + AdmissionTime + "','" + Pwd + "','" + Phone + "','" + Photo + "')";
            return (int)DBHelper.InsertInfoRmation(sql);
        }
        //插入信息到护士表
        public static int InsertInfoRmation1(string NurseNumber, string NurseName, string NurseAge, string Gender, string DateBirth, string Title, DateTime AdmissionTime, string Pwd, string Telephone, string Photo)
        {
            string sql = "insert into T_Nurse(NurseNumber,NurseName,NurseAge,Gender,DateBirth,Title,AdmissionTime,Pwd,Telephone,Photo) values('" + NurseNumber + "','" + NurseName + "','" + NurseAge + "','" + Gender + "','" + DateBirth + "','" + Title + "','" + AdmissionTime + "','" + Pwd + "','" + Telephone + "','" + Photo + "')";
            return (int)DBHelper.InsertInfoRmation(sql);
        }
        //插入信息到病人表
        public static int InsertInfoRmation2(string PatientNumber, string PatientName, string PatientAge, string Gender, string DateBirth, string Pwd, string ContactNumber, string Photo)
        {
            string sql = "insert into T_Patient(PatientNumber,PatientName,PatientAge,Gender,DateBirth,Pwd,ContactNumber,Photo) values('" + PatientNumber + "','" + PatientName + "','" + PatientAge + "','" + Gender + "','" + DateBirth + "','" + Pwd + "','" + ContactNumber + "','" + Photo + "')";
            return (int)DBHelper.InsertInfoRmation(sql);
        }
        //删除未入职前信息
        public static int DeleteInfoRmation(string Name, string Age)
        {
            string sql = "delete from T_Hairpin where Name = '" + Name + "' and Age = '" + Age + "'";
            return (int)DBHelper.DeleteInfoRmation(sql);
        }
        #endregion

        #region 医生工作台

        //签到
        public static int UpdateDoctorInfo(string Department, string DoctorNo)
        {
            string sqlstr = "update T_Doctor set Department='" + Department + "' where DoctorNo='" + DoctorNo + "'";
            return DBHelper.UpdateInfoRmation(sqlstr);
        }
        #endregion

        #region 护士工作台

        // 药品入库
        public static int InsertDrugsInfo(string DrugNo, string DrugName, string StorageNumber, string QuantityDrugs, DateTime StorageTime, string DrugSellingUnitPrice,string Photo)
        {
            string sql = "insert into T_DrugInventory(DrugNo,DrugName,StorageNumber,QuantityDrugs,StorageTime,DrugSellingUnitPrice,Photo) values('" + DrugNo + "','" + DrugName + "','" + StorageNumber + "','" + QuantityDrugs + "','" + StorageTime + "','" + DrugSellingUnitPrice + "','" + Photo + "')";
            return (int)DBHelper.InsertInfoRmation(sql);
        }

        //药品添加
        public static int InsertDrugsAddInfo(string DrugNo, string DrugName, string DrugClassIfication, string DrugSpecIfications, string DrugBrand, string DrugPurchasePrice, string DrugSellingUnitPrice, string QuantityDrugs,string Photo)
        {
            string sql = "insert into T_Drugs(DrugNo,DrugName,DrugClassIfication,DrugSpecIfications,DrugBrand,DrugPurchasePrice,DrugSellingUnitPrice,QuantityDrugs,DrugImage) values('" + DrugNo + "','" + DrugName + "','" + DrugClassIfication + "','" + DrugSpecIfications + "','" + DrugBrand + "','" + DrugPurchasePrice + "','" + DrugSellingUnitPrice + "','" + QuantityDrugs + "','" + Photo + "')";
            return (int)DBHelper.InsertInfoRmation(sql);
        }

        #endregion

        #region 小龙写 病人 
        //插入信息到挂号表
        public static int InsertInfoRegister(string PatientNumber, string RegisteredType, string DepartmentNo, string ReturnNo, string DateRegistration, string Illness)
        {
            string sql = "insert into T_Register(PatientNumber,RegisteredType,DepartmentNo,ReturnNo,DateRegistration,Illness) values('" + PatientNumber + "','" + RegisteredType + "','" + DepartmentNo + "','" + ReturnNo + "','" + DateRegistration + "','" + Illness + "')";
            return (int)DBHelper.InsertInfoRmation(sql);
        }
        //更新信息到病床表
        public static int UpdateTnpatientWard(string PatientNumber, string PatientName,string DepartmentNo,string bedNo)
        {
            string sqlstr = "update T_InpatientWard set PatientNumber='" + PatientNumber + "' ,PatientName='" + PatientName + "' where DepartmentNo='" + DepartmentNo + "'and  BedNo='" + bedNo + "'";
            return DBHelper.UpdateInfoRmation(sqlstr);
        }
        //插入信息到购物车表
        public static int InsertSpingCart(string caiName, string Name, int count)
        {
            string sql = "insert into T_SpingCart(caiName,Name,count) values('" + caiName + "','" + Name + "','" + count + "')";
            return (int)DBHelper.InsertInfoRmation(sql);
        }

        //更新信息到购物车表  数量
        public static int UpdateSpingCart(string caiName, int count)
        {
            string sqlstr = "update T_SpingCart set count='" + count + "'  where caiName='" + caiName + "'";
            return DBHelper.UpdateInfoRmation(sqlstr);
        }
        //更新信息到病人表  金额
        public static int UpdatePatientjiner(int yuer,string PatientNumber)
        { 
            string sqlstr = "update T_Patient set yuer='" + yuer + "' where PatientNumber='" + PatientNumber + "'";
            return DBHelper.UpdateInfoRmation(sqlstr);
        }
        public static int DeleterPatientjiner(string name)
        { 
            string sqlstr = "delete  from  T_SpingCart  where Name='" + name + "'";
            return (int)DBHelper.DeleteInfoRmation(sqlstr);
        }
        #endregion

    }
}

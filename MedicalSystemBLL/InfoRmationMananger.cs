using MedicalSystemDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemBLL
{
    public class InfoRmationMananger
    {
        #region 人力资源管理
        public static int InsertInfoRmation(string DoctorNo, string DoctorName, string DoctorAge, string Gender, string DateBirth, string Title, DateTime AdmissionTime, string Pwd, string Phone, string Photo)
        {
            return InfoRmationService.InsertInfoRmation(DoctorNo, DoctorName, DoctorAge, Gender, DateBirth, Title, AdmissionTime, Pwd, Phone, Photo);
        }

        public static int InsertInfoRmation1(string NurseNumber, string NurseName, string NurseAge, string Gender, string DateBirth, string Title, DateTime AdmissionTime, string Pwd, string Telephone, string Photo)
        {
            return InfoRmationService.InsertInfoRmation1(NurseNumber, NurseName, NurseAge, Gender, DateBirth, Title, AdmissionTime, Pwd, Telephone, Photo);
        }
        public static int InsertInfoRmation2(string PatientNumber, string PatientName, string PatientAge, string Gender, string DateBirth, string Pwd, string ContactNumber, string Photo)
        {
            return InfoRmationService.InsertInfoRmation2(PatientNumber, PatientName, PatientAge, Gender, DateBirth, Pwd, ContactNumber, Photo);
        }
        public static int DeleteInfoRmation(string Name, string Age)
        {
            return InfoRmationService.DeleteInfoRmation(Name, Age);
        }
        #endregion

        #region 医生工作台
        //签到
        public static int UpdateDoctorInfo(string Department, string DoctorNo)
        {
            return InfoRmationService.UpdateDoctorInfo(Department, DoctorNo);
        }
        #endregion

        #region 护士工作台
        // 药品入库
        public static int InsertDrugsInfo(string DrugNo, string DrugName, string StorageNumber, string QuantityDrugs, DateTime StorageTime, string DrugSellingUnitPrice, string Photo)
        {
            return InfoRmationService.InsertDrugsInfo(DrugNo, DrugName, StorageNumber, QuantityDrugs, StorageTime, DrugSellingUnitPrice, Photo);
        }

        // 药品添加
        public static int InsertDrugsAddInfo(string DrugNo, string DrugName, string DrugClassIfication, string DrugSpecIfications, string DrugBrand, string DrugPurchasePrice, string DrugSellingUnitPrice, string QuantityDrugs, string Photo)
        {
            return InfoRmationService.InsertDrugsAddInfo(DrugNo, DrugName, DrugClassIfication, DrugSpecIfications, DrugBrand, DrugPurchasePrice, DrugSellingUnitPrice, QuantityDrugs, Photo);
        }
        #endregion

        #region 小龙写 病人 
        public static int InsertInfoRegister(string PatientNumber, string RegisteredType, string DepartmentNo, string ReturnNo, string DateRegistration, string Illness)
        {
            return InfoRmationService.InsertInfoRegister(PatientNumber, RegisteredType, DepartmentNo, ReturnNo, DateRegistration, Illness);
        }
        public static int UpdateTnpatientWard(string PatientNumber, string PatientName, string DepartmentNo, string bedNo)
        {
            return InfoRmationService.UpdateTnpatientWard(PatientNumber, PatientName, DepartmentNo, bedNo);
        }
        //插入信息到购物车表
        public static int InsertSpingCart(string caiName, string Name, int count)
        {
            return InfoRmationService.InsertSpingCart(caiName, Name, count);
        }

        //更新信息到购物车表  数量
        public static int UpdateSpingCart(string caiName, int count)
        {
            return InfoRmationService.UpdateSpingCart(caiName, count);
        }
        public static int UpdatePatientjiner(int yuer, string PatientNumber)
        {
            return InfoRmationService.UpdatePatientjiner(yuer, PatientNumber);
        }
        public static int DeleterPatientjiner(string name)
        {
            return InfoRmationService.DeleterPatientjiner(name);
        }
        #endregion
    }
}

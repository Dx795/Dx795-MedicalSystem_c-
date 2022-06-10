using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemDAL
{
    public class SelectReadInfoRmationService
    {
        #region 登陆系统
        public static int SelectReadInfoRmation(string UserName, string Pwd, string Type)
        {
            string sqlstr = null;
            if (Type == "医生")
            {
                sqlstr = "select count(*) from T_Doctor where DoctorName='" + UserName + "' and Pwd='" + Pwd + "';";

            }
            else if (Type == "护士")
            {
                sqlstr = "select count(*) from T_Nurse where NurseName='" + UserName + "' and Pwd='" + Pwd + "';";
            }
            else if (Type == "病人")
            {
                sqlstr = "select count(*) from T_Patient where PatientName='" + UserName + "' and Pwd='" + Pwd + "';";
            }
            return (int)DBHelper.SelectInfoRmation(sqlstr);
        }
        #endregion

        #region 签到
        public static int SelectSignInInfoRmation(string CardNo, string Type)
        {
            string sqlstr = null;
            if (Type == "医生")
            {
                sqlstr = "select count(*) from T_Doctor where DoctorNo='" + CardNo + "';";

            }
            else if (Type == "护士")
            {
                sqlstr = "select count(*) from T_Nurse where NurseNumber='" + CardNo + "';";
            }
            return (int)DBHelper.SelectInfoRmation(sqlstr);
        }
        #endregion
    }
}

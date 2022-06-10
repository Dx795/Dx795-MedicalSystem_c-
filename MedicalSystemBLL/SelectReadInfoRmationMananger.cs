using MedicalSystemDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemBLL
{
    public class SelectReadInfoRmationMananger
    {
        //登录
        public static int SelectReadInfoRmation(string CardNumber, string Pwd, string Type)
        {
            return SelectReadInfoRmationService.SelectReadInfoRmation(CardNumber, Pwd, Type);
        }
        //签到
        public static int SelectSignInInfoRmation(string CardNo, string Type)
        {
            return SelectReadInfoRmationService.SelectSignInInfoRmation(CardNo, Type);
        }
    }
}

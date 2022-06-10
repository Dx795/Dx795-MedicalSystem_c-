using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalSystemModel
{
    public class Config
    {
        private static string ip;

        private static string img;

        private static string user;
        private static DateTime classTime;
        private static string ys;
        public static string Ip { get => ip; set => ip = value; }
        public static string Img { get => img; set => img = value; }
        public static string User { get => user; set => user = value; }
        public static DateTime ClassTime { get => classTime; set => classTime = value; }
        public static string Ys { get => ys; set => ys = value; }
    }
}

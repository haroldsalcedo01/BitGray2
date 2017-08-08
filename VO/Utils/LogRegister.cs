using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO.Utils
{
    /// <summary>
    /// clase encargada del registo en el log
    /// 
    /// </summary>
    public class LogRegister
    {
        /// <summary>
        /// metodo de registro de errores en log.txt
        /// queda la base de el proyecto web
        /// </summary>
        /// <param name="ex"></param>
        public static void RegisterLog(Exception ex) 
        {
            string hola = "";
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory +  @"\log.txt"))
            {
                string format = "Fecha: {0} : Error : {1}";
                string date = DateTime.Now.ToString();
                file.WriteLine(string.Format(format, date, ex.Message));
            }
        }
    }
}

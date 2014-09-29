using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.View;
using System.Data.Sql;
using System.Data.SqlClient;
using SRDFAA;
using DBManager; 

namespace DAL
{
    public class System
    {
        SRDSystemDB connString = DBManager.SRDSystemDB.GetSRDSystemDB(DBServerName.SRDK3, DataBaseName.DataControlCenterSystem);

        public List<SystemVO> GetList()
        { 
            SqlParameter[] parameters = new SqlParameter[]{};

            return DbHelperSQL.RunProcedure<SystemVO>(connString, "UP_System_GetList", parameters).ToList();
        }

        public int Save(SystemVO systemItem, string userName)
        {
            SqlParameter[] parameters = new SqlParameter[] { 
                new SqlParameter("@SystemID", systemItem.SystemID),
                new SqlParameter("@SystemName", systemItem.SystemName),
                new SqlParameter("@SystemDescription", systemItem.SystemDescription),
                new SqlParameter("@UserName", userName)
            };
            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_System_Save", parameters, out rowsAffected);
        }

        public int Delete(int systemID)
        {
            SqlParameter[] parameters = new SqlParameter[] { 
                new SqlParameter("@SystemID", systemID)
            };
            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_System_Delete", parameters, out rowsAffected);
        }
    }
}

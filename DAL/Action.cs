using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.View;
using System.Data.SqlClient;
using DBManager;
using SRDFAA;

namespace DAL
{
    public class Action
    {
        SRDSystemDB connString = DBManager.SRDSystemDB.GetSRDSystemDB(DBServerName.SRDK3, DataBaseName.DataControlCenterSystem);

        //public List<ActionVO> GetActionList(int moduleItemID)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]{
        //        new SqlParameter("@ModuleItemID", moduleItemID)
        //    };

        //    return DbHelperSQL.RunProcedure<ActionVO>(connString, "UP_Action_Select", parameters).ToList();
        //}

        //public List<ActionVO> GetActionList(int actionID, string actionCode)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]{                
        //        new SqlParameter("@ActionID", actionID),
        //        new SqlParameter("@ActionCode", actionCode)
        //    };

        //    return DbHelperSQL.RunProcedure<ActionVO>("UP_Action_Select", parameters).ToList();
        //}

        public int Delete(int actionID)
        {
            SqlParameter[] parameters = new SqlParameter[]{      
                new SqlParameter("@ActionID", actionID)
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Action_Delete", parameters, out rowsAffected);
        }

        public int Save(ActionVO action, string editUser)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MenuID", action.MenuID),
                new SqlParameter("@ActionName", action.ActionName),
                new SqlParameter("@ActionCode", action.ActionCode),
                new SqlParameter("@ActionType", action.ActionType),
                new SqlParameter("@ActionPath", action.ActionPath),
                new SqlParameter("@CreateUser", editUser),
                new SqlParameter("@ActionID", action.ActionID)
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Action_Save", parameters, out rowsAffected);
        }
    }
}

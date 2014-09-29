using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.View;
using System.Data.SqlClient;
using DBManager;
using SRDFAA;
using Model.Condition;

namespace DAL
{
    public class Menu
    {
        SRDSystemDB connString = DBManager.SRDSystemDB.GetSRDSystemDB(DBServerName.SRDK3, DataBaseName.DataControlCenterSystem);

        public List<MenuActionVO> GetMenuList(MenuQueryCondition queryCondition)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@SystemID", queryCondition.SystemID),
                new SqlParameter("@MenuName", queryCondition.MenuName)
            };

            return DbHelperSQL.RunProcedure<MenuActionVO>(connString, "UP_Menu_Select", parameters).ToList();
        }

        public List<MenuActionVO> GetMenuActionList(int systemID)
        {
            return GetMenuActionList(systemID, "");
        }

        public List<MenuActionVO> GetMenuActionList(int systemID, string menuName)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@SystemID", systemID),
                new SqlParameter("@MenuName", menuName)
            };

            return DbHelperSQL.RunProcedure<MenuActionVO>(connString, "UP_MenuAction_Select", parameters).ToList();
        }

        public int Save(MenuActionVO menu, string createUser)
        {
            SqlParameter[] parameters = new SqlParameter[] { 
                new SqlParameter("@SystemID", menu.SystemID),
                new SqlParameter("@ParentID", menu.ParentMenuID),
                new SqlParameter("@MenuName", menu.MenuActionName),
                new SqlParameter("@MenuDescription", menu.Description),
                new SqlParameter("@MenuPath", menu.Path),
                new SqlParameter("@IsVisible", menu.IsVisible),
                new SqlParameter("@VisibleIndex", menu.VisibleIndex),
                new SqlParameter("@UserName", createUser),
                new SqlParameter("@MenuID", menu.KeyID)
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Menu_Save", parameters, out rowsAffected);
        }

        public int Delete(int menuID)
        {
            SqlParameter[] parameters = new SqlParameter[] { 
                new SqlParameter("@MenuID", menuID)
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Menu_Delete", parameters, out rowsAffected);
        }

        //public List<ModuleVO> GetModuleList(int moduleID, string moduleName, int isValid)
        //{
        //    SqlParameter[] parameters = new SqlParameter[] { 
        //        new SqlParameter("@ModuleID", moduleID),
        //        new SqlParameter("@ModuleName", moduleName),
        //        new SqlParameter("@IsValid", isValid),
        //    };

        //    return DbHelperSQL.RunProcedure<ModuleVO>(connString, "UP_Module_Select", parameters).ToList();
        //}        

        
    }
}

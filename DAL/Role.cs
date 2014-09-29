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
    public class Role
    {
        SRDSystemDB connString = DBManager.SRDSystemDB.GetSRDSystemDB(DBServerName.SRDK3, DataBaseName.DataControlCenterSystem);

        /// <summary>
        /// 角色列表
        /// </summary>
        /// <param name="roleID"></param>
        /// <param name="roleName"></param>
        /// <param name="isValid"></param>
        /// <returns></returns>
        public List<RoleVO> GetRoleList(int roleID, string roleName, int isValid)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@RoleID", roleID),
                new SqlParameter("@RoleName", roleName),
                new SqlParameter("@IsValid", isValid)
            };

            return DbHelperSQL.RunProcedure<RoleVO>(connString, "UP_Role_Select", parameters).ToList();
        }

        /// <summary>
        /// 增加角色
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="roleDescription"></param>
        /// <param name="isValid"></param>
        /// <param name="createUser"></param>
        /// <returns></returns>
        public int RoleInsert(RoleVO role, string createUser)
        {
            SqlParameter[] parameters = new SqlParameter[]{                
                new SqlParameter("@RoleName", role.RoleName),
                new SqlParameter("@Description", role.RoleDescription),
                new SqlParameter("@IsValid", role.IsValid),
                new SqlParameter("@CreateUser", createUser)
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Role_Insert", parameters, out rowsAffected);
        }

        /// <summary>
        /// 角色更新
        /// </summary>
        /// <param name="role"></param>
        /// <param name="editUser"></param>
        /// <returns></returns>
        public int RoleUpdate(RoleVO role, string editUser)
        {
            SqlParameter[] parameters = new SqlParameter[]{                
                new SqlParameter("@RoleName", role.RoleName),
                new SqlParameter("@Description", role.RoleDescription),
                new SqlParameter("@IsValid", role.IsValid),
                new SqlParameter("@EditUser", editUser),
                new SqlParameter("@RoleID", role.RoleID),
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Role_Update", parameters, out rowsAffected);
        }

        /// <summary>
        /// 角色删除
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public int RoleDelete(int roleID)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@RoleID", roleID)
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Role_Delete", parameters, out rowsAffected);
        }

        /// <summary>
        /// 角色的菜单及功能列表
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public List<RoleMenuAction> GetRoleMenuActionList(int roleID)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@RoleID", roleID)
            };

            return DbHelperSQL.RunProcedure<RoleMenuAction>(connString, "UP_Role_MenuActionAuthority", parameters).ToList();
        }

        public int SaveRoleAuthority(string menuActionIDs, int roleID, string userName)
        {
            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@MenuActionIDs", menuActionIDs),
                new SqlParameter("@RoleID", roleID),
                new SqlParameter("@UserName", userName)
            };

            int rowsAffected = 0;

            return DbHelperSQL.RunProcedure(connString, "UP_Role_SaveRoleAuthority", parameters, out rowsAffected);
        }
    }
}

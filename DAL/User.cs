using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.View;
using SRDFAA;
using System.Data.SqlClient;
using DBManager;
using Model.Enum;

namespace DAL
{
    public class User
    {
        SRDSystemDB connString = DBManager.SRDSystemDB.GetSRDSystemDB(DBServerName.SRDK3, DataBaseName.DataControlCenterSystem);

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public List<UserVO> GetUsers()
        {
            string SQL = @"
                SELECT  t0.FUSERID AS 'UserID', t0.FNAME AS 'UserName', t0.FUSERACCOUNT AS 'Account'
                FROM AISSRD20140423140226..T_SEC_user t0
                WHERE (
                    (t0.FCREATEORG IN (1)
                    OR 
                    t0.FUSERID IN
                        (SELECT DISTINCT fuserid FROM AISSRD20140423140226..T_SEC_USERORG WHERE forgid IN (1))) AND (t0.FFORBIDSTATUS = 'A' AND t0.FUSERTYPE = '1'))
                ORDER BY fname";

            try
            {
                return DbHelperSQL.Query<UserVO>(SQL).ToList();                
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 根据用户身份查询
        /// </summary>
        /// <param name="userIdentity"></param>
        /// <returns></returns>
        public List<UserVO> GetUsers(string userName, Identity userIdentity)
        {
            string SQL = @"
                SELECT  t0.FUSERID AS 'UserID', t0.FNAME AS 'UserName', t0.FUSERACCOUNT AS 'Account'
                FROM AISSRD20140423140226..T_SEC_user t0
                WHERE (
                    (t0.FCREATEORG IN (1)
                    OR 
                    t0.FUSERID IN
                        (SELECT DISTINCT fuserid FROM AISSRD20140423140226..T_SEC_USERORG WHERE forgid IN (1))
                    ) AND (t0.FFORBIDSTATUS = 'A' AND t0.FUSERTYPE = '1')
                )
                AND t0.FNAME = @UserName AND 
                ORDER BY fname";
            SqlParameter[] parameter = new SqlParameter[] { 
                new SqlParameter("", global::System.Data.SqlDbType.NVarChar),
                new SqlParameter("@UserName", userName)
            };
            switch (userIdentity)
            { 
                case Identity.Businessman:
                    parameter[0].Value = "";
                    break;
                case Identity.Buyer:
                    parameter[0].Value = "";
                    break;
            }            

            try
            {
                return DbHelperSQL.Query<UserVO>(SQL, parameter).ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<UserRole> GetUserRoles()
        {
            string SQL = @"SELECT UserID, RoleID FROM dbo.T_BD_UserRole";
            try
            {
                return DbHelperSQL.Query<UserRole>(connString, SQL).ToList();
            }
            catch
            {
                throw;
            }
        }

        public void SaveRoleOfUsers(string userIDs, int roleID, string userName)
        {
            SqlParameter[] parameter = new SqlParameter[]{
                new SqlParameter("@UserIDs", userIDs),
                new SqlParameter("@RoleID", roleID),
                new SqlParameter("@UserName", userName)
            };
            int rowsAffected = 0;
            DbHelperSQL.RunProcedure(connString, "UP_UserRole_SaveRoleOfUsers", parameter, out rowsAffected);
        }
    }
}

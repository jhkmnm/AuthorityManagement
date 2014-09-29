using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Model.View;
using SRDFAA.Fram.Utilities;
using Model.Enum;

namespace AuthorityManagement
{
    public partial class FormUserSelected : Form
    {
        #region 属性
        /// <summary>
        /// 用户列表
        /// </summary>
        public List<UserVO> UserList
        {
            get
            {
                return bsUserList.DataSource as List<UserVO>;
            }
            set
            {
                if (value != null)
                {
                    bsUserList.DataSource = value;
                    grdUserList.RefreshDataSource();
                }
                else
                {
                    bsUserList.Clear();
                }
            }
        }

        public List<UserVO> SelectedUsers
        {
            get
            {
                return UserList.Where(where => where.IsSelected).ToList();
            }
        }
        #endregion

        #region 变量
        private string _selectedUserIDs;

        private bool _multipleChoice;

        private Identity _userIdentity;
        #endregion

        public FormUserSelected(string selectedUserIDs, bool multipleChoice, Identity userIdentity)
        {
            _selectedUserIDs = selectedUserIDs;
            _multipleChoice = multipleChoice;
            InitializeComponent();

            GridHelper.SetStyle(this.grdUserList, GridHelper.GridStyle.List);
            GridHelper.SetColumnEditable(colIsSelected);
        }

        #region 自定义方法
        private void Query()
        {
            DAL.User userDal = new DAL.User();
            string username = "";           

            var v = userDal.GetUsers(username, _userIdentity);

            if (_selectedUserIDs.Length > 0)
            {
                string[] userids = _selectedUserIDs.Split(',');
                v.Where(where => userids.Contains(where.UserID.ToString())).ToList().ForEach(f => f.IsSelected = true);
            }

            UserList = v;
            
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CommonUtil.ExecAction(Query, "正在查询用户数据", "查询出错");
        }

        private void grdUserList_DoubleClick(object sender, EventArgs e)
        {
            DataVerifier dv = new DataVerifier();
            dv.Check(!_multipleChoice && SelectedUsers.Count > 1, "只能单选, 请重新选择");
            if (dv.Pass)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }

            dv.CustomShowMsgIfFailed(MsgTool.ShowMsg);
        }

    }
}

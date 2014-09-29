using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRDFAA.Fram.Utilities;
using Model.View;
using Model.Enum;

namespace AuthorityManagement
{
    public partial class FormActionManage : Form
    {
        DAL.Menu menudal = new DAL.Menu();
        DAL.Action actiondal = new DAL.Action();
        EditType _edittype;

        public FormActionManage()
        {
            InitializeComponent();
            this.Load += FormActionManage_Load;
        }        

        #region 属性
        private IList<MenuActionVO> MenuActionList
        {
            get { return bsMenuActionList.DataSource as IList<MenuActionVO>; }
            set
            {
                if (value == null)
                {
                    bsMenuActionList.Clear();
                }
                else
                {
                    bsMenuActionList.DataSource = value;
                    treeMenuList.RefreshDataSource();
                }
            }
        }

        private MenuActionVO SelectedMenuAction
        {
            get { return bsMenuActionList.Current as MenuActionVO; }
        }

        public ActionVO ActionEdit
        {
            get
            {
                return bsActionEdit.Current as ActionVO;
            }
            set
            {
                if (value == null)
                {
                    bsActionEdit.Clear();
                }
                else
                {
                    bsActionEdit.DataSource = value;
                }
            }
        } 
        #endregion

        #region 自定义方法
        private void Query_MenuAction()
        {
            int systemid = ddlSystem.SelectedValue.ToString().ToInt32();
            string menuname = txtMenuName.Text;
            CommonUtil.ExecAction(() => { MenuActionList = menudal.GetMenuActionList(systemid, menuname); }, "正在查询功能列表", "查询出错");
            if (ddlParent.Items.Count == 0)
            {
                InitMenu();
            }
        }

        private void InitSystem()
        {
            var systemlist = new DAL.System().GetList();
            ddlSystem.DataSource = systemlist;
            ddlSystem.DisplayMember = "SystemName";
            ddlSystem.ValueMember = "SystemID";
        }

        void InitMenu()
        {
            var modulelist = MenuActionList.Where(menu => menu.Type == 0 && menu.ParentID != 0).ToList();
            MenuActionVO first = new MenuActionVO();
            first.MenuActionName = "全部";
            first.KeyID = 0;
            modulelist.Insert(0, first);
            ddlParent.DataSource = modulelist.ToList();
            ddlParent.DisplayMember = "MenuActiveName";
            ddlParent.ValueMember = "KeyID";
            ddlParent.SelectedIndex = 0;
        }

        private void ClearControlValue()
        {
            foreach (var grpitem in grpEdit.Controls)
            {
                if (grpitem is DevExpress.XtraEditors.TextEdit)
                {
                    ((DevExpress.XtraEditors.TextEdit)grpitem).Text = string.Empty;
                }
            }
        }

        private void LoadMenuInfo()
        {
            txtName.Text = SelectedMenuAction.MenuActionName;
            ddlParent.SelectedValue = SelectedMenuAction.ParentMenuID;
            txtActionCode.Text = SelectedMenuAction.ActionCode;
            txtPath.Text = SelectedMenuAction.Path;
        }

        private void SaveAction()
        { 
            
        }
        #endregion

        #region 事件
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormActionManage_Load(object sender, EventArgs e)
        {
            InitSystem();
            ActionEdit = new ActionVO() { ActionName = "" };

            this.treeMenuList.FocusedNodeChanged += treeMenuList_FocusedNodeChanged;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Query_MenuAction();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _edittype = EditType.ADD;
            ClearControlValue();
        }

        private void treeMenuList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            LoadMenuInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

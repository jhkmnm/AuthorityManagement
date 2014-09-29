using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.View;
using SRDFAA.Fram.Utilities;

namespace AuthorityManagement
{
    public partial class FormSystemManage : Form
    {
        DAL.System systemDal = new DAL.System();

        string _savetype = "Edit";

        private SystemVO SelectedSystem
        {
            get
            {
                return bsSystemList.Current as SystemVO;
            }
        }

        public IList<SystemVO> SystemList
        {
            get
            {
                return bsSystemList.DataSource as IList<SystemVO>;
            }
            set
            {
                if (value == null)
                {
                    bsSystemList.Clear();
                }
                else
                {
                    bsSystemList.DataSource = value;
                    grdSystem.RefreshDataSource();
                }
            }
        }

        public FormSystemManage()
        {
            InitializeComponent();
            BandData();
        }        

        #region 自定义方法
        /// <summary>
        /// 清除控件中的值
        /// </summary>
        private void ClearControlValue()
        {
            txtSystemName.Text = txtDescription.Text = string.Empty;
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        private void BandData()
        {
            CommonUtil.ExecAction(() => { SystemList = systemDal.GetList(); });
        }

        /// <summary>
        /// 显示选择的信息
        /// </summary>
        private void LoadData()
        {
            txtSystemName.Text = SelectedSystem.SystemName;
            txtDescription.Text = SelectedSystem.SystemDescription;
        }

        /// <summary>
        /// 保存修改的数据
        /// </summary>
        private void Save()
        {
            SystemVO systemitem = new SystemVO();
            systemitem.SystemName = txtSystemName.Text;
            systemitem.SystemDescription = txtDescription.Text;

            if (_savetype == "Edit")
            {
                systemitem.SystemID = SelectedSystem.SystemID;
            }

            int result = systemDal.Save(systemitem, SRDFAA.Fram.SystemInfo.CurrentUser);
            DataVerifier dv = new DataVerifier();
            dv.Check(result == -1, "已经存在相同的系统分类名称,请确认");

            if (dv.Pass)
            {
                MsgTool.Show("保存成功");
                _savetype = "Edit";
                BandData();
            }
        }

        private void Delete()
        {
            systemDal.Delete(SelectedSystem.SystemID);
        }
        #endregion

        #region 窗体事件
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearControlValue();
            _savetype = "Add";
        }

        private void grvSystem_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CommonUtil.ExecAction(Save, "正在保存数据", "保存数据出错");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CommonUtil.ExecAction(Delete, "正在删除数据", "删除数据出错");
        }
        #endregion

        
    }
}

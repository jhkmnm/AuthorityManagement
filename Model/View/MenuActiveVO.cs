using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.View
{
    public class MenuActionVO : ViewObjectBase
    {
        /// <summary>
        /// 绑定树控件的ID
        /// </summary>
        public int ID
        { get; set; }

        /// <summary>
        /// 标识树中的上下级关系
        /// </summary>
        public int ParentID
        { get; set; }

        /// <summary>
        /// 所属系统ID
        /// </summary>
        public int SystemID
        { get; set; }

        /// <summary>
        /// 表中的主键
        /// </summary>
        public int KeyID
        { get; set; }        

        /// <summary>
        /// 菜单或功能名称
        /// </summary>
        public string MenuActionName
        { get; set; }

        /// <summary>
        /// 所属上级ID
        /// </summary>
        public int ParentMenuID
        { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        { get; set; }
        
        /// <summary>
        /// 访问路径
        /// </summary>
        public string Path
        { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsVisible
        { get; set; }

        public int ItemCount
        { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int VisibleIndex
        { get; set; }

        /// <summary>
        /// 标识当前的类型，0菜单，1按钮，2列
        /// </summary>
        public int Type
        { get; set; }

        public string ActionCode
        { get; set; }

        public int ActionType
        { get; set; }
    }
}

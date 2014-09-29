using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.View
{
    public class ActionVO : ViewObjectBase
    {
        /// <summary>
        /// 功能ID
        /// </summary>
        public int ActionID
        { get; set; }

        /// <summary>
        /// 所属菜单ID
        /// </summary>
        public int MenuID
        { get; set; }

        public string ActionName
        { get; set; }

        /// <summary>
        /// 功能编码
        /// </summary>
        public string ActionCode
        { get; set; }

        /// <summary>
        /// 功能类型
        /// </summary>
        public int ActionType
        { get; set; }

        /// <summary>
        /// 功能路径
        /// </summary>
        public string ActionPath
        { get; set; }
    }
}

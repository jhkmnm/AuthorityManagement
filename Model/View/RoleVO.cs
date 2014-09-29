using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.View
{
    public class RoleVO : ViewObjectBase
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID
        { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName
        { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        public string RoleDescription
        { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsValid
        { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.View
{
    public class UserVO: ViewObjectBase
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        public string Account
        { get; set; }
    }
}

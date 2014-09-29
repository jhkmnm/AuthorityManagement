using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Enum
{
    public enum Operator
    {
        /// <summary>
        /// 等于
        /// </summary>
        Equal,
        /// <summary>
        /// 不等于
        /// </summary>
        NotEqual,
        /// <summary>
        /// 包含
        /// </summary>
        Include,
        /// <summary>
        /// 不包含
        /// </summary>
        NotInclude,
        /// <summary>
        /// 等于运算符左边的值
        /// </summary>
        EqualSelf
    }
}

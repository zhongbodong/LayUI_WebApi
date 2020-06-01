using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum AjaxLognEnum
    {
        /// <summary>
        /// 登录成功
        /// </summary>
        Success = 0,

        /// <summary>
        /// 用户不存在
        /// </summary>
        NoUser = 1,

        /// <summary>
        /// 密码错误
        /// </summary>
        WrongPassord = 2,

        /// <summary>
        ///  验证码失效
        /// </summary>
        VerifyCodeInvalid = 3,
        /// <summary>
        ///  验证码错误
        /// </summary>
        WrongVerifyCode = 4,

        /// <summary>
        /// 登录失败
        /// </summary>
        Wrong = 5,

        /// <summary>
        /// 用户被冻结
        /// </summary>
        Frozen = 6

    }
}

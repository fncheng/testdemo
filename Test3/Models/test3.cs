using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test3.Models
{
    //以业务为主的用户模式
    public class UserModel
    {
        public int UserID { get; set; }             //用户编号
        public string UserName { get; set; }        //用户名
        public string Password { get; set; }        //用户密码
        public int Sex { get; set; }                //性别，0男，1女
        public int Age { get; set; }                //年龄
    }

    //以页面为主的用户登陆模型
    public class LoginModel
    {
        public string UserName { get; set; }        //用户名
        public string Password { get; set; }        //密码
    }

    //以页面为主的用户注册模式
    public class RegeditModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
    }

}
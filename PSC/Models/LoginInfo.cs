using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSC.Models
{
    public class LoginInfo
    {
        const string LOGIN_INFO_FIELD = "logininfo";
        HttpSessionStateBase context;
        public LoginInfo(HttpContextBase context)
        {
            this.context = context.Session;
        }
        public LoginInfo(HttpSessionStateBase context)
        {
            this.context = context;
        }
        public int RoleId
        {
            get { return GetLoginInfoModel().RoleId; }
            set { GetLoginInfoModel().RoleId = value; }
        }
        private LoginInfoModel GetLoginInfoModel()
        {
            if (context[LOGIN_INFO_FIELD] == null)
                context[LOGIN_INFO_FIELD] = new LoginInfoModel();
            return (LoginInfoModel)context[LOGIN_INFO_FIELD];
        }
    }
    public class LoginInfoModel
    {
        public int RoleId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Web410716097.ViewModels;

namespace Web410716097.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(new SignUpData());
        }

        [HttpPost]
        public ActionResult SignUp(SignUpData data)
        { 
            if (data.Name.IsNullOrWhiteSpace()) 
            { 
                data.NameMessage = "請輸入名稱"; 
            }
            if (data.Account.IsNullOrWhiteSpace())
            {
                data.AccountMessage = "請輸入帳號";
            }
            if (data.Password.IsNullOrWhiteSpace())
            {
                data.PasswordMessage = "請輸入密碼";
            }
            if(!data.Name.IsNullOrWhiteSpace()&&
                !data.Account.IsNullOrWhiteSpace()&&
                !data.Password.IsNullOrWhiteSpace())
            { 
                data.Message = "註冊成功";
            }
            return View(data);
        }
    }
}
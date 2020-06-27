using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly RestaurentDBContext _context;

        public LoginController(RestaurentDBContext context)
        {
            _context = context;
        }
       
        [HttpPost]
        [Route("[action]")]
        public Response Login(Login Lg)
        {
            
            UsersDetail Obj = _context.UsersDetail.FromSql("EXEC Usp_Login @UserName={0}, @Password={1}",Lg.UserName,Lg.Password).FirstOrDefault();
            if (Obj.Status == 0)
                return new Response { Status = "Invalid", Message = "Invalid User." };
            if (Obj.Status == -1)
                return new Response { Status = "Inactive", Message = "User Inactive." };
            else
                return new Response { Status = "Success", Message = Lg.UserName };
        }
        [HttpPost]
        [Route("[action]")]
        public object createcontact(Registration Lvm)
        {
            try
            {
                
                UsersDetail Ud = new UsersDetail();
                if (Ud.UserId == 0)
                {
                    Ud.UserName = Lvm.UserName;
                    Ud.LoginName = Lvm.LoginName;
                    Ud.Password = Lvm.Password;
                    Ud.Email = Lvm.Email;
                    Ud.ContactNo = Lvm.ContactNo;
                    Ud.Address = Lvm.Address;
                    Ud.IsApporved = Lvm.IsApporved;
                    Ud.Status = Lvm.Status;
                    _context.UsersDetail.Add(Ud);
                    _context.SaveChanges();
                    return new Response
                    { Status = "Success", Message = "SuccessFully Saved." };
                }
            }
            catch (Exception)
            {

                throw;
            }
            return new Response
            { Status = "Error", Message = "Invalid Data." };
        }
    }
}
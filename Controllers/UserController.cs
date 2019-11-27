using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            
            return View(UsersData.GetAll);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            // ViewBag.user = user;
            //var message = validate( addUserViewModel;
            //ViewBag.message = message;
            if (ModelState.IsValid)
            {
                User myNewUser = new User();
                myNewUser.Username = addUserViewModel.Username;
                myNewUser.Email = addUserViewModel.Email;
                myNewUser.Password = addUserViewModel.Password;
                UsersData.Add(myNewUser);
                return Redirect("Index");

            }

            return View(addUserViewModel);

        }

        private static string validate (AddUserViewModel addUserViewModel, string verify)
        {
           
            string answer = "";
            if (addUserViewModel.Password != null || verify != null)
            {
                if (addUserViewModel.Password == verify)
                {
                    answer = ("Welcome {0}"+ addUserViewModel.Username);
                }
                else 
                {
                    answer = ("The password cannot be verified");
                };
            }
            else
            {
                answer = "Password and verification need to be valid";
            }
            return answer;
        }
    }
}
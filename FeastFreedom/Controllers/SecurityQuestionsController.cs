using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeastFreedom.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FeastFreedom.Controllers
{
    public class SecurityQuestionsController : Controller
    {
        private ISecurityQuestionsRepository _securityQuestionsRepository;

        public SecurityQuestionsController(ISecurityQuestionsRepository securityQuestionsRepository)
        {
            _securityQuestionsRepository = securityQuestionsRepository;
        }

        [HttpGet]
        public ViewResult getQuestion(int id)
        {
            SecurityQuestions securityQuestion = _securityQuestionsRepository.GetSecurityQuesiton(id);
            return View(securityQuestion);
        }
    }
}

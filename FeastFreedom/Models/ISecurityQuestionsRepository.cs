using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public interface ISecurityQuestionsRepository
    {
        SecurityQuestions GetSecurityQuesiton(int id);
        IEnumerable<SecurityQuestions> GetAllSecurityQuestions();
        SecurityQuestions Add(SecurityQuestions securityQuestion);
        SecurityQuestions Delete(int id);
        SecurityQuestions Update(SecurityQuestions securityQuesitonChanges);
    }
}

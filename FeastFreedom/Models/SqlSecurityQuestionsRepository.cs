using System;
using System.Collections.Generic;

namespace FeastFreedom.Models
{
    public class SqlSecurityQuestionsRepository : ISecurityQuestionsRepository
    {
        private readonly AppDbContext context;
        public SqlSecurityQuestionsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public SecurityQuestions Add(SecurityQuestions securityQuestion)
        {
            context.SecurityQuestions.Add(securityQuestion);
            context.SaveChanges();
            return securityQuestion;
        }

        public SecurityQuestions Delete(int id)
        {
            SecurityQuestions securityQuestions = context.SecurityQuestions.Find(id);
            if (securityQuestions != null)
            {
                context.SecurityQuestions.Remove(securityQuestions);
                context.SaveChanges();
            }
            return securityQuestions;
        }

        public IEnumerable<SecurityQuestions> GetAllSecurityQuestions()
        {
            return context.SecurityQuestions;
        }

        public SecurityQuestions GetSecurityQuesiton(int id)
        {
            return context.SecurityQuestions.Find(id);
        }

        public SecurityQuestions Update(SecurityQuestions securityQuesitonChanges)
        {
            var securityQuestion = context.SecurityQuestions.Attach(securityQuesitonChanges);
            securityQuestion.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return securityQuesitonChanges;
        }
    }
}
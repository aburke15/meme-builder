using System;
using MemeBuilder.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Storage;

namespace MemeBuilder.Implementations
{
    public class UnitOfWorkAttribute : Attribute, IActionFilter
    {
        private readonly MemeBuilderContext MemeBuilderContext = new MemeBuilderContext();

        public void OnActionExecuted(ActionExecutedContext context) 
            => MemeBuilderContext.Database.BeginTransaction();

        public void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                MemeBuilderContext.SaveChangesAsync();
                
                MemeBuilderContext.Database
                    .CommitTransaction();
            }
            catch (Exception e)
            {
                MemeBuilderContext.Database
                    .RollbackTransaction();
                
                throw e;
            }

            MemeBuilderContext.Dispose();
        }
    }
}
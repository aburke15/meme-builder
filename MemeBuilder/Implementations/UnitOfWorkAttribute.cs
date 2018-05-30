using System;
using MemeBuilder.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Storage;

namespace MemeBuilder.Implementations
{
    public class UnitOfWorkAttribute : ActionFilterAttribute
    {
        private readonly MemeBuilderContext MemeBuilderContext;

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // begin transaction
            MemeBuilderContext.Database.BeginTransaction();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // save
                // commit transaction
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

            // dispose? EF diposes automatically?
            MemeBuilderContext.Dispose();
        }
    }
}
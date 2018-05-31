using MemeBuilder.Implementations;
using MemeBuilder.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemeBuilder.Infrastructure
{
    public abstract class BaseController : Controller
    {
        protected readonly MemeBuilderContext MemeBuilderContext;

        public BaseController(MemeBuilderContext memeBuilderContext) 
            => MemeBuilderContext = memeBuilderContext;
    }
}

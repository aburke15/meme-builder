using MemeBuilder.Interfaces;
using MemeBuilder.Models;

namespace MemeBuilder.Implementations
{
    public class TemplateRepository : Repository<Template>, ITemplateRepository
    {
        public TemplateRepository(MemeBuilderContext memeBuilderContext) 
            : base(memeBuilderContext)
        {
        }
    }
}
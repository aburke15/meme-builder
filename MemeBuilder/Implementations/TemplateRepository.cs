using MemeBuilder.Interfaces;
using MemeBuilder.Models;

namespace MemeBuilder.Implementations
{
    public class TemplateRepository : Repository<Template>, ITemplateRepository
    {
        private new readonly MemeBuilderContext MemeBuilderContext;

        public TemplateRepository(MemeBuilderContext memeBuilderContext)
            : base(memeBuilderContext) => MemeBuilderContext = memeBuilderContext;
    }
}
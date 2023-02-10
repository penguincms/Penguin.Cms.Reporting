using Penguin.Cms.Entities;
using Penguin.Persistence.Abstractions.Attributes.Control;

namespace Penguin.Cms.Reporting
{
    public class ParameterInfo : AuditableEntity
    {
        public ParameterConstraint Default { get; set; }

        public ParameterConstraint MaxValue { get; set; }

        public ParameterConstraint MinValue { get; set; }

        [DontAllow(DisplayContexts.Edit)]
        public string ParameterName { get; set; } = string.Empty;

        [DontAllow(DisplayContexts.Edit)]
        public string ProcedureName { get; set; } = string.Empty;

        public ParameterInfo()
        {
            MinValue = new ParameterConstraint();
            MaxValue = new ParameterConstraint();
            Default = new ParameterConstraint();
        }
    }
}
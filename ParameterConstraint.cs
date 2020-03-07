using Penguin.Persistence.Abstractions.Attributes.Relations;

namespace Penguin.Cms.Reporting
{
    [ComplexType]
    public class ParameterConstraint
    {
        public bool Enabled { get; set; }

        public ConstraintType Type { get; set; }

        public string Value { get; set; } = string.Empty;

        public enum ConstraintType
        {
            Static,
            SQL,
            Lambda
        }
    }
}
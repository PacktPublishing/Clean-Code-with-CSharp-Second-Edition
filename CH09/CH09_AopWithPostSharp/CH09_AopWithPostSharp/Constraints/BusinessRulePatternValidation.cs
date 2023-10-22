using PostSharp.Constraints;
using PostSharp.Extensibility;

namespace CH09_AopWithPostSharp.Constraints;

[MulticastAttributeUsage(MulticastTargets.Class, Inheritance = MulticastInheritance.Strict)]
public class BusinessRulePatternValidation : ScalarConstraint
{
    public override void ValidateCode(object target)
    {
        var targetType = (Type)target;
        if (targetType.GetNestedType("Factory") == null)
        {
            Message.Write(
                targetType, SeverityType.Warning,
                "10",
                "You must include a 'Factory' as a nested type for {0}.",
                targetType.DeclaringType,
                targetType.Name);
        }
    }
}

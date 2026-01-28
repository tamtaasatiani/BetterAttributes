namespace BetterAttributes.Runtime
{
    public sealed class SerializeConditionalAttribute : BetterAttributeBase
    {
        public readonly bool Condition;
        
        public SerializeConditionalAttribute(bool condition)
        {
            this.Condition = condition;
        }
    }
}

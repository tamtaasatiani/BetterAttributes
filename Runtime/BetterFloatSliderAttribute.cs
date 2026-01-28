namespace BetterAttributes.Runtime
{
    public sealed class BetterFloatSliderAttribute : BetterAttributeBase
    {
        public readonly float Min;
        public readonly float Max;

        public BetterFloatSliderAttribute()
        {
            this.Min = 0;
            this.Max = 1;
        }

        public BetterFloatSliderAttribute(float min, float max)
        {
            this.Min = min;
            this.Max = max;
        }
    }
}

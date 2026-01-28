namespace BetterAttributes.Runtime
{
    public sealed class BetterSliderAttribute : BetterAttributeBase
    {
        public readonly int Min;
        public readonly int Max;

        public BetterSliderAttribute()
        {
            this.Min = 0;
            this.Max = 100;
        }

        public BetterSliderAttribute(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }
    }
}

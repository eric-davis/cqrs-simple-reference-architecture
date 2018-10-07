namespace CQRS.Simple.Core.ValueObjects
{
    using ArgSentry;

    public sealed class OccupantCount
    {
        public OccupantCount(int value)
        {
            Prevent.ValueLessThan(value, 1, nameof(value));
            this.Value = value;
        }

        public int Value { get; }
    }
}

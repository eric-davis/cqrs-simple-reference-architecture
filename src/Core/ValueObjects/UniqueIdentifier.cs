namespace CQRS.Simple.Core.ValueObjects
{
    /// <summary>
    /// The unique identifier base class.
    /// </summary>
    /// <typeparam name="T">
    /// The value type.
    /// </typeparam>
    public abstract class UniqueIdentifier<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdentifier{T}"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        protected UniqueIdentifier(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        public virtual T Value { get; }
    }
}

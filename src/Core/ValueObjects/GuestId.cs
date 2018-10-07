namespace CQRS.Simple.Core.ValueObjects
{
    using System;

    using ArgSentry;

    /// <inheritdoc />
    /// <summary>
    /// The GuestId value object.
    /// </summary>
    public sealed class GuestId : UniqueIdentifier<Guid>
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="GuestId" /> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <exception cref="ArgumentException">
        /// if value is empty.
        /// </exception>
        public GuestId(Guid value)
            : base(value)
        {
            Prevent.EmptyGuid(value, nameof(value));
        }
    }
}

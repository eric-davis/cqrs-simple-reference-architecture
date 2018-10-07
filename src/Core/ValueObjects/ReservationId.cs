namespace CQRS.Simple.Core.ValueObjects
{
    using System;

    using ArgSentry;

    /// <inheritdoc />
    /// <summary>
    /// The ReservationId object type.
    /// </summary>
    public sealed class ReservationId : UniqueIdentifier<Guid>
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationId" /> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <exception cref="ArgumentException">
        /// if value is empty.
        /// </exception>
        public ReservationId(Guid value)
            : base(value)
        {
            Prevent.EmptyGuid(value, nameof(value));
        }
    }
}

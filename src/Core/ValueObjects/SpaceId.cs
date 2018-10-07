namespace CQRS.Simple.Core.ValueObjects
{
    using System;

    using ArgSentry;

    /// <inheritdoc />
    /// <summary>
    /// The SpaceId value object.
    /// </summary>
    public sealed class SpaceId : UniqueIdentifier<Guid>
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceId" /> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <exception cref="ArgumentException">
        /// if value is empty.
        /// </exception>
        public SpaceId(Guid value)
            : base(value)
        {
            Prevent.EmptyGuid(value, nameof(value));
        }
    }
}

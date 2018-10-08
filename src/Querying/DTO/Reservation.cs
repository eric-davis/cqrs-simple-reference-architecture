namespace CQRS.Simple.Querying.DTO
{
    using System;

    /// <summary>
    /// The reservation DTO.
    /// </summary>
    public sealed class Reservation
    {
        /// <summary>
        /// Gets or sets the space id.
        /// </summary>
        public Guid SpaceId { get; set; }

        /// <summary>
        /// Gets or sets the start UTC date.
        /// </summary>
        public DateTime StartDateUtc{ get; set; }

        /// <summary>
        /// Gets or sets the end UTC date.
        /// </summary>
        public DateTime EndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the guest id.
        /// </summary>
        public Guid GuestId { get; set; }

        /// <summary>
        /// Gets or sets the occupant count.
        /// </summary>
        public int OccupantCount { get; set; }
    }
}

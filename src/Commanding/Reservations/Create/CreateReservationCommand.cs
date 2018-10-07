namespace CQRS.Simple.Commanding.Reservations.Create
{
    using ArgSentry;

    using CQRS.Simple.Core.ValueObjects;

    /// <summary>
    /// The create reservation command.
    /// </summary>
    public sealed class CreateReservationCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReservationCommand"/> class.
        /// </summary>
        /// <param name="spaceId">
        /// The space id.
        /// </param>
        /// <param name="dateRange">
        /// The date range.
        /// </param>
        /// <param name="guestId">
        /// The guest id.
        /// </param>
        /// <param name="occupantCount">
        /// The occupant count.
        /// </param>
        private CreateReservationCommand(
            SpaceId spaceId,
            DateRange dateRange,
            GuestId guestId,
            OccupantCount occupantCount)
        {
            Prevent.NullObject(spaceId, nameof(spaceId));
            Prevent.NullObject(dateRange, nameof(dateRange));
            Prevent.NullObject(guestId, nameof(guestId));
            Prevent.NullObject(occupantCount, nameof(occupantCount));

            this.SpaceId = spaceId;
            this.DateRange = dateRange;
            this.GuestId = guestId;
            this.OccupantCount = occupantCount;
        }

        /// <summary>
        /// Gets the space id.
        /// </summary>
        public SpaceId SpaceId { get; }

        /// <summary>
        /// Gets the UTC date range.
        /// </summary>
        public DateRange DateRange { get; }

        /// <summary>
        /// Gets the guest id.
        /// </summary>
        public GuestId GuestId { get; }

        /// <summary>
        /// Gets the occupant count.
        /// </summary>
        public OccupantCount OccupantCount { get; }
    }
}

namespace CQRS.Simple.Core.ValueObjects
{
    using System;

    using ArgSentry;

    /// <summary>
    /// The date range value object.
    /// </summary>
    public sealed class DateRange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRange"/> class.
        /// </summary>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        public DateRange(DateTime startDate, DateTime endDate)
        {
            Prevent.ValueLessThanOrEqualTo(endDate.Date, startDate.Date, nameof(endDate));

            this.StartDate = startDate.Date;
            this.EndDate = endDate.Date;
        }

        /// <summary>
        /// Gets the start date.
        /// </summary>
        public DateTime StartDate { get; }

        /// <summary>
        /// Gets the end date.
        /// </summary>
        public DateTime EndDate { get; }

        /// <summary>
        /// The duration.
        /// </summary>
        public TimeSpan Duration => this.EndDate - this.StartDate;

        /// <summary>
        /// Determines whether this specified date value is within this range.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// True if the specified value is within this range; otherwise, false.
        /// </returns>
        public bool Contains(DateTime value)
        {
            return this.StartDate <= value.Date && value.Date <= this.EndDate;
        }
    }
}

namespace CQRS.Simple.Querying.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CQRS.Simple.Querying.DTO;

    /// <summary>
    /// The reservation DTO provider.
    /// </summary>
    public sealed class ReservationProvider
    {
        /// <summary>
        /// Gets a reservation by id.
        /// </summary>
        /// <param name="reservationId">
        /// The reservation id.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<Reservation> GetByIdAsync(Guid reservationId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds reservations based on an optional filter.
        /// </summary>
        /// <param name="tbdFilter">
        /// The filter definition - TBD
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<IEnumerable<Reservation>> FindAsync(string tbdFilter)
        {
            throw new NotImplementedException();
        }
    }
}

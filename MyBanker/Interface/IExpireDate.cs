using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    /// <summary>
    /// Adds ExpireDate to Card
    /// </summary>
    public interface IExpireDate
    {
        /// <summary>
        /// The ExpireDate
        /// </summary>
        public DateTime ExpireDate { get; }

        /// <summary>
        /// Checks if the date is expired.
        /// </summary>
        public bool IfDateIsExpired();
    }
}

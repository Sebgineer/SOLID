using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Mastercard : CreditCard
    {
        /// <summary>
        /// Expire date
        /// </summary>
        private DateTime expireDate;

        /// <summary>
        /// Get Date of the Expire Date
        /// </summary>
        public DateTime ExpireDate { get { return this.expireDate; } }

        public Mastercard()
        {
            DateTime date = DateTime.Now;
            this.expireDate = date.AddYears(5);
            this.Prefix = new List<string>() { "51", "52", "53", "54", "55" };
            CreateCardNumber();
        }

        /// <summary>
        /// Checks if the date is expired.
        /// </summary>
        public bool IfDateIsExpired()
        {
            if (this.expireDate < DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}

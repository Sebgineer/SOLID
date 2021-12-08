using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class VisaElectron : DebitCard, IExpireDate
    {
        /// <summary>
        /// Expire date
        /// </summary>
        private DateTime expireDate;

        /// <summary>
        /// Get Date of the Expire Date
        /// </summary>
        public DateTime ExpireDate { get { return this.expireDate; } }


        public VisaElectron()
        {
            DateTime date = DateTime.Now;
            this.expireDate = date.AddYears(5);
            this.Prefix = new List<string>() { "4026", "417500", "4508", "4844", "4913", "4917" };
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

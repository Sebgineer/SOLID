using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Maestro : DebitCard
    {
        /// <summary>
        /// Expire date
        /// </summary>
        private DateTime expireDate;

        /// <summary>
        /// Get Date of the Expire Date
        /// </summary>
        public DateTime ExpireDate { get { return this.expireDate; } }

        public Maestro()
        {
            DateTime date = DateTime.Now;
            this.expireDate = date.AddYears(5);
            this.Prefix = new List<string>() { "5018", "5020", "5038", "58932", "6304", "6759", "6761", "6762", "6763" };
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

        /// <summary>
        /// Create Card number with Prefix
        /// </summary>
        protected override void CreateCardNumber()
        {
            string result = "";
            Random rnd = new Random();
            result = this.Prefix[rnd.Next(0, this.Prefix.Count)];

            for (int i = 0; i < 19 - result.Length; i++)
            {
                result += rnd.Next(0, 10);
            }
            this.cardNumber = result;
        }
    }
}

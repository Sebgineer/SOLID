using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    /// <summary>
    /// Super class for all the cards
    /// </summary>
    abstract class Card
    {
        /// <summary>
        /// List of Prefixs that the card have.
        /// </summary>
        protected List<string> Prefix;
        /// <summary>
        /// The Card Number.
        /// </summary>
        protected string cardNumber;
        /// <summary>
        /// The Holders Name.
        /// </summary>
        protected string holderName;

        /// <summary>
        /// Gets CardNumber.
        /// </summary>
        public string CardNumber { get { return this.cardNumber; } }
        /// <summary>
        /// Get the holders name.
        /// </summary>
        public string HolderName { get { return this.holderName; } }

        /// <summary>
        /// 
        /// </summary>
        protected Card()
        {

        }

        /// <summary>
        /// Create Card number with Prefix
        /// </summary>
        protected virtual void CreateCardNumber()
        {
            string result = "";
            Random rnd = new Random();
            result = this.Prefix[rnd.Next(0, this.Prefix.Count)];

            for (int i = 0; i < 16 - result.Length; i++)
            {
                result += rnd.Next(0, 10);
            }
            this.cardNumber = result;
        }
    }
}

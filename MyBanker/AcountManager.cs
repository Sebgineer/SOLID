using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class AcountManager
    {
        private Account account;
        private List<Card> cards;

        public Account Account { get { return this.account; } }
        public List<Card> Cards { get { return this.cards; } }

        /// <summary>
        /// Create Account Manager
        /// </summary>
        public AcountManager()
        {
            this.account = new Account();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        public AcountManager(Account account)
        {
            this.account = account;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {
            this.cards.Add(card);
        }

    }
}

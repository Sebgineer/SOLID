using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Account
    {
        private string accountNumber;
        private string regNumber;
        private double balence;

        /// <summary>
        /// Get The Balence
        /// </summary>
        public double Balence { get { return this.balence; } }

        /// <summary>
        /// Contructor for Account
        /// </summary>
        public Account()
        {
            this.balence = 0;
            GenerateAccount();
        }

        /// <summary>
        /// Generated Account Infomation.
        /// </summary>
        private void GenerateAccount()
        {
            string result = "3520";
            Random rnd = new Random();

            this.regNumber = result;
            for (int i = 0; i < 10; i++)
            {
                result += rnd.Next(0, 10);
            }

            this.accountNumber = result;
        }

        /// <summary>
        /// Add money to balence.
        /// </summary>
        /// <param name="addionBalence">The amount of money added to balence</param>
        public void AddBalence(double addionBalence)
        {
            this.balence += addionBalence;
        }

        /// <summary>
        /// Remove money from balence.
        /// </summary>
        /// <param name="removelBalence">The money you want to remove</param>
        public void RemoveBalence(double removelBalence)
        {
            this.balence -= removelBalence;
        }
    }
}

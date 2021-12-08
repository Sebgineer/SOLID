using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class DebitCard : Card
    {

        public DebitCard()
        {
            this.Prefix = new List<string>() { "2400" };
            CreateCardNumber();
        }
    }
}

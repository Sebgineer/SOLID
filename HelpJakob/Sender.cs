using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakob
{
    class Sender
    {
        Converter converter = new Converter();

        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = converter.BodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = converter.BodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = converter.BodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = converter.BodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}

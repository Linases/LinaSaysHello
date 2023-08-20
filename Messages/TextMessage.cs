using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Messages
{
    public class TextMessage : Message, IDelete
    {
        
        private string _recipient;
        public override string Recipient { get; set; }
        public string TextBody { get; set; }
       
        public TextMessage( string recipient, string textbody) 
        {
            Recipient = recipient;
            TextBody = textbody;
            
        }
        public override void Send()
        {
            Console.WriteLine("Text message is sent.");
        }
        public void Print()
        {
            Console.WriteLine($"Hello, {Recipient}, {TextBody}");

        }

        public void Delete ()
        {
            Console.WriteLine("Your text message was deleted");
        }
    }
}

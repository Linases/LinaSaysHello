using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class EmailMessage : Message, ISender
    {

        private string _recipient;
        public override string Recipient
        {
            get
            {
                return $"Email to: {_recipient}";
            }
            set {
                _recipient = value;
            }

        }
        public bool IsImportant { get; set; }

        public string SenderName { get; set; }

        public EmailMessage(string recipient, string senderName, bool isImportant)
        {
            Recipient = recipient;
            IsImportant = isImportant;
            SenderName = senderName;
        }
        public override void Send()
        {
            Console.WriteLine("Email message is sent.");
        }
        public void Print()
        {
            if (IsImportant)
            {
                Console.WriteLine($"{Recipient}, {Subject} -  please reply urgent!, {SenderName}");
            }
            else
            {
                Console.WriteLine($"{Recipient},\n" +
                    $"Hello, how are you?, {SenderName}");
            }

        }
        public override void Delete()
        {
            Console.WriteLine("Your email message was deleted.");
        }

        public void UpdateSenderName(string NewSenderName)
        {
            Console.WriteLine(SenderName = NewSenderName);
        }
    }
}


using Messages;

internal class Program
{
    private static void Main(string[] args)
    {
        TextMessage textMessage = new TextMessage("Lina", "I am learning abstract classes");
        textMessage.Send();
       
        textMessage.Print();
        Message textMessage1 = new TextMessage("Hola", "So much new");
        
        textMessage.Subject = "Priviet Nastia!";
        Console.WriteLine(textMessage.Subject);
        textMessage.ChangeSubject("Priviet");
        Console.WriteLine(textMessage.Subject);

        EmailMessage emailMessage = new EmailMessage("Lina","Friend",true );
        emailMessage.Send();
        emailMessage.Recipient = "Nastia";
        emailMessage.ChangeSubject("Important");
        Console.WriteLine(emailMessage.Subject);
        emailMessage.Print ();

        Message[] messages = {textMessage, emailMessage};
        foreach (Message message in messages) 
        { 
           message.Send();
        }
        emailMessage.UpdateSenderName("New Name");
        emailMessage.Print();
        textMessage.Delete();
        emailMessage.Delete();  
        
    }
}
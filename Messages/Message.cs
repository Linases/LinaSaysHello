namespace Messages
{
    abstract public class Message
    {

        public string Subject = "Hello";

        abstract public string Recipient { get; set; }
        public abstract void Send();
        public void ChangeSubject(string newSubject)
        {
            Subject = newSubject;
        }
    }
}
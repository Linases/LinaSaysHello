namespace Messages
{
    abstract public class Message: IDelete
    {

        public string Subject = "Hello";

        public abstract string Recipient { get; set; }
        public abstract void Send();
        public void ChangeSubject(string newSubject)
        {
            Subject = newSubject;
        }

        public virtual void Delete () { }
    }
}
namespace DILibrary
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}
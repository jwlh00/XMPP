namespace XMPP.Data
{
	public interface IXmppService
	{
		void SendMessage(string toJid, string message);
		void Connect(string username, string password);
	}
}

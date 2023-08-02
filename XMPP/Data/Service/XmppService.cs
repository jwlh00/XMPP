using System;
using System.Threading.Tasks;
using Matrix;
using Matrix.Xmpp;
using Matrix.Xmpp.Client;

public class XmppClientService
{
	private readonly XmppClient _xmppClient;
	private readonly string _username;
	private readonly string _password;

	public XmppClientService(string xmppDomain = "alumchat.xyz")
	{
		_username = "junwoo20358";
		_password = "NOmeabandonepls123!@#";

		_xmppClient = new XmppClient
		{
			XmppDomain = xmppDomain,
			Username = _username,
			Password = _password,
			Resource = "MatriX"
		};

	}

	public async Task ConnectAsync()
	{
		await _xmppClient.ConnectAsync();

		_xmppClient.SendAsync(new Presence(Show.Chat));
	}

	public async Task SendMessageAsync(string to, string messageBody)
	{
		var msg = new Message(new Jid(to), MessageType.Chat, messageBody);
		await _xmppClient.SendAsync(msg);
	}

}

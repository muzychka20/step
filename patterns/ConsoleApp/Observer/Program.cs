/*
Вы разрабатываете систему мониторинга серверов.
Есть сервер, который периодически обновляет своё состояние (включен/выключен),
и список "наблюдателей" (например, администраторы, которым приходят уведомления о состоянии сервера).

Ваша задача — реализовать паттерн Observer, чтобы наблюдатели автоматически получали уведомления, когда состояние сервера изменяется.
*/

using System.Text;

public interface IAdmin
{
	void Update(Server server);
}

public class Admin : IAdmin
{
	public string Name { get; set; }
	public void Update(Server server)
	{
		Console.WriteLine($"Админ {Name} уведомлён: Состояние сервера {server.Name} изменилось, текущее состояние: {server.Status}");
	}
}


public abstract class Server
{
	private readonly List<IAdmin> _admins = new List<IAdmin>();

	public Server(string name, bool status)
	{
		Name = name;
		_status = status;
	}

	public string Name { get; set; }
	private bool _status;
	public bool Status { 
		get => _status; 
		set
		{
			_status = value;
			Notify();
		}
	}

	public void Attach(IAdmin admin) => _admins.Add(admin);
	public void Dettach(IAdmin admin) => _admins.Remove(admin);

	protected void Notify()
	{
		foreach(var admin in _admins)
		{
			admin.Update(this);
		}
	}
}

public class ConcreteServer : Server
{
	public ConcreteServer(string name, bool status) : base(name, status) { }
}

class Program
{
	static void Main()
	{
		Console.OutputEncoding = Encoding.UTF8;
		
		ConcreteServer server = new ConcreteServer("SERV", true);
		Admin admin1 = new Admin
		{
			Name = "John"
		};
		Admin admin2 = new Admin
		{
			Name = "Sam"
		};

		server.Attach(admin1);
		server.Attach(admin2);

		server.Status = false;

		server.Status = true;

		server.Dettach(admin2);

		server.Status = false;
	}
}
using MediatR;
using Microsoft.Extensions.DependencyInjection;


ConcreteMediator m = new ConcreteMediator();

Colleague1 c1 = new Colleague1(m);
Colleague2 c2 = new Colleague2(m);

m.Colleague1 = c1;
m.Colleague2 = c2;

c1.Send("How are you?");
c2.Send("Fine, thanks");


public interface IMediator
{
    void Send(string message, Colleague colleague);
}

public class ConcreteMediator : IMediator
{
    private Colleague _colleague1;
    private Colleague _colleague2;

    public Colleague Colleague1
    {
        set { _colleague1 = value; }
    }

    public Colleague Colleague2
    {
        set { _colleague2 = value; }
    }

    public void Send(string message, Colleague colleague)
    {
        if (colleague == _colleague1)
        {
            _colleague2.Notify(message);
        }
        else
        {
            _colleague1.Notify(message);
        }
    }
}

public abstract class Colleague
{
    protected IMediator mediator;

    // Constructor
    public Colleague(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public virtual void Send(string message)
    {
        mediator.Send(message, this);
    }

    public abstract void Notify(string message);
}

public class Colleague1 : Colleague
{
    // Constructor
    public Colleague1(IMediator mediator)
        : base(mediator)
    {
    }

    public override void Notify(string message)
    {
        Console.WriteLine("Colleague1 gets message: " + message);
    }
}

public class Colleague2 : Colleague
{
    // Constructor
    public Colleague2(IMediator mediator)
        : base(mediator)
    {
    }

    public override void Notify(string message)
    {
        Console.WriteLine("Colleague2 gets message: " + message);
    }
}



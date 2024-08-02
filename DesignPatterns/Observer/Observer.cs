
// Interface de um observador
public interface IObserver
{
    public void Update(Subject subject);
}

// Classe abstrata Sujeito
// Pode ser observada/monitorada por observadores
public abstract class Subject
{
    private IList<IObserver> _observers = new List<IObserver>();

    public Subject AddObserver(IObserver observer)
    {
        _observers.Add(observer);
        return this;
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
            observer.Update(this);
    }
}

// Classe que representa a taxa Selic como um sujeito
// Quando a taxa Selic é alterada, os observadores são notificados
public class SelicSubject : Subject
{
    public double Selic { get; private set; }

    public void SetSelic(double selic)
    {
        Selic = selic;
        NotifyObservers();
    }
}

// Implementando um Observer do tipo cartão de crédito
public class CreditCardObserver : IObserver
{
    public void Update(Subject subject)
    {
        var rate = (SelicSubject) subject;
        var selic = rate.Selic;

        // Some work...
    }
}

// Implementando um Observer do tipo cartão de crédito
public class PersonalLoanObserver : IObserver
{
    public void Update(Subject subject)
    {
        var rate = (SelicSubject) subject;
        var selic = rate.Selic;

        // Some work...
    }
}

// Implementando um Observer do tipo cartão de crédito
public class FinancingObserver : IObserver
{
    public void Update(Subject subject)
    {
        var rate = (SelicSubject) subject;
        var selic = rate.Selic;

        // Some work...
    }
}

public class ClientCode
{
    public void Consumer()
    {
        // Criando o sujeito
        var subject = new SelicSubject();

        // Adicionando os observadores
        subject.AddObserver(new CreditCardObserver());
        subject.AddObserver(new PersonalLoanObserver());
        subject.AddObserver(new FinancingObserver());

        // Notificando os observadores
        subject.SetSelic(10.25);
    }
}
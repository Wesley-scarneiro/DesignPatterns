namespace DesignPatterns.Visitor
{
    // Interface do Visitor
    public interface IVisitor
    {
        bool Persist(Car car);
        bool Persist(Motorcycle car);
    }

    // Implementação do Visitor
    // Persiste as informações no banco a depende de cada tipo manipulado
    public class RepositoryVisitor : IVisitor
    {
        public bool Persist(Car car)
        {
            // Algumas operações para carros
            // ...
           return Commit(car);
        }

        public bool Persist(Motorcycle motorcycle)
        {
            // algumas operações para motos
            // ...
            return Commit(motorcycle);
        }

        private static bool Commit(Vehicle vehicle)
        {
            Console.WriteLine("Commit: {0}", vehicle);
            return true;
        }
    }

    // Classe base
    public abstract class Vehicle
    {
        // Método que aceita um visitante (Visitor)
        // O visitante "visita" cada subclasse para identificar o seu subtipo
        public abstract bool Persist(IVisitor visitor);
    }

    // Subclasse para carros
    public class Car : Vehicle
    {
        // Persiste os dados
        public override bool Persist(IVisitor visitor)
        {
            // chama o subtipo Car
            return visitor.Persist(this);
        }
    }

    // Subclasse para motos
    public class Motorcycle : Vehicle
    {
        // Persiste os dados
        public override bool Persist(IVisitor visitor)
        {
            // Chama o subtipo Motorcycle
            return visitor.Persist(this);
        }
    }

    // Exemplo de chamada
    public class ClientCode
    {
        public static void Consumer()
        {
            // Visitante para persistir os dados
            var visitor = new RepositoryVisitor();

            // Manipulando os subtipos
            var car = new Car();
            car.Persist(visitor);

            var motorcycle = new Motorcycle();
            motorcycle.Persist(visitor);
        }
    }
}

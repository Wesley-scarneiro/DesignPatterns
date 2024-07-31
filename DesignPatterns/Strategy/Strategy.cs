namespace DesignPatterns.Strategy
{
    // Exemplo dos dados que são manipulados
    public record Data
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int Age { get; init; }
    }

    // Interface que define uma estratégia de ordenação
    public interface ISortStrategy
    {
        IEnumerable<Data> Sort(IEnumerable<Data> data);
    }

    // Implementações de ISortStrategy - Ordenação por ID
    public class IDSortStrategy : ISortStrategy
    {
        public IEnumerable<Data> Sort(IEnumerable<Data> data)
        {
            // Implementa ordenação
            return data;
        }
    }

    // Implementações de ISortStrategy - Ordenação por Nome
    public class NameSortStrategy : ISortStrategy
    {
        public IEnumerable<Data> Sort(IEnumerable<Data> data)
        {
            // Implementa ordenação
            return data;
        }
    }

    // Implementações de ISortStrategy - Ordenação por Idade
    public class AgeSortStrategy : ISortStrategy
    {
        public IEnumerable<Data> Sort(IEnumerable<Data> data)
        {
            // Implementa ordenação
            return data;
        }
    }

    // Classe principal que realiza a pesquisa e ordenação dos dados
    // Recebe um ISortStrategy para ordenação dos dados
    public class SearchService
    {
        private IEnumerable<Data> _data = new List<Data>();
        private ISortStrategy _sortStrategy;

        // Construtor padrão com uma estratégia padrão de ordenação
        public SearchService()
        {
            _sortStrategy = new IDSortStrategy();
        }

        // Parametriza o algoritmo de ordenação
        public SearchService SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
            return this;
        }

        // Retorna os dados ordenados de acordo com a estratégia definida
        public IEnumerable<Data> GetData()
        {
            return _sortStrategy.Sort(_data);
        }
    }

    // Exemplo do padrão no código cliente
    public class ClientCode
    {
        public void Consumer()
        {
            // Dados ordenados por ID - Estratégia padrão
            var data1 = new SearchService()
                .GetData();

            // Dados em ordem alfabética
            var data2 = new SearchService()
                .SetSortStrategy(new NameSortStrategy())
                .GetData();

            // Dados ordenados por idade
            var data3 = new SearchService()
                .SetSortStrategy(new AgeSortStrategy())
                .GetData();
        }
    }
}

namespace DesignPatterns.Factory.FactoryMethod;

// Interface para os produtos
public interface IApiService
{
    void Feature();
}

// Produto
public class ApiServiceOne : IApiService
{
    public void Feature()
    {
        throw new NotImplementedException();
    }
}

// Produto
public class ApiServiceTwo : IApiService
{
    public void Feature()
    {
        throw new NotImplementedException();
    }
}

// Fábrica de produtos
public static class ApiServiceFactory
{
    public static IApiService Create(bool availability)
    {
        if (availability)
            return new ApiServiceOne();
        
        return new ApiServiceTwo();
    }
}

// Exemplo de como o código cliente interage com o padrão
public class ClientCode
{
    // Obtêm uma implementação de IApiService por meio do ApiServiceFactory
    public static void Consumer(bool availability)
    {
        var api = ApiServiceFactory.Create(availability);
        api.Feature();
    }
}

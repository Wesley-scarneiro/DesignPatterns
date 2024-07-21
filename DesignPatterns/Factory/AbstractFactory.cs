
namespace DesignPatterns.Factory.AbstractFactory;


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

// Interface para uma fábrica de produtos
public interface IApiServiceFactory
{
    IApiService Create();
}

// Fábrica de produtos ApiServiceOne
public class ApiServiceOneFactory : IApiServiceFactory
{
    public IApiService Create()
    {
        return new ApiServiceOne();
    }
}

// Fábrica de produtos ApiServiceTwo
public class ApiServiceTwoFactory : IApiServiceFactory
{
    public IApiService Create()
    {
        return new ApiServiceTwo();
    }
}

// Exemplo de como o código cliente interage com o padrão
public class ClientCode
{
    // Recebe IApiServiceFactory que possibilita construir uma implementação de IApiService
    public static void Consumer(IApiServiceFactory factory)
    {
        IApiService api = factory.Create();
        api.Feature();
    }
}
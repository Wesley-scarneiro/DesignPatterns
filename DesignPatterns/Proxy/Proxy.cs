namespace DesignPatterns.Proxy;

// Modelo de catálogo
public record ProductCatalogModel {}

// Interface do serviço de consulta ao catálogo de produtos
public interface IProductCatalogService
{
    public ProductCatalogModel? GetCatalog();
}

// Serviço de consulta que implementa IProductCatalogService
public class ProductCatalogService : IProductCatalogService
{
    public ProductCatalogModel? GetCatalog()
    {
        return new ProductCatalogModel();
    }
}

// Interface do serviço de cache
public interface ICacheService
{
    public void Write<T>(string key, T content) where T : class, new();
    public T? Get<T>(string key) where T : class, new();
}

// Implementação de ICacheService
public class CacheService : ICacheService
{
    public T? Get<T>(string key) where T : class, new()
    {
        return new T();
    }

    public void Write<T>(string key, T content) where T : class, new()
    {
        Console.WriteLine($"Cached - [{key}] = {content}");
    }
}

// Proxy que implementa IProductCatalogService para intermediar o cliente e serviço final
// Manipula o serviço de cache
public class ProductCatalogProxy : IProductCatalogService
{
    private readonly ICacheService _cache;
    private readonly IProductCatalogService _catalogService;

    public ProductCatalogProxy(ICacheService cache, IProductCatalogService catalogService)
    {
        _cache = cache;
        _catalogService = catalogService;
    }

    // Manipula o cache e ProductCatalogService
    public ProductCatalogModel? GetCatalog()
    {
        var response = _cache.Get<ProductCatalogModel>("product_catalog");
        if (response is null)
        {
            response = _catalogService.GetCatalog();
            if (response is not null)
                _cache.Write("product_catalog", response);
        }

        return response;
    }
}
namespace DesignPatterns.Adapter;

// Simulando uma implementação do AWS.SDK
public class ProviderAWS
{
    // Simulando a leitura de algum arquivo obtido do S3
    public Stream GetObjectS3()
    {
        return new MemoryStream();
    }
}

// Interface genérica para manipular serviços de arquivos
public interface IFileService
{
    public Stream GetFile();
}

// Implementação de um adaptar para AWS.S3
// Converte ProviderAWS na interface IFileService
public class AdapterProviderAWS : IFileService
{
    private readonly ProviderAWS _aws;

    public AdapterProviderAWS(ProviderAWS aws)
    {
        _aws = aws;
    }

    public Stream GetFile()
    {
        return _aws.GetObjectS3();
    }
}

// Código cliente
public class ClientCode {

    // Recebe uma adaptador que implementa IFileService
    public void Consumer(IFileService service)
    {
        var stream = service.GetFile();
    }
}

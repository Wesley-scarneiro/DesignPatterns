using System.Text;

namespace DesignPatterns.Facade;

// Um objeto a ser convertido em um registro de arquivo CSV
public record Record {}

// Como ocorria a chamada antiga
// Necessidade de manipular cada etapa para a geração do arquivo
public class CodeOld
{
    public void ClientCode()
    {
        var _string = ConvertListToString(new List<Record>());
        var stream = CreateStream(_string);
        CreateFileCsv(stream, "file");
    }

    private string ConvertListToString<T>(IList<T> records)
    {
        return "";
    }

    private Stream CreateStream(string content)
    {
        return new MemoryStream();
    }

    private void CreateFileCsv(Stream stream, string fileName) {}
}

// Interface para o novo serviço de geração de arquivo
// Implementa o Facade Pattern - Encapsula as complexidades
public interface IServiceCsv
{
    void CreateFileCsv<T>(IList<T> records, string fileName);
}

// Implementação de IServiceCsv
// Encasula a chamada aos três métodos para geração do arquivo
public class ServiceCsv : IServiceCsv
{
    public void CreateFileCsv<T>(IList<T> records, string fileName)
    {
        var _string = ConvertListToString(new List<Record>());
        var stream = CreateStream(_string);
        CreateFileCsv(stream, "file");
    }

    private string ConvertListToString<T>(IList<T> records)
    {
        return "";
    }

    private Stream CreateStream(string content)
    {
        return new MemoryStream();
    }

    private void CreateFileCsv(Stream stream, string fileName) {}
}


// Novo código cliente chamando ServiceCsv
public class CodeNew
{
    // Nova forma de criar arquivos CSV
    // Esconde as operações anteriores, através de uma interface mais simples
    public void Consumer(IServiceCsv serviceCsv)
    {
        var records = new List<Record>();
        serviceCsv.CreateFileCsv(records, "file");
    }
}
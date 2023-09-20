using DataKodBlazorServer.Data;

public interface IDataRepository
{
    IEnumerable<Issue> GetItems();
    // 1. GetPagedItems fonksiyonunu tanımlayın.
public IEnumerable<Issue> GetPagedItems(IEnumerable<Issue> allItems, int pageSize, int pageNumber)
{
    return allItems.Skip((pageNumber - 1) * pageSize).Take(pageSize);
}



}

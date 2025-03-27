namespace PWDBlazorApp.Services
{
    public interface IServices<T>
    {
        List<T> GetAll();
        T GetByID(int id);
    }
}

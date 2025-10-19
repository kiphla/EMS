namespace EMS.Core.Interfaces
{
    public interface IDataManager<T>
    {
        void Add(T item);
        void Remove(int id);
        T? GetById(int id);
        List<T> GetAll();
        List<T> FilterByDate(DateTime startDate, DateTime endDate);
        List<T> FilterByLocation(string location);
    }
}

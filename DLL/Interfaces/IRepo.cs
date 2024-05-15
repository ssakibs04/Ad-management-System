using System.Collections.Generic;

namespace DLL.Interfaces
{
    public interface IRepo<T, ID, RET>
    {
        RET Create(T obj);
        List<T> Read();
        T Read(ID id);
        RET Update(T obj);
        bool Delete(ID id);
     
    }
}

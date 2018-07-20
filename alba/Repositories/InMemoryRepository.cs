using alba.Models;
using System.Collections.Generic;

namespace alba.Repositories
{
    public class InMemoryRepository<T> where T: EntityBase
    {
        private int sequencer = 0;
        private Dictionary<string, T> data = new Dictionary<string, T>();

        public T Create(T obj)
        {
            sequencer++;
            obj.Id = "e" + sequencer.ToString();
            data.Add(obj.Id, obj);
            return obj;
        }
        public T Update(string id, T obj)
        {
            if (data.ContainsKey(id))
            {
                data[id] = obj;
                return obj;
            }
            else
            {
                throw new KeyNotFoundException("Cannot update object " + id);
            }
        }
        public IEnumerable<T> Get()
        {
            return data.Values;
        }
        public T GetById(string id)
        {
            if (!data.ContainsKey(id))
            {
                throw new KeyNotFoundException("Cannot find object " + id);
            }
            return data[id];
        }
        public T Delete(string id)
        {
            var obj = data[id];
            if (obj != null)
            {
                data.Remove(id);
                return obj;
            }
            throw new KeyNotFoundException("Cannot delete object " + id);
        }
    }
}

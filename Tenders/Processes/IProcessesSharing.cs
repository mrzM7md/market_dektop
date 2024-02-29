using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Processes
{
    public interface IProcessesSharing<Table>
    {
        void Add(Table table);
        void RemoveAt(int Id);
        void Update(Table table);
        
        Table Find(int Id);
        ICollection<Table> GetAll();
    }
}

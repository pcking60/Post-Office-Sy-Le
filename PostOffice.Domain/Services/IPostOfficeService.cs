using PostOffice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.Domain.Services
{
    public interface IPostOfficeService
    {
        IEnumerable<Service> GetServicesPage(int limit, int offset, string SortedField, bool isDesc);
        Service GetServiceById(int id);
        bool RemoveService(int id);
        Service UpdateService(Service s);
        int AddService(Service service);
    }
}

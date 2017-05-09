using PostOffice.Domain.Entities;
using PostOffice.Domain.Repos;
using PostOffice.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PostOffice.Web.Controllers
{
    public class ServiceController : ApiController
    {
        Domain.Services.IPostOfficeService _internalService;
        public ServiceController()
        {
            _internalService = Service.ServiceFactory.CreatePostOfficeService();
        }

        public IEnumerable<Domain.Entities.Service> Get(int limit, int offset, string sortedField, bool isDesc)
        {
            return _internalService.GetServicesPage(limit, offset, sortedField, isDesc);
        }

        public Domain.Entities.Service Get(int id)
        {
            return _internalService.GetServiceById(id);
        }

        public Domain.Entities.Service Put(int id, [FromBody]Domain.Entities.Service s)
        {
            return _internalService.UpdateService(s);
        }

        public bool Delete(int id)
        {
            return _internalService.RemoveService(id);
        }

        public int Post([FromBody] Domain.Entities.Service service)
        {
            return _internalService.AddService(service);
        }
    }
}
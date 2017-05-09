using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostOffice.Domain.Entities;

namespace PostOffice.Service
{
    public class PostOfficeService : Domain.Services.IPostOfficeService
    {
        public int AddService(Domain.Entities.Service service)
        {
            return service.Id;
        }

        public Domain.Entities.Service GetServiceById(int id)
        {
            return new Domain.Entities.Service
            {
                Id = id,
                Attributes = new List<Domain.Entities.ServiceAttribute>
                {
                    new ServiceAttribute{
                     Id = 1,
                     AttributeName = "attr 1",
                     BenefitPercent = 5,
                     ServiceId = id,
                     AttributeType = 1
                    },
                    new ServiceAttribute{
                     Id = 2,
                     AttributeName = "attr 2",
                     BenefitPercent = 7,
                     ServiceId = id,
                     AttributeType = 1
                    }
                },
                ServiceName = "Test 1"
            };
        }

        public IEnumerable<Domain.Entities.Service> GetServicesPage(int limit, int offset, string SortedField, bool isDesc)
        {
            return new List<Domain.Entities.Service>{
                new Domain.Entities.Service
                {
                    Id = 1,
                    Attributes = new List<Domain.Entities.ServiceAttribute>
                    {
                        new ServiceAttribute{
                         Id = 1,
                         AttributeName = "attr 1",
                         BenefitPercent = 5,
                         ServiceId = 1,
                         AttributeType = 1
                        },
                        new ServiceAttribute{
                         Id = 2,
                         AttributeName = "attr 2",
                         BenefitPercent = 7,
                         ServiceId = 1,
                         AttributeType = 1
                        }
                    },
                    ServiceName = "Test 1"
                },
                new Domain.Entities.Service
                {
                    Id = 2,
                    Attributes = new List<Domain.Entities.ServiceAttribute>
                    {
                        new ServiceAttribute{
                         Id = 3,
                         AttributeName = "attr 1_2",
                         BenefitPercent = 34,
                         ServiceId = 1,
                         AttributeType = 1
                        },
                        new ServiceAttribute{
                         Id = 4,
                         AttributeName = "attr 2_2",
                         BenefitPercent = 51,
                         ServiceId = 1,
                         AttributeType = 1
                        }
                    },
                    ServiceName = "Test 1"
                }
            };
        }

        public bool RemoveService(int id)
        {
            return true;
        }

        public Domain.Entities.Service UpdateService(Domain.Entities.Service s)
        {
            return s;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.Service
{
    public static class ServiceFactory
    {
        public static Domain.Services.IPostOfficeService CreatePostOfficeService()
        {
            return new PostOfficeService();
        }
    }
}

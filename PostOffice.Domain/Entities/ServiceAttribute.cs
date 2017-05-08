using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.Domain.Entities
{
    public class ServiceAttribute
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string AttributeName { get; set; }
        public float BenefitPercent { get; set; }
        public int AttributeType { get; set; }
    }
}

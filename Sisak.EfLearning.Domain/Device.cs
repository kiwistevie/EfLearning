using System;
using System.Collections.Generic;
using System.Text;

namespace Sisak.EfLearning.Domain
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HardwareId { get; set; }
        public Person Owner { get; set; }
    }
}

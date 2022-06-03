using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeylanTurizm.Entity
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusPlaque { get; set; }
        public string BusDriver { get; set; }
        public int BusSeatingCapacity { get; set; }
        public bool IsExpedition { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelte { get; set; }
        public List<Expedition> Expeditions { get; set; }
    }
}

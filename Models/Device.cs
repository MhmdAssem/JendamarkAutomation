using Jendamark_Automation.Enums;

namespace Jendamark_Automation.Models
{
    public class Device
    {
        public int DeviceID { get; set; }
        public string Name { get; set; }
        public DeviceType DeviceType { get; set; }
    }
}

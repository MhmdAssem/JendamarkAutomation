using Jendamark_Automation.Models;
using System.Collections.Generic;

namespace Jendamark_Automation.Interfaces
{
    public interface IDevicesRepository
    {
        bool AddNewDevice(Device device);
        List<Device> List();
        Device GetDeviceById(int id);
    }
}

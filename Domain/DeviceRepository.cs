using Jendamark_Automation.Interfaces;
using Jendamark_Automation.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Jendamark_Automation.Domain
{
    public class DeviceRepository : IDevicesRepository
    {
        List<Device> _devices;
        public DeviceRepository()
        {
            _devices = new List<Device>();
        }
        public bool AddNewDevice(Device device)
        {
            try
            {
                _devices.Add(device);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public Device GetDeviceById(int id)
        {
            return _devices.Where(d => d.DeviceID == id).FirstOrDefault();
        }

        public List<Device> List()
        {
            return _devices;
        }
    }
}

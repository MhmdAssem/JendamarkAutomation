using Jendamark_Automation.Interfaces;
using Jendamark_Automation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jendamark_Automation
{
    public class HomeController : Controller
    {
        private readonly IOperationRepository _operationRepository;
        private readonly IDevicesRepository _devicesRepository;
        public HomeController(IOperationRepository operationRepository,
                              IDevicesRepository devicesRepository)
        {
            _operationRepository = operationRepository;
            _devicesRepository = devicesRepository;
        }
        public IActionResult Index()
        {

            var model = new ViewModel
            {
                Operations = _operationRepository.List(),
                Devices = _devicesRepository.List()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult SaveDevice(string Name, int DeviceTypes)
        {
            _devicesRepository.AddNewDevice(new Device
            {
                DeviceID = _devicesRepository.List().Count + 1,
                DeviceType = (Enums.DeviceType)DeviceTypes,
                Name = Name
            });
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SaveOperation(string Name, int Devices)
        {
            _operationRepository.AddOperation(new Operation
            {
                OperationID = _operationRepository.List().Count+1,
                Name = Name,
                Device = _devicesRepository.GetDeviceById(Devices)
            });
            return RedirectToAction("Index");
        }
    }
}

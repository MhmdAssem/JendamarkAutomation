using Jendamark_Automation.Models;
using System.Collections.Generic;

namespace Jendamark_Automation.Interfaces
{
    public interface IOperationRepository
    {
        bool AddOperation(Operation opereation);
        bool RemoveOperation(int operationID);
        List<Operation> List();
    }
}

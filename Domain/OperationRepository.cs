using Jendamark_Automation.Interfaces;
using Jendamark_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jendamark_Automation.Domain
{
    public class OperationRepository: IOperationRepository
    {
        private List<Operation> _operations;
        public static int Id = 0;
        public OperationRepository()
        {
            _operations = new List<Operation>();
        }

        public bool AddOperation(Operation opereation)
        {
            try
            {
                opereation.OperationID = Id++;
                _operations.Add(opereation);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public bool RemoveOperation(int operationID)
        {

            try
            {
                var operation = _operations.Where(op => op.OperationID == operationID).FirstOrDefault();
                if (operation == null)
                    return false;
                _operations.Remove(operation);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        public List<Operation> List()
        {
            return _operations;
        }
    }
}

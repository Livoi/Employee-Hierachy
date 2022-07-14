using System;
using System.Runtime.Serialization;

namespace EmployeeHierarchy.CustomException
{
    public class ManagerMoreThanOne : Exception
    {
        public ManagerMoreThanOne(string message) : base(message)
        {
        }
    }
}

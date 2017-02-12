using System.Collections.Generic;
using System.ServiceModel;

namespace EmployeesService
{    
    [ServiceContract]
    public interface IEmployeesService
    {
        [OperationContract]
        List<Employee> GetAllEmployees();

        [OperationContract]
        Employee GetEmployeeById(int id);

        [OperationContract]
        void InsertEmployee(Employee employee);

        [OperationContract]
        void UpdateEmployee(Employee employee);

        [OperationContract]
        void DeleteEmployee(int id);
    }
}

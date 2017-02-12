using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeesService
{    
    public class EmployeesService : IEmployeesService
    {        
        public List<Employee> GetAllEmployees()
        {            
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["wcfCnStr"].ConnectionString);

            List<Employee> employees = new List<Employee>();

            SqlCommand com = new SqlCommand("spGetAllEmployees", cn);
            com.CommandType = CommandType.StoredProcedure;

            cn.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Id = (int)reader["Id"];
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.Department = reader["Department"].ToString();
                employee.Salary = (int)reader["Salary"];
                employee.City = reader["City"].ToString();
                employee.Telephone = reader["Telephone"].ToString();

                employees.Add(employee);
            }
            cn.Close();

            return employees;
        }

        public Employee GetEmployeeById(int id)
        {            
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["wcfCnStr"].ConnectionString);

            Employee employee = new Employee();

            SqlCommand com = new SqlCommand("spGetEmployeeById", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            com.Parameters.Add(parameterId);

            cn.Open();
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {                                
                employee.Id = (int)reader["Id"];
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.Department = reader["Department"].ToString();
                employee.Salary = (int)reader["Salary"];
                employee.City = reader["City"].ToString();
                employee.Telephone = reader["Telephone"].ToString();
            }
            cn.Close();

            return employee;
        }

        public void InsertEmployee(Employee employee)
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["wcfCnStr"].ConnectionString);

            SqlCommand com = new SqlCommand("spInsertEmployee", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterFirstName = new SqlParameter()
            {
                ParameterName = "@FirstName",
                Value = employee.FirstName
            };
            com.Parameters.Add(parameterFirstName);

            SqlParameter parameterLastName = new SqlParameter()
            {
                ParameterName = "@LastName",
                Value = employee.LastName
            };
            com.Parameters.Add(parameterLastName);

            SqlParameter parameterDepartment = new SqlParameter()
            {
                ParameterName = "@Department",
                Value = employee.Department
            };
            com.Parameters.Add(parameterDepartment);

            SqlParameter parameterSalary = new SqlParameter()
            {
                ParameterName = "@Salary",
                Value = employee.Salary
            };
            com.Parameters.Add(parameterSalary);

            SqlParameter parameterCity = new SqlParameter()
            {
                ParameterName = "@City",
                Value = employee.City
            };
            com.Parameters.Add(parameterCity);

            SqlParameter parameterTelephone = new SqlParameter()
            {
                ParameterName = "@Telephone",
                Value = employee.Telephone
            };
            com.Parameters.Add(parameterTelephone);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public void UpdateEmployee(Employee employee)
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["wcfCnStr"].ConnectionString);

            SqlCommand com = new SqlCommand("spUpdateEmployee", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = employee.Id
            };
            com.Parameters.Add(parameterId);

            SqlParameter parameterFirstName = new SqlParameter()
            {
                ParameterName = "@FirstName",
                Value = employee.FirstName
            };
            com.Parameters.Add(parameterFirstName);

            SqlParameter parameterLastName = new SqlParameter()
            {
                ParameterName = "@LastName",
                Value = employee.LastName
            };
            com.Parameters.Add(parameterLastName);

            SqlParameter parameterDepartment = new SqlParameter()
            {
                ParameterName = "@Department",
                Value = employee.Department
            };
            com.Parameters.Add(parameterDepartment);

            SqlParameter parameterSalary = new SqlParameter()
            {
                ParameterName = "@Salary",
                Value = employee.Salary
            };
            com.Parameters.Add(parameterSalary);

            SqlParameter parameterCity = new SqlParameter()
            {
                ParameterName = "@City",
                Value = employee.City
            };
            com.Parameters.Add(parameterCity);

            SqlParameter parameterTelephone = new SqlParameter()
            {
                ParameterName = "@Telephone",
                Value = employee.Telephone
            };
            com.Parameters.Add(parameterTelephone);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public void DeleteEmployee(int id)
        {
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["wcfCnStr"].ConnectionString);

            SqlCommand com = new SqlCommand("spDeleteEmployee", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            com.Parameters.Add(parameterId);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }
    }
}

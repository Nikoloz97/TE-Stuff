using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class EmployeeSqlDao : IEmployeeDao
    {
        private readonly string connectionString;

        public EmployeeSqlDao(string connString)
        {
            connectionString = connString;
        }

        public IList<Employee> GetAllEmployees()
        {
            IList<Employee> EmployeeList = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from employee", conn);

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Employee Employee = CreateEmployeeFromReader(reader);
                    EmployeeList.Add(Employee);

                }
                return EmployeeList;
            }
        }

        


        public IList<Employee> SearchEmployeesByName(string firstNameSearch, string lastNameSearch)
        {
            IList<Employee> EmployeeList = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
             
                conn.Open();

                SqlCommand cmd;

                if ((firstNameSearch == "" || firstNameSearch == null) && (lastNameSearch == "" || lastNameSearch == null))
                {
                    cmd = new SqlCommand("select * from employee", conn);
                }

                if (firstNameSearch == "" || firstNameSearch == null)
                {
                    cmd = new SqlCommand("select * from employee where last_name like @lastNameSearch", conn);
                    string wildLastName = ("%" + lastNameSearch + "%");
                    cmd.Parameters.AddWithValue("@lastNameSearch", wildLastName);

                }

                if (lastNameSearch == "" || lastNameSearch == null)
                {
                    cmd = new SqlCommand("select * from employee where first_name like @firstNameSearch", conn);
                    string wildFirstName = ("%" + firstNameSearch + "%");

                    cmd.Parameters.AddWithValue("@firstNameSearch", wildFirstName);
                }

                else
                {
                    cmd = new SqlCommand("select * from employee where first_name like @firstNameSearch AND last_name like @lastNameSearch", conn);

                    string wildFirstName = ("%" + firstNameSearch + "%");
                    cmd.Parameters.AddWithValue("@firstNameSearch", wildFirstName);

                    string wildLastName = ("%" + lastNameSearch + "%");
                    cmd.Parameters.AddWithValue("@lastNameSearch", wildLastName);



                }

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee Employee = CreateEmployeeFromReader(reader);
                    EmployeeList.Add(Employee);
                }
            }
            return EmployeeList;
        }

        public IList<Employee> GetEmployeesByProjectId(int projectId)
        {
            IList<Employee> EmployeeList = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from employee join project_employee on employee.employee_id = project_employee.employee_id where project_id = @project_id", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    EmployeeList.Add(employee);

                }
            }

            return EmployeeList;

        }





        public void AddEmployeeToProject(int projectId, int employeeId)
        {
           

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into project_employee(project_id, employee_id) values (@project_id, @employee_id);", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.Parameters.AddWithValue("@employee_id", employeeId);

                cmd.ExecuteNonQuery();

            }

      
        }

        public void RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("delete from project_employee where project_id = @project_id AND employee_id = @employee_id", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.Parameters.AddWithValue("@employee_id", employeeId);

                cmd.ExecuteNonQuery();
            }

        }



        public IList<Employee> GetEmployeesWithoutProjects()
        {
            IList<Employee> EmployeeList = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from employee" + 
                    "left join project_employee on employee.employee_id = project_employee.employee_id" + 
                    "where project_id is null", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = CreateEmployeeFromReader(reader);
                    EmployeeList.Add(employee);
                }
            }

            return EmployeeList;
        }


        private Employee CreateEmployeeFromReader(SqlDataReader reader)
        {
            Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(reader["employee_id"]);
            employee.EmployeeId = Convert.ToInt32(reader["department_id"]);
            employee.FirstName = Convert.ToString(reader["first_name"]);
            employee.LastName = Convert.ToString(reader["last_name"]);
            employee.BirthDate = Convert.ToDateTime(reader["birth_date"]);
            employee.HireDate = Convert.ToDateTime(reader["hire_date"]);

            return employee;
        }




    }
}

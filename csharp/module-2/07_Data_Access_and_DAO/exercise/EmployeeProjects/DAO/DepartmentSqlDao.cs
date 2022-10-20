using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class DepartmentSqlDao : IDepartmentDao
    {
        private readonly string connectionString;

        public DepartmentSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Department GetDepartment(int departmentId)
        {
            Department department = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM department WHERE department_id = @department_id", conn);
                cmd.Parameters.AddWithValue("@department_id", departmentId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    department = CreateDepartmentFromReader(reader);
                }
               

            }
            return department;

        }

        private Department CreateDepartmentFromReader(SqlDataReader reader)
        {
            Department department = new Department();
            department.DepartmentId = Convert.ToInt32(reader["department_id"]);
            department.Name = Convert.ToString(reader["name"]);
            return department;
        }

        public IList<Department> GetAllDepartments()
        {
            IList<Department> DepartmentList = new List<Department>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from department", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Department department = CreateDepartmentFromReader(reader);
                    DepartmentList.Add(department);

                }
            }

            return DepartmentList;

        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update department set name = @name where department_id = @department_id", conn);
                cmd.Parameters.AddWithValue("@department_id", updatedDepartment.DepartmentId);
                cmd.Parameters.AddWithValue("@name", updatedDepartment.Name);
                cmd.ExecuteNonQuery();
            }


        }





    }
}

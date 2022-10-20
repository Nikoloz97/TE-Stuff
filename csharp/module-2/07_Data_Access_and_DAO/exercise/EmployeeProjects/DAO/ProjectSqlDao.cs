using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class ProjectSqlDao : IProjectDao
    {
        private readonly string connectionString;

        public ProjectSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Project GetProject(int projectId)
        {
            Project project = null;


           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from project where project_id = @project_id", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    project = CreateProjectFromReader(reader);
                }

            }
            return project;
        }

        private Project CreateProjectFromReader(SqlDataReader reader)
        {
            Project project = new Project();
            project.ProjectId= Convert.ToInt32(reader["project_id"]);
            project.Name = Convert.ToString(reader["name"]);
            project.FromDate = Convert.ToDateTime(reader["from_date"]);
            project.ToDate = Convert.ToDateTime(reader["to_date"]);

            return project;
        }

        public IList<Project> GetAllProjects()
        {
            IList<Project> ProjectList = new List<Project>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from project", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Project department = CreateProjectFromReader(reader);
                    ProjectList.Add(department);

                }
            }

            return ProjectList;
        }

        public Project CreateProject(Project newProject)
        {
            int newProjID;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("insert into project (name, from_date, to_date) output inserted.project_id values(@name, @from_date, @to_date); ", conn);
                cmd.Parameters.AddWithValue("@name", newProject.Name);
                cmd.Parameters.AddWithValue("@from_date", newProject.FromDate);
                cmd.Parameters.AddWithValue("@to_date",newProject.ToDate);

                newProjID = Convert.ToInt32(cmd.ExecuteScalar());

            }

            return GetProject(newProjID);
        }

        public void DeleteProject(int projectId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from project_employee where project_id = @project_id_1", conn);
                cmd.Parameters.AddWithValue("@project_id_1", projectId);

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("delete from project where project_id = @project_id_2", conn);
                cmd.Parameters.AddWithValue("@project_id_2", projectId);

                cmd.ExecuteNonQuery();
            }


        }
    }


    }


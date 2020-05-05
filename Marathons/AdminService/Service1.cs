using System.Collections.Generic;
using Marathons;
using SerializationClasses;
using System.Data.SqlClient;
using System.Data;

namespace AdminService
{

    public class Service1 : IAdminService
    {

        public List<Charity> GetAllCharity()
        {
            var reader = Reader.GetTableReader(AdminRequest.Charities());
            var charities = new List<Charity>();
            while (reader.Read())
            {
                var charity = new Charity(
                        reader["CharityId"].ToString(),
                        reader["CharityName"].ToString(),
                        reader["CharityDescription"].ToString(),
                        reader["CharityLogo"].ToString()
                    );
                charities.Add(charity);
            }
            return charities;
        }

        public void EditCharity(Charity charity)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = AdminRequest.UpdateCharity(charity);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddCharity(string name, string desc, string logo)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = AdminRequest.NewCharity(name, desc, logo);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddVolunteers(List<Volunteer> volunteers)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                volunteers.ForEach(volunteer =>
                {
                    cmd.CommandText = AdminRequest.NewVolunteer(volunteer);
                    cmd.ExecuteNonQuery();
                });
            }
        }

        public List<User> GetAllUser()
        {
            var reader = Reader.GetTableReader(AdminRequest.Users());
            var users = new List<User>();
            while (reader.Read())
            {
                var role = new Role(reader["RoleId"].ToString());
                var user = new User(
                        reader["Email"].ToString(),
                        reader["Password"].ToString(),
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        role
                    );
                users.Add(user);
            }
            return users;
        }

        public void EditUser(User user)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = AdminRequest.UpdateUser(user);
                cmd.ExecuteNonQuery();
            }
        }

        public void AddUser(string email, string password, string firstName, string lastName, string roleId)
        {
            using (SqlConnection con = new SqlConnection(Configuration.someeServer))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = AdminRequest.NewUser(email, password, firstName, lastName, roleId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

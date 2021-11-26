using System;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Concrete.StoredProcedure
{
    public class SpUserDal : IEntityRepository<User>, IUserDal
    {
        public void Add(User entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new System.NotImplementedException();
        }

        public User Get()
        {
            throw new System.NotImplementedException();
        }

        public List<User> GetAll(ETradeTools eTradeConnection)
        {
            using (var connection = eTradeConnection.ETradeConnection())
            {
                //using (var command = new SqlCommand("SELECT * FROM Vw_GetAllUsers",connection))
                //{

                //    List<User> listUser = new List<User>();
                //    DataTable dataTable = new DataTable();
                //    using (var dataAdapter = new SqlDataAdapter(command))
                //    {
                //        dataAdapter.Fill(dataTable);
                //        foreach (DataRow users in dataTable.Rows)
                //        {
                //            User user = new User
                //            {
                //                UserName = users["USERNAME"].ToString(),
                //                NameSurname = users["NAMESURNAME"].ToString(),
                //                Email = users["EMAIL"].ToString(),
                //                Gender = users["GENDER"].ToString(),
                //                BirthDate = users["BIRTHDATE"].ToString(),
                //                CreatedDate = (DateTime) users["CREATEDATE"],
                //                TelephoneNumber1 = users["TELEPHONE1"].ToString(),
                //                TelephoneNumber2 = users["TELEPHONE2"].ToString()
                //            };
                //        }

                //        command.ExecuteReader();
                //        return listUser;
                //    }
                //}
                DataTable dataTable = new DataTable();
                List<User> listUser = new List<User>();
                SqlCommand command = new SqlCommand("Sp_GetAllUsers", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                foreach (DataRow users in dataTable.Rows)
                {
                    User user = new User
                    {
                        UserName = users["USERNAME"].ToString(),
                        NameSurname = users["NAMESURNAME"].ToString(),
                        Email = users["EMAIL"].ToString(),
                        Gender = users["GENDER"].ToString(),
                        BirthDate = users["BIRTHDATE"].ToString(),
                        CreatedDate = (DateTime)users["CREATEDATE"],
                        TelephoneNumber1 = users["TELEPHONE1"].ToString(),
                        TelephoneNumber2 = users["TELEPHONE2"].ToString()
                    };
                }

                return listUser;
            }
        }

        public void Update(User entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
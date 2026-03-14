using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Service
{
    public class Program
    {
        class ValidateUserDataModel
        {
            public string UserName { get; set; }

            public string Password { get; set; }

            public string Email { get; set; }

            public bool IsEmailConfirmed { get; set; } = true;

         
        }

      

        public class TableModel
        {
            ValidateUserDataModel model = new ValidateUserDataModel();
            public void CreateDataModel()
            {
              
                model.UserName = "User1";
                model.Password = "password";
                model.Email = "email1@gmail.com";
                model.IsEmailConfirmed = true;

               Console.WriteLine("Data Model was created successfully : \n");
              
            }
           public void Add(string _username ,string _password , string _email ,bool _isEmailConfirmed)
                
            {
             
             model.UserName  = _username;
                model.Password  = _password;
                model.Email = _email;
                model.IsEmailConfirmed = _isEmailConfirmed;

              
            }
            public void Show()
            {
                string[] _dataCell =

                {
                       model.UserName,
                       model.Password,
                       model.Email,
                       model.IsEmailConfirmed.ToString(),
                };

                foreach (var cell in _dataCell)
                {
                    Console.WriteLine(cell);
                }
            }

        }
      
        static void Main(string[] args)
        {
           TableModel tableModel = new TableModel();
            tableModel.CreateDataModel();
            tableModel.Add("{ User1 }", "{ 12345 }", "{ email1@gmail.com }", true);
           tableModel.Show();
       
        }
    }
}

using Castle.Windsor;
using LibraryOfDash;
using MyDataBase;
using Repository;
using Servise;
using Servise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash.cs
{
   public class Program
    {
        static void Main(string[] args)
        {
            /*  MyDataBasEntityContext context = new MyDataBasEntityContext();
              UserRepository userRepository = new UserRepository(context);
              UnitOfWork unitOfWork = new UnitOfWork(context);
              UserServise userServise = new UserServise(userRepository, unitOfWork);
            */
            WindsorContainer container = Bootstrap.BuildContainer();
            IUserServise userServise = container.Resolve<IUserServise>();
            IDeviseServise deviseServise = container.Resolve<IDeviseServise>();

            /*
            User user= new User();
            user.User_name = "Lomonosov";
            user.Role = "admin";
            user.CreationDate = DateTime.Now.ToString();

            userRepository.Create(user);
            unitOfWork.Save();
            */
            var devData = deviseServise.GetAll();
            List<User> myData = userServise.GetAll().ToList();
            Console.WriteLine("|| Id || User_Name || Role || CreationDate ||");
            Console.WriteLine("||----||-----------||------||--------------||");
            foreach (User user in myData)
            {string one= user.Id.ToString(), two= user.User_name, three= user.Role, four= user.CreationDate.ToString();
                for (int i = 0; i < 4 - user.Id.ToString().Length; i++) one += ' ';
                for (int i = 0; i < 11 - user.User_name.Length; i++) two += ' ';
                for (int i = 0; i < 6 - user.Role.Length; i++) three += ' ';
                for (int i = 0; i < 14 - user.CreationDate.ToString().Length; i++) four += ' ';
                Console.WriteLine("||{0}||{1}||{2}||{3}||", one, two, three, four);
                Console.WriteLine("||____||___________||______||______________||");
            }
            Console.ReadKey();

        }
    }
}

using Castle.Windsor;
using Dash.cs;
using LibraryOfDash;
using Servise.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiWinForms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WindsorContainer container = Bootstrap.BuildContainer();
            IUserServise userServise = container.Resolve<IUserServise>();
            ISession_journalServise session_JournalServise = container.Resolve<ISession_journalServise>();

            List<User> users = userServise.GetAll(x => x.User_name == UserNameBox.Text).ToList();
            foreach( var user in users)
            {
                if (UserPassBox.Text.Equals(user.Password))
                {
                    Session_journal session_Journal = new Session_journal
                    {
                        CreationDate = DateTime.Now.ToShortDateString(),
                        Id_User = user.Id,
                        Session_time = DateTime.Now.ToLongTimeString()
                    };
                    session_JournalServise.Create(session_Journal);
                    ErrLable.ForeColor = Color.WhiteSmoke;
                    Program.CloseReg();
                    this.Close();
                    this.Dispose();
                    Console.WriteLine("RegForm_Close");
                }
            }
            ErrLable.Text = "Неверный логин или пароль";
            ErrLable.ForeColor = Color.Red;
            UserPassBox.Text = null;
        }

        private void UserName_MouseClick(object sender, MouseEventArgs e)
        {
            UserNameBox.Text = null;
            UserNameBox.ForeColor = Color.Black;
        }


        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WindsorContainer container = Bootstrap.BuildContainer();
            IUserServise userServise = container.Resolve<IUserServise>();
            User Setuser = new User
            {
                CreationDate = DateTime.Now.ToShortDateString(),
                User_name = UserNameBox.Text,
                Password = UserPassBox.Text == "Пароль" ? null : UserPassBox.Text 
            };
            List<User> users = userServise.GetAll().ToList();
            bool RepeatFlag=false;
            foreach (var user in users)
            {
                if (Setuser.User_name == user.User_name)  RepeatFlag = true;
            }
            if (RepeatFlag) 
            {
                ErrLable.Text = "Данное имя занято!";
                ErrLable.ForeColor = Color.Red;
                return;
            }
            userServise.Create(Setuser);
            
            ErrLable.ForeColor = Color.WhiteSmoke;
            Program.CloseReg();
            this.Close();
            this.Dispose();
            Console.WriteLine("RegForm_Close");
        }

        private void UserPassBox_MouseClick(object sender, MouseEventArgs e)
        {
            UserPassBox.Text = null;
            UserPassBox.ForeColor = Color.Black;
        }
    }
}

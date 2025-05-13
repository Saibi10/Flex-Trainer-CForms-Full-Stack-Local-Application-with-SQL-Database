using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class TrainerrequestDiv : UserControl
    {
        #region Properties
        public event EventHandler acceptBtn;
        public event EventHandler declineBtn;
        private int memberid;
        private string name;
        private string speclization;
        private string gender;
        private string contact;
        private string email;

        public int get_set_memberid
        {
            get
            {
                return memberid;
            }
            set
            {
                memberid = value;
            }
        }

        public string get_set_name
        {
            get
            { 
                return name; 
            } 
            set
            {
                name = value;
                edit_owner_name.Text = value;
            }
        }
        public string get_set_speclization
        {
            get
            {
                return speclization;
            }
            set
            {
                speclization = value;
                edit_spec.Text = value;
            }
        }

        public string get_set_gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
                edit_gender.Text = value;
            }
        }
        public string get_set_contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
                edit_phone_number.Text = value;
            }
        }

        public string get_set_email
        { 
            get
            {
                return email;
            }
            set
            {
                email = value;
                edit_email.Text = value;
            }
        }


        #endregion
        public TrainerrequestDiv()
        {
            InitializeComponent();
        }

        private void edit_gym_name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            acceptBtn?.Invoke(this, e);
        }

        private void decline_button_Click(object sender, EventArgs e)
        {
            declineBtn?.Invoke(this, e);
        }
    }
}

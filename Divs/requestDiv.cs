using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class requestDiv : UserControl
    {
        #region Properties
        public event EventHandler acceptBtn;
        public event EventHandler declineBtn;
        private string name;
        private string gymname;
        private string gymaddress;
        private string contactnumber;
        private string price;
        private int userid;

        public int get_set_userid
        {
            set
            {
                userid = value;
            }
            get
            {
                return userid;
            }

        }

        public string get_set_name
        {
            set
            {
                name = value;
                edit_owner_name.Text = value;  
            }
            get
            {
                return name;
            }
        }
        public string get_set_gymname
        {
            set
            {
                gymname = value;
                edit_gym_name.Text = value;
            }
            get
            {
                return gymname;
            }
        }

        public string get_set_gymaddress
        {
            set
            {
                gymaddress = value;
                edit_address.Text = value;
            }
            get
            {
                return gymaddress;
            }
        }

        public string get_set_contactnumber
        {
            set
            {
                contactnumber = value;
                edit_phone_number.Text = value;
            }
            get
            {
                return contactnumber;
            }
        }

        public string get_set_price
        {
            set
            {
                price = value;
                edit_price.Text = value;
            }
            get
            {
                return price;
            }
        }


        #endregion

        public requestDiv()
        {
            InitializeComponent();
        }

        private void owner_name_Click(object sender, EventArgs e)
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
            declineBtn?.Invoke(this, e); ;
        }
    }
}

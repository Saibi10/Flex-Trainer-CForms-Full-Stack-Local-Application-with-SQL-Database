using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class removeDiv : UserControl
    {

        #region Properties

        public event EventHandler removeBtn;
        private string username;
        private int ownerid;
        private int gymid;
        private string gymname;
        private string ownername;
        private string contactno;
        private string address;

        public string get_set_username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public int get_set_userid
        {
            get
            {
                return ownerid;
            }
            set
            {
                ownerid = value;
            }
        }

        public int get_set_gymid
        {
            get
            {
                return gymid;
            }
            set
            {
                gymid = value;
            }
        }

        public string get_set_gymname
        {
            get
            {
                return gymname;
            }
            set 
            {
                gymname = value;
                edit_gymname.Text = value;
            }
        }

        public string get_set_ownername
        {
            get
            {
                return ownername;
            }
            set
            {
                ownername = value;
                edit_owner_name.Text = value;
            }
        }

        public string get_set_contactno
        {
            get
            {
                return contactno;
            }
            set
            {
                contactno = value;
                edit_phone.Text = value;
            }
        }

        public string get_set_address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                edit_address.Text = value;
            }
        }


        #endregion
        public removeDiv()
        {
            InitializeComponent();
        }

        private void decline_button_Click(object sender, EventArgs e)
        {
            removeBtn?.Invoke(this, e);
        }
    }
}

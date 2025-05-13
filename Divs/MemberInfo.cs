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
    public partial class MemberInfo : UserControl
    {
        #region Properties
        public event EventHandler removeBtn;
        private int memberid;
        private string fullname;
        private string contact;
        private string gender;
        private string email;
        private string duration;

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

        public string get_set_fullname
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
                member_name.Text = value;
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
                member_contact.Text = value;
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
                mem_gender.Text = value;
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
                member_email.Text = value;
            }
        }
        public string get_set_duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
                member_duration.Text = value;
            }
        }

        #endregion
        public MemberInfo()
        {
            InitializeComponent();
        }

        private void member_name_Click(object sender, EventArgs e)
        {

        }

        private void decline_button_Click(object sender, EventArgs e)
        {
            removeBtn?.Invoke(this, e);
        }
    }
}

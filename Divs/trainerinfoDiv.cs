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
    public partial class trainerinfoDiv : UserControl
    {
        #region Properties
        public event EventHandler viewBtn;
        private string name;
        private string speclization;
        private int id;
        private string phone;
        private string gender;
        private string username;

        public string get_set_name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                edit_name.Text = value;
            }
        }

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

        public string get_set_speclization
        {
            get
            {
                return speclization;
            }
            set
            {
                speclization = value;
                edit_speclization.Text = value;
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
            }
        }

        public string get_set_phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public int get_set_id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }


        #endregion
        public trainerinfoDiv()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            viewBtn?.Invoke(this,e);
        }
    }
}

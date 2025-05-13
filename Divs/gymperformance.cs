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
    public partial class gymperformance : UserControl
    {

        #region Properties
        public event EventHandler viewBtn;
        private string gymname;
        private string location;
        private int gymid;
        private int ownerid;
        private int price;

        public string get_set_gymname
        {
            get
            {
                return gymname;
            }
            set
            {
                gymname = value;
                edit_gym_name.Text = gymname;
            }
        }
        public string get_set_location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
                edit_location.Text = location;
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
        public int get_set_ownerid
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
        public int get_set_price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


        #endregion
        public gymperformance()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            viewBtn?.Invoke(this, e);
        }
    }
}

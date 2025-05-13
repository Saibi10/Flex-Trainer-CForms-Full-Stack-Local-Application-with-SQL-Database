using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer.Divs
{
    public partial class feedbackdiv : UserControl
    {
        #region Properties

        private string name;
        private string description;
        private string date;

        public string get_set_name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                member_name.Text = value;
            }
        }

        public string get_set_description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                feedback_detail.Text = value;
            }
        }

        public string get_set_date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                date_time.Text = value;
            }
        }
        #endregion
        public feedbackdiv()
        {
            InitializeComponent();
        }
    }
}

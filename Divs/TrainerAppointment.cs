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
    public partial class TrainerAppointment : UserControl
    {

        #region Properties

        public event EventHandler detail;

        private string date;
        private string memName;

        public string getSetDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                dateLabel.Text = value;
            }
        }

        public string getSetmemName
        {
            get
            {
                return memName;
            }
            set
            {
                memName = value;
                memberNameLbl.Text = value;
            }
        }


        #endregion
        public TrainerAppointment()
        {
            InitializeComponent();
        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            detail?.Invoke(this, e);
        }

    }
}

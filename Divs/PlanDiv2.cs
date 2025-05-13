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
    public partial class PlanDiv2 : UserControl
    {
        #region Properties
        public event EventHandler detailBtn;
        public event EventHandler planSubBtn;
        private int planid;
        private string planName;
        private string ownername;

        public int get_set_planid
        {
            get
            {
                return planid;
            }
            set
            {
                planid = value;
            }
        }

        public string get_set_planName
        {
            get
            {
                return planName;
            }
            set
            {
                planName = value;
                planNameLbl.Text = value;
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
                creatorNameLbl.Text = value;
            }
        }



        #endregion

        public PlanDiv2()
        {
            InitializeComponent();
        }

        private void planDetailBtn_Click(object sender, EventArgs e)
        {
            detailBtn?.Invoke(this, e);
        }

        private void planSubscriberBtn_Click(object sender, EventArgs e)
        {
            planSubBtn?.Invoke(this, e);
        }
    }
}

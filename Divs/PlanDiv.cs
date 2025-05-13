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
    public partial class PlanDiv : UserControl
    {
        #region Properties

        public event EventHandler detailBtn;
        public event EventHandler subBtn;

        private string id;
        private string planName;
        private string creatorName;

        public string getSetId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                idLbl.Text = value;
            }
        }

        public string getSetplanName
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
        public string getSetcreatorName
        {
            get
            {
                return creatorName;
            }
            set
            {
                creatorName = value;
                creatorNameLbl.Text = value;
            }
        }

        #endregion
        public PlanDiv()
        {
            InitializeComponent();
        }

        private void planDetailBtn_Click(object sender, EventArgs e)
        {
            detailBtn?.Invoke(this, e);
        }

        private void subscribeBtn_Click(object sender, EventArgs e)
        {
            subBtn?.Invoke(this, e);
        }
    }
}

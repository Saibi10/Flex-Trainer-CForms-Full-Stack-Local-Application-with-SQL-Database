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

    public partial class SubscribedMember : UserControl
    {

        #region Properties

        public event EventHandler kickBtn;

        private string memberName;
        private string memberId;
        private string phone;
        private string gender;

        public string getSetMemName
        {
            get
            {
                return memberName;
            }
            set
            {
                memberName = value;
                memberNameLbl.Text = value;
            }
        }

        public string getSetPhone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                phoneLbl.Text = value;
            }
        }

        public string getSetGender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
                genderLbl.Text = value;
            }
        }

        public string getSetMemberId
        {
            get
            {
                return memberId;
            }
            set
            {
                memberId = value;
            }
        }



        #endregion
        public SubscribedMember()
        {
            InitializeComponent();
        }

        private void kickMemberBtn_Click(object sender, EventArgs e)
        {
            kickBtn?.Invoke(this, e);
        }
    }
}

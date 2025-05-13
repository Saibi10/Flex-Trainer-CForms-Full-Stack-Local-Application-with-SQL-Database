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
    public partial class meal : UserControl
    {
        #region Properties
        private string planname;
        private string planDetails;
        private string protein;
        private string carbo;
        private string fats;
        private string fiber;

        public string get_set_planname
        {
            get
            {
                return planname;
            }
            set
            {
                planname = value;
                planNameLbl.Text = planname;
            }
        }
        public string get_set_plandetails
        {
            get
            {
                return planDetails;
            }
            set
            {
                planDetails = value;
                label1.Text = value;
            }
        }

        public string get_set_protein
        {
            get
            {
                return protein;
            }
            set
            {
                protein = value;
                protein_edit.Text = value;
            }
        }

        public string get_set_carbo
        {
            get
            {
                return carbo;
            }
            set
            {
                carbo = value;
                carbo_edit.Text = value;
            }
        }

        public string get_set_fats
        {
            get
            {
                return fats;
            }
            set
            {
                fats = value;
                fats_edit.Text = value;
            }
        }

        public string get_set_fiber
        {
            get
            {
                return fiber;
            }
            set
            {
                fiber = value;
                fiber_edit.Text = value;
            }
        }
        #endregion
        public meal()
        {
            InitializeComponent();
        }
    }
}

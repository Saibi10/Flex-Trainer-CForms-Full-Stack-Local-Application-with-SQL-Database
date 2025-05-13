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
    public partial class exercise : UserControl
    {

        #region Properties
        private string planname;
        private string planDetails;
        private string sets;
        private string reps;
        private string restIntervals;
        private string muscle;
        private string machine;

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

        public string get_set_sets
        {
            get
            {
                return sets;
            }
            set
            {
                sets = value;
                sets_edit.Text = value;
            }
        }

        public string get_set_reps
        {
            get
            {
                return reps;
            }
            set
            {
                reps = value;
                reps_edit.Text = value;
            }
        }

        public string get_set_restIntervals
        {
            get
            {
                return restIntervals;
            }
            set
            {
                restIntervals = value;
                rest_edit.Text = value;
            }
        }

        public string get_set_muscle
        {
            get
            {
                return muscle;
            }
            set
            {
                muscle = value;
                muscle_edit.Text = value;
            }
        }

        public string get_set_machine
        {
            get
            {
                return machine;
            }
            set
            {
                machine = value;
                edit_machine.Text = value;
            }
        }
        #endregion
        public exercise()
        {
            InitializeComponent();
        }
    }
}

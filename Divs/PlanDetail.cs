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
    public partial class PlanDetail : UserControl
    {
        #region Properties

        private string planName;
        private string planDesc;
        private string creatorName;
        private string exerciseName;
        private string exerciseDesc;
        private string setNum;
        private string restNum;
        private string targetMuscle;
        private string reps;

        public string getSetPlanName
        {
            get { return planName; }
            set
            {
                planName = value;
                planName1.Text = value;
            }
        }

        public string getSetPlanDesc
        {
            get { return planDesc; }
            set
            {
                planDesc = value;
                planDesc1.Text = value;
            }
        }

        public string getSetCreatorName
        {
            get { return creatorName; }
            set
            {
                creatorName = value;
                creatorName1.Text = value;
            }
        }

        public string getSetExerciseName
        {
            get { return exerciseName; }
            set
            {
                exerciseName = value;
                exerciseName1.Text = value;
            }
        }

        public string getSetExerciseDesc
        {
            get { return exerciseDesc; }
            set
            {
                exerciseDesc = value;
                exerciseDesc1.Text = value;
            }
        }

        public string getSetSetNum
        {
            get { return setNum; }
            set
            {
                setNum = value;
                setNum1.Text = value;
            }
        }

        public string getSetRestNum
        {
            get { return restNum; }
            set
            {
                restNum = value;
                rest1.Text = value;
            }
        }

        public string getSetTargetMuscle
        {
            get { return targetMuscle; }
            set
            {
                targetMuscle = value;
                muscle1.Text = value;
            }
        }

        public string getSetReps
        {
            get { return reps; }
            set
            {
                reps = value;
                reps1.Text = value;
            }
        }

        #endregion

        public PlanDetail()
        {
            InitializeComponent();
        }

    }
}

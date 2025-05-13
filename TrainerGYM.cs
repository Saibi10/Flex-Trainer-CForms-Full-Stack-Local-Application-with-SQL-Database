using Flex_Trainer.Classes;
using Flex_Trainer.Divs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Flex_Trainer
{

    public partial class TrainerGYM : Form
    {
        DB_Access database = new DB_Access();
        bool alreadyExist = false;
        public string username { get; set; }
        public string name { get; set; }
        public int trainerid { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string specialization { get; set; }

        public string email { get; set; }

        public int gymid { get; set; }

        Form1 mainForm;

        private static string ConvertToCustomFormat(string dateString)
        {
            // Parse the input string into a DateTime object
            DateTime date = DateTime.ParseExact(dateString, "dddd, MMMM d, yyyy", System.Globalization.CultureInfo.InvariantCulture);

            // Format the DateTime object into the desired format
            string formattedDate = date.ToString("yyyy-M-d");

            return formattedDate;
        }

        public TrainerGYM(Form1 t)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mainForm = t;
            feedback_view.Hide();
            drop_down.Hide();
            edit_rating.KeyPress += numericTextBox_KeyPress;
            edit_carbo.KeyPress += numericTextBox_KeyPress;
            edit_cal.KeyPress += numericTextBox_KeyPress;
            cal_dropdown.Hide();
            dropdown_carbo.Hide();
            dropdown_Set.Hide();
            

        }

        private void trainer_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trainer_tab.SelectedTab.Name == "profile_tab")
            {
                string query = "select * from gym where gymid = '" + gymid + "'";
                DataTable dt = database.search_to_check(query);
                edit_gym_name.PlaceholderText = dt.Rows[0][1].ToString();

                query = "select * from account where username = '" + username + "'";
                dt = database.search_to_check(query);
                email_txt.PlaceholderText = dt.Rows[0][2].ToString();

                edit_username.PlaceholderText = username;
                edit_name.Text = name;
                edit_phone.PlaceholderText = phone;
                edit_gender.PlaceholderText = gender;

            }
            else if (trainer_tab.SelectedTab.Name == "feedback_tab")
            {
                flow_gym_feedback.Controls.Clear();
                header_trainer_name.Text = name;
                string query = "select * from feedback where trainer_name = '" + username + "'";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    query = "select * from member where username = '" + dt.Rows[i][3] + "'";
                    DataTable dt2 = database.search_to_check(query);
                    feedbackdiv feedback = new feedbackdiv()
                    {
                        get_set_name = dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][3].ToString(),
                        get_set_description = dt.Rows[i][2].ToString(),
                        get_set_date = "Rating = " + dt.Rows[i][5].ToString(),
                    };
                    flow_gym_feedback.Controls.Add(feedback);
                }
            }
            else if(trainer_tab.SelectedTab.Name == "workout_tab")
            {
                dropdown_targetMuscle.Items.Clear();
                machine_dropdown.Items.Clear();

                string q = "select target_muscle " +
                    "from exercise " +
                    "group by target_muscle";
                DataTable d = database.search_to_check(q);
                dropdown_targetMuscle.Items.Add("Target Muscle");

                for (int i = 0; i < d.Rows.Count; ++i)
                {
                    dropdown_targetMuscle.Items.Add(d.Rows[i][0].ToString());
                }
                dropdown_targetMuscle.SelectedIndex = 0;

                q = "select exercise.machine " +
                    "from exercise " +
                    "where exercise.machine != 'N/A' " +
                    "group by machine";
                d = database.search_to_check(q);
                machine_dropdown.Items.Add("Specfic Machine");
                machine_dropdown.Items.Add("No Machine");
                for (int i = 0; i < d.Rows.Count; ++i)
                {
                    machine_dropdown.Items.Add(d.Rows[i][0].ToString());
                }
                machine_dropdown.SelectedIndex = 0;


                workout_Flow.Controls.Clear();
                string query = "select * from workout_plan where creator = '" + username + "'";
                DataTable dt = database.search_to_check(query);
                for(int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = name,
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += showPlanDetails;
                    plan.planSubBtn += show_subscriber_diet;

                    workout_Flow.Controls.Add(plan);
                }

                query = "select workout_plan.plan_id , workout_plan.plan_name , workout_plan.details , workout_plan.creator, CONCAT(member.firstname ,' '  , member.lastname)" +
                    "from workout_plan " +
                    "join member on member.username = workout_plan.creator";
                dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = dt.Rows[i][4].ToString(),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };

                    plan.detailBtn += showPlanDetails;
                    plan.planSubBtn += show_subscriber_diet;

                    workout_Flow.Controls.Add(plan);
                }
            }
            else if(trainer_tab.SelectedTab.Name == "DietPlan_tab")
            {
                diet_plan_flow.Controls.Clear();
                string query = "select * from diet_plan where creator = '" + username + "'";
                DataTable dt = database.search_to_check(query);
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = name,
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += showDietPlanDetails;
                    plan.planSubBtn += show_subscriber_workout;
                    diet_plan_flow.Controls.Add(plan);
                }

                query = "select plan_id , plan_name , details , creator , CONCAT(member.firstname , ' '  , member.lastname) " +
                    "from diet_plan " +
                    "join member on member.username = creator;";
                dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = dt.Rows[i][4].ToString(),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };

                    plan.detailBtn += showDietPlanDetails;
                    plan.planSubBtn += show_subscriber_workout;
                    diet_plan_flow.Controls.Add(plan);
                }
            }
            else if (trainer_tab.SelectedTab.Name == "appointment_tab")
            {
                appointmentFlow.Controls.Clear();

                string getId = $"select * from trainer where username = '{username}'";
                DataTable dt = database.search_to_check(getId);

                string getApps = $"select * from appointment where trainer_id = '{int.Parse(dt.Rows[0][0].ToString())}'";
                dt = database.search_to_check(getApps);

                if (dt.Rows.Count == 0)
                {
                    noAppointmentPanel.Show();
                    appointmentPanel.Hide();
                }
                else
                {
                    noAppointmentPanel.Hide();
                    appointmentPanel.Show();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string getMemName = $"select * from member where userid = {int.Parse(dt.Rows[i][2].ToString())}";
                        DataTable dt2 = database.search_to_check(getMemName);

                        TrainerAppointment app = new TrainerAppointment()
                        {
                            getSetDate = dt.Rows[i][1].ToString(),
                            getSetmemName = dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][3].ToString()
                        };
                        appointmentFlow.Controls.Add(app);
                        app.detail += viewAppointmentDetail;
                    }
                }
            }
            else if (trainer_tab.SelectedTab.Name == "createPlan_tab")
            {
                createWorkoutPlanPanel.Hide();
                createDietPlanPanel.Hide();
            }
        }

        private void show_subscriber_diet(object sender, EventArgs e)
        {
            memberListFlow.Controls.Clear();
            trainer_tab.SelectTab("planSubscriber_tab");
            PlanDiv2 plan = (PlanDiv2)sender;

            string getMembers = $"select * from member_diet where diet_plan_id = '{plan.get_set_planid}'";
            DataTable dt = database.search_to_check(getMembers);
            int numMems = dt.Rows.Count;

            if (numMems == 0)
            {
                noSubsPanel.Show();
                memberSubsPanel.Hide();
            }
            else
            {
                noSubsPanel.Hide();
                memberSubsPanel.Show();
            }

            if (numMems != 0)
            {
                noSubsPanel.Hide();
                memberSubsPanel.Show();

                for (int i = 0; i < numMems; ++i)
                {
                    string getMember = $"select * from member where userid = {dt.Rows[i][0]}";
                    DataTable dt2 = database.search_to_check(getMember);
                    SubscribedMember member = new SubscribedMember()
                    {
                        getSetMemName = dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][3].ToString(),
                        getSetGender = dt2.Rows[0][4].ToString(),
                        getSetPhone = dt2.Rows[0][5].ToString(),
                        getSetMemberId = dt2.Rows[0][0].ToString()
                    };
                    memberListFlow.Controls.Add(member);
                    member.kickBtn += kickMemberDiet;
                }
            }

        }
        private void show_subscriber_workout(object sender, EventArgs e)
        {

            memberListFlow.Controls.Clear();
            trainer_tab.SelectTab("planSubscriber_tab");
            PlanDiv2 plan = (PlanDiv2)sender;


            string getMembers = $"select * from member_workout where workout_plan = '{plan.get_set_planid}'";
            DataTable dt = database.search_to_check(getMembers);
            int numMems = dt.Rows.Count;

            if (numMems == 0)
            {
                noSubsPanel.Show();
                memberSubsPanel.Hide();
            }
            else
            {
                noSubsPanel.Hide();
                memberSubsPanel.Show();
            }

            for (int i = 0; i < numMems; ++i)
            {
                string getMember = $"select * from member where userid = {dt.Rows[i][0]}";
                DataTable dt2 = database.search_to_check(getMember);
                SubscribedMember member = new SubscribedMember()
                {
                    getSetMemName = dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][3].ToString(),
                    getSetGender = dt2.Rows[0][4].ToString(),
                    getSetPhone = dt2.Rows[0][5].ToString(),
                    getSetMemberId = dt2.Rows[0][0].ToString()
                };
                memberListFlow.Controls.Add(member);
                member.kickBtn += kickMemberWorkout;
            }
            return;
        }


        private void edit_targetmuscle_SelectedIndexChanged(object sender, EventArgs e)
        {

            workout_Flow.Controls.Clear();
            string item = dropdown_targetMuscle.SelectedItem.ToString();

            if (item == "Target Muscle")
                return;
            string query = "select workout_plan.plan_id " +
                "from workout_plan " +
                "join exercise on exercise.plan_id = workout_plan.plan_id " +
                "where workout_plan.creator = '"+username+"' AND exercise.target_muscle = '"+item+"' " +
                "group by workout_plan.plan_id";
            DataTable dt = database.search_to_check(query);
            for(int i = 0; i  < dt.Rows.Count; ++i)
            {
                query = "select * from workout_plan where plan_id = '" + dt.Rows[0][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                PlanDiv2 plan = new PlanDiv2()
                {
                    get_set_planid = int.Parse(dt2.Rows[0][0].ToString()),
                    get_set_ownername = name,
                    get_set_planName = dt2.Rows[0][1].ToString(),
                };
                plan.detailBtn += showPlanDetails;
                plan.planSubBtn += show_subscriber_workout;

                workout_Flow.Controls.Add(plan);
            }

            query = "select workout_plan.plan_id , workout_plan.plan_name , workout_plan.details , workout_plan.creator , CONCAT(member.firstname , ' '  , member.lastname) " +
                "from workout_plan " +
                "join member on member.username = workout_plan.creator;";
            dt = database.search_to_check(query);

            for(int i =0; i < dt.Rows.Count; ++i)
            {
                query = "select *  " +
                    "from workout_plan  " +
                    "join exercise on exercise.plan_id = workout_plan.plan_id " +
                    "where exercise.target_muscle = '" + item + "' and workout_plan.plan_id = '" + dt.Rows[0][0] + "';";
                DataTable dt2 = database.search_to_check(query) ;
                if(dt2.Rows.Count > 0)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = dt.Rows[i][4].ToString(),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };

                    plan.detailBtn += showPlanDetails;
                    plan.planSubBtn += show_subscriber_workout;

                    workout_Flow.Controls.Add(plan);
                }
            }
        }
        private void viewAppointmentDetail(object sender, EventArgs e)
        {

            TrainerAppointment appDetail = (TrainerAppointment)sender;
            trainer_tab.SelectTab("appointmentDetail_tab");

            string memName = appDetail.getSetmemName;
            string appdate = appDetail.getSetDate;

            appDetailMemberName.Text = memName;
            appDetailDate.Text = appdate;

            appDetailDateChange.Hide();
            appDetailChangeDateDone.Hide();

        }
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            dropdown_Set.Hide();
            if (edit_Set.Text == "")
                return;

            int value = int.Parse(edit_Set.Text);

            workout_Flow.Controls.Clear();
            string query = "select * from workout_plan where creator = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from exercise where plan_id = '" + dt.Rows[0][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                int totalsets = 0;
                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    totalsets = totalsets + int.Parse(dt2.Rows[j][4].ToString());
                }
                if (totalsets < value)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = name,
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += showPlanDetails;
                    plan.planSubBtn += show_subscriber_workout;

                    workout_Flow.Controls.Add(plan);
                }
            }

            query = "select workout_plan.plan_id , workout_plan.plan_name , workout_plan.details , workout_plan.creator, CONCAT(member.firstname , member.lastname)" +
                    "from workout_plan " +
                    "join member on member.username = workout_plan.creator";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from exercise where plan_id = '" + dt.Rows[0][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                int totalsets = 0;
                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    totalsets = totalsets + int.Parse(dt2.Rows[j][4].ToString());
                }
                PlanDiv2 plan = new PlanDiv2()
                {
                    get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_ownername = dt.Rows[i][4].ToString(),
                    get_set_planName = dt.Rows[i][1].ToString(),
                };

                plan.detailBtn += showPlanDetails;
                plan.planSubBtn += show_subscriber_workout;

                workout_Flow.Controls.Add(plan);
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            dropdown_carbo.Hide();
            if (edit_carbo.Text == "")
                return;
            diet_plan_flow.Controls.Clear();
            
            int value = int.Parse(edit_carbo.Text);

           
            string query = "select * from diet_plan where creator = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from meals where plan_id = '" + dt.Rows[0][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                float totalCarbs = 0;
                for(int j = 0; j < dt2.Rows.Count; ++j)
                {
                    totalCarbs = totalCarbs + float.Parse(dt2.Rows[j][6].ToString());
                }
                if (totalCarbs < value)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = name,
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += showDietPlanDetails;
                    plan.planSubBtn += show_subscriber_diet;

                    diet_plan_flow.Controls.Add(plan);
                }
            }

            query = "select plan_id , plan_name , details , creator , CONCAT(member.firstname , ' '  , member.lastname) " +
                    "from diet_plan " +
                    "join member on member.username = creator;";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from meals where plan_id = '" + dt.Rows[0][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                float totalCarbs = 0;
                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    totalCarbs = totalCarbs + float.Parse(dt2.Rows[j][6].ToString());
                }
                if (totalCarbs < value)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = dt.Rows[i][4].ToString(),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };

                    plan.planSubBtn += show_subscriber_diet;
                    plan.detailBtn += showDietPlanDetails;
                    diet_plan_flow.Controls.Add(plan);
                }
            }
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            cal_dropdown.Hide();
            if (edit_cal.Text == "")
                return;
            diet_plan_flow.Controls.Clear();
            int value = int.Parse(edit_cal.Text);

            string query = "select * from diet_plan where creator = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from meals where plan_id = '" + dt.Rows[0][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                float totalCarbs = 0;
                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    totalCarbs = totalCarbs + float.Parse(dt2.Rows[j][3].ToString());
                }
                if (totalCarbs < value)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = name,
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += showPlanDetails;
                    plan.planSubBtn += show_subscriber_diet;
                    diet_plan_flow.Controls.Add(plan);
                }
            }

            query = "select plan_id , plan_name , details , creator , CONCAT(member.firstname , ' '  , member.lastname) " +
                    "from diet_plan " +
                    "join member on member.username = creator;";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from meals where plan_id = '" + dt.Rows[0][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                float totalCarbs = 0;
                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    totalCarbs = totalCarbs + float.Parse(dt2.Rows[j][3].ToString());
                }
                if (totalCarbs < value)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = dt.Rows[i][4].ToString(),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };

                    plan.detailBtn += showDietPlanDetails;
                    plan.planSubBtn += show_subscriber_diet;

                    diet_plan_flow.Controls.Add(plan);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            feedback_view.Show();
            string query = "select * from gym_review where gym_id = '" + gymid + "' and Username = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            if (dt.Rows.Count > 0)
            {
                edit_rating.Text = dt.Rows[0][3].ToString();
                edit_description.Text = dt.Rows[0][4].ToString();
                alreadyExist = true;
                login_button.Text = "Edit";
            }

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (edit_rating.Text == "")
            {
                error_label_tab1.Text = "Required";
                return;
            }
            if (int.Parse(edit_rating.Text) > 10 || int.Parse(edit_rating.Text) < 0)
            {
                error_label_tab1.Text = "Must be < 10";
                return;
            }
            if (alreadyExist == true)
            {
                string query = "update gym_review " +
                    " set rating = '" + edit_rating.Text + "' ,details = '" + edit_description.Text + "'  " +
                    " where Username = '" + username + "' and gym_id = '" + gymid + "'";
                database.query_data(query);
            }
            else
            {
                string query = "insert into gym_review values (" +
                    "'" + gymid + "' , '" + username + "' , '" + edit_rating.Text + "' , '" + edit_description.Text + "')";
                database.query_data(query);
            }
            feedback_view.Hide();
            login_button.Text = "Submit";
            alreadyExist = false;
        }
     
        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("profile_tab");
            drop_down.Hide();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            drop_down.Show();
        }

        private void showPlanDetails(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("plandetail_tab");
            PlanDiv2 plan = (PlanDiv2)sender;
            
            string query = "select * from exercise where plan_id = '" + plan.get_set_planid + "'";
            DataTable dt = database.search_to_check(query);
            workout_plan_flow.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string reps;
                if(dt.Rows[i][7] == null)
                {
                    reps = "0";
                }
                else
                {
                    reps = dt.Rows[i][7].ToString();
                }
                exercise ex = new exercise()
                {
                    get_set_planname = dt.Rows[i][3].ToString(),
                    get_set_plandetails = dt.Rows[i][2].ToString(),
                    get_set_reps = reps,
                    get_set_sets = dt.Rows[i][4].ToString(),
                    get_set_muscle = dt.Rows[i][6].ToString(),
                    get_set_restIntervals = dt.Rows[i][5].ToString(),
                    get_set_machine = dt.Rows[i][8].ToString(),
                };
                workout_plan_flow.Controls.Add(ex);
            }

        }

        private void showDietPlanDetails(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("plandetail_tab");
            PlanDiv2 plan = (PlanDiv2)sender;

            string query = "select * from meals where plan_id = '" + plan.get_set_planid + "'";
            DataTable dt = database.search_to_check(query);
            workout_plan_flow.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                meal me = new meal()
                {
                    get_set_planname = dt.Rows[i][2].ToString(),
                    get_set_plandetails = dt.Rows[i][7].ToString(),
                    get_set_protein = dt.Rows[i][3].ToString(),
                    get_set_fats = dt.Rows[i][4].ToString(),
                    get_set_carbo = dt.Rows[i][6].ToString(),
                    get_set_fiber = dt.Rows[i][5].ToString(),
                };
                workout_plan_flow.Controls.Add(me);
            }
        }

      

        private void kickMemberWorkout(object sender, EventArgs e)
        {
            SubscribedMember mem = (SubscribedMember)sender;

            string remMem = $"delete member_workout where member_id = '{mem.getSetMemberId}'";
            database.query_data(remMem);
            MessageBox.Show("Member Deleted");
            trainer_tab.SelectTab("workout_tab");
        }

        private void kickMemberDiet(object sender, EventArgs e)
        {
            SubscribedMember mem = (SubscribedMember)sender;

            string remMem = $"delete member_diet where member_id = '{mem.getSetMemberId}'";
            database.query_data(remMem);
            MessageBox.Show("Member Deleted");
            trainer_tab.SelectTab("DietPlan_tab");
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Rectangle tabBounds = drop_down.Bounds;


            drop_down.Visible = false;
            dropdown_carbo.Visible = false;
            cal_dropdown.Visible = false;
            dropdown_Set.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("workout_tab");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            dropdown_carbo.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            trainer_tab.SelectTab("DietPlan_tab");
            edit_carbo.Text = "";
            edit_cal.Text = "";
            diet_plan_flow.Controls.Clear();
            string query = "select * from diet_plan where creator = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv2 plan = new PlanDiv2()
                {
                    get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_ownername = name,
                    get_set_planName = dt.Rows[i][1].ToString(),
                };
                plan.detailBtn += showDietPlanDetails;
                plan.planSubBtn += show_subscriber_diet;

                diet_plan_flow.Controls.Add(plan);
            }

            query = "select plan_id , plan_name , details , creator , CONCAT(member.firstname , ' '  , member.lastname) " +
                "from diet_plan " +
                "join member on member.username = creator;";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv2 plan = new PlanDiv2()
                {
                    get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_ownername = dt.Rows[i][4].ToString(),
                    get_set_planName = dt.Rows[i][1].ToString(),
                };

                plan.detailBtn += showDietPlanDetails;
                plan.planSubBtn += show_subscriber_diet;

                diet_plan_flow.Controls.Add(plan);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            cal_dropdown.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            dropdown_Set.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dropdown_targetMuscle.SelectedIndex = 0;

            workout_Flow.Controls.Clear();
            string query = "select * from workout_plan where creator = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv2 plan = new PlanDiv2()
                {
                    get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_ownername = name,
                    get_set_planName = dt.Rows[i][1].ToString(),
                };
                plan.detailBtn += showPlanDetails;
                plan.planSubBtn += show_subscriber_workout;

                workout_Flow.Controls.Add(plan);
            }

            query = "select workout_plan.plan_id , workout_plan.plan_name , workout_plan.details , workout_plan.creator, CONCAT(member.firstname , member.lastname)" +
                "from workout_plan " +
                "join member on member.username = workout_plan.creator";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv2 plan = new PlanDiv2()
                {
                    get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_ownername = dt.Rows[i][4].ToString(),
                    get_set_planName = dt.Rows[i][1].ToString(),
                };

                plan.detailBtn += showPlanDetails;
                plan.planSubBtn += show_subscriber_workout;

                workout_Flow.Controls.Add(plan);
            }
        }

        private void username_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            trainer_tab.SelectTab("profile_tab");
        }


        private void appointmentDetailToAppointmentBtn_Click(object sender, EventArgs e)
        {
            trainer_tab.SelectedIndex = 1;
        }

        private void planTypeWorkout_Click_1(object sender, EventArgs e)
        {
            planTypePanel.Hide();
            createDietPlanPanel.Hide();
            createWorkoutPlanPanel.Show();
        }

        private void planTypeDiet_Click_1(object sender, EventArgs e)
        {
            planTypePanel.Hide();
            createWorkoutPlanPanel.Hide();
            createDietPlanPanel.Show();
        }

        private void createWorkoutBtn_Click(object sender, EventArgs e)
        {
            if (workoutPlanName.Text == "" || workoutPlanDesc.Text == "" || exerciseName.Text == "" || exerciseDesc.Text == "" || targetMuscle.Text == "" || Reps.Text == "" || setNum.Text == "" || restInterval.Text == "")
            {
                createWorkoutErrorLbl.ForeColor = Color.Red;
                createWorkoutErrorLbl.Text = "Please fill all the fields";
                return;
            }
            else
            {
                createWorkoutErrorLbl.Text = "";
            }

            string insertInPlan = $"insert into workout_plan values ('{workoutPlanName.Text}', '{workoutPlanDesc.Text}', '{username}')";
            database.query_data(insertInPlan);

            string getPlanId = $"select * from workout_plan where plan_name = '{workoutPlanName.Text}'";
            DataTable dt = database.search_to_check(getPlanId);

            string insertInExercise = $"insert into exercise values ('{dt.Rows[0][0].ToString()}', '{exerciseDesc.Text}', '{exerciseName.Text}', '{int.Parse(setNum.Text)}', '{int.Parse(restInterval.Text)}', '{targetMuscle.Text}', '{int.Parse(Reps.Text)}')";

            database.query_data(insertInExercise);

            MessageBox.Show("Plan Created");
        }

        private void createDietBtn_Click(object sender, EventArgs e)
        {
            if (createDietPlanName.Text == "" || createDietPlanDesc.Text == "" || mealName.Text == "" || mealDesc.Text == "" || fibreNum.Text == "" || carbNum.Text == "" || protienNum.Text == "" || fatNum.Text == "")
            {
                createDietErrorLbl.ForeColor = Color.Red;
                createDietErrorLbl.Text = "Please fill all the fields";
                return;
            }
            else
            {
                createDietErrorLbl.Text = "";
            }

            string insertInPlan = $"insert into diet_plan values ('{createDietPlanName.Text}', '{createDietPlanDesc.Text}', '{username}')";
            database.query_data(insertInPlan);

            string getPlanId = $"select * from diet_plan where plan_name = '{createDietPlanName.Text}'";
            DataTable dt = database.search_to_check(getPlanId);

            string insertInMeal = $"insert into meals values ('{dt.Rows[0][0].ToString()}', '{createDietPlanName.Text}', '{int.Parse(protienNum.Text)}', '{int.Parse(fatNum.Text)}', '{int.Parse(fibreNum.Text)}', '{int.Parse(carbNum.Text)}', '{createDietPlanDesc.Text}')";

            database.query_data(insertInMeal);

            string getMemId = $"select * from member where username = '{username}'";
            dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string getdietId = $"select * from diet_plan where plan_name = '{createDietPlanName.Text}'";
            dt = database.search_to_check(getdietId);

            string insertInMemDiet = $"insert into member_diet values ('{memId}','{dt.Rows[0][0]}')";
            database.query_data(insertInMemDiet);

            MessageBox.Show("Plan Created");

        }

        private void createDietToBack_Click(object sender, EventArgs e)
        {
            planTypePanel.Show();
            createDietPlanPanel.Hide();
        }

        private void createWorkoutToBack_Click(object sender, EventArgs e)
        {
            planTypePanel.Show();
            createWorkoutPlanPanel.Hide();
        }

        private void TrainerGYM_Load(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("DietPlan_tab");
            trainer_tab.SelectTab("appointment_tab");
        }

        private void changeAppDateBtn_Click(object sender, EventArgs e)
        {
            appDetailDateChange.Show();
            appDetailChangeDateDone.Show();
        }

        private void appDetailChangeDateDone_Click(object sender, EventArgs e)
        {
            string date = ConvertToCustomFormat(appDetailDateChange.Text);

            string originalString = appDetailMemberName.Text;
            string[] parts = originalString.Split(' ');
            string firstPart = parts[0];
            string secondPart = parts[1];

            string getMem = $"select * from member where firstname = '{firstPart}' and lastname = '{secondPart}'";
            DataTable dt = database.search_to_check(getMem);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string updateDate = $"update appointment set appointment_date = '{date}' where member_id = '{memId}'";
            database.query_data(updateDate);
            MessageBox.Show("Date Updated");
            appDetailDateChange.Hide();
            appDetailChangeDateDone.Hide();

            DateTime currentTime = DateTime.Now;

            // Convert current time to string with only the time part
            string currentTimeString = currentTime.ToString("HH:mm:ss");

            appDetailDate.Text = date + " " + currentTimeString;
        }

        private void cancelAppBtn_Click(object sender, EventArgs e)
        {
            string originalString = appDetailMemberName.Text;
            string[] parts = originalString.Split(' ');
            string firstPart = parts[0];
            string secondPart = parts[1];

            string getMem = $"select * from member where firstname = '{firstPart}' and lastname = '{secondPart}'";
            DataTable dt = database.search_to_check(getMem);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string deleteApp = $"delete appointment where member_id = '{memId}'";
            database.query_data(deleteApp);
            MessageBox.Show("Appointment Deleted");
            trainer_tab.SelectTab("appointment_tab");
        }

        private void planSubscribersToWorkoutPlanBtn_Click(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("workout_tab");
        }

        private void machine_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            workout_Flow.Controls.Clear();
            string item = machine_dropdown.SelectedItem.ToString();
            if (item == "Specfic Machine")
                return;
            if (item == "No Machine")
                item = "N/A";
            string query = "select workout_plan.plan_id " +
                "from workout_plan " +
                "join exercise on exercise.plan_id = workout_plan.plan_id " +
                "where workout_plan.creator = '" + username + "' AND exercise.machine = '" + item + "' " +
                "group by workout_plan.plan_id";

            DataTable dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from workout_plan where plan_id = '" + dt.Rows[i][0] + "'";
                DataTable dt2 = database.search_to_check(query);
                if (dt2.Rows.Count == 0)
                    continue;
                PlanDiv2 plan = new PlanDiv2()
                {
                    get_set_planid = int.Parse(dt2.Rows[0][0].ToString()),
                    get_set_ownername = name,
                    get_set_planName = dt2.Rows[0][1].ToString(),
                };
                plan.detailBtn += showPlanDetails;
                plan.planSubBtn += show_subscriber_workout;

                workout_Flow.Controls.Add(plan);
            }

            query = "select workout_plan.plan_id , workout_plan.plan_name , workout_plan.details , workout_plan.creator , CONCAT(member.firstname , ' '  , member.lastname) " +
                "from workout_plan " +
                "join member on member.username = workout_plan.creator;";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select *  " +
                    "from workout_plan  " +
                    "join exercise on exercise.plan_id = workout_plan.plan_id " +
                    "where exercise.machine = '" + item + "' and workout_plan.plan_id = '" + dt.Rows[i][0] + "';";
                DataTable dt2 = database.search_to_check(query);
                if (dt2.Rows.Count > 0)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_ownername = dt.Rows[i][4].ToString(),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };

                    plan.detailBtn += showPlanDetails;
                    plan.planSubBtn += show_subscriber_workout;

                    workout_Flow.Controls.Add(plan);
                }
            }
        }

        private void appointmentDetailToAppointmentBtn_Click_1(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("appointment_tab");
        }

        private void createWorkoutToBack_Click_1(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("createPlan_tab");
        }

        private void createDietToBack_Click_1(object sender, EventArgs e)
        {
            trainer_tab.SelectTab("createPlan_tab");
        }
    }
}

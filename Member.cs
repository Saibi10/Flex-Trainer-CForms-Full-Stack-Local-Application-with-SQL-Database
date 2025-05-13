using Flex_Trainer.Classes;
using Flex_Trainer.Divs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Flex_Trainer
{
    public partial class Member : Form
    {
        DB_Access database = new DB_Access();
        private static string ConvertToCustomFormat(string dateString)
        {
            // Parse the input string into a DateTime object
            DateTime date = DateTime.ParseExact(dateString, "dddd, MMMM d, yyyy", System.Globalization.CultureInfo.InvariantCulture);

            // Format the DateTime object into the desired format
            string formattedDate = date.ToString("yyyy-M-d");

            return formattedDate;
        }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string contactNo { get; set; }
        public string gender { get; set; }
        public string email { get; set; }

        Form1 mainForm { get; set; }

        public Member(Form1 A)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Member_Load;
            mainForm = A;
        }

        private void Member_Load(object sender, EventArgs e)
        {

            drop_down.Hide();
            string query = "select * from member where username = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            string phone = dt.Rows[0][4].ToString();

            string query2 = "select * from account where username = '" + username + "'";
            DataTable dt2 = database.search_to_check(query2);
            string email = dt2.Rows[0][2].ToString();

            string query3 = "select * from member where username = '" + username + "'";
            DataTable dt3 = database.search_to_check(query3);
            string gender = dt3.Rows[0][5].ToString();

            managePanel.Hide();
            DietPlanPanel.Hide();
            WorkoutPlansPanel.Hide();
            createWorkoutPlanPanel.Hide();
            createDietPlanPanel.Hide();

            Member_tab.SelectedIndex = 1;
            Member_tab.SelectedIndex = 0;

        }

        private void viewPlanDetailsWorkout(object sender, EventArgs e)
        {
            planDetailFlow.Controls.Clear();
            Member_tab.SelectedIndex = 7;

            PlanDiv plan = (PlanDiv)sender;

            string getPlan = $"select * from workout_plan where plan_name = '{plan.getSetplanName}' and creator = '{plan.getSetcreatorName}'";
            DataTable dt = database.search_to_check(getPlan);
            int pId = int.Parse(dt.Rows[0][0].ToString());

            string query = $"select * from exercise where plan_id = '{pId}'";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string reps;
                if (dt.Rows[i][7] == null)
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
                    get_set_machine = dt.Rows[i][7].ToString(),
                };
                planDetailFlow.Controls.Add(ex);
            }

        }

        private void viewPlanDetailsWorkout2(object sender, EventArgs e)
        {
            planDetailFlow.Controls.Clear();
            Member_tab.SelectedIndex = 7;

            PlanDiv4 plan = (PlanDiv4)sender;

            string getPlan = $"select * from workout_plan where plan_name = '{plan.getSetplanName}' and creator = '{plan.getSetcreatorName}'";
            DataTable dt = database.search_to_check(getPlan);
            int pId = int.Parse(dt.Rows[0][0].ToString());

            string query = $"select * from exercise where plan_id = '{pId}'";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                string reps;
                if (dt.Rows[i][7] == null)
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
                    get_set_machine = dt.Rows[i][7].ToString(),
                };
                planDetailFlow.Controls.Add(ex);
            }

        }

        private void viewPlanDetailsDiet(object sender, EventArgs e)
        {
            planDetailFlow.Controls.Clear();
            Member_tab.SelectedIndex = 7;

            PlanDiv plan = (PlanDiv)sender;

            string getPlan = $"select * from diet_plan where plan_name = '{plan.getSetplanName}' and creator = '{plan.getSetcreatorName}'";
            DataTable dt = database.search_to_check(getPlan);
            int pId = int.Parse(dt.Rows[0][0].ToString());

            string query = $"select * from meals where plan_id = '{pId}'";
            dt = database.search_to_check(query);

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
                planDetailFlow.Controls.Add(me);
            }
        }

        private void viewPlanDetailsDiet2(object sender, EventArgs e)
        {
            planDetailFlow.Controls.Clear();
            Member_tab.SelectedIndex = 7;

            PlanDiv4 plan = (PlanDiv4)sender;

            string getPlan = $"select * from diet_plan where plan_name = '{plan.getSetplanName}' and creator = '{plan.getSetcreatorName}'";
            DataTable dt = database.search_to_check(getPlan);
            int pId = int.Parse(dt.Rows[0][0].ToString());

            string query = $"select * from meals where plan_id = '{pId}'";
            dt = database.search_to_check(query);

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
                planDetailFlow.Controls.Add(me);
            }
        }

        private void subsrcibePlanWorkout(object sender, EventArgs e)
        {
            PlanDiv plan = (PlanDiv)sender;
            string planName = plan.getSetplanName;

            string getPlan = $"select * from workout_plan where plan_name = '{planName}' and creator = '{plan.getSetcreatorName}'";
            DataTable dt = database.search_to_check(getPlan);

            int planId = int.Parse(dt.Rows[0][0].ToString());

            string getMem = $"select * from member where username = '{username}'";
            dt = database.search_to_check(getMem);

            int userId = int.Parse(dt.Rows[0][0].ToString());

            string subPlan = $"insert into member_workout values ('{userId}', '{planId}')";
            database.query_data(subPlan);

            MessageBox.Show("Plan Subscribed");
            Member_tab.SelectTab("myPlansTab");
        }

        private void subsrcibePlanDiet(object sender, EventArgs e)
        {
            PlanDiv plan = (PlanDiv)sender;
            string planName = plan.getSetplanName;

            string getPlanD = $"select * from diet_plan where plan_name = '{planName}'";
            DataTable dtD = database.search_to_check(getPlanD);

            int planIdD = int.Parse(dtD.Rows[0][0].ToString());

            string getMemD = $"select * from member where username = '{username}'";
            dtD = database.search_to_check(getMemD);

            int userIdD = int.Parse(dtD.Rows[0][0].ToString());

            string subPlanD = $"insert into member_diet values ('{userIdD}', '{planIdD}')";
            database.query_data(subPlanD);

            MessageBox.Show("Plan Subscribed");
            Member_tab.SelectTab("myPlansTab");

        }

        private void Member_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Member_tab.SelectedIndex == 0) // Profile
            {
                usernameLbl.Text = username;
                edit_name.Text = firstname + " " + lastname;
                edit_username.Text = username;

                edit_phone.Text = contactNo;
                edit_gender.Text = gender;
                email_txt.Text = email;

                becomeTrainerPanel.Hide();
                profilePanel.Show();
            }
            else if (Member_tab.SelectedIndex == 6) //My Plans
            {
                DietFlow.Controls.Clear();
                workoutFlow.Controls.Clear();

                string query = $"SELECT CASE WHEN EXISTS (SELECT 1 FROM member_workout WHERE member_id = m.userid) OR EXISTS (SELECT 1 FROM member_diet WHERE member_id = m.userid) THEN 'Yes' ELSE 'No' END AS Has_Plans FROM member m WHERE username = '{username}';";
                DataTable dt3 = database.search_to_check(query);
                string isAvailable = dt3.Rows[0][0].ToString();
                if (isAvailable == "No")
                {
                    //233, 17;
                    noPlanPanel.Show();
                    myPlanLbl.Hide();
                    workoutPanel.Hide();
                    dietPanel.Hide();
                    DietFlow.Hide();
                    workoutFlow.Hide();
                    return;
                }
                else
                {
                    noPlanPanel.Hide();
                    myPlanLbl.Show();
                    workoutPanel.Show();
                    dietPanel.Show();
                    DietFlow.Show();
                    workoutFlow.Show();
                    string query2 = $"SELECT dp.* FROM diet_plan dp INNER JOIN member_diet md ON dp.plan_id = md.diet_plan_id INNER JOIN member m ON md.member_id = m.userid WHERE m.username = '{username}';";
                    DataTable dt = database.search_to_check(query2);

                    if (dt.Rows.Count == 0)
                    {
                        dietPanel.Hide();
                        DietFlow.Hide();
                        workoutPanel.Location = new System.Drawing.Point(dietPanel.Location.X, dietPanel.Location.Y);
                        workoutFlow.Location = new System.Drawing.Point(DietFlow.Location.X, DietFlow.Location.Y);
                    }
                    else if (dt.Rows.Count == 1)
                    {
                        DietFlow.Size = new System.Drawing.Size(1150, 90);
                    }
                    else if (dt.Rows.Count == 2)
                    {
                        DietFlow.Size = new System.Drawing.Size(1150, 180);
                        workoutPanel.Location = new System.Drawing.Point(workoutPanel.Location.X, workoutPanel.Location.Y + 60);
                        workoutFlow.Location = new System.Drawing.Point(workoutFlow.Location.X, workoutFlow.Location.Y + 60);
                    }
                    else
                    {
                        DietFlow.Size = new System.Drawing.Size(1150, 270);
                        workoutPanel.Location = new System.Drawing.Point(workoutPanel.Location.X, workoutPanel.Location.Y + 125);
                        workoutFlow.Location = new System.Drawing.Point(workoutFlow.Location.X, workoutFlow.Location.Y + 125);
                    }

                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        PlanDiv4 diet = new PlanDiv4()
                        {
                            getSetcreatorName = dt.Rows[i][3].ToString(),
                            getSetId = (i + 1).ToString(),
                            getSetplanName = dt.Rows[i][1].ToString()
                        };
                        DietFlow.Controls.Add(diet);
                        diet.detailBtn += viewPlanDetailsDiet2;
                        
                    }

                    string query3 = $"SELECT wp.* FROM workout_plan wp INNER JOIN member_workout mw ON wp.plan_id = mw.workout_plan INNER JOIN member m ON mw.member_id = m.userid WHERE m.username = '{username}';";
                    dt = database.search_to_check(query3);

                    if (dt.Rows.Count == 0)
                    {
                        workoutPanel.Hide();
                        workoutFlow.Hide();
                        return;
                    }
                    else if (dt.Rows.Count == 1)
                    {
                        workoutFlow.Size = new System.Drawing.Size(1150, 90);
                    }
                    else if (dt.Rows.Count == 2)
                    {
                        workoutFlow.Size = new System.Drawing.Size(1150, 180);
                    }
                    else
                    {
                        workoutFlow.Size = new System.Drawing.Size(1150, 270);
                    }


                    // Workout Plans
                    for (int i = 0; i < dt.Rows.Count; ++i)
                    {
                        PlanDiv4 workout = new PlanDiv4()
                        {
                            getSetcreatorName = dt.Rows[i][3].ToString(),
                            getSetId = (i + 1).ToString(),
                            getSetplanName = dt.Rows[i][1].ToString()
                        };
                        workoutFlow.Controls.Add(workout);
                        workout.detailBtn += viewPlanDetailsWorkout2;
                    }
                }
            }
            else if (Member_tab.SelectedIndex == 1) // Manage Plan
            {
                managePanel.Show();
            }
            else if (Member_tab.SelectedIndex == 3)
            {
                string getMemId = $"select * from member where username = '{username}'";
                DataTable dt = database.search_to_check(getMemId);

                string checkAppointments = $"select * from appointment where member_id = {int.Parse(dt.Rows[0][0].ToString())}";
                dt = database.search_to_check(checkAppointments);

                if (dt.Rows.Count == 0)
                {
                    noAppointmentPanel.Show();
                    appointmentsPanel.Hide();
                }
                else
                {
                    noAppointmentPanel.Hide();
                    appointmentsPanel.Show();

                    string date = dt.Rows[0][1].ToString().Substring(0, Math.Min(10, dt.Rows[0][1].ToString().Length));
                    string time = dt.Rows[0][1].ToString().Substring(10);

                    appDate.Text = date;
                    appTime.Text = time;

                    noAppointmentPanel.Hide();
                    appointmentsPanel.Show();

                    string getTrainer = $"select * from trainer where userid = '{dt.Rows[0][3]}'";
                    dt = database.search_to_check(getTrainer);

                    trainerNameApp.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();

                    string getGym = $"select * from gym where gymid = {int.Parse(dt.Rows[0][7].ToString())}";
                    dt = database.search_to_check(getGym);

                    gymAddress.Text = dt.Rows[0][1].ToString();

                }
            }
            else if (Member_tab.SelectedIndex == 8) // Book Appointment
            {
                string getMemId = $"select * from member where username = '{username}'";
                DataTable dt = database.search_to_check(getMemId);

                string getGym = $"select * from membership where member_id = {int.Parse(dt.Rows[0][0].ToString())}";
                dt = database.search_to_check(getGym);

                int gymId = int.Parse(dt.Rows[0][3].ToString());

                string getTrainers = $"SELECT t.* FROM trainer t INNER JOIN Gym g ON t.gym_id = g.gymid WHERE g.gymid = {int.Parse(dt.Rows[0][3].ToString())}";
                dt = database.search_to_check(getTrainers);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bookAppTrainerName.Items.Add(dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString());
                }

                string getGymName = $"SELECT * from gym where gymid = {gymId}";
                dt = database.search_to_check(getGymName);

                bookAppGymName.Text = dt.Rows[0][1].ToString();

            }
            else if (Member_tab.SelectedIndex == 9) // Add Membership
            {
                string getGyms = $"select * from gym";
                DataTable dt = database.search_to_check(getGyms);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    addMemGymName.Items.Add(dt.Rows[i][1]);
                }
            }
            else if (Member_tab.SelectedIndex == 4) //Membership
            {
                string getMemId = $"select * from member where username = '{username}'";
                DataTable dt = database.search_to_check(getMemId);
                int memId = int.Parse(dt.Rows[0][0].ToString());

                string getMemShip = $"select * from membership where member_id = {memId}";
                dt = database.search_to_check(getMemShip);

                if (dt.Rows.Count == 0)
                {
                    noMembershipPanel.Show();
                    membershipPanel.Hide();
                }
                else
                {
                    noMembershipPanel.Hide();
                    membershipPanel.Show();

                    memDuration.Text = dt.Rows[0][1].ToString();

                    string getGym = $"select * from gym where gymid = '{int.Parse(dt.Rows[0][3].ToString())}'";
                    dt = database.search_to_check(getGym);

                    memGymName.Text = dt.Rows[0][1].ToString();
                    memAddress.Text = dt.Rows[0][2].ToString();
                    memPrice.Text = dt.Rows[0][4].ToString();

                    int ownId = int.Parse(dt.Rows[0][3].ToString());
                    string getOwner = $"select * from gym_owner where userid = {ownId}";
                    dt = database.search_to_check(getOwner);
                    memOwner.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
                }
            }
            else if (Member_tab.SelectedIndex == 2) // Feedback
            {
                feedbackTrainer.Items.Clear();
                string getMemId = $"select * from member where username = '{username}'";
                DataTable dt = database.search_to_check(getMemId);
                int memId = int.Parse(dt.Rows[0][0].ToString());

                string getGym = $"select * from membership where member_id = '{memId}'";
                dt = database.search_to_check(getGym);

                if (dt.Rows.Count == 0)
                {
                    feedbackPanel.Hide();
                    noFeedbackPanel.Show();
                    return;
                }
                else
                {
                    feedbackPanel.Show();
                    noFeedbackPanel.Hide();
                }

                string getTrainers = $"select * from trainer where gym_id = {int.Parse(dt.Rows[0][3].ToString())}";
                dt = database.search_to_check(getTrainers);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    feedbackTrainer.Items.Add(dt.Rows[i][2].ToString() + " " + dt.Rows[i][2].ToString());
                }
            }
        }
        private void dietToManageBtn_Click(object sender, EventArgs e)
        {
            DietPlanPanel.Hide();
            managePanel.Show();
        }

        private void workoutToManageBtn_Click(object sender, EventArgs e)
        {
            WorkoutPlansPanel.Hide();
            managePanel.Show();
        }

        private void becomeOwnerToProfile_Click(object sender, EventArgs e)
        {
            becomeOwnerPanel.Hide();
            profilePanel.Show();
        }

        private void wokroutPlanShowBtn_Click(object sender, EventArgs e)
        {
            managePanel.Hide();
            WorkoutPlansPanel.Show();
            trainerWorkoutFlow.Controls.Clear();
            memberWorkoutFlow.Controls.Clear();

            string getMemId = $"select * from member where username = '{username}'";
            DataTable dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string q = $"SELECT * FROM workout_plan WHERE plan_id NOT IN (SELECT workout_plan FROM member_workout WHERE member_id = {memId}) AND creator IN (SELECT username FROM trainer);";
            dt = database.search_to_check(q);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv workout = new PlanDiv()
                {
                    getSetcreatorName = dt.Rows[i][3].ToString(),
                    getSetId = (i + 1).ToString(),
                    getSetplanName = dt.Rows[i][1].ToString()
                };
                trainerWorkoutFlow.Controls.Add(workout);
                workout.detailBtn += viewPlanDetailsWorkout;
                workout.subBtn += subsrcibePlanWorkout;
            }

            q = $"SELECT * FROM workout_plan WHERE plan_id NOT IN (SELECT workout_plan FROM member_workout WHERE member_id = {memId}) AND creator IN (SELECT username FROM member);";
            dt = database.search_to_check(q);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv workout = new PlanDiv()
                {
                    getSetcreatorName = dt.Rows[i][3].ToString(),
                    getSetId = (i + 1).ToString(),
                    getSetplanName = dt.Rows[i][1].ToString()
                };
                workout.detailBtn += viewPlanDetailsWorkout;
                workout.subBtn += subsrcibePlanWorkout;
                memberWorkoutFlow.Controls.Add(workout);
            }

        }


        private void dietPlanShowBtn_Click(object sender, EventArgs e)
        {
            managePanel.Hide();
            DietPlanPanel.Show();

            trainerDietFlow.Controls.Clear();
            memberDietFlow.Controls.Clear();

            string getMemId = $"select * from member where username = '{username}'";
            DataTable dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string q = $"SELECT * FROM diet_plan WHERE plan_id NOT IN (SELECT diet_plan_id FROM member_diet WHERE member_id = {memId}) AND creator IN (SELECT username FROM trainer);";
            dt = database.search_to_check(q);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv diet = new PlanDiv()
                {
                    getSetcreatorName = dt.Rows[i][3].ToString(),
                    getSetId = (i + 1).ToString(),
                    getSetplanName = dt.Rows[i][1].ToString()
                };
                trainerDietFlow.Controls.Add(diet);
                diet.subBtn += subsrcibePlanDiet;
                diet.detailBtn += viewPlanDetailsDiet;
            }

            q = $"SELECT * FROM diet_plan WHERE plan_id NOT IN (SELECT diet_plan_id FROM member_diet WHERE member_id = {memId}) AND creator IN (SELECT username FROM member);";
            dt = database.search_to_check(q);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv diet = new PlanDiv()
                {
                    getSetcreatorName = dt.Rows[i][3].ToString(),
                    getSetId = (i + 1).ToString(),
                    getSetplanName = dt.Rows[i][1].ToString()
                };
                memberDietFlow.Controls.Add(diet);
                diet.detailBtn += viewPlanDetailsDiet;
                diet.subBtn += subsrcibePlanDiet;
            }
        }
        private void addPlanBtn_Click(object sender, EventArgs e)
        {
            Member_tab.SelectTab(1);
        }


        private void becomeOwnerBtn_Click(object sender, EventArgs e)
        {
            profilePanel.Hide();
            becomeTrainerPanel.Hide();
            becomeOwnerPanel.Show();
        }
        private void becomeTrainerBtn_Click(object sender, EventArgs e)
        {
            // 12,17
            profilePanel.Hide();
            becomeOwnerPanel.Hide();
            becomeTrainerPanel.Show();

            string query = "select name from Gym";
            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gymDropDown.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        //Become trainer back to profile button
        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            profilePanel.Show();
            becomeTrainerPanel.Hide();
        }

        //Send Request Button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passwordTxt.Text == "" || specialityTxt.Text == "" || gymDropDown.Text == "Gym Name")
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please fill all the information";
                return;
            }
            string query = $"select * from account where username = '{username}'";
            DataTable dt = database.search_to_check(query);
            if (usernameTxt.Text != username || passwordTxt.Text != dt.Rows[0][3].ToString())
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Invalid Username or Password";
                return;
            }
            else
            {
                MessageBox.Show("Request Sent\nYou will be promoted when the request is accepted by Gym Owner");

                string getUserId = $"select userid from member where username = '{username}'";
                string getGymId = $"select gymid from Gym where name = '{gymDropDown.Text}'";

                dt = database.search_to_check(getUserId);
                string userid = dt.Rows[0][0].ToString();
                dt = database.search_to_check(getGymId);
                string gymid = dt.Rows[0][0].ToString();

                string query2 = $"insert into trainer_request values ({int.Parse(userid)}, '{specialityTxt.Text}', {int.Parse(gymid)})";
                database.query_data(query2);
                becomeTrainerPanel.Hide();
                profilePanel.Show();
                becomeTrainerBtn.Hide();
            }
        }

        private void makeOwnPlan_Click(object sender, EventArgs e)
        {
            Member_tab.SelectTab(5);
        }

        private void createWorkoutToBack_Click(object sender, EventArgs e)
        {
            planTypePanel.Show();
            createWorkoutPlanPanel.Hide();
        }

        private void createDietToBack_Click(object sender, EventArgs e)
        {
            planTypePanel.Show();
            createDietPlanPanel.Hide();
        }

        private void donePlanBtn_Click_1(object sender, EventArgs e)
        {
            if (workoutPlanName.Text == "" || workoutPlanDesc.Text == "")
            {
                createWorkoutErrorLbl.ForeColor = Color.Red;
                createWorkoutErrorLbl.Text = "Please fill all the fields";
                return;
            }

            string insertInPlan = $"insert into workout_plan values ('{workoutPlanName.Text}', '{workoutPlanDesc.Text}', '{username}')";
            database.query_data(insertInPlan);

            string getMemId = $"select * from member where username = '{username}'";
            DataTable dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string getworkId = $"select * from workout_plan where plan_name = '{workoutPlanName.Text}' and creator = '{username}'";
            dt = database.search_to_check(getworkId);

            string insertInMemWork = $"insert into member_workout values ('{memId}','{dt.Rows[0][0]}')";
            database.query_data(insertInMemWork);

            planInfoWorkout.Hide();
            exerciseInfoWorkout.Show();
        }

        private void finishCreationWorkout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plan Created");
            workoutPlanName.Text = "";
            workoutPlanDesc.Text = "";
            Member_tab.SelectTab("myPlansTab");
        }

        private void createWorkoutBtn_Click_1(object sender, EventArgs e)
        {
            if (exerciseName.Text == "" || exerciseDesc.Text == "" || targetMuscle.Text == "" || Reps.Text == "" || setNum.Text == "" || restInterval.Text == "" || machine.Text == "")
            {
                createWorkoutErrorLbl.ForeColor = Color.Red;
                createWorkoutErrorLbl.Text = "Please fill all the fields";
                return;
            }
            else
            {
                createWorkoutErrorLbl.Text = "";
            }

            string getPlanId = $"select * from workout_plan where plan_name = '{workoutPlanName.Text}' and creator = '{username}'";
            DataTable dt = database.search_to_check(getPlanId);

            string insertInExercise = $"insert into exercise values ('{dt.Rows[0][0].ToString()}', '{exerciseDesc.Text}', '{exerciseName.Text}', '{int.Parse(setNum.Text)}', '{int.Parse(restInterval.Text)}', '{targetMuscle.Text}', '{int.Parse(Reps.Text)}', '{machine.Text}')";

            database.query_data(insertInExercise);

            exerciseName.Text = "";
            exerciseDesc.Text = "";
            targetMuscle.Text = "";
            Reps.Text = "";
            setNum.Text = "";
            restInterval.Text = "";
            machine.Text = "";
            finishCreationWorkout.Show();
        }



        private void endCreationDiet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plan Created");
            createDietPlanName.Text = "";
            createDietPlanDesc.Text = "";
            Member_tab.SelectTab("myPlansTab");
        }

        private void donePlanDietBtn_Click(object sender, EventArgs e)
        {
            if (createDietPlanName.Text == "" || createDietPlanDesc.Text == "")
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

            string getMemId = $"select * from member where username = '{username}'";
            DataTable dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string getdietId = $"select * from diet_plan where plan_name = '{createDietPlanName.Text}'";
            dt = database.search_to_check(getdietId);

            string insertInMemDiet = $"insert into member_diet values ('{memId}','{dt.Rows[0][0]}')";
            database.query_data(insertInMemDiet);

            planInfoDiet.Hide();
            mealInfoDiet.Show();
        }

        private void createDietBtn_Click_1(object sender, EventArgs e)
        {
            if (mealName.Text == "" || mealDesc.Text == "" || fibreNum.Text == "" || carbNum.Text == "" || protienNum.Text == "" || fatNum.Text == "")
            {
                createDietErrorLbl.ForeColor = Color.Red;
                createDietErrorLbl.Text = "Please fill all the fields";
                return;
            }
            else
            {
                createDietErrorLbl.Text = "";
            }

            string getPlanId = $"select * from diet_plan where plan_name = '{createDietPlanName.Text}'";
            DataTable dt = database.search_to_check(getPlanId);

            string insertInMeal = $"insert into meals values ('{dt.Rows[0][0].ToString()}', '{createDietPlanName.Text}', '{int.Parse(protienNum.Text)}', '{int.Parse(fatNum.Text)}', '{int.Parse(fibreNum.Text)}', '{int.Parse(carbNum.Text)}', '{createDietPlanDesc.Text}')";

            database.query_data(insertInMeal);

            endCreationDiet.Show();

            mealName.Text = "";
            mealDesc.Text = "";
            fibreNum.Text = "";
            carbNum.Text = "";
            protienNum.Text = "";
            fatNum.Text = "";
        }

        private void planDetailToBack_Click(object sender, EventArgs e)
        {
            Member_tab.SelectedIndex = 1;
        }

        private void startMembershipBtn_Click(object sender, EventArgs e)
        {
            Member_tab.SelectedIndex = 9;
        }

        private void bookAppointmentBtn_Click_1(object sender, EventArgs e)
        {
            //56
            string getMemId = $"select * from member where username = '{username}'";
            DataTable dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string getGym = $"select * from membership where member_id = {memId}";
            dt = database.search_to_check(getGym);

            if (dt.Rows.Count == 0)
            {
                Member_tab.SelectedIndex = 4;
                return;
            }

            noAppointmentPanel.Hide();
            appointmentsPanel.Hide();
            Member_tab.SelectedIndex = 8;
        }

        private void bookAppBtn_Click(object sender, EventArgs e)
        {
            if (bookAppUsername.Text == "" || bookAppPass.Text == "" || bookAppTrainerName.Text == "Trainer")
            {
                bookAppError.Text = "Please Fill all the fields";
                return;
            }
            string getAcc = $"select * from account where username = '{bookAppUsername.Text}' and password = '{bookAppPass.Text}'";
            DataTable dt = database.search_to_check(getAcc);

            if (dt.Rows.Count == 0)
            {
                bookAppError.Text = "Invalid Username or Password";
                return;
            }
            else
            {
                string getMemId = $"select * from member where username = '{username}'";
                dt = database.search_to_check(getMemId);
                int memId = int.Parse(dt.Rows[0][0].ToString());

                string originalString = bookAppTrainerName.Text;
                string[] parts = originalString.Split(' ');
                string firstPart = parts[0];
                string secondPart = parts[1];

                string getTrainer = $"select * from trainer where firstname = '{firstPart}' and lastname = '{secondPart}'";
                dt = database.search_to_check(getTrainer);
                string date = ConvertToCustomFormat(bookAppDate.Text);

                string intoApp = $"insert into appointment values ('{date}', {memId}, {int.Parse(dt.Rows[0][0].ToString())})";
                database.query_data(intoApp);
                MessageBox.Show("Appointment Added");
                Member_tab.SelectedIndex = 3;
            }
        }

        private void addMemGymName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addMemGymName.Text == "Gym Name")
            {
                return;
            }

            string getGym = $"select * from gym where name = '{addMemGymName.Text}'";
            DataTable dt = database.search_to_check(getGym);

            addMemAddress.Text = dt.Rows[0][2].ToString();
            addMemPrice.Text = dt.Rows[0][4].ToString();

            string getOwner = $"select * from gym_owner where userid = {int.Parse(dt.Rows[0][3].ToString())}";
            dt = database.search_to_check(getOwner);

            addMemOwnerName.Text = dt.Rows[0][2].ToString() + " " + dt.Rows[0][3].ToString();
        }

        private void addMembershipBtn_Click(object sender, EventArgs e)
        {
            if (addMemUsername.Text == "" || addMemPassword.Text == "" || addMemGymName.Text == "Gym Name" || addMemDuration.Text == "")
            {
                addMemError.Text = "Please Fill all the fields";
                return;
            }
            int number;
            if ((int.TryParse(addMemDuration.Text, out number)) == false)
            {
                addMemError.Text = "Please enter vaild duration in Months";
                return;
            }
            string getAcc = $"select * from account where username = '{addMemUsername.Text}' and password = '{addMemPassword.Text}'";
            DataTable dt = database.search_to_check(getAcc);

            if (dt.Rows.Count == 0)
            {
                addMemError.Text = "Invalid Username or Password";
                return;
            }

            string getMemId = $"select * from member where username = '{username}'";
            dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string getGym = $"select * from gym where name = '{addMemGymName.Text}'";
            dt = database.search_to_check(getGym);

            string addGym = $"insert into membership values ({int.Parse(addMemDuration.Text)}, {memId}, {int.Parse(dt.Rows[0][0].ToString())})";
            database.query_data(addGym);
            MessageBox.Show("Membership added");
            Member_tab.SelectedIndex = 4;
        }

        private void feedbackAcceptor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            feedbackTrainer.Items.Clear();
            string getMemId = $"select * from member where username = '{username}'";
            DataTable dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string getGym = $"select * from membership where member_id = '{memId}'";
            dt = database.search_to_check(getGym);

            if (feedbackAcceptor.Text == "Trainer")
            {
                string getTrainers = $"select * from trainer where gym_id = {int.Parse(dt.Rows[0][3].ToString())}";
                dt = database.search_to_check(getTrainers);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    feedbackTrainer.Items.Add(dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString());
                }
            }
            else
            {
                string owner = "select * from gym where gymid = '" + dt.Rows[0][3] + "'";
                dt = database.search_to_check(owner);
                string getOwner = $"select * from gym_owner where userid = {int.Parse(dt.Rows[0][3].ToString())}";
                dt = database.search_to_check(getOwner);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    feedbackTrainer.Items.Add(dt.Rows[i][2].ToString() + " " + dt.Rows[i][3].ToString());
                }
            }
        }

        private void submitFeedbackBtn_Click_1(object sender, EventArgs e)
        {
            if (feedbackTrainer.Text == "" || feedbackUsername.Text == "" || feedbackPassword.Text == "" || feedbackRating.Text == "Rating" || feedback.Text == "")
            {
                feedbackErrorLabel.Text = "Please fill all the fields";
                return;
            }
            string getAcc = $"select * from account where username = '{username}' and password = '{feedbackPassword.Text}'";
            DataTable dt = database.search_to_check(getAcc);

            if (feedbackUsername.Text != username || dt.Rows.Count == 0)
            {
                feedbackErrorLabel.Text = "Invalid username or password";
                return;
            }

            string getMemId = $"select * from member where username = '{username}'";
            dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string getGym = $"select * from membership where member_id = '{memId}'";
            dt = database.search_to_check(getGym);

            if (feedbackAcceptor.Text == "Trainer")
            {
                string trainer = feedbackTrainer.Text;
                string realtrainer = "";
                for (int i = 0; trainer[i] != ' '; ++i)
                    realtrainer += trainer[i];
                string getTrainers = $"select * from trainer where firstname = '{realtrainer}'";
                dt = database.search_to_check(getTrainers);

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string insertFeedback = $"insert into feedback values ('{currentDate}', '{feedback.Text}', '{username}', '{dt.Rows[0][1]}', {feedbackRating.Text})";
                database.query_data(insertFeedback);
                MessageBox.Show("Feedback for trainer has been submitted");
            }
            else
            {
                getGym = $"select * from membership where member_id = '{memId}'";
                dt = database.search_to_check(getGym);

                string insertReview = $"insert into gym_review values ({int.Parse(dt.Rows[0][3].ToString())}, '{username}', {feedbackRating.Text}, '{feedback.Text}')";
                database.query_data(insertReview);
                MessageBox.Show("Feedback for Gym Owner has been submitted");
            }
        }

        private void bookAppointmentToAppointment_Click(object sender, EventArgs e)
        {
            Member_tab.SelectedIndex = 3;
        }

        private void startMemberShipInFeedbackBtn_Click(object sender, EventArgs e)
        {
            Member_tab.SelectedIndex = 9;
        }

        private void createWorkoutPlanBtn_Click(object sender, EventArgs e)
        {
            finishCreationWorkout.Hide();
            planTypePanel.Hide();
            createDietPlanPanel.Hide();
            createWorkoutPlanPanel.Show();
            planInfoWorkout.Show();
            exerciseInfoWorkout.Hide();
        }

        private void createDietPlanTab_Click(object sender, EventArgs e)
        {
            endCreationDiet.Hide();
            planTypePanel.Hide();
            createWorkoutPlanPanel.Hide();
            createDietPlanPanel.Show();
            planInfoDiet.Show();
            mealInfoDiet.Hide();
        }

        private void addMemToMembership_Click(object sender, EventArgs e)
        {
            Member_tab.SelectTab("membershipTab");
        }

        private void sendOwnerRequestBtn_Click(object sender, EventArgs e)
        {
            if (usernameBoxOwnerReq.Text == "" || passwordBoxOwnerReq.Text == "" || gymNameBoxOwnerReq.Text == "" || priceBoxOwnerReq.Text == "" || addressBoxOwnerReq.Text == "")
            {
                onwerReqErrorLabel.Text = "Please fill all the fields!";
                return;
            }
            string getMem = $"select * from account where username = '{username}' and password = '{passwordBoxOwnerReq.Text}'";
            DataTable dt = database.search_to_check(getMem);
            if (dt.Rows.Count == 0 || username != usernameBoxOwnerReq.Text)
            {
                onwerReqErrorLabel.Text = "Invalid username or password";
                return;
            }

            getMem = $"select * from member where username = '{username}'";
            dt = database.search_to_check(getMem);

            string addMemReq = $"insert into gym_owner_request values ('{dt.Rows[0][0].ToString()}', '{gymNameBoxOwnerReq.Text}', '{addressBoxOwnerReq.Text}', '{priceBoxOwnerReq.Text}')";
            database.query_data(addMemReq);
            MessageBox.Show("Request Sent");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            drop_down.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Member_tab.SelectedIndex = 0;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Rectangle tabBounds = Member_tab.Bounds;

            drop_down.Visible = false;
        }

        private void deleteMembership_Click(object sender, EventArgs e)
        {
            string getMemId = $"select * from member where username = '{username}'";
            DataTable dt = database.search_to_check(getMemId);
            int memId = int.Parse(dt.Rows[0][0].ToString());

            string delApps = $"delete appointment where member_id = {memId}";
            database.query_data(delApps);

            string delMembership = $"delete membership where member_id = {memId}";
            database.query_data(delMembership);

            MessageBox.Show("Membership Removed");
            Member_tab.SelectTab("planDetailTab");
            Member_tab.SelectTab("membershipTab");

        }

        private void feedbackTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void appDate_Click(object sender, EventArgs e)
        {

        }
    }
}


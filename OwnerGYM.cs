using Flex_Trainer.Classes;
using Flex_Trainer.Divs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flex_Trainer
{
    public partial class OwnerGYM : Form
    {
        bool check = false;
        trainerinfoDiv trainer = null;
        DB_Access database = new DB_Access();
        public int userid { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string contactNo { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public int gymid { get; set; }
        public string gymname { get; set; }
        public string gymaddress { get; set; }
        public int membership_price { get; set; }

        Form1 mainForm;
        public OwnerGYM(Form1 A)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += GymOwner_Load;
            this.mainForm = A;
        }

        public void GymOwner_Load(object sender, EventArgs e)
        {
            username_link.Text = username;

            string query = "select * from account where username = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            email = dt.Rows[0][2].ToString();
            dropdown_Set.Hide();

            drop_down.Hide();

            query = "select * from gym where owner_id = '" + userid + "'";
            dt = database.search_to_check(query);
            gymid = int.Parse(dt.Rows[0][0].ToString());
            gymname = dt.Rows[0][1].ToString();
            gymaddress = dt.Rows[0][2].ToString();
            membership_price = int.Parse(dt.Rows[0][4].ToString());

            flow_member_show.Controls.Clear();
            check = true;
            query = "select * from membership where gym_id = '" + gymid + "'";
            dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from member where userid = '" + dt.Rows[i][2] + "'";
                DataTable dt2 = database.search_to_check(query);

                query = "select * from account where username = '" + dt2.Rows[0][1] + "'";
                DataTable dt3 = database.search_to_check(query);

                MemberInfo member = new MemberInfo()
                {
                    get_set_memberid = int.Parse(dt2.Rows[0][0].ToString()),
                    get_set_fullname = dt2.Rows[0][2].ToString() + ' ' + dt2.Rows[0][3].ToString(),
                    get_set_contact = dt2.Rows[0][4].ToString(),
                    get_set_gender = dt2.Rows[0][5].ToString(),
                    get_set_email = dt3.Rows[0][2].ToString(),
                    get_set_duration = dt.Rows[i][1].ToString()
                };
                member.removeBtn += remove_member;
                flow_member_show.Controls.Add(member);
            }

        }

        private void gymowner_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            drop_down.Visible = false;
            if (gymowner_tab.SelectedTab.Name == "memberreport_tab")
            {
                flow_member_show.Controls.Clear();
                check = true;
                string query = "select * from membership where gym_id = '" + gymid + "'";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    query = "select * from member where userid = '" + dt.Rows[i][2] + "'";
                    DataTable dt2 = database.search_to_check(query);

                    query = "select * from account where username = '" + dt2.Rows[0][1] + "'";
                    DataTable dt3 = database.search_to_check(query);

                    MemberInfo member = new MemberInfo()
                    {
                        get_set_memberid = int.Parse(dt2.Rows[0][0].ToString()),
                        get_set_fullname = dt2.Rows[0][2].ToString() + ' ' + dt2.Rows[0][3].ToString(),
                        get_set_contact = dt2.Rows[0][4].ToString(),
                        get_set_gender = dt2.Rows[0][5].ToString(),
                        get_set_email = dt3.Rows[0][2].ToString(),
                        get_set_duration = dt.Rows[i][1].ToString()
                    };
                    member.removeBtn += remove_member;
                    flow_member_show.Controls.Add(member);
                }

            }
            else if (gymowner_tab.SelectedTab.Name == "trainerreport_tab")
            {
                flow_trainer_report.Controls.Clear();
                string q = "select specialization from trainer where gym_id = '" + gymid + "'";
                DataTable t = database.search_to_check(q);
                spec_dropdown.Items.Clear();
                spec_dropdown.Items.Add("Specialization");
                
                foreach (DataRow row in t.Rows)
                {
                    // Assuming the value you want to display is in the first column
                    spec_dropdown.Items.Add(row[0]);
                }
                spec_dropdown.SelectedIndex = 0;
                rating_filer.SelectedIndex = 0;
                flow_trainer_report.Controls.Clear();

                string query = "select * from trainer where gym_id = '" + gymid + "'";

                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    trainerinfoDiv trainer = new trainerinfoDiv()
                    {
                        get_set_name = dt.Rows[i][2].ToString() + ' ' + dt.Rows[i][3].ToString(),
                        get_set_speclization = dt.Rows[i][6].ToString(),
                        get_set_id = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_phone = dt.Rows[i][4].ToString(),
                        get_set_gender = dt.Rows[i][5].ToString(),
                        get_set_username = dt.Rows[i][1].ToString(),

                    };
                    trainer.viewBtn += view_trainer;
                    flow_trainer_report.Controls.Add(trainer);
                }
            }
            else if (gymowner_tab.SelectedTab.Name == "trainerrequest_tab")
            {
                flow_trainer_reqest.Controls.Clear();
                string query = "select * from trainer_request where gym_id = '" + gymid + "'";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    query = "select * from member where userid = '" + dt.Rows[i][0] + "'";
                    DataTable dt2 = database.search_to_check(query);
                    query = "select * from account where username = '" + dt2.Rows[0][1] + "'";
                    DataTable dt3 = database.search_to_check(query);

                    TrainerrequestDiv trainer = new TrainerrequestDiv()
                    {
                        get_set_memberid =  int.Parse(dt2.Rows[0][0].ToString()),
                        get_set_name = dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][2],
                        get_set_gender = dt2.Rows[0][5].ToString(),
                        get_set_contact = dt2.Rows[0][4].ToString(),
                        get_set_email = dt3.Rows[0][2].ToString(),
                        get_set_speclization = dt.Rows[i][1].ToString()
                    };
                    trainer.acceptBtn += accept_trainer_request;
                    trainer.declineBtn += decline_trainer_request;
                    flow_trainer_reqest.Controls.Add(trainer);
                }
            }
            else if (gymowner_tab.SelectedTab.Name == "trainerfeeback_tab")
            {
                flow_view_feedback.Controls.Clear();
                feedback_header.Text = trainer.get_set_name;
                string query = "select * from feedback where trainer_name = '" + trainer.get_set_username + "'";
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
                    flow_view_feedback.Controls.Add(feedback);
                }
            }
            else if (gymowner_tab.SelectedTab.Name == "profile_tab")
            {
                guna2TextBox1.PlaceholderText = gymname;
                edit_name.Text = firstname + ' ' + lastname;
                email_txt.PlaceholderText = email;
                edit_phone.PlaceholderText = contactNo;
                edit_gender.PlaceholderText = gender;
                edit_username.PlaceholderText = username;
            }
            else if(gymowner_tab.SelectedTab.Name == "feedback_tab")
            {
                header_gym_name.Text = gymname;
                flow_gym_feedback.Controls.Clear();
                string query = "select * from gym_review where gym_id = '" + gymid + "'";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    query = "select * from member where username = '" + dt.Rows[i][2] + "'";
                    DataTable dt2 = database.search_to_check(query);
                    if(dt2.Rows.Count == 0)
                    {
                        query = "select * from trainer where username = '" + dt.Rows[i][2] + "'";
                        dt2 = database.search_to_check(query);
                    }
                    feedbackdiv feedback = new feedbackdiv()
                    {
                        get_set_name = dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][3].ToString(),
                        get_set_description = dt.Rows[i][4].ToString(),
                        get_set_date = "Rating = " + dt.Rows[i][3].ToString()
                    };
                    flow_gym_feedback.Controls.Add(feedback);
                }
            }
            else if(gymowner_tab.SelectedTab.Name == "gymPlans_tab")
            {
                planflow.Controls.Clear();
                filter_plan.SelectedIndex = 0;

                string query = "select plan_id , plan_name , details  , creator " +
                    "from workout_plan " +
                    "join trainer on  trainer.username = workout_plan.creator " +
                    "where trainer.gym_id = '"+gymid+"'";
                DataTable dt = database.search_to_check(query);

                for(int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv3 plan = new PlanDiv3()
                    {
                        get_set_ownername = dt.Rows[i][3].ToString(),
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += show_Details_workout;
                    plan.planSubBtn += show_subscriber_workout;
                    plan.removebtn += remove_workout_plan;
                    planflow.Controls.Add(plan);
                }

                query = "select plan_id , plan_name , details  , creator " +
                    "from diet_plan " +
                    "join trainer on  trainer.username = diet_plan.creator " +
                    "where trainer.gym_id = '"+gymid+"'";
                dt = database.search_to_check(query);
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv3 plan = new PlanDiv3()
                    {
                        get_set_ownername = dt.Rows[i][3].ToString(),
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += show_Details_diet;
                    plan.planSubBtn += show_subscriber_diet;
                    plan.removebtn += remove_diet_plan;
                    planflow.Controls.Add(plan);
                }
            }
        }
        private void remove_diet_plan(object sender, EventArgs e)
        {
            PlanDiv3 plan = (PlanDiv3)sender;

            gymowner_tab.SelectTab("gymPlans_tab");

            string q = "delete from member_diet " +
                "where diet_plan_id = '"+plan.get_set_planid+"'";
            database.query_data(q);

            string query = "delete from meals " +
                "where meals.plan_id = '"+plan.get_set_planid+"'";
            database.query_data(query);

            query = "delete from diet_plan " +
                "where diet_plan.plan_id = '"+plan.get_set_planid+"'";
            database.query_data(query);

            planflow.Controls.Remove(plan);
        }
        private void remove_workout_plan(object sender, EventArgs e)
        {
            PlanDiv3 plan = (PlanDiv3)sender;

            gymowner_tab.SelectTab("gymPlans_tab");

            string q = "delete from member_workout " +
                "where workout_plan = '" + plan.get_set_planid + "'";
            database.query_data(q);

            string query = "delete from exercise " +
                "where exercise.plan_id = '" + plan.get_set_planid + "';";
            database.query_data(query);

            query = "delete from workout_plan " +
                "where workout_plan.plan_id = '" + plan.get_set_planid + "'";
            database.query_data(query);

            planflow.Controls.Remove(plan);
        }

        private void show_subscriber_diet(object sender, EventArgs e)
        {
            memberListFlow.Controls.Clear();
            gymowner_tab.SelectTab("sub_tab");
            PlanDiv3 plan = (PlanDiv3)sender;

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
                    member.kickBtn += kickMemberWorkout;
                }
            }

        }
        private void show_subscriber_workout(object sender, EventArgs e)
        {

            memberListFlow.Controls.Clear();
            gymowner_tab.SelectTab("sub_tab");
            PlanDiv3 plan = (PlanDiv3)sender;

            
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
                member.kickBtn += kickMemberDiet;
            }
            return;
        }

        private void kickMemberWorkout(object sender, EventArgs e)
        {
            SubscribedMember mem = (SubscribedMember)sender;

            string remMem = $"delete member_workout where member_id = '{mem.getSetMemberId}'";
            database.query_data(remMem);
            MessageBox.Show("Member Deleted");
            gymowner_tab.SelectTab("gymPlans_tab");
        }

        private void kickMemberDiet(object sender, EventArgs e)
        {
            SubscribedMember mem = (SubscribedMember)sender;

            string remMem = $"delete member_diet where member_id = '{mem.getSetMemberId}'";
            database.query_data(remMem);
            MessageBox.Show("Member Deleted");
            gymowner_tab.SelectTab("gymPlans_tab");
        }

        private void show_Details_workout(object sender, EventArgs e)
        {
            gymowner_tab.SelectTab("plandetail_tab");
            PlanDiv3 plan = (PlanDiv3)sender;

            string query = "select * from exercise where plan_id = '" + plan.get_set_planid + "'";
            DataTable dt = database.search_to_check(query);
            plandetail_flow.Controls.Clear();
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
                    get_set_machine = dt.Rows[i][8].ToString(),
                };
                plandetail_flow.Controls.Add(ex);
            }

        }

        private void show_Details_diet(object sender, EventArgs e)
        {
            gymowner_tab.SelectTab("plandetail_tab");
            PlanDiv3 plan = (PlanDiv3)sender;

            string query = "select * from meals where plan_id = '" + plan.get_set_planid + "'";
            DataTable dt = database.search_to_check(query);
            plandetail_flow.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {

                meal ex = new meal()
                {
                   get_set_carbo = dt.Rows[i][6].ToString(),
                   get_set_fats = dt.Rows[i][4].ToString(),
                   get_set_plandetails = dt.Rows[i][7].ToString(),
                   get_set_fiber = dt.Rows[i][5].ToString(),
                   get_set_planname = dt.Rows[i][2].ToString(),
                   get_set_protein = dt.Rows[i][3].ToString(),
                };
                plandetail_flow.Controls.Add(ex);
            }

        }

        public void remove_member(object sender, EventArgs e)
        {
            MemberInfo member = (MemberInfo)sender;

            //select the trainer of GYM
            /*string query = "select * from trainer where gym_id = '" + gymid + "'";
            DataTable dt = database.search_to_check(query);*/


            /*for(int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from diet_plan where creator = '" + dt.Rows[i][1] + "'";
                DataTable dt2 = database.search_to_check(query);
                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    query = "delete from member_diet where member_id = '" + member.get_set_memberid + "' AND " +
                        "diet_plan_id = '" + dt2.Rows[j][0] +"'";
                    database.query_data(query);
                }

                query = "select * from workout_plan where creator = '" + dt.Rows[i][1] + "'";
                dt2 = database.search_to_check(query);
                for (int j = 0; j < dt2.Rows.Count; ++j)
                {
                    query = "delete from member_workout where member_id = '" + member.get_set_memberid + "' AND " +
                        "workout_plan = '" + dt2.Rows[j][0] + "'";
                    database.query_data(query);
                }

            }*/
            string query = "delete from membership where member_id = '" + member.get_set_memberid + "' and gym_id = '" + gymid + "'";
            database.query_data(query);

            query = "delete from appointment " +
                "where appointment.member_id = '"+member.get_set_memberid+"'"; 
             database.query_data(query);
            flow_member_show.Controls.Remove(member);
        }

        public void accept_trainer_request(object sender, EventArgs e)
        {
            TrainerrequestDiv trainer = (TrainerrequestDiv)sender;

            //get the data of user from member Table
            string query = "select * from member where userid = '" + trainer.get_set_memberid + "'";
            DataTable dt = database.search_to_check(query);

            //insert the user into trainer table
            query = "insert into trainer values('" + dt.Rows[0][1] + "','" + dt.Rows[0][2] + "','" + dt.Rows[0][3] + "'," +
                "'" + dt.Rows[0][4] + "','" + dt.Rows[0][5] + "', '" + trainer.get_set_speclization + "', '" + gymid + "')";
            database.query_data(query);

            //delete the trainer request of the user
            query = "delete from trainer_request where member_id = '" + trainer.get_set_memberid + "'";
            database.query_data(query);

            //delete any memberShip work out plan the user Follows
            query = "delete from member_diet where member_id = '" + trainer.get_set_memberid + "'";
            database.query_data(query);

            query = "delete from member_workout where member_id = '" + trainer.get_set_memberid + "'";
            database.query_data(query);

            query = "delete from membership where member_id = '" + trainer.get_set_memberid + "'";
            database.query_data(query);

            //delete the user from member table
            query = "delete from member where userid = '" + trainer.get_set_memberid + "'";
            database.query_data(query);

            flow_trainer_reqest.Controls.Remove(trainer);
        }

        public void decline_trainer_request(object sender, EventArgs e)
        {
            TrainerrequestDiv trainer = (TrainerrequestDiv)sender;

            string query = "delete from trainer_request where member_id = '" + trainer.get_set_memberid + "'";
            database.query_data(query);

            flow_trainer_reqest.Controls.Remove(trainer);
        }

        public void view_trainer(object sender, EventArgs e)
        {
            trainerinfoDiv trainer = (trainerinfoDiv)sender;
            this.trainer = trainer;
            string query = "select * from account where username = '" + trainer.get_set_username + "'";
            DataTable dt = database.search_to_check(query);

            header.Text = trainer.get_set_name;
            edit_spec.Text = trainer.get_set_speclization;
            edit_contact1.Text = trainer.get_set_phone;
            edit_gendre.Text = trainer.get_set_gender;
            edit_email1.Text = dt.Rows[0][2].ToString();


            query = "select plan_name as [Plan Name] , details as Details from workout_plan where creator = '" + trainer.get_set_username + "'";
            dt = database.search_to_check(query);
            work_out_plan_dt.DataSource = dt;

            work_out_plan_dt.Size = new Size(901, 30 + (30 * dt.Rows.Count));

            int y = work_out_plan_dt.Size.Height + work_out_plan_dt.Location.Y + 50;
            edit_plan_label.Location = new Point(38, y);

            y = edit_plan_label.Location.Y + 30;
            diet_plan_dt.Location = new Point(41, y);

            query = "select plan_name as [Plan Name] , details as Details from diet_plan where creator = '" + trainer.get_set_username + "'";
            dt = database.search_to_check(query);
            diet_plan_dt.DataSource = dt;

            diet_plan_dt.Size = new Size(901, 30 + (30 * dt.Rows.Count));

            gymowner_tab.SelectTab("trainer_tab");

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            gymowner_tab.SelectTab("trainerreport_tab");

            string query = "delete from trainer where username = '" + trainer.get_set_username + "'";
            database.query_data(query);
            query = "delete from appointment where trainer_id = '" + trainer.get_set_id + "'";
            database.query_data(query);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gymowner_tab.SelectTab("trainerfeeback_tab");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            gymowner_tab.SelectTab("trainer_tab");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            drop_down.Show();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Rectangle tabBounds = gymowner_tab.Bounds;

            drop_down.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            gymowner_tab.SelectTab("profile_tab");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void username_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gymowner_tab.SelectTab("profile_tab");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void spec_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = spec_dropdown.SelectedItem.ToString();
            if(spec_dropdown.SelectedIndex != 0 && rating_filer.SelectedIndex != 0)
            {
                specialization_rating_filer();
                return;
            }

            if(spec_dropdown.SelectedIndex == 0)
            {
                return;
            }
            flow_trainer_report.Controls.Clear();
            string query = "select * from trainer where gym_id = '" + gymid + "' and specialization = '"+selectedItem+"'";

            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                trainerinfoDiv trainer = new trainerinfoDiv()
                {
                    get_set_name = dt.Rows[i][2].ToString() + ' ' + dt.Rows[i][3].ToString(),
                    get_set_speclization = dt.Rows[i][6].ToString(),
                    get_set_id = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_phone = dt.Rows[i][4].ToString(),
                    get_set_gender = dt.Rows[i][5].ToString(),
                    get_set_username = dt.Rows[i][1].ToString(),

                };
                trainer.viewBtn += view_trainer;
                flow_trainer_report.Controls.Add(trainer);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spec_dropdown.SelectedIndex != 0 && rating_filer.SelectedIndex != 0)
            {
                specialization_rating_filer();
                return;
            }
            string selectedItem = rating_filer.SelectedItem.ToString();
            if(rating_filer.SelectedIndex == 0)
            {
                return;
            }

            int start = 0;
            int end = 0;
            if(rating_filer.SelectedIndex == 1)
            {
                start = 0;
                end = 3;
            }
            else if(rating_filer.SelectedIndex == 2)
            {
                start = 3;
                end = 7;
            }
            else if(rating_filer.SelectedIndex == 3)
            {
                start = 7;
                end = 10;
            }

                flow_trainer_report.Controls.Clear();
                string query = "WITH cte AS (" +
                    "select trainer_id ,avg(rating) as avg_feedback  " +
                    "from feedback " +
                    "group by trainer_id" +
                    ")" +
                    "select *" +
                    " from trainer " +
                    "join cte on cte.trainer_id = trainer.userid"; 

                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (int.Parse(dt.Rows[i][9].ToString()) >= start && int.Parse(dt.Rows[i][9].ToString()) < end)
                    {
                        trainerinfoDiv trainer = new trainerinfoDiv()
                        {
                            get_set_name = dt.Rows[i][2].ToString() + ' ' + dt.Rows[i][3].ToString(),
                            get_set_speclization = dt.Rows[i][6].ToString(),
                            get_set_id = int.Parse(dt.Rows[i][0].ToString()),
                            get_set_phone = dt.Rows[i][4].ToString(),
                            get_set_gender = dt.Rows[i][5].ToString(),
                            get_set_username = dt.Rows[i][1].ToString(),
                        };
                        trainer.viewBtn += view_trainer;
                        flow_trainer_report.Controls.Add(trainer);
                    }
                    
                }

        }
        private void specialization_rating_filer()
        {
            int start = 0;
            int end = 0;
            if (rating_filer.SelectedIndex == 1)
            {
                start = 0;
                end = 3;
            }
            else if (rating_filer.SelectedIndex == 2)
            {
                start = 3;
                end = 7;
            }
            else
            {
                start = 7;
                end = 10;
            }
            string selectedItem = spec_dropdown.SelectedItem.ToString();
            flow_trainer_report.Controls.Clear();
            string query = "WITH cte AS (" +
                "select trainer_id ,avg(rating) as avg_feedback  " +
                "from feedback " +
                "group by trainer_id " +
                ")" +
                " select *" +
                " from trainer " +
                "join cte on cte.trainer_id = trainer.userid " +
                " where trainer.specialization = '" + selectedItem + "'";
            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i][9].ToString()) >= start && int.Parse(dt.Rows[i][9].ToString()) < end)
                {
                    trainerinfoDiv trainer = new trainerinfoDiv()
                    {
                        get_set_name = dt.Rows[i][2].ToString() + ' ' + dt.Rows[i][3].ToString(),
                        get_set_speclization = dt.Rows[i][6].ToString(),
                        get_set_id = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_phone = dt.Rows[i][4].ToString(),
                        get_set_gender = dt.Rows[i][5].ToString(),
                        get_set_username = dt.Rows[i][1].ToString(),
                    };
                    trainer.viewBtn += view_trainer;
                    flow_trainer_report.Controls.Add(trainer);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flow_trainer_report.Controls.Clear();
            spec_dropdown.SelectedIndex = 0;
            rating_filer.SelectedIndex = 0;
            string query = "select * from trainer where gym_id = '" + gymid + "'";

            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                trainerinfoDiv trainer = new trainerinfoDiv()
                {
                    get_set_name = dt.Rows[i][2].ToString() + ' ' + dt.Rows[i][3].ToString(),
                    get_set_speclization = dt.Rows[i][6].ToString(),
                    get_set_id = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_phone = dt.Rows[i][4].ToString(),
                    get_set_gender = dt.Rows[i][5].ToString(),
                    get_set_username = dt.Rows[i][1].ToString(),

                };
                trainer.viewBtn += view_trainer;
                flow_trainer_report.Controls.Add(trainer);
            }

        }

        private void numericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            dropdown_Set.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            dropdown_Set.Hide();
            flow_member_show.Controls.Clear();

            string value = edit_Set.Text;

            if (value == "")
                return;
            if(value == "1" )
                value = value + " Month";
            else
                value = value + " Months";

            string query = "select * from  " +
                "membership  " +
                "where gym_id = '" + gymid + "' and duration = '" + value + "'";

            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from member where userid = '" + dt.Rows[i][2] + "'";
                DataTable dt2 = database.search_to_check(query);

                query = "select * from account where username = '" + dt2.Rows[0][1] + "'";
                DataTable dt3 = database.search_to_check(query);

                MemberInfo member = new MemberInfo()
                {
                    get_set_memberid = int.Parse(dt2.Rows[0][0].ToString()),
                    get_set_fullname = dt2.Rows[0][2].ToString() + ' ' + dt2.Rows[0][3].ToString(),
                    get_set_contact = dt2.Rows[0][4].ToString(),
                    get_set_gender = dt2.Rows[0][5].ToString(),
                    get_set_email = dt3.Rows[0][2].ToString(),
                    get_set_duration = dt.Rows[i][1].ToString()
                };
                member.removeBtn += remove_member;
                flow_member_show.Controls.Add(member);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            edit_Set.Text = "";
            flow_member_show.Controls.Clear();
            check = true;
            string query = "select * from membership where gym_id = '" + gymid + "'";
            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = "select * from member where userid = '" + dt.Rows[i][2] + "'";
                DataTable dt2 = database.search_to_check(query);

                query = "select * from account where username = '" + dt2.Rows[0][1] + "'";
                DataTable dt3 = database.search_to_check(query);

                MemberInfo member = new MemberInfo()
                {
                    get_set_memberid = int.Parse(dt2.Rows[0][0].ToString()),
                    get_set_fullname = dt2.Rows[0][2].ToString() + ' ' + dt2.Rows[0][3].ToString(),
                    get_set_contact = dt2.Rows[0][4].ToString(),
                    get_set_gender = dt2.Rows[0][5].ToString(),
                    get_set_email = dt3.Rows[0][2].ToString(),
                    get_set_duration = dt.Rows[i][1].ToString()
                };
                member.removeBtn += remove_member;
                flow_member_show.Controls.Add(member);
            }
        }

        private void filter_plan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter_plan.SelectedIndex == 0)
            {
                return;
            }
            if(filter_plan.SelectedIndex == 1)
            {
                planflow.Controls.Clear();
                string query = "select plan_id , plan_name , details  , creator " +
                    "from workout_plan " +
                    "join trainer on  trainer.username = workout_plan.creator " +
                    "where trainer.gym_id = '" + gymid + "'";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv3 plan = new PlanDiv3()
                    {
                        get_set_ownername = dt.Rows[i][3].ToString(),
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += show_Details_workout;
                    plan.planSubBtn += show_subscriber_workout;
                    plan.removebtn += remove_diet_plan;
                    planflow.Controls.Add(plan);
                }
            }
            else
            {
                planflow.Controls.Clear();
                string query = "select plan_id , plan_name , details  , creator " +
                    "from diet_plan " +
                    "join trainer on  trainer.username = diet_plan.creator " +
                    "where trainer.gym_id = '" + gymid + "'";
                DataTable dt = database.search_to_check(query);
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv3 plan = new PlanDiv3()
                    {
                        get_set_ownername = dt.Rows[i][3].ToString(),
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += show_Details_diet;
                    plan.planSubBtn += show_subscriber_diet;
                    plan.removebtn += remove_diet_plan;
                    planflow.Controls.Add(plan);
                }
            }

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            planflow.Controls.Clear();
            filter_plan.SelectedIndex = 0;

            string query = "select plan_id , plan_name , details  , creator " +
                "from workout_plan " +
                "join trainer on  trainer.username = workout_plan.creator " +
                "where trainer.gym_id = '" + gymid + "'";
            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv3 plan = new PlanDiv3()
                {
                    get_set_ownername = dt.Rows[i][3].ToString(),
                    get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_planName = dt.Rows[i][1].ToString(),
                };
                plan.detailBtn += show_Details_workout;
                plan.planSubBtn += show_subscriber_workout;
                plan.removebtn += remove_diet_plan;
                planflow.Controls.Add(plan);
            }

            query = "select plan_id , plan_name , details  , creator " +
                "from diet_plan " +
                "join trainer on  trainer.username = diet_plan.creator " +
                "where trainer.gym_id = '" + gymid + "'";
            dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                PlanDiv3 plan = new PlanDiv3()
                {
                    get_set_ownername = dt.Rows[i][3].ToString(),
                    get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_planName = dt.Rows[i][1].ToString(),
                };
                plan.detailBtn += show_Details_diet;
                plan.planSubBtn += show_subscriber_diet;
                plan.removebtn += remove_diet_plan;
                planflow.Controls.Add(plan);
            }
        }

        private void planSubscribersToWorkoutPlanBtn_Click(object sender, EventArgs e)
        {
            gymowner_tab.SelectTab("sub_tab");
        }
    }
}

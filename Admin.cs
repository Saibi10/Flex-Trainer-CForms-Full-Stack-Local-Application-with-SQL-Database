using Flex_Trainer.Classes;
using Flex_Trainer.Divs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Flex_Trainer
{
    public partial class Admin : Form
    {

        gymperformance gym = null;
        List<bool> tabs = new List<bool>();
        DB_Access database = new DB_Access();
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string contactNo { get; set; }
        public string gender { get; set; }
        public string email { get; set; }

        Form1 mainForm { get; set; }
        public Admin(Form1 A)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Admin_Load;
            mainForm = A;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            username_link.Text = username;
            drop_down.Visible = false;

            string query = "select * from account where username = '" + username + "'";
            DataTable dt = database.search_to_check(query);
            email = dt.Rows[0][2].ToString();
            query = "select * from admin where username = '" + username + "'";
            dt = database.search_to_check(query);
            gender = dt.Rows[0][5].ToString();


            query = "select * from gym";
            dt = database.search_to_check(query);
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                gymperformance gym = new gymperformance()
                {
                    get_set_gymid = int.Parse(dt.Rows[i][0].ToString()),
                    get_set_gymname = dt.Rows[i][1].ToString(),
                    get_set_location = dt.Rows[i][2].ToString(),
                    get_set_ownerid = int.Parse(dt.Rows[i][3].ToString()),
                    get_set_price = int.Parse(dt.Rows[i][4].ToString())
                };
                gym.viewBtn += view_gym_information;
                flow_all_gym.Controls.Add(gym);
            }

        }

        private void admin_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            drop_down.Visible = false;
            if (admin_tab.SelectedTab.Name == "ownerrequest_tab")
            {
                flow_gym_request.Controls.Clear();
                string query = "select gym_owner_request.member_id ,gym_owner_request.name , gym_owner_request.address , gym_owner_request.membership_price , CONCAT(member.firstname,' ' , member.lastname) as fullname , member.phone" +
                " from gym_owner_request" +
                " join member on member.userid = gym_owner_request.member_id";

                DataTable dt = database.search_to_check(query);
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    requestDiv request = new requestDiv()
                    {
                        get_set_name = dt.Rows[i][4].ToString(),
                        get_set_gymaddress = dt.Rows[i][2].ToString(),
                        get_set_contactnumber = dt.Rows[i][5].ToString(),
                        get_set_price = dt.Rows[i][3].ToString(),
                        get_set_gymname = dt.Rows[i][1].ToString(),
                        get_set_userid = int.Parse(dt.Rows[i][0].ToString())
                    };
                    request.acceptBtn += AcceptRequest;
                    request.declineBtn += declineRequest;
                    flow_gym_request.Controls.Add(request);
                }
            }
            else if (admin_tab.SelectedTab.Name == "removegym_tab") 
            {
                flow_remove_gym.Controls.Clear();
                string query = "select gym.gymid , gym.name , gym.address , gym_owner.userid , gym_owner.username , concat(gym_owner.firstname, ' ', gym_owner.lastname) as full_name, gym_owner.phone" +
                                " from gym" +
                                " join gym_owner on gym.owner_id = gym_owner.userid";


                DataTable dt = database.search_to_check(query);
                //MessageBox.Show(dt.Rows.Count.ToString());

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    removeDiv remove = new removeDiv()
                    {
                        get_set_gymid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_gymname = dt.Rows[i][1].ToString(),
                        get_set_address = dt.Rows[i][2].ToString(),
                        get_set_userid = int.Parse(dt.Rows[i][3].ToString()),
                        get_set_username = dt.Rows[i][4].ToString(),
                        get_set_ownername = dt.Rows[i][5].ToString(),
                        get_set_contactno = dt.Rows[i][6].ToString()
                    };
                    remove.removeBtn += removeGym;
                    flow_remove_gym.Controls.Add(remove);
                }
            }
            else if(admin_tab.SelectedTab.Name == "performance_tab")
            {
                flow_all_gym.Controls.Clear();
                string query = "select * from gym";
                DataTable dt = database.search_to_check(query);
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    gymperformance gym = new gymperformance()
                    {
                        get_set_gymid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_gymname = dt.Rows[i][1].ToString(),
                        get_set_location = dt.Rows[i][2].ToString(),
                        get_set_ownerid = int.Parse(dt.Rows[i][3].ToString()),
                        get_set_price = int.Parse(dt.Rows[i][4].ToString())
                    };
                    gym.viewBtn += view_gym_information;
                    flow_all_gym.Controls.Add(gym);
                }
            }
            else if (admin_tab.SelectedTab.Name == "view_profile")
            {
                edit_name.Text = firstname + " " + lastname;
                email_txt.PlaceholderText = email;
                edit_gender.PlaceholderText = gender;
                edit_phone.PlaceholderText = contactNo;
                edit_username.PlaceholderText = username;
            }
            else if(admin_tab.SelectedTab.Name == "fedbackGYm")
            {
                flow_view_feedback.Controls.Clear();
                gymname_tab_feedback.Text = gym.get_set_gymname; ;
                string query = "select * from gym_review where gym_id = '" + gym.get_set_gymid + "'";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    query = "select * from member where username = '" + dt.Rows[i][2] + "'";
                    DataTable dt2 = database.search_to_check(query);
                    if (dt2.Rows.Count == 0)
                        continue;
                    feedbackdiv feedback = new feedbackdiv()
                    {
                        get_set_name = dt2.Rows[0][2].ToString() + " " + dt2.Rows[0][3].ToString(),
                        get_set_description = dt.Rows[i][4].ToString(),
                        get_set_date = "Rating = " + dt.Rows[i][3].ToString()
                    };
                    flow_view_feedback.Controls.Add(feedback);
                }
            }
            else if(admin_tab.SelectedTab.Name == "workoutplan_tab")
            {
                workoutplan_flow.Controls.Clear();
                string query = "select * from workout_plan";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_ownername = dt.Rows[i][3].ToString(),
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += show_Details_workout;
                    plan.planSubBtn += show_subscriber_workout;
                    workoutplan_flow.Controls.Add(plan);
                }
            }
            else if(admin_tab.SelectedTab.Name == "dietplan_tab")
            {
                dietplan_flow.Controls.Clear();
                string query = "select * from diet_plan";
                DataTable dt = database.search_to_check(query);

                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    PlanDiv2 plan = new PlanDiv2()
                    {
                        get_set_ownername = dt.Rows[i][3].ToString(),
                        get_set_planid = int.Parse(dt.Rows[i][0].ToString()),
                        get_set_planName = dt.Rows[i][1].ToString(),
                    };
                    plan.detailBtn += show_Details_diet;
                    plan.planSubBtn += show_subscriber_diet;
                    dietplan_flow.Controls.Add(plan);
                }
            }
        }

        private void show_subscriber_diet(object sender, EventArgs e)
        {
            memberListFlow.Controls.Clear();
            admin_tab.SelectTab("sub_tab");
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
            admin_tab.SelectTab("sub_tab");
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

        private void show_Details_workout(object sender, EventArgs e)
        {
            admin_tab.SelectTab("plandetail_tab");
            PlanDiv2 plan = (PlanDiv2)sender;

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
            admin_tab.SelectTab("plandetail_tab");
            PlanDiv2 plan = (PlanDiv2)sender;

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
      
        private void kickMemberWorkout(object sender, EventArgs e)
        {
            SubscribedMember mem = (SubscribedMember)sender;

            string remMem = $"delete from member_workout where member_id = '{mem.getSetMemberId}'";
            database.query_data(remMem);
            MessageBox.Show("Member Deleted");
            admin_tab.SelectTab("workoutplan_tab");
        }

        private void kickMemberDiet(object sender, EventArgs e)
        {
            SubscribedMember mem = (SubscribedMember)sender;

            string remMem = $"delete from member_diet where member_id = '{mem.getSetMemberId}'";
            MessageBox.Show(remMem);
            database.query_data(remMem);
            MessageBox.Show("Member Deleted");
            admin_tab.SelectTab("dietplan_tab");
        }

        private void AcceptRequest(object sender, EventArgs e)
        {
            requestDiv user = (requestDiv)sender;

            //select the user from member
            string query = "select * from member where userid = '" + user.get_set_userid + "'";
            DataTable dt = database.search_to_check(query);
            //delete user from member
            string query2 = "delete member where userid = '" + user.get_set_userid + "' ";
            string delAcc = $"delete account where username = '{dt.Rows[0][1].ToString()}'";
            string delMemWork = $"delete member_workout where member_id = '{user.get_set_userid}'";
            string delMemDiet = $"delete member_diet where member_id = '{user.get_set_userid}'";
            string delMembership = $"delete membership where member_id = '{user.get_set_userid}'";
            string delApp = $"delete appointment where member_id = '{user.get_set_userid}'";

            //Get Plan to delete exercise and meals
            string getPlanW = $"select * from workout_plan where creator = '{dt.Rows[0][1].ToString()}'";
            string getPlanD = $"select * from diet_plan where creator = '{dt.Rows[0][1].ToString()}'";
            DataTable WT = database.search_to_check(getPlanW);
            DataTable DT2 = database.search_to_check(getPlanD);

            //Delete Plans
            if (WT.Rows.Count > 0)
            {
                string delEx = $"delete exercise where plan_id = {WT.Rows[0][0].ToString()}";
                database.query_data(delEx);
            }
            if (DT2.Rows.Count > 0)
            {
                string delMeal = $"delete meals where plan_id = {DT2.Rows[0][0].ToString()}";
                database.query_data(delMeal);
            }
            string delPlansWork = $"delete workout_plan where creator = '{dt.Rows[0][1].ToString()}'";
            string delPlansDiet = $"delete diet_plan where creator = '{dt.Rows[0][1].ToString()}'";

            //delete request 
            string query3 = "delete from gym_owner_request where member_id = '" + user.get_set_userid + "'";

            database.query_data(query3);
            database.query_data(delMemWork);
            database.query_data(delMemDiet);
            database.query_data(delMembership);
            database.query_data(delApp);
            database.query_data(delPlansDiet);
            database.query_data(delPlansWork);
            database.query_data(query2);


            //insert the user to gym owner
            query = "insert into gym_owner values('" + dt.Rows[0][1] + "' , '" + dt.Rows[0][2] + "' ,'" + dt.Rows[0][3] + "','" + dt.Rows[0][4] + "' ,'" + dt.Rows[0][5] + "')";

            database.query_data(query);

            //select the gymowner id from ggmowner table 
            query = "select * from gym_owner where username = '" + dt.Rows[0][1] + "'";

            DataTable dt2 = database.search_to_check(query);

            query = "insert into gym values ('" + user.get_set_gymname + "' ,'" + user.get_set_gymaddress + "' , '" + dt2.Rows[0][0] + "' ,'" + user.get_set_price + "' )";

            database.query_data(query);

            flow_gym_request.Controls.Remove(user);

            flow_all_gym.Controls.Clear();
            flow_remove_gym.Controls.Clear();

        }

        private void declineRequest(object sender, EventArgs e)
        {
            drop_down.Visible = false;
            requestDiv user = (requestDiv)sender;
            string query3 = "delete from gym_owner_request where member_id = '" + user.get_set_userid + "'";
            database.query_data(query3);
            flow_gym_request.Controls.Remove(user);
        }

        private void removeGym(object sender, EventArgs e)
        {
            drop_down.Visible = false;
            removeDiv user = (removeDiv)sender;

            string query = "select * from trainer where gym_id = '" + user.get_set_gymid + "'";
            DataTable dt = database.search_to_check(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //delete all the appointment related to the this gym with some trainer
                query = "delete from appointment where trainer_id = '" + dt.Rows[i][0] + "'";
                database.query_data(query);

            }

            //delete all the membership of this gym
            query = "delete from membership where gym_id = '" + user.get_set_gymid + "'";
            database.query_data(query);
  
            //delete all the review of the deleted GYM
            query = "delete from gym_review where gym_id = '" + user.get_set_gymid + "'";
            database.query_data(query);

            //select all the trainer of the GYM
            query = "select * from trainer where gym_id = '" + user.get_set_gymid + "'";
            dt = database.search_to_check(query);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //demote all the trainer to member
                query = "insert into member values('" + dt.Rows[i][1] + "','" + dt.Rows[i][2] + "','" + dt.Rows[i][3] + "','" + dt.Rows[i][4] + "', '" + dt.Rows[i][5] + "')";
                database.query_data(query);
            }

            //delete all the the trainer
            query = "delete from trainer where gym_id = '" + user.get_set_gymid + "'";
            database.query_data(query);

            //delete all trainer reuqest where gym is equal to gym
            query = "delete from trainer_request where gym_id= '" + user.get_set_gymid + "'";
            database.query_data(query);

            //delete GYM of the gym id
            query = "delete from gym where gymid = '" + user.get_set_gymid + "'";
            database.query_data(query);

            //Select the GYM owner of the GYM
            query = "select * from gym_owner where userid = '" + user.get_set_userid + "'";
            dt = database.search_to_check(query);

            //Remove the GYM Owner Form GYM
            query = "delete from gym_owner where userid = '" + user.get_set_userid + "'";
            database.query_data(query);

            //demote the gym owner to normal member of the app
            query = "insert into member values('" + dt.Rows[0][1] + "','" + dt.Rows[0][2] + "','" + dt.Rows[0][3] + "','" + dt.Rows[0][4] + "', '" + dt.Rows[0][5] + "')";
            database.query_data(query);

            flow_remove_gym.Controls.Remove(user);

            flow_all_gym.Controls.Clear();
        }

        private void view_gym_information(object sender, EventArgs e)
        {
            gymperformance gym = (gymperformance)sender;
            this.gym = gym;
            header.Text = gym.get_set_gymname;
            edit_address.Text = gym.get_set_location;
            edit_mem_price.Text = gym.get_set_price.ToString();

            string q = "select * from membership where gym_id = '" + gym.get_set_gymid + "'";
            DataTable dtx = database.search_to_check(q);
            edit_revenue.Text = (dtx.Rows.Count * gym.get_set_price).ToString();

            string query = "select * from gym_owner where gym_owner.userid = '" + gym.get_set_ownerid + "'";

            DataTable dt = database.search_to_check(query);
             
            edit_owner_name.Text = dt.Rows[0][2].ToString() +  " "+ dt.Rows[0][3].ToString();
            edit_gendre.Text = dt.Rows[0][5].ToString();
            edit_contact.Text = dt.Rows[0][4].ToString();

            query = "select membership.gym_id from membership  where membership.gym_id = '" + gym.get_set_gymid + "'";
            dt = database.search_to_check(query);

            edit_Tmembers.Text = dt.Rows.Count.ToString();

            query = "select * from trainer where gym_id = '" + gym.get_set_gymid + "'";

            edit_Ttrainers.Text = dt.Rows.Count.ToString();

            query = "select CONCAT(member.firstname , ' ' , member.lastname) as Name , member.phone as [Contact Number], member.gender as Gender, membership.duration As [Membership Duration]" +
                "from member " +
                "join membership on membership.member_id = member.userid " +
                "where membership.gym_id = '"+gym.get_set_gymid+"'";

            dt = database.search_to_check(query);

            member_data_grid.DataSource = dt;

            member_data_grid.Size = new Size(928,5 + 30 + (30 * dt.Rows.Count));

           
            int y = member_data_grid.Size.Height + member_data_grid.Location.Y + 50;
            trainer_tag.Location = new Point(30, y);

            y = trainer_tag.Location.Y + 30;
            grid_trainer_view.Location = new Point(15, y);

            query = "select concat(trainer.firstname , ' ' , trainer.lastname) as Name , trainer.phone as [Contact Number],trainer.gender as Gender , trainer.specialization As Speclization " +
                "from trainer " +
                "where trainer.gym_id = '"+gym.get_set_gymid+"'";
            

            dt = database.search_to_check(query);
            grid_trainer_view.Size = new Size(928,5 + 30 + (30 * dt.Rows.Count));
            grid_trainer_view.DataSource = dt;

            bottom_btn.Location = new Point(0, grid_trainer_view.Size.Height + grid_trainer_view.Location.Y + 10);
            admin_tab.SelectTab("tabPage1");
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            drop_down.Show();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Rectangle tabBounds =  admin_tab.Bounds;

            drop_down.Visible = false;
            logs_grid.Hide();
            flow_all_gym.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            admin_tab.SelectTab("view_profile");
        }

        private void username_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_tab.SelectTab("view_profile");
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            admin_tab.SelectTab("fedbackGYm");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            admin_tab.SelectTab("tabPage1"); 
        }

        private void planSubscribersToWorkoutPlanBtn_Click(object sender, EventArgs e)
        {

        }

        private void planSubscribersToWorkoutPlanBtn_Click_1(object sender, EventArgs e)
        {
            admin_tab.SelectTab("workoutplan_tab");
        }

        private void notifications_btn_Click(object sender, EventArgs e)
        {
            flow_all_gym.Hide();
            logs_grid.Show();

            admin_tab.SelectedIndex = 0;

            string query = "select  * from logs";

            DataTable dt = database.search_to_check(query);

            logs_grid.DataSource = dt;

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string machine = machine_name.Text;
            string location = location_text.Text;

            string query = "select * from gym join membership on membership.gym_id = gym.gymid where address like '%" +location+"%'";
            DataTable dt = database.search_to_check(query);

            logs_grid.DataSource = dt;
            int count = 0;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                query = " select * from member_workout join exercise on member_workout.workout_plan = exercise.plan_id where member_workout.member_id = '" + dt.Rows[i][7] +"'";

                DataTable dt2 = database.search_to_check(query);

                for(int j = 0; j < dt2.Rows.Count; ++j)
                {
                    if (dt2.Rows[j][10].ToString() == machine)
                    {
                        count++;
                    }
                }

            }
            count_text.Text = count.ToString();
            machine_name.Text = "";
            location_text.Text = "";

        }
    }



}

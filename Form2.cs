using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHibernateStart
{
    public partial class Form2 : Form
    {
        //private bool editMode = false;
        private int taskId;
        private Task task;

        internal Task Task { get => task; set => task = value; }

        public Form2()
        {
            InitializeComponent();
        }
        public void SetTaskName(string name)
        {
            this.textBoxTaskName.Text = name;
        }
        public void SetTaskDescription(string description)
        {
            this.richTextBoxTaskDescription.Text = description;
        }
        public void SetTaskId(int id)
        {
            this.taskId = id;
        }
        public void SaveHandler(object sender, EventArgs e)
        {
            if (taskId > 0)
            {
                EditTask();
            }
            else
            {
                AddTask();
            }
            this.Close();
        }
        public void CloseHandler(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AddTask()
        {
            ISession mySession = NHibernateHelper.GetCurrentSession();
            try
            {
                // Adding Task
                using (mySession.BeginTransaction())
                {
                    Task task = new Task
                    {
                        Name = this.textBoxTaskName.Text,
                        Description = this.richTextBoxTaskDescription.Text,
                        Status = "Undone",
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now
                    };
                    mySession.Save(task);
                    mySession.Transaction.Commit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error - task not added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        public void EditTask()
        {
            ISession mySession = NHibernateHelper.GetCurrentSession();
            try
            {
                // Update Task
                using (mySession.BeginTransaction())
                {
                    Task.Name = this.textBoxTaskName.Text;
                    Task.Description = this.richTextBoxTaskDescription.Text;

                    mySession.Update(Task);
                    mySession.Transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error - task not saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

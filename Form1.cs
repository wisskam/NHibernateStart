using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHibernateStart
{
    public partial class Form1 : Form
    {
        TaskPanel[] taskPanels;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }
        private void LoadTasks()
        {
            ISession mySession = NHibernateHelper.GetCurrentSession();
            try
            {
                //Getting Tasks
                using (mySession.BeginTransaction())
                {
                    List<Task> tasks = mySession.Query<Task>().ToList();
                    mySession.Transaction.Commit();
                    taskPanels = new TaskPanel[tasks.Count];
                    //this.checkedListBoxTasks.Items.AddRange(tasks.Select(x => x.Name).ToArray());
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        taskPanels[i] = new TaskPanel();
                        taskPanels[i].Changed += new System.EventHandler(this.ReloadTasks);
                        taskPanels[i].GenerateControls(tasks[i], i);

                    }
                    this.panelTasksGroup.Controls.AddRange(taskPanels);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error - task not added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void ReloadTasks(object sender, EventArgs e)
        {
            this.panelTasksGroup.Controls.Clear();
            LoadTasks();
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            Form2 addDialog = new Form2();
            addDialog.ShowDialog(this);
            addDialog.Dispose();
            ReloadTasks(sender, e);
        }
        private void CloseSessionHandler(object sender, EventArgs e)
        {
            NHibernateHelper.CloseSession();
            NHibernateHelper.CloseSessionFactory();
        }

        private void buttonTaskReload_Click(object sender, EventArgs e)
        {
            ReloadTasks(sender, e);
        }
    }
}

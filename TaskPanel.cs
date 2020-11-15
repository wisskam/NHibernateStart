using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHibernateStart
{
    class TaskPanel : Panel
    {
        public Label taskNameLabel;
        public Label taskDescriptionLabel;
        public CheckBox taskStatusCheckBox;
        public Button taskRemoveButton;
        public Task task;

        public event System.EventHandler Changed;
        public EventArgs e = null;

        public TaskPanel()
        {

        }
        public void GenerateControls(Task task, int taskNumber)
        {
            this.task = task;
            this.taskStatusCheckBox = new CheckBox();
            this.taskDescriptionLabel = new Label();
            this.taskNameLabel = new Label();
            this.taskRemoveButton = new Button();
            this.SuspendLayout();
            //
            // TaskPanel
            //
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor = task.Status == "Done" 
                ? System.Drawing.Color.DarkSeaGreen 
                : System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.taskStatusCheckBox);
            this.Controls.Add(this.taskDescriptionLabel);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.taskRemoveButton);
            this.Location = new System.Drawing.Point(7, 20 + ((65 * taskNumber)));
            this.MinimumSize = new System.Drawing.Size(292, 50);
            this.Name = $"panelTask{task.Id}";
            this.Size = new System.Drawing.Size(320, 50);
            this.TabIndex = 0;
            this.DoubleClick += new System.EventHandler(this.DoubleClickHandler);
            // 
            // taskStatusCheckBox
            // 
            this.taskStatusCheckBox.AutoSize = true;
            this.taskStatusCheckBox.Location = new System.Drawing.Point(4, 21);
            this.taskStatusCheckBox.Name = $"taskStatusCheckBox{task.Id}";
            this.taskStatusCheckBox.Size = new System.Drawing.Size(15, 14);
            this.taskStatusCheckBox.TabIndex = 2;
            this.taskStatusCheckBox.UseVisualStyleBackColor = true;
            this.taskStatusCheckBox.Checked = task.Status == "Done";
            this.taskStatusCheckBox.CheckStateChanged += new System.EventHandler(this.ChangeTaskStatusHandler);

            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.AutoSize = true;
            this.taskDescriptionLabel.Location = new System.Drawing.Point(20, 22);
            this.taskDescriptionLabel.MaximumSize = new System.Drawing.Size(230, 200);
            this.taskDescriptionLabel.Name = $"taskDescriptionLabel{task.Id}";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(230, 13);
            this.taskDescriptionLabel.TabIndex = 1;
            this.taskDescriptionLabel.Text = $"{task.Description}";
            this.taskDescriptionLabel.DoubleClick += new System.EventHandler(this.DoubleClickHandler);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskNameLabel.Location = new System.Drawing.Point(20, 9);
            this.taskNameLabel.Name = $"taskNameLabel{task.Id}";
            this.taskNameLabel.MaximumSize = new System.Drawing.Size(200, 13);
            this.taskNameLabel.Size = new System.Drawing.Size(41, 13);
            this.taskNameLabel.TabIndex = 0;
            this.taskNameLabel.Text = $"{task.Name}";
            this.taskNameLabel.DoubleClick += new System.EventHandler(this.DoubleClickHandler);
            // 
            // taskRemoveButton
            // 
            this.taskRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskRemoveButton.BackColor = System.Drawing.Color.Crimson;
            this.taskRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskRemoveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskRemoveButton.Location = new System.Drawing.Point(290, 3);
            this.taskRemoveButton.Name = "button1";
            this.taskRemoveButton.Size = new System.Drawing.Size(25, 25);
            this.taskRemoveButton.Text = "X";
            this.taskRemoveButton.UseVisualStyleBackColor = false;
            this.taskRemoveButton.Click += new System.EventHandler(this.RemoveTaskHandler);


            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void ChangeTaskStatusHandler(object sender, EventArgs e)
        {
            this.BackColor = this.taskStatusCheckBox.Checked 
                ? System.Drawing.Color.DarkSeaGreen 
                : System.Drawing.SystemColors.ControlLight;
            task.Status = 
                task.Status == "Done"
                ? task.Status = "Undone"
                : task.Status = "Done";

            ISession mySession = NHibernateHelper.GetCurrentSession();
            try
            {
                // Update Task
                using (mySession.BeginTransaction())
                {
                    mySession.Update(task);
                    mySession.Transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error - task not updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void DoubleClickHandler(object sender, EventArgs e)
        {
            Form2 editDialog = new Form2();
            editDialog.SetTaskName(task.Name);
            editDialog.SetTaskDescription(task.Description);
            editDialog.SetTaskId(task.Id);
            editDialog.Task = task;
            editDialog.ShowDialog(this);
            Changed(this, e);
            editDialog.Dispose();
        }
        private void RemoveTaskHandler(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Do you want to remove this task? - {this.task.Name}",
                    "Remove task",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dialogResult == DialogResult.Yes)
                {
                    ISession mySession = NHibernateHelper.GetCurrentSession();
                    try
                    {
                        // Remove Task
                        using (mySession.BeginTransaction())
                        {
                            mySession.Delete(this.task);
                            mySession.Transaction.Commit();
                        }
                        Changed(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Error - cannot delete task",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            catch (NullReferenceException nex)
            {
                MessageBox.Show(
                    nex.Message,
                    "Error - task is empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error - task is empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}

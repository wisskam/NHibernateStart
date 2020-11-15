namespace NHibernateStart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTasks = new System.Windows.Forms.Panel();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.groupBoxGeneratedTasks = new System.Windows.Forms.GroupBox();
            this.panelTasksGroup = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTaskReload = new System.Windows.Forms.Button();
            this.panelTasks.SuspendLayout();
            this.groupBoxGeneratedTasks.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTasks
            // 
            this.panelTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTasks.AutoScroll = true;
            this.panelTasks.Controls.Add(this.buttonTaskReload);
            this.panelTasks.Controls.Add(this.buttonAddTask);
            this.panelTasks.Controls.Add(this.groupBoxGeneratedTasks);
            this.panelTasks.Location = new System.Drawing.Point(12, 12);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(362, 465);
            this.panelTasks.TabIndex = 0;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTask.Location = new System.Drawing.Point(275, 6);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTask.TabIndex = 0;
            this.buttonAddTask.Text = "Add task";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // groupBoxGeneratedTasks
            // 
            this.groupBoxGeneratedTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneratedTasks.Controls.Add(this.panelTasksGroup);
            this.groupBoxGeneratedTasks.Location = new System.Drawing.Point(3, 35);
            this.groupBoxGeneratedTasks.Name = "groupBoxGeneratedTasks";
            this.groupBoxGeneratedTasks.Size = new System.Drawing.Size(347, 427);
            this.groupBoxGeneratedTasks.TabIndex = 1;
            this.groupBoxGeneratedTasks.TabStop = false;
            this.groupBoxGeneratedTasks.Text = "Tasks";
            // 
            // panelTasksGroup
            // 
            this.panelTasksGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTasksGroup.AutoScroll = true;
            this.panelTasksGroup.BackColor = System.Drawing.SystemColors.Control;
            this.panelTasksGroup.Location = new System.Drawing.Point(7, 20);
            this.panelTasksGroup.Name = "panelTasksGroup";
            this.panelTasksGroup.Size = new System.Drawing.Size(334, 401);
            this.panelTasksGroup.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel1.MinimumSize = new System.Drawing.Size(292, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 50);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(289, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.MinimumSize = new System.Drawing.Size(250, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // buttonTaskReload
            // 
            this.buttonTaskReload.Location = new System.Drawing.Point(10, 6);
            this.buttonTaskReload.Name = "buttonTaskReload";
            this.buttonTaskReload.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskReload.TabIndex = 2;
            this.buttonTaskReload.Text = "Reload";
            this.buttonTaskReload.UseVisualStyleBackColor = true;
            this.buttonTaskReload.Click += new System.EventHandler(this.buttonTaskReload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(386, 489);
            this.Controls.Add(this.panelTasks);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "NHibernate Tasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Disposed += new System.EventHandler(this.CloseSessionHandler);
            this.panelTasks.ResumeLayout(false);
            this.groupBoxGeneratedTasks.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.GroupBox groupBoxGeneratedTasks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Panel panelTasksGroup;
        private System.Windows.Forms.Button buttonTaskReload;
    }
}


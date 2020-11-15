namespace NHibernateStart
{
    partial class Form2
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
            this.labelTaskName = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.richTextBoxTaskDescription = new System.Windows.Forms.RichTextBox();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.buttonTaskSave = new System.Windows.Forms.Button();
            this.buttonTaskCancel = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(3, 2);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(35, 13);
            this.labelTaskName.TabIndex = 0;
            this.labelTaskName.Text = "Name";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(6, 19);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(385, 20);
            this.textBoxTaskName.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.richTextBoxTaskDescription);
            this.groupBoxTask.Controls.Add(this.labelTaskDescription);
            this.groupBoxTask.Controls.Add(this.textBoxTaskName);
            this.groupBoxTask.Controls.Add(this.labelTaskName);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(397, 176);
            this.groupBoxTask.TabIndex = 2;
            this.groupBoxTask.TabStop = false;
            // 
            // richTextBoxTaskDescription
            // 
            this.richTextBoxTaskDescription.Location = new System.Drawing.Point(6, 58);
            this.richTextBoxTaskDescription.Name = "richTextBoxTaskDescription";
            this.richTextBoxTaskDescription.Size = new System.Drawing.Size(385, 112);
            this.richTextBoxTaskDescription.TabIndex = 3;
            this.richTextBoxTaskDescription.Text = "";
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(3, 42);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(60, 13);
            this.labelTaskDescription.TabIndex = 2;
            this.labelTaskDescription.Text = "Description";
            // 
            // buttonTaskSave
            // 
            this.buttonTaskSave.Location = new System.Drawing.Point(334, 194);
            this.buttonTaskSave.Name = "buttonTaskSave";
            this.buttonTaskSave.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskSave.TabIndex = 3;
            this.buttonTaskSave.Text = "Save";
            this.buttonTaskSave.UseVisualStyleBackColor = true;
            this.buttonTaskSave.Click += new System.EventHandler(this.SaveHandler);
            // 
            // buttonTaskCancel
            // 
            this.buttonTaskCancel.Location = new System.Drawing.Point(12, 194);
            this.buttonTaskCancel.Name = "buttonTaskCancel";
            this.buttonTaskCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskCancel.TabIndex = 4;
            this.buttonTaskCancel.Text = "Cancel";
            this.buttonTaskCancel.UseVisualStyleBackColor = true;
            this.buttonTaskCancel.Click += new System.EventHandler(this.CloseHandler);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 224);
            this.Controls.Add(this.buttonTaskCancel);
            this.Controls.Add(this.buttonTaskSave);
            this.Controls.Add(this.groupBoxTask);
            this.Name = "Form2";
            this.Text = "NHibernate Tasks - Task";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelTaskDescription;
        private System.Windows.Forms.RichTextBox richTextBoxTaskDescription;
        private System.Windows.Forms.Button buttonTaskSave;
        private System.Windows.Forms.Button buttonTaskCancel;
    }
}
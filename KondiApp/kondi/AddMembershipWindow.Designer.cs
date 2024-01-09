namespace kondi
{
    partial class AddMembershipWindow
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
            label1 = new Label();
            radioButtonDaily = new RadioButton();
            radioButtonMonthly = new RadioButton();
            radioButtonAnnual = new RadioButton();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            buttonCancel = new Button();
            buttonAdd = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(238, 30);
            label1.TabIndex = 1;
            label1.Text = "Create new membership";
            // 
            // radioButtonDaily
            // 
            radioButtonDaily.AutoSize = true;
            radioButtonDaily.Location = new Point(48, 77);
            radioButtonDaily.Name = "radioButtonDaily";
            radioButtonDaily.Size = new Size(121, 19);
            radioButtonDaily.TabIndex = 2;
            radioButtonDaily.TabStop = true;
            radioButtonDaily.Text = "Daily membership";
            radioButtonDaily.UseVisualStyleBackColor = true;
            radioButtonDaily.CheckedChanged += radioButtonDaily_CheckedChanged;
            // 
            // radioButtonMonthly
            // 
            radioButtonMonthly.AutoSize = true;
            radioButtonMonthly.Location = new Point(48, 102);
            radioButtonMonthly.Name = "radioButtonMonthly";
            radioButtonMonthly.Size = new Size(140, 19);
            radioButtonMonthly.TabIndex = 3;
            radioButtonMonthly.TabStop = true;
            radioButtonMonthly.Text = "Monthly membership";
            radioButtonMonthly.UseVisualStyleBackColor = true;
            radioButtonMonthly.CheckedChanged += radioButtonMonthly_CheckedChanged;
            // 
            // radioButtonAnnual
            // 
            radioButtonAnnual.AutoSize = true;
            radioButtonAnnual.Location = new Point(48, 127);
            radioButtonAnnual.Name = "radioButtonAnnual";
            radioButtonAnnual.Size = new Size(133, 19);
            radioButtonAnnual.TabIndex = 4;
            radioButtonAnnual.TabStop = true;
            radioButtonAnnual.Text = "Annual membership";
            radioButtonAnnual.UseVisualStyleBackColor = true;
            radioButtonAnnual.CheckedChanged += radioButtonAnnual_CheckedChanged;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(39, 188);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(200, 23);
            dateTimePickerStartDate.TabIndex = 5;
            dateTimePickerStartDate.ValueChanged += dateTimePickerStartDate_ValueChanged;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Enabled = false;
            dateTimePickerEndDate.Location = new Point(39, 217);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(200, 23);
            dateTimePickerEndDate.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.Window;
            buttonCancel.Location = new Point(164, 298);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 27;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.Window;
            buttonAdd.FlatAppearance.BorderColor = Color.Black;
            buttonAdd.Location = new Point(39, 298);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 26;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(39, 170);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 28;
            label2.Text = "Time range";
            // 
            // AddMembershipWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(281, 335);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(radioButtonAnnual);
            Controls.Add(radioButtonMonthly);
            Controls.Add(radioButtonDaily);
            Controls.Add(label1);
            Name = "AddMembershipWindow";
            Text = "Membership Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButtonDaily;
        private RadioButton radioButtonMonthly;
        private RadioButton radioButtonAnnual;
        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private Button buttonCancel;
        private Button buttonAdd;
        private Label label2;
    }
}
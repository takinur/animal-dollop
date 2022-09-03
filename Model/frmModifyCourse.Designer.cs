
namespace animalWeightTracker_00183727.Model
{
    partial class frmModifyCourse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyCourse));
            this.tmrError = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboGoal = new System.Windows.Forms.ComboBox();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lblIDName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrError
            // 
            this.tmrError.Interval = 2000;
            this.tmrError.Tick += new System.EventHandler(this.tmrError_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 26);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(492, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 26);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboGoal
            // 
            this.cboGoal.FormattingEnabled = true;
            this.cboGoal.Items.AddRange(new object[] {
            "Weight Gain",
            "Weight Loss"});
            this.cboGoal.Location = new System.Drawing.Point(154, 178);
            this.cboGoal.Name = "cboGoal";
            this.cboGoal.Size = new System.Drawing.Size(234, 21);
            this.cboGoal.TabIndex = 4;
            // 
            // cboAnimal
            // 
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboAnimal.Location = new System.Drawing.Point(154, 58);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(234, 21);
            this.cboAnimal.TabIndex = 0;
            // 
            // cboStaff
            // 
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(154, 148);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(234, 21);
            this.cboStaff.TabIndex = 3;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.dtEnd);
            this.pnlBody.Controls.Add(this.dtStart);
            this.pnlBody.Controls.Add(this.lblIDName);
            this.pnlBody.Controls.Add(this.lblID);
            this.pnlBody.Controls.Add(this.cboGoal);
            this.pnlBody.Controls.Add(this.cboAnimal);
            this.pnlBody.Controls.Add(this.cboStaff);
            this.pnlBody.Controls.Add(this.pnlError);
            this.pnlBody.Controls.Add(this.btnCancel);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.btnSave);
            this.pnlBody.Controls.Add(this.lblSp);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Location = new System.Drawing.Point(38, 99);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(427, 317);
            this.pnlBody.TabIndex = 9;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd-MM-yyy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(154, 117);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(234, 20);
            this.dtEnd.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd-MM-yyy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(154, 85);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(234, 20);
            this.dtStart.TabIndex = 1;
            // 
            // lblIDName
            // 
            this.lblIDName.AutoSize = true;
            this.lblIDName.BackColor = System.Drawing.Color.White;
            this.lblIDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDName.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblIDName.Location = new System.Drawing.Point(67, 31);
            this.lblIDName.Name = "lblIDName";
            this.lblIDName.Size = new System.Drawing.Size(196, 24);
            this.lblIDName.TabIndex = 15;
            this.lblIDName.Text = "Selected Course ID:";
            this.lblIDName.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Tomato;
            this.lblID.Location = new System.Drawing.Point(262, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 20);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "{ID}";
            this.lblID.Visible = false;
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.Tomato;
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlError.Location = new System.Drawing.Point(0, 0);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(425, 22);
            this.pnlError.TabIndex = 11;
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(425, 22);
            this.lblError.TabIndex = 12;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(211, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Goal:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(310, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSp
            // 
            this.lblSp.AutoSize = true;
            this.lblSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSp.Location = new System.Drawing.Point(95, 149);
            this.lblSp.Name = "lblSp";
            this.lblSp.Size = new System.Drawing.Size(48, 20);
            this.lblSp.TabIndex = 8;
            this.lblSp.Text = "Staff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(71)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 27);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(521, 48);
            this.pnlHeader.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Course";
            // 
            // frmModifyCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModifyCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModifyCourse";
            this.Load += new System.EventHandler(this.frmModifyCourse_Load);
            this.panel1.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboGoal;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblIDName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
    }
}
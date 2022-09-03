
namespace animalWeightTracker_00183727
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMinmz = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlRpsub = new System.Windows.Forms.Panel();
            this.btnDexList = new System.Windows.Forms.Button();
            this.btnMelist = new System.Windows.Forms.Button();
            this.btnMlist = new System.Windows.Forms.Button();
            this.btnDlist = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlDsub = new System.Windows.Forms.Panel();
            this.btnDex = new System.Windows.Forms.Button();
            this.btnDmeas = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.btnDlog = new System.Windows.Forms.Button();
            this.btnDr = new System.Windows.Forms.Button();
            this.pnlStSub = new System.Windows.Forms.Panel();
            this.btnStaf = new System.Windows.Forms.Button();
            this.btnAllOrg = new System.Windows.Forms.Button();
            this.btnOrg = new System.Windows.Forms.Button();
            this.pnlAnSub = new System.Windows.Forms.Panel();
            this.btnAex = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnSpecies = new System.Windows.Forms.Button();
            this.btnAnCourse = new System.Windows.Forms.Button();
            this.btnAnView = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TIME = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRpsub.SuspendLayout();
            this.pnlDsub.SuspendLayout();
            this.pnlStSub.SuspendLayout();
            this.pnlAnSub.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(196, 47);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(746, 553);
            this.pnlContainer.TabIndex = 13;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(71)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.btnMax);
            this.pnlTitle.Controls.Add(this.btnMinmz);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(196, 10);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(746, 37);
            this.pnlTitle.TabIndex = 9;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Advance Weight Tracking System";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(711, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 26);
            this.btnClose.TabIndex = 14;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMax.Location = new System.Drawing.Point(683, 6);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(28, 25);
            this.btnMax.TabIndex = 13;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMinmz
            // 
            this.btnMinmz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinmz.FlatAppearance.BorderSize = 0;
            this.btnMinmz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinmz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinmz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinmz.Image = ((System.Drawing.Image)(resources.GetObject("btnMinmz.Image")));
            this.btnMinmz.Location = new System.Drawing.Point(645, 5);
            this.btnMinmz.Name = "btnMinmz";
            this.btnMinmz.Size = new System.Drawing.Size(32, 28);
            this.btnMinmz.TabIndex = 13;
            this.btnMinmz.UseVisualStyleBackColor = true;
            this.btnMinmz.Click += new System.EventHandler(this.btnMinmz_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(196, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(746, 10);
            this.pnlTop.TabIndex = 12;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltop_MouseDown);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlMain.Controls.Add(this.lblTime);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.pnlRpsub);
            this.pnlMain.Controls.Add(this.btnReports);
            this.pnlMain.Controls.Add(this.pnlDsub);
            this.pnlMain.Controls.Add(this.btnDr);
            this.pnlMain.Controls.Add(this.pnlStSub);
            this.pnlMain.Controls.Add(this.btnOrg);
            this.pnlMain.Controls.Add(this.pnlAnSub);
            this.pnlMain.Controls.Add(this.btnAnimal);
            this.pnlMain.Controls.Add(this.pnlLogo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(196, 600);
            this.pnlMain.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(0, 512);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(196, 36);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = ":";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(3, 548);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(187, 52);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = ":";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRpsub
            // 
            this.pnlRpsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlRpsub.Controls.Add(this.btnDexList);
            this.pnlRpsub.Controls.Add(this.btnMelist);
            this.pnlRpsub.Controls.Add(this.btnMlist);
            this.pnlRpsub.Controls.Add(this.btnDlist);
            this.pnlRpsub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRpsub.Location = new System.Drawing.Point(0, 806);
            this.pnlRpsub.Name = "pnlRpsub";
            this.pnlRpsub.Size = new System.Drawing.Size(196, 178);
            this.pnlRpsub.TabIndex = 13;
            // 
            // btnDexList
            // 
            this.btnDexList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnDexList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDexList.FlatAppearance.BorderSize = 0;
            this.btnDexList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnDexList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnDexList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDexList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDexList.ForeColor = System.Drawing.Color.White;
            this.btnDexList.Location = new System.Drawing.Point(0, 135);
            this.btnDexList.Name = "btnDexList";
            this.btnDexList.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDexList.Size = new System.Drawing.Size(196, 43);
            this.btnDexList.TabIndex = 3;
            this.btnDexList.Text = "Daily Exercise";
            this.btnDexList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDexList.UseVisualStyleBackColor = false;
            this.btnDexList.Click += new System.EventHandler(this.btnDexList_Click);
            // 
            // btnMelist
            // 
            this.btnMelist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnMelist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMelist.FlatAppearance.BorderSize = 0;
            this.btnMelist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnMelist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnMelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMelist.ForeColor = System.Drawing.Color.White;
            this.btnMelist.Location = new System.Drawing.Point(0, 90);
            this.btnMelist.Name = "btnMelist";
            this.btnMelist.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMelist.Size = new System.Drawing.Size(196, 45);
            this.btnMelist.TabIndex = 2;
            this.btnMelist.Text = "Measurement";
            this.btnMelist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMelist.UseVisualStyleBackColor = false;
            this.btnMelist.Click += new System.EventHandler(this.btnMelist_Click);
            // 
            // btnMlist
            // 
            this.btnMlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnMlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMlist.FlatAppearance.BorderSize = 0;
            this.btnMlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnMlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnMlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMlist.ForeColor = System.Drawing.Color.White;
            this.btnMlist.Location = new System.Drawing.Point(0, 45);
            this.btnMlist.Name = "btnMlist";
            this.btnMlist.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMlist.Size = new System.Drawing.Size(196, 45);
            this.btnMlist.TabIndex = 1;
            this.btnMlist.Text = "Daily Meal";
            this.btnMlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMlist.UseVisualStyleBackColor = false;
            this.btnMlist.Click += new System.EventHandler(this.btnMlist_Click);
            // 
            // btnDlist
            // 
            this.btnDlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnDlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDlist.FlatAppearance.BorderSize = 0;
            this.btnDlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnDlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnDlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlist.ForeColor = System.Drawing.Color.White;
            this.btnDlist.Location = new System.Drawing.Point(0, 0);
            this.btnDlist.Name = "btnDlist";
            this.btnDlist.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDlist.Size = new System.Drawing.Size(196, 45);
            this.btnDlist.TabIndex = 0;
            this.btnDlist.Text = "Daily Log";
            this.btnDlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDlist.UseVisualStyleBackColor = false;
            this.btnDlist.Click += new System.EventHandler(this.btnDlist_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(72)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 752);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(196, 54);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlDsub
            // 
            this.pnlDsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlDsub.Controls.Add(this.btnDex);
            this.pnlDsub.Controls.Add(this.btnDmeas);
            this.pnlDsub.Controls.Add(this.btnMi);
            this.pnlDsub.Controls.Add(this.btnDlog);
            this.pnlDsub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDsub.Location = new System.Drawing.Point(0, 577);
            this.pnlDsub.Name = "pnlDsub";
            this.pnlDsub.Size = new System.Drawing.Size(196, 175);
            this.pnlDsub.TabIndex = 11;
            // 
            // btnDex
            // 
            this.btnDex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnDex.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDex.FlatAppearance.BorderSize = 0;
            this.btnDex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnDex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnDex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDex.ForeColor = System.Drawing.Color.White;
            this.btnDex.Location = new System.Drawing.Point(0, 131);
            this.btnDex.Name = "btnDex";
            this.btnDex.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDex.Size = new System.Drawing.Size(196, 45);
            this.btnDex.TabIndex = 3;
            this.btnDex.Text = "Daily Exercise";
            this.btnDex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDex.UseVisualStyleBackColor = false;
            this.btnDex.Click += new System.EventHandler(this.btnDex_Click);
            // 
            // btnDmeas
            // 
            this.btnDmeas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnDmeas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDmeas.FlatAppearance.BorderSize = 0;
            this.btnDmeas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnDmeas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnDmeas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDmeas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDmeas.ForeColor = System.Drawing.Color.White;
            this.btnDmeas.Location = new System.Drawing.Point(0, 86);
            this.btnDmeas.Name = "btnDmeas";
            this.btnDmeas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDmeas.Size = new System.Drawing.Size(196, 45);
            this.btnDmeas.TabIndex = 2;
            this.btnDmeas.Text = "Measurement";
            this.btnDmeas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDmeas.UseVisualStyleBackColor = false;
            this.btnDmeas.Click += new System.EventHandler(this.btnDmeas_Click);
            // 
            // btnMi
            // 
            this.btnMi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnMi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMi.FlatAppearance.BorderSize = 0;
            this.btnMi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnMi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnMi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMi.ForeColor = System.Drawing.Color.White;
            this.btnMi.Location = new System.Drawing.Point(0, 41);
            this.btnMi.Name = "btnMi";
            this.btnMi.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMi.Size = new System.Drawing.Size(196, 45);
            this.btnMi.TabIndex = 1;
            this.btnMi.Text = "Daily Meal";
            this.btnMi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMi.UseVisualStyleBackColor = false;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // btnDlog
            // 
            this.btnDlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnDlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDlog.FlatAppearance.BorderSize = 0;
            this.btnDlog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnDlog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnDlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlog.ForeColor = System.Drawing.Color.White;
            this.btnDlog.Location = new System.Drawing.Point(0, 0);
            this.btnDlog.Name = "btnDlog";
            this.btnDlog.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDlog.Size = new System.Drawing.Size(196, 41);
            this.btnDlog.TabIndex = 0;
            this.btnDlog.Text = "Daily Log";
            this.btnDlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDlog.UseVisualStyleBackColor = false;
            this.btnDlog.Click += new System.EventHandler(this.btnDlog_Click);
            // 
            // btnDr
            // 
            this.btnDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnDr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDr.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnDr.FlatAppearance.BorderSize = 0;
            this.btnDr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(72)))));
            this.btnDr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnDr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDr.ForeColor = System.Drawing.Color.White;
            this.btnDr.Location = new System.Drawing.Point(0, 523);
            this.btnDr.Name = "btnDr";
            this.btnDr.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDr.Size = new System.Drawing.Size(196, 54);
            this.btnDr.TabIndex = 10;
            this.btnDr.Text = "Daily Records";
            this.btnDr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDr.UseVisualStyleBackColor = false;
            this.btnDr.Click += new System.EventHandler(this.btnDr_Click);
            // 
            // pnlStSub
            // 
            this.pnlStSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlStSub.Controls.Add(this.btnStaf);
            this.pnlStSub.Controls.Add(this.btnAllOrg);
            this.pnlStSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStSub.Location = new System.Drawing.Point(0, 435);
            this.pnlStSub.Name = "pnlStSub";
            this.pnlStSub.Size = new System.Drawing.Size(196, 88);
            this.pnlStSub.TabIndex = 9;
            // 
            // btnStaf
            // 
            this.btnStaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnStaf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaf.FlatAppearance.BorderSize = 0;
            this.btnStaf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnStaf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnStaf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaf.ForeColor = System.Drawing.Color.White;
            this.btnStaf.Location = new System.Drawing.Point(0, 45);
            this.btnStaf.Name = "btnStaf";
            this.btnStaf.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnStaf.Size = new System.Drawing.Size(196, 45);
            this.btnStaf.TabIndex = 1;
            this.btnStaf.Text = "View All Sraff";
            this.btnStaf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaf.UseVisualStyleBackColor = false;
            this.btnStaf.Click += new System.EventHandler(this.btnStaf_Click);
            // 
            // btnAllOrg
            // 
            this.btnAllOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAllOrg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllOrg.FlatAppearance.BorderSize = 0;
            this.btnAllOrg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnAllOrg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnAllOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllOrg.ForeColor = System.Drawing.Color.White;
            this.btnAllOrg.Location = new System.Drawing.Point(0, 0);
            this.btnAllOrg.Name = "btnAllOrg";
            this.btnAllOrg.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAllOrg.Size = new System.Drawing.Size(196, 45);
            this.btnAllOrg.TabIndex = 0;
            this.btnAllOrg.Text = "All Organization";
            this.btnAllOrg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllOrg.UseVisualStyleBackColor = false;
            this.btnAllOrg.Click += new System.EventHandler(this.btnAllOrg_Click);
            // 
            // btnOrg
            // 
            this.btnOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnOrg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnOrg.FlatAppearance.BorderSize = 0;
            this.btnOrg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(72)))));
            this.btnOrg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrg.ForeColor = System.Drawing.Color.White;
            this.btnOrg.Location = new System.Drawing.Point(0, 381);
            this.btnOrg.Name = "btnOrg";
            this.btnOrg.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnOrg.Size = new System.Drawing.Size(196, 54);
            this.btnOrg.TabIndex = 8;
            this.btnOrg.Text = "Organization";
            this.btnOrg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrg.UseVisualStyleBackColor = false;
            this.btnOrg.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // pnlAnSub
            // 
            this.pnlAnSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pnlAnSub.Controls.Add(this.btnAex);
            this.pnlAnSub.Controls.Add(this.btnMeal);
            this.pnlAnSub.Controls.Add(this.btnSpecies);
            this.pnlAnSub.Controls.Add(this.btnAnCourse);
            this.pnlAnSub.Controls.Add(this.btnAnView);
            this.pnlAnSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAnSub.Location = new System.Drawing.Point(0, 156);
            this.pnlAnSub.Name = "pnlAnSub";
            this.pnlAnSub.Size = new System.Drawing.Size(196, 225);
            this.pnlAnSub.TabIndex = 7;
            // 
            // btnAex
            // 
            this.btnAex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAex.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAex.FlatAppearance.BorderSize = 0;
            this.btnAex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnAex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnAex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAex.ForeColor = System.Drawing.Color.White;
            this.btnAex.Location = new System.Drawing.Point(0, 180);
            this.btnAex.Name = "btnAex";
            this.btnAex.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAex.Size = new System.Drawing.Size(196, 48);
            this.btnAex.TabIndex = 4;
            this.btnAex.Text = "All Exercise";
            this.btnAex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAex.UseVisualStyleBackColor = false;
            this.btnAex.Click += new System.EventHandler(this.btnAex_Click);
            // 
            // btnMeal
            // 
            this.btnMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnMeal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeal.FlatAppearance.BorderSize = 0;
            this.btnMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeal.ForeColor = System.Drawing.Color.White;
            this.btnMeal.Location = new System.Drawing.Point(0, 135);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMeal.Size = new System.Drawing.Size(196, 45);
            this.btnMeal.TabIndex = 3;
            this.btnMeal.Text = "All Meal";
            this.btnMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeal.UseVisualStyleBackColor = false;
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // btnSpecies
            // 
            this.btnSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnSpecies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpecies.FlatAppearance.BorderSize = 0;
            this.btnSpecies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnSpecies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecies.ForeColor = System.Drawing.Color.White;
            this.btnSpecies.Location = new System.Drawing.Point(0, 90);
            this.btnSpecies.Name = "btnSpecies";
            this.btnSpecies.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSpecies.Size = new System.Drawing.Size(196, 45);
            this.btnSpecies.TabIndex = 2;
            this.btnSpecies.Text = "View All Species";
            this.btnSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpecies.UseVisualStyleBackColor = false;
            this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
            // 
            // btnAnCourse
            // 
            this.btnAnCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAnCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnCourse.FlatAppearance.BorderSize = 0;
            this.btnAnCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnAnCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnAnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnCourse.ForeColor = System.Drawing.Color.White;
            this.btnAnCourse.Location = new System.Drawing.Point(0, 45);
            this.btnAnCourse.Name = "btnAnCourse";
            this.btnAnCourse.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAnCourse.Size = new System.Drawing.Size(196, 45);
            this.btnAnCourse.TabIndex = 1;
            this.btnAnCourse.Text = "Animal Course";
            this.btnAnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnCourse.UseVisualStyleBackColor = false;
            this.btnAnCourse.Click += new System.EventHandler(this.btnAnCourse_Click);
            // 
            // btnAnView
            // 
            this.btnAnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnAnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnView.FlatAppearance.BorderSize = 0;
            this.btnAnView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.btnAnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnAnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnView.ForeColor = System.Drawing.Color.White;
            this.btnAnView.Location = new System.Drawing.Point(0, 0);
            this.btnAnView.Name = "btnAnView";
            this.btnAnView.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAnView.Size = new System.Drawing.Size(196, 45);
            this.btnAnView.TabIndex = 0;
            this.btnAnView.Text = "View All Animal";
            this.btnAnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnView.UseVisualStyleBackColor = false;
            this.btnAnView.Click += new System.EventHandler(this.btnAnView_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.btnAnimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnimal.FlatAppearance.BorderSize = 0;
            this.btnAnimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(12)))), ((int)(((byte)(72)))));
            this.btnAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(15)))), ((int)(((byte)(75)))));
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.ForeColor = System.Drawing.Color.White;
            this.btnAnimal.Image = global::animalWeightTracker_00183727.Properties.Resources.rabbit;
            this.btnAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnimal.Location = new System.Drawing.Point(0, 102);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAnimal.Size = new System.Drawing.Size(196, 54);
            this.btnAnimal.TabIndex = 6;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click_1);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(196, 102);
            this.pnlLogo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::animalWeightTracker_00183727.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // TIME
            // 
            this.TIME.Interval = 1000;
            this.TIME.Tick += new System.EventHandler(this.TIME_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 600);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlRpsub.ResumeLayout(false);
            this.pnlDsub.ResumeLayout(false);
            this.pnlStSub.ResumeLayout(false);
            this.pnlAnSub.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnMinmz;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlAnSub;
        private System.Windows.Forms.Button btnMeal;
        private System.Windows.Forms.Button btnSpecies;
        private System.Windows.Forms.Button btnAnCourse;
        private System.Windows.Forms.Button btnAnView;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Panel pnlStSub;
        private System.Windows.Forms.Button btnStaf;
        private System.Windows.Forms.Button btnAllOrg;
        private System.Windows.Forms.Button btnOrg;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDsub;
        private System.Windows.Forms.Button btnDmeas;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.Button btnDlog;
        private System.Windows.Forms.Button btnDr;
        private System.Windows.Forms.Button btnAex;
        private System.Windows.Forms.Panel pnlRpsub;
        private System.Windows.Forms.Button btnDexList;
        private System.Windows.Forms.Button btnMelist;
        private System.Windows.Forms.Button btnMlist;
        private System.Windows.Forms.Button btnDlist;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TIME;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}


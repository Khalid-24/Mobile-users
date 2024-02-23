namespace WindowsFormsApp1
{
    partial class MyForm
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
            this.grpbxPerson = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.nmrAge = new System.Windows.Forms.NumericUpDown();
            this.lblMobile = new System.Windows.Forms.Label();
            this.rdbtnAndroid = new System.Windows.Forms.RadioButton();
            this.rdbtnApple = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpbxPeople = new System.Windows.Forms.GroupBox();
            this.rdbtnAllUsers = new System.Windows.Forms.RadioButton();
            this.rdbtnAppleUsers = new System.Windows.Forms.RadioButton();
            this.rdbtnAndroidUsers = new System.Windows.Forms.RadioButton();
            this.dtgdPeople = new System.Windows.Forms.DataGridView();
            this.lblTotalPeople = new System.Windows.Forms.Label();
            this.lblVisiblePeople = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbxPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).BeginInit();
            this.grpbxPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxPerson
            // 
            this.grpbxPerson.Controls.Add(this.btnAdd);
            this.grpbxPerson.Controls.Add(this.btnClear);
            this.grpbxPerson.Controls.Add(this.rdbtnApple);
            this.grpbxPerson.Controls.Add(this.rdbtnAndroid);
            this.grpbxPerson.Controls.Add(this.lblMobile);
            this.grpbxPerson.Controls.Add(this.nmrAge);
            this.grpbxPerson.Controls.Add(this.lblAge);
            this.grpbxPerson.Controls.Add(this.txtbxLastName);
            this.grpbxPerson.Controls.Add(this.lblLastName);
            this.grpbxPerson.Controls.Add(this.txtbxFirstName);
            this.grpbxPerson.Controls.Add(this.lblFirstName);
            this.grpbxPerson.Location = new System.Drawing.Point(28, 12);
            this.grpbxPerson.Name = "grpbxPerson";
            this.grpbxPerson.Size = new System.Drawing.Size(860, 258);
            this.grpbxPerson.TabIndex = 0;
            this.grpbxPerson.TabStop = false;
            this.grpbxPerson.Text = "Person";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(61, 52);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(166, 46);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(668, 26);
            this.txtbxFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(61, 96);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(166, 90);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(668, 26);
            this.txtbxLastName.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(61, 146);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // nmrAge
            // 
            this.nmrAge.Location = new System.Drawing.Point(166, 140);
            this.nmrAge.Name = "nmrAge";
            this.nmrAge.Size = new System.Drawing.Size(668, 26);
            this.nmrAge.TabIndex = 5;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(61, 200);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(55, 20);
            this.lblMobile.TabIndex = 6;
            this.lblMobile.Text = "Mobile";
            // 
            // rdbtnAndroid
            // 
            this.rdbtnAndroid.AutoSize = true;
            this.rdbtnAndroid.Location = new System.Drawing.Point(266, 196);
            this.rdbtnAndroid.Name = "rdbtnAndroid";
            this.rdbtnAndroid.Size = new System.Drawing.Size(89, 24);
            this.rdbtnAndroid.TabIndex = 7;
            this.rdbtnAndroid.TabStop = true;
            this.rdbtnAndroid.Text = "Android";
            this.rdbtnAndroid.UseVisualStyleBackColor = true;
            // 
            // rdbtnApple
            // 
            this.rdbtnApple.AutoSize = true;
            this.rdbtnApple.Location = new System.Drawing.Point(166, 196);
            this.rdbtnApple.Name = "rdbtnApple";
            this.rdbtnApple.Size = new System.Drawing.Size(75, 24);
            this.rdbtnApple.TabIndex = 8;
            this.rdbtnApple.TabStop = true;
            this.rdbtnApple.Text = "Apple";
            this.rdbtnApple.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(484, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(678, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpbxPeople
            // 
            this.grpbxPeople.Controls.Add(this.btnDeleteAll);
            this.grpbxPeople.Controls.Add(this.lblVisiblePeople);
            this.grpbxPeople.Controls.Add(this.lblTotalPeople);
            this.grpbxPeople.Controls.Add(this.dtgdPeople);
            this.grpbxPeople.Controls.Add(this.rdbtnAndroidUsers);
            this.grpbxPeople.Controls.Add(this.rdbtnAppleUsers);
            this.grpbxPeople.Controls.Add(this.rdbtnAllUsers);
            this.grpbxPeople.Location = new System.Drawing.Point(28, 276);
            this.grpbxPeople.Name = "grpbxPeople";
            this.grpbxPeople.Size = new System.Drawing.Size(859, 456);
            this.grpbxPeople.TabIndex = 1;
            this.grpbxPeople.TabStop = false;
            this.grpbxPeople.Text = "People";
            // 
            // rdbtnAllUsers
            // 
            this.rdbtnAllUsers.AutoSize = true;
            this.rdbtnAllUsers.Location = new System.Drawing.Point(65, 25);
            this.rdbtnAllUsers.Name = "rdbtnAllUsers";
            this.rdbtnAllUsers.Size = new System.Drawing.Size(141, 24);
            this.rdbtnAllUsers.TabIndex = 0;
            this.rdbtnAllUsers.TabStop = true;
            this.rdbtnAllUsers.Text = "Show All Users";
            this.rdbtnAllUsers.UseVisualStyleBackColor = true;
            this.rdbtnAllUsers.CheckedChanged += new System.EventHandler(this.rdbtnAllUsers_CheckedChanged);
            // 
            // rdbtnAppleUsers
            // 
            this.rdbtnAppleUsers.AutoSize = true;
            this.rdbtnAppleUsers.Location = new System.Drawing.Point(323, 25);
            this.rdbtnAppleUsers.Name = "rdbtnAppleUsers";
            this.rdbtnAppleUsers.Size = new System.Drawing.Size(200, 24);
            this.rdbtnAppleUsers.TabIndex = 1;
            this.rdbtnAppleUsers.TabStop = true;
            this.rdbtnAppleUsers.Text = "Only Show Apple Users";
            this.rdbtnAppleUsers.UseVisualStyleBackColor = true;
            this.rdbtnAppleUsers.CheckedChanged += new System.EventHandler(this.rdbtnAppleUsers_CheckedChanged);
            // 
            // rdbtnAndroidUsers
            // 
            this.rdbtnAndroidUsers.AutoSize = true;
            this.rdbtnAndroidUsers.Location = new System.Drawing.Point(620, 25);
            this.rdbtnAndroidUsers.Name = "rdbtnAndroidUsers";
            this.rdbtnAndroidUsers.Size = new System.Drawing.Size(214, 24);
            this.rdbtnAndroidUsers.TabIndex = 2;
            this.rdbtnAndroidUsers.TabStop = true;
            this.rdbtnAndroidUsers.Text = "Only Show Android Users";
            this.rdbtnAndroidUsers.UseVisualStyleBackColor = true;
            this.rdbtnAndroidUsers.CheckedChanged += new System.EventHandler(this.rdbtnAndroidUsers_CheckedChanged);
            // 
            // dtgdPeople
            // 
            this.dtgdPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdPeople.Location = new System.Drawing.Point(65, 55);
            this.dtgdPeople.Name = "dtgdPeople";
            this.dtgdPeople.RowHeadersVisible = false;
            this.dtgdPeople.RowHeadersWidth = 62;
            this.dtgdPeople.RowTemplate.Height = 28;
            this.dtgdPeople.Size = new System.Drawing.Size(769, 328);
            this.dtgdPeople.TabIndex = 3;
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.AutoSize = true;
            this.lblTotalPeople.Location = new System.Drawing.Point(81, 408);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(114, 20);
            this.lblTotalPeople.TabIndex = 4;
            this.lblTotalPeople.Text = "Total People: ?";
            // 
            // lblVisiblePeople
            // 
            this.lblVisiblePeople.AutoSize = true;
            this.lblVisiblePeople.Location = new System.Drawing.Point(217, 408);
            this.lblVisiblePeople.Name = "lblVisiblePeople";
            this.lblVisiblePeople.Size = new System.Drawing.Size(128, 20);
            this.lblVisiblePeople.TabIndex = 5;
            this.lblVisiblePeople.Text = "Visibile People: ?";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(678, 408);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(139, 36);
            this.btnDeleteAll.TabIndex = 6;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(706, 738);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 36);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 899);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpbxPeople);
            this.Controls.Add(this.grpbxPerson);
            this.Name = "MyForm";
            this.Text = "People";
            this.grpbxPerson.ResumeLayout(false);
            this.grpbxPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAge)).EndInit();
            this.grpbxPeople.ResumeLayout(false);
            this.grpbxPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxPerson;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdbtnApple;
        private System.Windows.Forms.RadioButton rdbtnAndroid;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.NumericUpDown nmrAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.GroupBox grpbxPeople;
        private System.Windows.Forms.RadioButton rdbtnAndroidUsers;
        private System.Windows.Forms.RadioButton rdbtnAppleUsers;
        private System.Windows.Forms.RadioButton rdbtnAllUsers;
        private System.Windows.Forms.DataGridView dtgdPeople;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label lblVisiblePeople;
        private System.Windows.Forms.Label lblTotalPeople;
        private System.Windows.Forms.Button btnClose;
    }
}


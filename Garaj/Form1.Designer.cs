namespace Garaj
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGaraj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.сметаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tcGaraj = new System.Windows.Forms.TabControl();
            this.tabPageListGarajes = new System.Windows.Forms.TabPage();
            this.tabPageAddGaraj = new System.Windows.Forms.TabPage();
            this.tcPersons = new System.Windows.Forms.TabControl();
            this.tabPageListPerson = new System.Windows.Forms.TabPage();
            this.tabPageEditPerson = new System.Windows.Forms.TabPage();
            this.cbEditPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPartonimus = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbPatronimus = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbGarage = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblGarage = new System.Windows.Forms.Label();
            this.listViewPerson = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.tcGaraj.SuspendLayout();
            this.tcPersons.SuspendLayout();
            this.tabPageListPerson.SuspendLayout();
            this.tabPageEditPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyToolStripMenuItem,
            this.tsmGaraj,
            this.tsmPersons,
            this.сметаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menyToolStripMenuItem
            // 
            this.menyToolStripMenuItem.Name = "menyToolStripMenuItem";
            this.menyToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menyToolStripMenuItem.Text = "Меню";
            // 
            // tsmGaraj
            // 
            this.tsmGaraj.Name = "tsmGaraj";
            this.tsmGaraj.Size = new System.Drawing.Size(60, 20);
            this.tsmGaraj.Text = "Гаражи";
            this.tsmGaraj.Click += new System.EventHandler(this.tsmGaraj_Click);
            // 
            // tsmPersons
            // 
            this.tsmPersons.Name = "tsmPersons";
            this.tsmPersons.Size = new System.Drawing.Size(80, 20);
            this.tsmPersons.Text = "Владельцы";
            this.tsmPersons.Click += new System.EventHandler(this.tsmPersons_Click);
            // 
            // сметаToolStripMenuItem1
            // 
            this.сметаToolStripMenuItem1.Name = "сметаToolStripMenuItem1";
            this.сметаToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.сметаToolStripMenuItem1.Text = "Смета";
            // 
            // tcGaraj
            // 
            this.tcGaraj.Controls.Add(this.tabPageListGarajes);
            this.tcGaraj.Controls.Add(this.tabPageAddGaraj);
            this.tcGaraj.Location = new System.Drawing.Point(12, 27);
            this.tcGaraj.Name = "tcGaraj";
            this.tcGaraj.SelectedIndex = 0;
            this.tcGaraj.Size = new System.Drawing.Size(553, 375);
            this.tcGaraj.TabIndex = 1;
            // 
            // tabPageListGarajes
            // 
            this.tabPageListGarajes.Location = new System.Drawing.Point(4, 22);
            this.tabPageListGarajes.Name = "tabPageListGarajes";
            this.tabPageListGarajes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListGarajes.Size = new System.Drawing.Size(545, 349);
            this.tabPageListGarajes.TabIndex = 0;
            this.tabPageListGarajes.Text = "Список гаражей";
            this.tabPageListGarajes.UseVisualStyleBackColor = true;
            // 
            // tabPageAddGaraj
            // 
            this.tabPageAddGaraj.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddGaraj.Name = "tabPageAddGaraj";
            this.tabPageAddGaraj.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddGaraj.Size = new System.Drawing.Size(545, 349);
            this.tabPageAddGaraj.TabIndex = 1;
            this.tabPageAddGaraj.Text = "Добавить гараж";
            this.tabPageAddGaraj.UseVisualStyleBackColor = true;
            // 
            // tcPersons
            // 
            this.tcPersons.Controls.Add(this.tabPageListPerson);
            this.tcPersons.Controls.Add(this.tabPageEditPerson);
            this.tcPersons.Location = new System.Drawing.Point(8, 27);
            this.tcPersons.Name = "tcPersons";
            this.tcPersons.SelectedIndex = 0;
            this.tcPersons.Size = new System.Drawing.Size(553, 375);
            this.tcPersons.TabIndex = 2;
            // 
            // tabPageListPerson
            // 
            this.tabPageListPerson.Controls.Add(this.listViewPerson);
            this.tabPageListPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPageListPerson.Name = "tabPageListPerson";
            this.tabPageListPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListPerson.Size = new System.Drawing.Size(545, 349);
            this.tabPageListPerson.TabIndex = 0;
            this.tabPageListPerson.Text = "Список владельцев";
            this.tabPageListPerson.UseVisualStyleBackColor = true;
            // 
            // tabPageEditPerson
            // 
            this.tabPageEditPerson.Controls.Add(this.lblGarage);
            this.tabPageEditPerson.Controls.Add(this.lblTelephone);
            this.tabPageEditPerson.Controls.Add(this.lblPassword);
            this.tabPageEditPerson.Controls.Add(this.lblLogin);
            this.tabPageEditPerson.Controls.Add(this.tbGarage);
            this.tabPageEditPerson.Controls.Add(this.tbTelephone);
            this.tabPageEditPerson.Controls.Add(this.tbPassword);
            this.tabPageEditPerson.Controls.Add(this.tbLogin);
            this.tabPageEditPerson.Controls.Add(this.tbPatronimus);
            this.tabPageEditPerson.Controls.Add(this.tbSurname);
            this.tabPageEditPerson.Controls.Add(this.tbName);
            this.tabPageEditPerson.Controls.Add(this.lblPartonimus);
            this.tabPageEditPerson.Controls.Add(this.lblSurname);
            this.tabPageEditPerson.Controls.Add(this.lblName);
            this.tabPageEditPerson.Controls.Add(this.label1);
            this.tabPageEditPerson.Controls.Add(this.cbEditPerson);
            this.tabPageEditPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditPerson.Name = "tabPageEditPerson";
            this.tabPageEditPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditPerson.Size = new System.Drawing.Size(545, 349);
            this.tabPageEditPerson.TabIndex = 1;
            this.tabPageEditPerson.Text = "Реквизиты владельцев";
            this.tabPageEditPerson.UseVisualStyleBackColor = true;
            // 
            // cbEditPerson
            // 
            this.cbEditPerson.FormattingEnabled = true;
            this.cbEditPerson.Location = new System.Drawing.Point(86, 20);
            this.cbEditPerson.Name = "cbEditPerson";
            this.cbEditPerson.Size = new System.Drawing.Size(100, 21);
            this.cbEditPerson.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Роль: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Имя: ";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(24, 76);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(62, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Фамилия: ";
            // 
            // lblPartonimus
            // 
            this.lblPartonimus.AutoSize = true;
            this.lblPartonimus.Location = new System.Drawing.Point(24, 103);
            this.lblPartonimus.Name = "lblPartonimus";
            this.lblPartonimus.Size = new System.Drawing.Size(60, 13);
            this.lblPartonimus.TabIndex = 4;
            this.lblPartonimus.Text = "Отчество: ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(86, 73);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 6;
            // 
            // tbPatronimus
            // 
            this.tbPatronimus.Location = new System.Drawing.Point(86, 99);
            this.tbPatronimus.Name = "tbPatronimus";
            this.tbPatronimus.Size = new System.Drawing.Size(100, 20);
            this.tbPatronimus.TabIndex = 7;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(86, 125);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(86, 151);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 9;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(86, 177);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(100, 20);
            this.tbTelephone.TabIndex = 10;
            // 
            // tbGarage
            // 
            this.tbGarage.Location = new System.Drawing.Point(86, 203);
            this.tbGarage.Name = "tbGarage";
            this.tbGarage.Size = new System.Drawing.Size(100, 20);
            this.tbGarage.TabIndex = 11;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(24, 130);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 13);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "Логин:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 157);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Пароль:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(24, 184);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 14;
            this.lblTelephone.Text = "Телефон: ";
            // 
            // lblGarage
            // 
            this.lblGarage.AutoSize = true;
            this.lblGarage.Location = new System.Drawing.Point(24, 211);
            this.lblGarage.Name = "lblGarage";
            this.lblGarage.Size = new System.Drawing.Size(42, 13);
            this.lblGarage.TabIndex = 15;
            this.lblGarage.Text = "Гараж:";
            // 
            // listViewPerson
            // 
            this.listViewPerson.Location = new System.Drawing.Point(4, 0);
            this.listViewPerson.Name = "listViewPerson";
            this.listViewPerson.Size = new System.Drawing.Size(539, 346);
            this.listViewPerson.TabIndex = 0;
            this.listViewPerson.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcPersons);
            this.Controls.Add(this.tcGaraj);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Управление гаражным кооперативом";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcGaraj.ResumeLayout(false);
            this.tcPersons.ResumeLayout(false);
            this.tabPageListPerson.ResumeLayout(false);
            this.tabPageEditPerson.ResumeLayout(false);
            this.tabPageEditPerson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmGaraj;
        private System.Windows.Forms.ToolStripMenuItem tsmPersons;
        private System.Windows.Forms.ToolStripMenuItem сметаToolStripMenuItem1;
        private System.Windows.Forms.TabControl tcGaraj;
        private System.Windows.Forms.TabPage tabPageListGarajes;
        private System.Windows.Forms.TabPage tabPageAddGaraj;
        private System.Windows.Forms.TabControl tcPersons;
        private System.Windows.Forms.TabPage tabPageListPerson;
        private System.Windows.Forms.TabPage tabPageEditPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEditPerson;
        private System.Windows.Forms.Label lblPartonimus;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPatronimus;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblGarage;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbGarage;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.ListView listViewPerson;
    }
}


namespace AutoUpload
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distTextBox = new System.Windows.Forms.TextBox();
            this.deployTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noDeleteListView = new System.Windows.Forms.ListView();
            this.StatementButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SaveSettingButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yes404RadioButton = new System.Windows.Forms.RadioButton();
            this.no404RadioButton = new System.Windows.Forms.RadioButton();
            this.select1Button = new System.Windows.Forms.Button();
            this.select2Button = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gitPathTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gitNoRadioButton = new System.Windows.Forms.RadioButton();
            this.gitYesRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编译代码目录:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Page仓库目录:";
            // 
            // distTextBox
            // 
            this.distTextBox.Location = new System.Drawing.Point(103, 21);
            this.distTextBox.Name = "distTextBox";
            this.distTextBox.ReadOnly = true;
            this.distTextBox.Size = new System.Drawing.Size(315, 21);
            this.distTextBox.TabIndex = 2;
            // 
            // deployTextBox
            // 
            this.deployTextBox.Location = new System.Drawing.Point(103, 48);
            this.deployTextBox.Name = "deployTextBox";
            this.deployTextBox.ReadOnly = true;
            this.deployTextBox.Size = new System.Drawing.Size(315, 21);
            this.deployTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "防删文件名单:";
            // 
            // noDeleteListView
            // 
            this.noDeleteListView.Location = new System.Drawing.Point(102, 26);
            this.noDeleteListView.Name = "noDeleteListView";
            this.noDeleteListView.Size = new System.Drawing.Size(235, 63);
            this.noDeleteListView.TabIndex = 5;
            this.noDeleteListView.UseCompatibleStateImageBehavior = false;
            // 
            // StatementButton
            // 
            this.StatementButton.Location = new System.Drawing.Point(19, 306);
            this.StatementButton.Name = "StatementButton";
            this.StatementButton.Size = new System.Drawing.Size(75, 23);
            this.StatementButton.TabIndex = 6;
            this.StatementButton.Text = "说明";
            this.StatementButton.UseVisualStyleBackColor = true;
            this.StatementButton.Click += new System.EventHandler(this.StatementButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(245, 306);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "开始";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SaveSettingButton
            // 
            this.SaveSettingButton.Location = new System.Drawing.Point(462, 306);
            this.SaveSettingButton.Name = "SaveSettingButton";
            this.SaveSettingButton.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingButton.TabIndex = 8;
            this.SaveSettingButton.Text = "保存配置";
            this.SaveSettingButton.UseVisualStyleBackColor = true;
            this.SaveSettingButton.Click += new System.EventHandler(this.SaveSettingButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "创建404文件:";
            // 
            // yes404RadioButton
            // 
            this.yes404RadioButton.AutoSize = true;
            this.yes404RadioButton.Checked = true;
            this.yes404RadioButton.Location = new System.Drawing.Point(19, 6);
            this.yes404RadioButton.Name = "yes404RadioButton";
            this.yes404RadioButton.Size = new System.Drawing.Size(35, 16);
            this.yes404RadioButton.TabIndex = 10;
            this.yes404RadioButton.TabStop = true;
            this.yes404RadioButton.Text = "是";
            this.yes404RadioButton.UseVisualStyleBackColor = true;
            // 
            // no404RadioButton
            // 
            this.no404RadioButton.AutoSize = true;
            this.no404RadioButton.Location = new System.Drawing.Point(60, 6);
            this.no404RadioButton.Name = "no404RadioButton";
            this.no404RadioButton.Size = new System.Drawing.Size(35, 16);
            this.no404RadioButton.TabIndex = 11;
            this.no404RadioButton.Text = "否";
            this.no404RadioButton.UseVisualStyleBackColor = true;
            // 
            // select1Button
            // 
            this.select1Button.Location = new System.Drawing.Point(427, 20);
            this.select1Button.Name = "select1Button";
            this.select1Button.Size = new System.Drawing.Size(75, 23);
            this.select1Button.TabIndex = 15;
            this.select1Button.Text = "浏览";
            this.select1Button.UseVisualStyleBackColor = true;
            this.select1Button.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // select2Button
            // 
            this.select2Button.Location = new System.Drawing.Point(427, 47);
            this.select2Button.Name = "select2Button";
            this.select2Button.Size = new System.Drawing.Size(75, 23);
            this.select2Button.TabIndex = 16;
            this.select2Button.Text = "浏览";
            this.select2Button.UseVisualStyleBackColor = true;
            this.select2Button.Click += new System.EventHandler(this.select2Button_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(345, 26);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(156, 21);
            this.fileNameTextBox.TabIndex = 19;
            this.fileNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileNameTextBox_KeyDown);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(344, 66);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 20;
            this.createButton.Text = "新增";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(426, 66);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 21;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gitPathTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.distTextBox);
            this.groupBox1.Controls.Add(this.deployTextBox);
            this.groupBox1.Controls.Add(this.select2Button);
            this.groupBox1.Controls.Add(this.select1Button);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 107);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路径设置";
            // 
            // gitPathTextBox
            // 
            this.gitPathTextBox.Location = new System.Drawing.Point(103, 75);
            this.gitPathTextBox.Name = "gitPathTextBox";
            this.gitPathTextBox.Size = new System.Drawing.Size(315, 21);
            this.gitPathTextBox.TabIndex = 19;
            this.gitPathTextBox.TextChanged += new System.EventHandler(this.gitPathTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Git安装目录:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.messageTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.noDeleteListView);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.createButton);
            this.groupBox2.Controls.Add(this.fileNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 175);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数配置";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gitNoRadioButton);
            this.panel2.Controls.Add(this.gitYesRadioButton);
            this.panel2.Location = new System.Drawing.Point(102, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 26);
            this.panel2.TabIndex = 28;
            // 
            // gitNoRadioButton
            // 
            this.gitNoRadioButton.AutoSize = true;
            this.gitNoRadioButton.Location = new System.Drawing.Point(60, 6);
            this.gitNoRadioButton.Name = "gitNoRadioButton";
            this.gitNoRadioButton.Size = new System.Drawing.Size(35, 16);
            this.gitNoRadioButton.TabIndex = 11;
            this.gitNoRadioButton.Text = "否";
            this.gitNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // gitYesRadioButton
            // 
            this.gitYesRadioButton.AutoSize = true;
            this.gitYesRadioButton.Checked = true;
            this.gitYesRadioButton.Location = new System.Drawing.Point(19, 6);
            this.gitYesRadioButton.Name = "gitYesRadioButton";
            this.gitYesRadioButton.Size = new System.Drawing.Size(35, 16);
            this.gitYesRadioButton.TabIndex = 10;
            this.gitYesRadioButton.TabStop = true;
            this.gitYesRadioButton.Text = "是";
            this.gitYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.no404RadioButton);
            this.panel1.Controls.Add(this.yes404RadioButton);
            this.panel1.Location = new System.Drawing.Point(102, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 26);
            this.panel1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "使用Git上传:";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(345, 101);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(157, 21);
            this.messageTextBox.TabIndex = 23;
            this.messageTextBox.Text = "Auto Upload";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "git commit message :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveSettingButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StatementButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "一键同步代码 - 茶荼先生";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox distTextBox;
        private System.Windows.Forms.TextBox deployTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView noDeleteListView;
        private System.Windows.Forms.Button StatementButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SaveSettingButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton yes404RadioButton;
        private System.Windows.Forms.RadioButton no404RadioButton;
        private System.Windows.Forms.Button select1Button;
        private System.Windows.Forms.Button select2Button;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton gitNoRadioButton;
        private System.Windows.Forms.RadioButton gitYesRadioButton;
        private System.Windows.Forms.TextBox gitPathTextBox;
        private System.Windows.Forms.Label label9;
    }
}


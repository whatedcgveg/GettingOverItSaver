namespace GettingOverItSaver
{
    partial class Form_Main
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
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label_About = new System.Windows.Forms.Label();
            this.linkLabel_Github = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Website = new System.Windows.Forms.LinkLabel();
            this.listBox_Main = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(12, 445);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(75, 30);
            this.button_Read.TabIndex = 0;
            this.button_Read.Text = "Read";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(235, 445);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 30);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(125, 445);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 30);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.Location = new System.Drawing.Point(92, 489);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(143, 15);
            this.label_About.TabIndex = 3;
            this.label_About.Text = "Ver1.0 By Azure99";
            // 
            // linkLabel_Github
            // 
            this.linkLabel_Github.AutoSize = true;
            this.linkLabel_Github.Location = new System.Drawing.Point(255, 489);
            this.linkLabel_Github.Name = "linkLabel_Github";
            this.linkLabel_Github.Size = new System.Drawing.Size(55, 15);
            this.linkLabel_Github.TabIndex = 4;
            this.linkLabel_Github.TabStop = true;
            this.linkLabel_Github.Text = "Github";
            this.linkLabel_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Github_LinkClicked);
            // 
            // linkLabel_Website
            // 
            this.linkLabel_Website.AutoSize = true;
            this.linkLabel_Website.Location = new System.Drawing.Point(12, 489);
            this.linkLabel_Website.Name = "linkLabel_Website";
            this.linkLabel_Website.Size = new System.Drawing.Size(63, 15);
            this.linkLabel_Website.TabIndex = 5;
            this.linkLabel_Website.TabStop = true;
            this.linkLabel_Website.Text = "WebSite";
            this.linkLabel_Website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Website_LinkClicked);
            // 
            // listBox_Main
            // 
            this.listBox_Main.FormattingEnabled = true;
            this.listBox_Main.ItemHeight = 15;
            this.listBox_Main.Location = new System.Drawing.Point(15, 12);
            this.listBox_Main.Name = "listBox_Main";
            this.listBox_Main.Size = new System.Drawing.Size(295, 409);
            this.listBox_Main.TabIndex = 6;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 513);
            this.Controls.Add(this.listBox_Main);
            this.Controls.Add(this.linkLabel_Website);
            this.Controls.Add(this.linkLabel_Github);
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Read);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G-O-ISaver";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.LinkLabel linkLabel_Github;
        private System.Windows.Forms.LinkLabel linkLabel_Website;
        private System.Windows.Forms.ListBox listBox_Main;
    }
}


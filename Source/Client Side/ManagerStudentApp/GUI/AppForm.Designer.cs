﻿namespace ManagerStudentApp
{
    partial class AppForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewControls = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.imageTreeList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 40);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(978, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Xin chào, Bạch Chấn Minh (Học sinh)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 753);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewControls);
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1094, 685);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeViewControls
            // 
            this.treeViewControls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeViewControls.Location = new System.Drawing.Point(0, 0);
            this.treeViewControls.Name = "treeViewControls";
            this.treeViewControls.Size = new System.Drawing.Size(249, 685);
            this.treeViewControls.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(21, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.button16);
            this.tabPage6.Controls.Add(this.button18);
            this.tabPage6.Controls.Add(this.button17);
            this.tabPage6.Controls.Add(this.textBox8);
            this.tabPage6.Controls.Add(this.textBox11);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label28);
            this.tabPage6.Controls.Add(this.textBox13);
            this.tabPage6.Controls.Add(this.textBox12);
            this.tabPage6.Controls.Add(this.label33);
            this.tabPage6.Controls.Add(this.label32);
            this.tabPage6.Controls.Add(this.label30);
            this.tabPage6.Controls.Add(this.label31);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(833, 647);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Quy định";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(326, 222);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(175, 40);
            this.button16.TabIndex = 16;
            this.button16.Text = "Thay đổi";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(38, 222);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(134, 40);
            this.button18.TabIndex = 17;
            this.button18.Text = "Về mặc định";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(199, 222);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(112, 40);
            this.button17.TabIndex = 17;
            this.button17.Text = "Hoàn tác";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(207, 160);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(146, 22);
            this.textBox8.TabIndex = 14;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(207, 120);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(146, 22);
            this.textBox11.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 17);
            this.label18.TabIndex = 9;
            this.label18.Text = "Điểm chuẩn môn";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(33, 123);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 17);
            this.label28.TabIndex = 9;
            this.label28.Text = "Sỉ số lớp tối đa";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(435, 81);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(66, 22);
            this.textBox13.TabIndex = 15;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(287, 81);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(66, 22);
            this.textBox12.TabIndex = 15;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(370, 84);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 17);
            this.label33.TabIndex = 11;
            this.label33.Text = "tối đa";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(202, 84);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 17);
            this.label32.TabIndex = 11;
            this.label32.Text = "tối thiểu";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(33, 84);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(110, 17);
            this.label30.TabIndex = 11;
            this.label30.Text = "Độ tuổi học sinh";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label31.Location = new System.Drawing.Point(143, 23);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(153, 39);
            this.label31.TabIndex = 5;
            this.label31.Text = "Quy định";
            // 
            // imageTreeList
            // 
            this.imageTreeList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageTreeList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageTreeList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1094, 775);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewControls;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;


        public System.Windows.Forms.ImageList imageTreeList;
    }
}
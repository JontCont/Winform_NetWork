﻿namespace TCP_Tennis
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.Panel();
            this.H1 = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.Label();
            this.H2 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label3 = new System.Windows.Forms.Label();
            this.G.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label5.Location = new System.Drawing.Point(520, 438);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(67, 15);
            this.Label5.TabIndex = 117;
            this.Label5.Text = "系統訊息";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(523, 456);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(153, 25);
            this.TextBox4.TabIndex = 116;
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.G.Controls.Add(this.H1);
            this.G.Controls.Add(this.Q);
            this.G.Controls.Add(this.H2);
            this.G.Location = new System.Drawing.Point(13, 11);
            this.G.Margin = new System.Windows.Forms.Padding(4);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(480, 500);
            this.G.TabIndex = 115;
            // 
            // H1
            // 
            this.H1.BackColor = System.Drawing.Color.Black;
            this.H1.Location = new System.Drawing.Point(187, 458);
            this.H1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(107, 25);
            this.H1.TabIndex = 4;
            this.H1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.H1_MouseDown);
            this.H1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.H1_MouseMove);
            // 
            // Q
            // 
            this.Q.Image = global::TCP_Tennis.Properties.Resources.Q_Image;
            this.Q.Location = new System.Drawing.Point(209, 224);
            this.Q.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(43, 40);
            this.Q.TabIndex = 6;
            // 
            // H2
            // 
            this.H2.BackColor = System.Drawing.Color.Lime;
            this.H2.Location = new System.Drawing.Point(187, 19);
            this.H2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H2.Name = "H2";
            this.H2.Size = new System.Drawing.Size(107, 25);
            this.H2.TabIndex = 5;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 15;
            this.ListBox1.Location = new System.Drawing.Point(523, 265);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(153, 139);
            this.ListBox1.TabIndex = 114;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label4.Location = new System.Drawing.Point(517, 246);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(82, 15);
            this.Label4.TabIndex = 113;
            this.Label4.Text = "線上使用者";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button1.Location = new System.Drawing.Point(516, 191);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(161, 39);
            this.Button1.TabIndex = 112;
            this.Button1.Text = "登入伺服器";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(523, 156);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(152, 25);
            this.TextBox3.TabIndex = 111;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(523, 94);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(153, 25);
            this.TextBox2.TabIndex = 109;
            this.TextBox2.Text = "2013";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.Location = new System.Drawing.Point(520, 75);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 15);
            this.Label2.TabIndex = 108;
            this.Label2.Text = "伺服器Port：";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(523, 30);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(153, 25);
            this.TextBox1.TabIndex = 107;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(520, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 15);
            this.Label1.TabIndex = 106;
            this.Label1.Text = "伺服器IP：";
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(199, 530);
            this.GO.Margin = new System.Windows.Forms.Padding(4);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(104, 29);
            this.GO.TabIndex = 105;
            this.GO.Text = "啟動遊戲";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label3.Location = new System.Drawing.Point(520, 138);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(82, 15);
            this.Label3.TabIndex = 110;
            this.Label3.Text = "玩家名稱：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 571);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.G);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.Label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "線上打桌球";
            this.G.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Panel G;
        internal System.Windows.Forms.Label H1;
        internal System.Windows.Forms.Label Q;
        internal System.Windows.Forms.Label H2;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button GO;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label3;
    }
}


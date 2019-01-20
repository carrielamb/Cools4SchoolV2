namespace WindowsFormsApp1
{
    partial class placementtest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placementtest));
            this.geoq = new System.Windows.Forms.TextBox();
            this.mq = new System.Windows.Forms.TextBox();
            this.vq = new System.Windows.Forms.TextBox();
            this.csq = new System.Windows.Forms.TextBox();
            this.geoquestion = new System.Windows.Forms.Label();
            this.multiquestion = new System.Windows.Forms.Label();
            this.vcquestion = new System.Windows.Forms.Label();
            this.csquestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // geoq
            // 
            this.geoq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.geoq.Location = new System.Drawing.Point(12, 27);
            this.geoq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geoq.Name = "geoq";
            this.geoq.Size = new System.Drawing.Size(76, 20);
            this.geoq.TabIndex = 0;
            // 
            // mq
            // 
            this.mq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mq.Location = new System.Drawing.Point(9, 81);
            this.mq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mq.Name = "mq";
            this.mq.Size = new System.Drawing.Size(76, 20);
            this.mq.TabIndex = 1;
            // 
            // vq
            // 
            this.vq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.vq.Location = new System.Drawing.Point(9, 142);
            this.vq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vq.Name = "vq";
            this.vq.Size = new System.Drawing.Size(76, 20);
            this.vq.TabIndex = 2;
            // 
            // csq
            // 
            this.csq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.csq.Location = new System.Drawing.Point(9, 205);
            this.csq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.csq.Name = "csq";
            this.csq.Size = new System.Drawing.Size(76, 20);
            this.csq.TabIndex = 3;
            // 
            // geoquestion
            // 
            this.geoquestion.AutoSize = true;
            this.geoquestion.Location = new System.Drawing.Point(14, 11);
            this.geoquestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.geoquestion.Name = "geoquestion";
            this.geoquestion.Size = new System.Drawing.Size(156, 13);
            this.geoquestion.TabIndex = 4;
            this.geoquestion.Text = "How many side are on a square";
            // 
            // multiquestion
            // 
            this.multiquestion.AutoSize = true;
            this.multiquestion.Location = new System.Drawing.Point(10, 65);
            this.multiquestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.multiquestion.Name = "multiquestion";
            this.multiquestion.Size = new System.Drawing.Size(161, 13);
            this.multiquestion.TabIndex = 5;
            this.multiquestion.Text = "What is 4^2? Type help for help.";
            // 
            // vcquestion
            // 
            this.vcquestion.AutoSize = true;
            this.vcquestion.Location = new System.Drawing.Point(10, 126);
            this.vcquestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vcquestion.Name = "vcquestion";
            this.vcquestion.Size = new System.Drawing.Size(164, 13);
            this.vcquestion.TabIndex = 6;
            this.vcquestion.Text = "What word means to spread out?";
            // 
            // csquestion
            // 
            this.csquestion.AutoSize = true;
            this.csquestion.Location = new System.Drawing.Point(10, 181);
            this.csquestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.csquestion.Name = "csquestion";
            this.csquestion.Size = new System.Drawing.Size(202, 13);
            this.csquestion.TabIndex = 7;
            this.csquestion.Text = "What variable type should be used for C?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(9, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Done!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 367);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // placementtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.csquestion);
            this.Controls.Add(this.vcquestion);
            this.Controls.Add(this.multiquestion);
            this.Controls.Add(this.geoquestion);
            this.Controls.Add(this.csq);
            this.Controls.Add(this.vq);
            this.Controls.Add(this.mq);
            this.Controls.Add(this.geoq);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "placementtest";
            this.Text = "placementtest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox geoq;
        private System.Windows.Forms.TextBox mq;
        private System.Windows.Forms.TextBox vq;
        private System.Windows.Forms.TextBox csq;
        private System.Windows.Forms.Label geoquestion;
        private System.Windows.Forms.Label multiquestion;
        private System.Windows.Forms.Label vcquestion;
        private System.Windows.Forms.Label csquestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace assianmentgame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShot = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnPlayagain = new System.Windows.Forms.Button();
            this.chamber = new System.Windows.Forms.PictureBox();
            this.Gun = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chamber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShot
            // 
            this.btnShot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShot.Location = new System.Drawing.Point(121, 301);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(92, 43);
            this.btnShot.TabIndex = 0;
            this.btnShot.Text = "Shot";
            this.btnShot.UseVisualStyleBackColor = true;
            this.btnShot.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(219, 301);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 43);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(311, 301);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 43);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click_1);
            // 
            // btnPlayagain
            // 
            this.btnPlayagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayagain.Location = new System.Drawing.Point(393, 301);
            this.btnPlayagain.Name = "btnPlayagain";
            this.btnPlayagain.Size = new System.Drawing.Size(75, 43);
            this.btnPlayagain.TabIndex = 3;
            this.btnPlayagain.Text = "Play Again";
            this.btnPlayagain.UseVisualStyleBackColor = true;
            this.btnPlayagain.Click += new System.EventHandler(this.btnPlayagain_Click);
            // 
            // chamber
            // 
            this.chamber.Image = ((System.Drawing.Image)(resources.GetObject("chamber.Image")));
            this.chamber.Location = new System.Drawing.Point(44, 76);
            this.chamber.Name = "chamber";
            this.chamber.Size = new System.Drawing.Size(271, 197);
            this.chamber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chamber.TabIndex = 4;
            this.chamber.TabStop = false;
            this.chamber.Click += new System.EventHandler(this.chamber_Click);
            // 
            // Gun
            // 
            this.Gun.Image = ((System.Drawing.Image)(resources.GetObject("Gun.Image")));
            this.Gun.Location = new System.Drawing.Point(367, 76);
            this.Gun.Name = "Gun";
            this.Gun.Size = new System.Drawing.Size(296, 197);
            this.Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gun.TabIndex = 5;
            this.Gun.TabStop = false;
            this.Gun.Click += new System.EventHandler(this.Gun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "welcome to russian roullete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gun);
            this.Controls.Add(this.chamber);
            this.Controls.Add(this.btnPlayagain);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnShot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chamber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnPlayagain;
        private System.Windows.Forms.PictureBox chamber;
        private System.Windows.Forms.PictureBox Gun;
        private System.Windows.Forms.Label label1;
    }
}


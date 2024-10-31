namespace Topic_10___Images_and_Resources
{
    partial class FormAddResources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddResources));
            this.imgMario = new System.Windows.Forms.PictureBox();
            this.imgSleep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMario
            // 
            this.imgMario.Image = global::Topic_10___Images_and_Resources.Properties.Resources.MarioSleep;
            this.imgMario.Location = new System.Drawing.Point(142, 12);
            this.imgMario.Name = "imgMario";
            this.imgMario.Size = new System.Drawing.Size(502, 413);
            this.imgMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMario.TabIndex = 0;
            this.imgMario.TabStop = false;
            this.imgMario.Click += new System.EventHandler(this.imgMario_Click);
            // 
            // imgSleep
            // 
            this.imgSleep.Image = ((System.Drawing.Image)(resources.GetObject("imgSleep.Image")));
            this.imgSleep.Location = new System.Drawing.Point(650, 174);
            this.imgSleep.Name = "imgSleep";
            this.imgSleep.Size = new System.Drawing.Size(145, 85);
            this.imgSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSleep.TabIndex = 1;
            this.imgSleep.TabStop = false;
            this.imgSleep.Visible = false;
            this.imgSleep.Click += new System.EventHandler(this.imgSleep_Click);
            // 
            // FormAddResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgSleep);
            this.Controls.Add(this.imgMario);
            this.Name = "FormAddResources";
            this.Text = "Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSleep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMario;
        private System.Windows.Forms.PictureBox imgSleep;
    }
}


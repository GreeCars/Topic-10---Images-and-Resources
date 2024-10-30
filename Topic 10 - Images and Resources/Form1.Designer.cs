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
            this.imgMario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
            this.SuspendLayout();
            // 
            // imgMario
            // 
            this.imgMario.Location = new System.Drawing.Point(448, 195);
            this.imgMario.Name = "imgMario";
            this.imgMario.Size = new System.Drawing.Size(100, 50);
            this.imgMario.TabIndex = 0;
            this.imgMario.TabStop = false;
            // 
            // FormAddResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgMario);
            this.Name = "FormAddResources";
            this.Text = "Resources";
            ((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMario;
    }
}


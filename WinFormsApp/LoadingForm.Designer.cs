namespace WinFormsApp
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.pictureBoxAnim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAnim
            // 
            this.pictureBoxAnim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAnim.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAnim.Image")));
            this.pictureBoxAnim.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAnim.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxAnim.Name = "pictureBoxAnim";
            this.pictureBoxAnim.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxAnim.TabIndex = 0;
            this.pictureBoxAnim.TabStop = false;
            this.pictureBoxAnim.UseWaitCursor = true;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxAnim);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAnim;
    }
}
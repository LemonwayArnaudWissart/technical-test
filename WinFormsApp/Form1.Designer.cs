namespace WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComputeFib = new System.Windows.Forms.Button();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.btnComputeXML2JSON = new System.Windows.Forms.Button();
            this.tbXmlString = new System.Windows.Forms.TextBox();
            this.numericUpDownFibonacci = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFibonacci)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComputeFib
            // 
            this.btnComputeFib.Location = new System.Drawing.Point(243, 34);
            this.btnComputeFib.Name = "btnComputeFib";
            this.btnComputeFib.Size = new System.Drawing.Size(169, 20);
            this.btnComputeFib.TabIndex = 0;
            this.btnComputeFib.Text = "Compute Fibonancci";
            this.btnComputeFib.UseVisualStyleBackColor = true;
            this.btnComputeFib.Click += new System.EventHandler(this.btnComputeFib_Click);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMain.Controls.Add(this.btnComputeXML2JSON);
            this.groupBoxMain.Controls.Add(this.tbXmlString);
            this.groupBoxMain.Controls.Add(this.numericUpDownFibonacci);
            this.groupBoxMain.Controls.Add(this.btnComputeFib);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(418, 199);
            this.groupBoxMain.TabIndex = 1;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Tests des services SOAP";
            // 
            // btnComputeXML2JSON
            // 
            this.btnComputeXML2JSON.Location = new System.Drawing.Point(243, 117);
            this.btnComputeXML2JSON.Name = "btnComputeXML2JSON";
            this.btnComputeXML2JSON.Size = new System.Drawing.Size(169, 23);
            this.btnComputeXML2JSON.TabIndex = 3;
            this.btnComputeXML2JSON.Text = "Compute Xml to Json";
            this.btnComputeXML2JSON.UseVisualStyleBackColor = true;
            this.btnComputeXML2JSON.Click += new System.EventHandler(this.btnComputeXML2JSON_Click);
            // 
            // tbXmlString
            // 
            this.tbXmlString.Location = new System.Drawing.Point(6, 69);
            this.tbXmlString.Multiline = true;
            this.tbXmlString.Name = "tbXmlString";
            this.tbXmlString.Size = new System.Drawing.Size(231, 124);
            this.tbXmlString.TabIndex = 2;
            // 
            // numericUpDownFibonacci
            // 
            this.numericUpDownFibonacci.Location = new System.Drawing.Point(6, 34);
            this.numericUpDownFibonacci.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownFibonacci.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numericUpDownFibonacci.Name = "numericUpDownFibonacci";
            this.numericUpDownFibonacci.Size = new System.Drawing.Size(231, 20);
            this.numericUpDownFibonacci.TabIndex = 1;
            this.numericUpDownFibonacci.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 223);
            this.Controls.Add(this.groupBoxMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFibonacci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwFibonacci;
        private System.Windows.Forms.Button btnComputeFib;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.ComponentModel.BackgroundWorker bgwXml2Json;
        private System.Windows.Forms.NumericUpDown numericUpDownFibonacci;
        private System.Windows.Forms.Button btnComputeXML2JSON;
        private System.Windows.Forms.TextBox tbXmlString;
    }
}


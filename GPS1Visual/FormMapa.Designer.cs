namespace GPS1Visual
{
    partial class FormMapa
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
            this.webBrowserGoogleEarth = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserGoogleEarth
            // 
            this.webBrowserGoogleEarth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGoogleEarth.Location = new System.Drawing.Point(0, 0);
            this.webBrowserGoogleEarth.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGoogleEarth.Name = "webBrowserGoogleEarth";
            this.webBrowserGoogleEarth.ScriptErrorsSuppressed = true;
            this.webBrowserGoogleEarth.Size = new System.Drawing.Size(471, 419);
            this.webBrowserGoogleEarth.TabIndex = 0;
            // 
            // FormMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 419);
            this.Controls.Add(this.webBrowserGoogleEarth);
            this.Name = "FormMapa";
            this.Text = "FormMapa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserGoogleEarth;
    }
}
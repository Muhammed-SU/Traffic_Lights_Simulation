namespace Traffic_Lights_Sim
{
    partial class ctrlTraficLight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.pbLight = new System.Windows.Forms.PictureBox();
            this.LightTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountDown
            // 
            this.lblCountDown.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountDown.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.Red;
            this.lblCountDown.Location = new System.Drawing.Point(2, 57);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(27, 19);
            this.lblCountDown.TabIndex = 1;
            this.lblCountDown.Text = "??";
            // 
            // pbLight
            // 
            this.pbLight.BackgroundImage = global::Traffic_Lights_Sim.Properties.Resources.Red;
            this.pbLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLight.Location = new System.Drawing.Point(3, 3);
            this.pbLight.Name = "pbLight";
            this.pbLight.Size = new System.Drawing.Size(26, 51);
            this.pbLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLight.TabIndex = 0;
            this.pbLight.TabStop = false;
            // 
            // LightTimer
            // 
            this.LightTimer.Interval = 1000;
            this.LightTimer.Tick += new System.EventHandler(this.LightTimer_Tick);
            // 
            // ctrlTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.pbLight);
            this.Name = "ctrlTraficLight";
            this.Size = new System.Drawing.Size(31, 79);
            ((System.ComponentModel.ISupportInitialize)(this.pbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLight;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer LightTimer;
    }
}

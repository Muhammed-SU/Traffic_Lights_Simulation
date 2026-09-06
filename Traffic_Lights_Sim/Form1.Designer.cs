namespace Traffic_Lights_Sim
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
            this.ctrlTraficLight1 = new Traffic_Lights_Sim.ctrlTraficLight();
            this.ctrlTraficLight2 = new Traffic_Lights_Sim.ctrlTraficLight();
            this.ctrlTraficLight3 = new Traffic_Lights_Sim.ctrlTraficLight();
            this.ctrlTraficLight4 = new Traffic_Lights_Sim.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // ctrlTraficLight1
            // 
            this.ctrlTraficLight1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight1.CurrentLight = Traffic_Lights_Sim.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight1.GreenTime = 10;
            this.ctrlTraficLight1.Location = new System.Drawing.Point(280, 200);
            this.ctrlTraficLight1.Name = "ctrlTraficLight1";
            this.ctrlTraficLight1.OrangeTime = 3;
            this.ctrlTraficLight1.RedTime = 10;
            this.ctrlTraficLight1.Size = new System.Drawing.Size(31, 79);
            this.ctrlTraficLight1.TabIndex = 0;
            // 
            // ctrlTraficLight2
            // 
            this.ctrlTraficLight2.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight2.CurrentLight = Traffic_Lights_Sim.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight2.GreenTime = 10;
            this.ctrlTraficLight2.Location = new System.Drawing.Point(215, 500);
            this.ctrlTraficLight2.Name = "ctrlTraficLight2";
            this.ctrlTraficLight2.OrangeTime = 3;
            this.ctrlTraficLight2.RedTime = 10;
            this.ctrlTraficLight2.Size = new System.Drawing.Size(31, 79);
            this.ctrlTraficLight2.TabIndex = 1;
            // 
            // ctrlTraficLight3
            // 
            this.ctrlTraficLight3.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight3.CurrentLight = Traffic_Lights_Sim.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight3.GreenTime = 10;
            this.ctrlTraficLight3.Location = new System.Drawing.Point(537, 532);
            this.ctrlTraficLight3.Name = "ctrlTraficLight3";
            this.ctrlTraficLight3.OrangeTime = 3;
            this.ctrlTraficLight3.RedTime = 10;
            this.ctrlTraficLight3.Size = new System.Drawing.Size(31, 79);
            this.ctrlTraficLight3.TabIndex = 2;
            // 
            // ctrlTraficLight4
            // 
            this.ctrlTraficLight4.BackColor = System.Drawing.Color.Transparent;
            this.ctrlTraficLight4.CurrentLight = Traffic_Lights_Sim.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight4.GreenTime = 10;
            this.ctrlTraficLight4.Location = new System.Drawing.Point(590, 265);
            this.ctrlTraficLight4.Name = "ctrlTraficLight4";
            this.ctrlTraficLight4.OrangeTime = 3;
            this.ctrlTraficLight4.RedTime = 10;
            this.ctrlTraficLight4.Size = new System.Drawing.Size(31, 79);
            this.ctrlTraficLight4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Traffic_Lights_Sim.Properties.Resources.Gemini_Generated_Image_jppn8zjppn8zjppn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(847, 845);
            this.Controls.Add(this.ctrlTraficLight4);
            this.Controls.Add(this.ctrlTraficLight3);
            this.Controls.Add(this.ctrlTraficLight2);
            this.Controls.Add(this.ctrlTraficLight1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight ctrlTraficLight1;
        private ctrlTraficLight ctrlTraficLight2;
        private ctrlTraficLight ctrlTraficLight3;
        private ctrlTraficLight ctrlTraficLight4;
    }
}


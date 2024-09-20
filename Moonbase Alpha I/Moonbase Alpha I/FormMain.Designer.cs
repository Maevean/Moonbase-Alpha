namespace Moonbase_Alpha_I
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxLocationInfo = new System.Windows.Forms.GroupBox();
            this.textBoxAreaDescription = new System.Windows.Forms.TextBox();
            this.labelAreaName = new System.Windows.Forms.Label();
            this.groupBoxNav = new System.Windows.Forms.GroupBox();
            this.buttonSimRoom = new System.Windows.Forms.Button();
            this.buttonTravel = new System.Windows.Forms.Button();
            this.buttonRelaxStat = new System.Windows.Forms.Button();
            this.buttonContRoom = new System.Windows.Forms.Button();
            this.groupBoxLocationInfo.SuspendLayout();
            this.groupBoxNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLocationInfo
            // 
            this.groupBoxLocationInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxLocationInfo.BackgroundImage = global::Moonbase_Alpha_I.Properties.Resources.blue_futuristic_control_panel_design_vector;
            this.groupBoxLocationInfo.Controls.Add(this.textBoxAreaDescription);
            this.groupBoxLocationInfo.Controls.Add(this.labelAreaName);
            this.groupBoxLocationInfo.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold);
            this.groupBoxLocationInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxLocationInfo.Location = new System.Drawing.Point(1243, 12);
            this.groupBoxLocationInfo.Name = "groupBoxLocationInfo";
            this.groupBoxLocationInfo.Size = new System.Drawing.Size(293, 497);
            this.groupBoxLocationInfo.TabIndex = 0;
            this.groupBoxLocationInfo.TabStop = false;
            this.groupBoxLocationInfo.Text = "Location Information";
            // 
            // textBoxAreaDescription
            // 
            this.textBoxAreaDescription.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxAreaDescription.Font = new System.Drawing.Font("Papyrus", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBoxAreaDescription.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxAreaDescription.Location = new System.Drawing.Point(6, 64);
            this.textBoxAreaDescription.Multiline = true;
            this.textBoxAreaDescription.Name = "textBoxAreaDescription";
            this.textBoxAreaDescription.ReadOnly = true;
            this.textBoxAreaDescription.Size = new System.Drawing.Size(281, 426);
            this.textBoxAreaDescription.TabIndex = 1;
            this.textBoxAreaDescription.Text = resources.GetString("textBoxAreaDescription.Text");
            // 
            // labelAreaName
            // 
            this.labelAreaName.AutoSize = true;
            this.labelAreaName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAreaName.Location = new System.Drawing.Point(15, 39);
            this.labelAreaName.Name = "labelAreaName";
            this.labelAreaName.Size = new System.Drawing.Size(167, 13);
            this.labelAreaName.TabIndex = 0;
            this.labelAreaName.Text = "General Purpose Room";
            // 
            // groupBoxNav
            // 
            this.groupBoxNav.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxNav.BackgroundImage = global::Moonbase_Alpha_I.Properties.Resources.blue_futuristic_control_panel_design_vector;
            this.groupBoxNav.Controls.Add(this.buttonSimRoom);
            this.groupBoxNav.Controls.Add(this.buttonTravel);
            this.groupBoxNav.Controls.Add(this.buttonRelaxStat);
            this.groupBoxNav.Controls.Add(this.buttonContRoom);
            this.groupBoxNav.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNav.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxNav.Location = new System.Drawing.Point(674, 118);
            this.groupBoxNav.Name = "groupBoxNav";
            this.groupBoxNav.Size = new System.Drawing.Size(209, 171);
            this.groupBoxNav.TabIndex = 1;
            this.groupBoxNav.TabStop = false;
            this.groupBoxNav.Text = "Moon Base Navigation";
            // 
            // buttonSimRoom
            // 
            this.buttonSimRoom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSimRoom.Font = new System.Drawing.Font("OCR A Extended", 7F, System.Drawing.FontStyle.Bold);
            this.buttonSimRoom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonSimRoom.Location = new System.Drawing.Point(97, 101);
            this.buttonSimRoom.Name = "buttonSimRoom";
            this.buttonSimRoom.Size = new System.Drawing.Size(83, 48);
            this.buttonSimRoom.TabIndex = 3;
            this.buttonSimRoom.Text = "Simulation Room";
            this.buttonSimRoom.UseVisualStyleBackColor = false;
            this.buttonSimRoom.Click += new System.EventHandler(this.buttonSimRoom_Click);
            // 
            // buttonTravel
            // 
            this.buttonTravel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTravel.Font = new System.Drawing.Font("OCR A Extended", 7F, System.Drawing.FontStyle.Bold);
            this.buttonTravel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonTravel.Location = new System.Drawing.Point(24, 101);
            this.buttonTravel.Name = "buttonTravel";
            this.buttonTravel.Size = new System.Drawing.Size(67, 48);
            this.buttonTravel.TabIndex = 2;
            this.buttonTravel.Text = "Travel Room";
            this.buttonTravel.UseVisualStyleBackColor = false;
            this.buttonTravel.Click += new System.EventHandler(this.buttonTravel_Click);
            // 
            // buttonRelaxStat
            // 
            this.buttonRelaxStat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRelaxStat.Font = new System.Drawing.Font("OCR A Extended", 7F, System.Drawing.FontStyle.Bold);
            this.buttonRelaxStat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonRelaxStat.Location = new System.Drawing.Point(97, 47);
            this.buttonRelaxStat.Name = "buttonRelaxStat";
            this.buttonRelaxStat.Size = new System.Drawing.Size(83, 48);
            this.buttonRelaxStat.TabIndex = 1;
            this.buttonRelaxStat.Text = "Relaxation Station";
            this.buttonRelaxStat.UseVisualStyleBackColor = false;
            this.buttonRelaxStat.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonContRoom
            // 
            this.buttonContRoom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonContRoom.Font = new System.Drawing.Font("OCR A Extended", 7F, System.Drawing.FontStyle.Bold);
            this.buttonContRoom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonContRoom.Location = new System.Drawing.Point(24, 47);
            this.buttonContRoom.Name = "buttonContRoom";
            this.buttonContRoom.Size = new System.Drawing.Size(67, 48);
            this.buttonContRoom.TabIndex = 0;
            this.buttonContRoom.Text = "Control Room";
            this.buttonContRoom.UseVisualStyleBackColor = false;
            this.buttonContRoom.Click += new System.EventHandler(this.buttonContRoom_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Moonbase_Alpha_I.Properties.Resources.splq;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.groupBoxNav);
            this.Controls.Add(this.groupBoxLocationInfo);
            this.Name = "FormMain";
            this.Text = "Moonbase Alpha";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.groupBoxLocationInfo.ResumeLayout(false);
            this.groupBoxLocationInfo.PerformLayout();
            this.groupBoxNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocationInfo;
        private System.Windows.Forms.TextBox textBoxAreaDescription;
        private System.Windows.Forms.GroupBox groupBoxNav;
        private System.Windows.Forms.Button buttonRelaxStat;
        private System.Windows.Forms.Button buttonContRoom;
        private System.Windows.Forms.Button buttonSimRoom;
        private System.Windows.Forms.Button buttonTravel;
        private System.Windows.Forms.Label labelAreaName;
    }
}
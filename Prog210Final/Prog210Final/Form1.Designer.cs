namespace Prog210Final
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
            this.dataGridViewSports = new System.Windows.Forms.DataGridView();
            this.dataGridViewHealth = new System.Windows.Forms.DataGridView();
            this.buttonToHealth = new System.Windows.Forms.Button();
            this.buttonToSport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSports
            // 
            this.dataGridViewSports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSports.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSports.Name = "dataGridViewSports";
            this.dataGridViewSports.Size = new System.Drawing.Size(468, 150);
            this.dataGridViewSports.TabIndex = 0;
            // 
            // dataGridViewHealth
            // 
            this.dataGridViewHealth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHealth.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewHealth.Name = "dataGridViewHealth";
            this.dataGridViewHealth.Size = new System.Drawing.Size(468, 150);
            this.dataGridViewHealth.TabIndex = 1;
            // 
            // buttonToHealth
            // 
            this.buttonToHealth.Location = new System.Drawing.Point(44, 392);
            this.buttonToHealth.Name = "buttonToHealth";
            this.buttonToHealth.Size = new System.Drawing.Size(110, 23);
            this.buttonToHealth.TabIndex = 2;
            this.buttonToHealth.Text = "Move To Health";
            this.buttonToHealth.UseVisualStyleBackColor = true;
            this.buttonToHealth.Click += new System.EventHandler(this.buttonToHealth_Click);
            // 
            // buttonToSport
            // 
            this.buttonToSport.Location = new System.Drawing.Point(347, 392);
            this.buttonToSport.Name = "buttonToSport";
            this.buttonToSport.Size = new System.Drawing.Size(102, 23);
            this.buttonToSport.TabIndex = 3;
            this.buttonToSport.Text = "Move To Sport";
            this.buttonToSport.UseVisualStyleBackColor = true;
            this.buttonToSport.Click += new System.EventHandler(this.buttonToSport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 452);
            this.Controls.Add(this.buttonToSport);
            this.Controls.Add(this.buttonToHealth);
            this.Controls.Add(this.dataGridViewHealth);
            this.Controls.Add(this.dataGridViewSports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHealth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSports;
        private System.Windows.Forms.DataGridView dataGridViewHealth;
        private System.Windows.Forms.Button buttonToHealth;
        private System.Windows.Forms.Button buttonToSport;
    }
}


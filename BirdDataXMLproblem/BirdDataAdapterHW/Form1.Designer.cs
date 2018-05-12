namespace BirdDataAdapterHW
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
            this.DataGridViewBirds = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewXML = new System.Windows.Forms.DataGridView();
            this.buttonReadXML = new System.Windows.Forms.Button();
            this.buttonUpdateFromXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBirds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewBirds
            // 
            this.DataGridViewBirds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBirds.Location = new System.Drawing.Point(45, 282);
            this.DataGridViewBirds.Name = "DataGridViewBirds";
            this.DataGridViewBirds.Size = new System.Drawing.Size(709, 302);
            this.DataGridViewBirds.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(154, 606);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(407, 606);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh From SQL";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewXML
            // 
            this.dataGridViewXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXML.Location = new System.Drawing.Point(45, 26);
            this.dataGridViewXML.Name = "dataGridViewXML";
            this.dataGridViewXML.Size = new System.Drawing.Size(709, 179);
            this.dataGridViewXML.TabIndex = 3;
            // 
            // buttonReadXML
            // 
            this.buttonReadXML.Location = new System.Drawing.Point(182, 226);
            this.buttonReadXML.Name = "buttonReadXML";
            this.buttonReadXML.Size = new System.Drawing.Size(75, 23);
            this.buttonReadXML.TabIndex = 4;
            this.buttonReadXML.Text = "Read XML File";
            this.buttonReadXML.UseVisualStyleBackColor = true;
            this.buttonReadXML.Click += new System.EventHandler(this.buttonReadXML_Click);
            // 
            // buttonUpdateFromXML
            // 
            this.buttonUpdateFromXML.Location = new System.Drawing.Point(471, 226);
            this.buttonUpdateFromXML.Name = "buttonUpdateFromXML";
            this.buttonUpdateFromXML.Size = new System.Drawing.Size(154, 23);
            this.buttonUpdateFromXML.TabIndex = 5;
            this.buttonUpdateFromXML.Text = "Add Records to SQL";
            this.buttonUpdateFromXML.UseVisualStyleBackColor = true;
            this.buttonUpdateFromXML.Click += new System.EventHandler(this.buttonUpdateFromXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 641);
            this.Controls.Add(this.buttonUpdateFromXML);
            this.Controls.Add(this.buttonReadXML);
            this.Controls.Add(this.dataGridViewXML);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.DataGridViewBirds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBirds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXML)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewBirds;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewXML;
        private System.Windows.Forms.Button buttonReadXML;
        private System.Windows.Forms.Button buttonUpdateFromXML;
    }
}


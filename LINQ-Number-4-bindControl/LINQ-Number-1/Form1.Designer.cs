namespace LINQ_Number_1
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
            this.buttonGetOrdDet = new System.Windows.Forms.Button();
            this.comboBoxResults = new System.Windows.Forms.ComboBox();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.textBoxProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetPrice = new System.Windows.Forms.Button();
            this.comboBoxResults2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetOrdDet
            // 
            this.buttonGetOrdDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGetOrdDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetOrdDet.Location = new System.Drawing.Point(12, 12);
            this.buttonGetOrdDet.Name = "buttonGetOrdDet";
            this.buttonGetOrdDet.Size = new System.Drawing.Size(145, 104);
            this.buttonGetOrdDet.TabIndex = 0;
            this.buttonGetOrdDet.Text = "Get Products  with more than 79 orders";
            this.buttonGetOrdDet.UseVisualStyleBackColor = false;
            this.buttonGetOrdDet.Click += new System.EventHandler(this.buttonGetOrdDet_Click);
            // 
            // comboBoxResults
            // 
            this.comboBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxResults.FormattingEnabled = true;
            this.comboBoxResults.Location = new System.Drawing.Point(195, 13);
            this.comboBoxResults.Name = "comboBoxResults";
            this.comboBoxResults.Size = new System.Drawing.Size(187, 24);
            this.comboBoxResults.TabIndex = 1;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(433, 12);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(458, 669);
            this.dataGridViewResults.TabIndex = 2;
            // 
            // textBoxProduct
            // 
            this.textBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProduct.Location = new System.Drawing.Point(46, 579);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new System.Drawing.Size(313, 26);
            this.textBoxProduct.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Item From Drop Down to See Maximum Price";
            // 
            // buttonGetPrice
            // 
            this.buttonGetPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGetPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetPrice.Location = new System.Drawing.Point(142, 622);
            this.buttonGetPrice.Name = "buttonGetPrice";
            this.buttonGetPrice.Size = new System.Drawing.Size(75, 59);
            this.buttonGetPrice.TabIndex = 5;
            this.buttonGetPrice.Text = "Get Price";
            this.buttonGetPrice.UseVisualStyleBackColor = false;
            this.buttonGetPrice.Click += new System.EventHandler(this.buttonGetPrice_Click);
            // 
            // comboBoxResults2
            // 
            this.comboBoxResults2.FormattingEnabled = true;
            this.comboBoxResults2.Location = new System.Drawing.Point(195, 292);
            this.comboBoxResults2.Name = "comboBoxResults2";
            this.comboBoxResults2.Size = new System.Drawing.Size(187, 21);
            this.comboBoxResults2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 693);
            this.Controls.Add(this.comboBoxResults2);
            this.Controls.Add(this.buttonGetPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.comboBoxResults);
            this.Controls.Add(this.buttonGetOrdDet);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetOrdDet;
        private System.Windows.Forms.ComboBox comboBoxResults;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.TextBox textBoxProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetPrice;
        private System.Windows.Forms.ComboBox comboBoxResults2;
    }
}


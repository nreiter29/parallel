
namespace ResistanceCalculation
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxResistorOne = new System.Windows.Forms.TextBox();
            this.tbxResistorTwo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalSeries = new System.Windows.Forms.Label();
            this.lblTotalParallel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(196, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(340, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gesamtwiderstand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "R2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "R1:";
            // 
            // tbxResistorOne
            // 
            this.tbxResistorOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResistorOne.Location = new System.Drawing.Point(55, 40);
            this.tbxResistorOne.Name = "tbxResistorOne";
            this.tbxResistorOne.Size = new System.Drawing.Size(69, 26);
            this.tbxResistorOne.TabIndex = 5;
            // 
            // tbxResistorTwo
            // 
            this.tbxResistorTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResistorTwo.Location = new System.Drawing.Point(55, 86);
            this.tbxResistorTwo.Name = "tbxResistorTwo";
            this.tbxResistorTwo.Size = new System.Drawing.Size(69, 26);
            this.tbxResistorTwo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ω";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ω";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(51, 130);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "berechnen";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalSeries
            // 
            this.lblTotalSeries.AutoSize = true;
            this.lblTotalSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeries.Location = new System.Drawing.Point(192, 191);
            this.lblTotalSeries.Name = "lblTotalSeries";
            this.lblTotalSeries.Size = new System.Drawing.Size(118, 20);
            this.lblTotalSeries.TabIndex = 11;
            this.lblTotalSeries.Text = "lblTotalSeries";
            // 
            // lblTotalParallel
            // 
            this.lblTotalParallel.AutoSize = true;
            this.lblTotalParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParallel.Location = new System.Drawing.Point(336, 191);
            this.lblTotalParallel.Name = "lblTotalParallel";
            this.lblTotalParallel.Size = new System.Drawing.Size(126, 20);
            this.lblTotalParallel.TabIndex = 12;
            this.lblTotalParallel.Text = "lblTotalParallel";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 230);
            this.Controls.Add(this.lblTotalParallel);
            this.Controls.Add(this.lblTotalSeries);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxResistorTwo);
            this.Controls.Add(this.tbxResistorOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxResistorOne;
        private System.Windows.Forms.TextBox tbxResistorTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalSeries;
        private System.Windows.Forms.Label lblTotalParallel;
    }
}


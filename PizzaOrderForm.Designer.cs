namespace PizzaOrder
{
    partial class frmPizzaOrder
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCostAnswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Trajan Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 39);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(324, 16);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Enter the diameter of the pizza in Inches ";
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCostAnswer
            // 
            this.lblCostAnswer.AutoSize = true;
            this.lblCostAnswer.Location = new System.Drawing.Point(12, 122);
            this.lblCostAnswer.Name = "lblCostAnswer";
            this.lblCostAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblCostAnswer.TabIndex = 1;
            this.lblCostAnswer.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(332, 86);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(110, 23);
            this.btnCost.TabIndex = 4;
            this.btnCost.Text = "Calculate Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(516, 239);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCostAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblCostAnswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCost;
    }
}


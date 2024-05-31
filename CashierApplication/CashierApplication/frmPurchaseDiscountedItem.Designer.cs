namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.DiscountT = new System.Windows.Forms.TextBox();
            this.PriceT = new System.Windows.Forms.TextBox();
            this.QuantityT = new System.Windows.Forms.TextBox();
            this.ComputeB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PaymentReceived = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalAmountT = new System.Windows.Forms.Label();
            this.DisChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM:";
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(12, 56);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(221, 20);
            this.ItemName.TabIndex = 1;
            // 
            // DiscountT
            // 
            this.DiscountT.Location = new System.Drawing.Point(250, 56);
            this.DiscountT.Name = "DiscountT";
            this.DiscountT.Size = new System.Drawing.Size(145, 20);
            this.DiscountT.TabIndex = 2;
            // 
            // PriceT
            // 
            this.PriceT.Location = new System.Drawing.Point(60, 89);
            this.PriceT.Name = "PriceT";
            this.PriceT.Size = new System.Drawing.Size(173, 20);
            this.PriceT.TabIndex = 3;
            // 
            // QuantityT
            // 
            this.QuantityT.Location = new System.Drawing.Point(324, 89);
            this.QuantityT.Name = "QuantityT";
            this.QuantityT.Size = new System.Drawing.Size(71, 20);
            this.QuantityT.TabIndex = 4;
            // 
            // ComputeB
            // 
            this.ComputeB.Location = new System.Drawing.Point(158, 124);
            this.ComputeB.Name = "ComputeB";
            this.ComputeB.Size = new System.Drawing.Size(100, 30);
            this.ComputeB.TabIndex = 5;
            this.ComputeB.Text = "COMPUTE";
            this.ComputeB.UseVisualStyleBackColor = true;
            this.ComputeB.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PaymentReceived
            // 
            this.PaymentReceived.Location = new System.Drawing.Point(158, 273);
            this.PaymentReceived.Name = "PaymentReceived";
            this.PaymentReceived.Size = new System.Drawing.Size(133, 20);
            this.PaymentReceived.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "DISCOUNT(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRICE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "QUANTITY:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL AMOUNT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "PAYMENT RECEIVED:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "CHANGE:";
            // 
            // TotalAmountT
            // 
            this.TotalAmountT.AutoSize = true;
            this.TotalAmountT.Location = new System.Drawing.Point(165, 186);
            this.TotalAmountT.Name = "TotalAmountT";
            this.TotalAmountT.Size = new System.Drawing.Size(61, 13);
            this.TotalAmountT.TabIndex = 14;
            this.TotalAmountT.Text = "< Amount >";
            // 
            // DisChange
            // 
            this.DisChange.AutoSize = true;
            this.DisChange.Location = new System.Drawing.Point(165, 312);
            this.DisChange.Name = "DisChange";
            this.DisChange.Size = new System.Drawing.Size(62, 13);
            this.DisChange.TabIndex = 15;
            this.DisChange.Text = "< Change >";
            // 
            // frmPurchaseDiscountedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.DisChange);
            this.Controls.Add(this.TotalAmountT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaymentReceived);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ComputeB);
            this.Controls.Add(this.QuantityT);
            this.Controls.Add(this.PriceT);
            this.Controls.Add(this.DiscountT);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.label1);
            this.Name = "frmPurchaseDiscountedItem";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox DiscountT;
        private System.Windows.Forms.TextBox PriceT;
        private System.Windows.Forms.TextBox QuantityT;
        private System.Windows.Forms.Button ComputeB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox PaymentReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalAmountT;
        private System.Windows.Forms.Label DisChange;
    }
}


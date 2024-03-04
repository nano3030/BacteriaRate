namespace BacteriaRate
{
    partial class MainForm
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
            this.HeadingLbl = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdLblBox = new System.Windows.Forms.Label();
            this.NameLblBox = new System.Windows.Forms.Label();
            this.CountLblBox = new System.Windows.Forms.Label();
            this.TimeLblBox = new System.Windows.Forms.Label();
            this.MessageLblBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeadingLbl
            // 
            this.HeadingLbl.BackColor = System.Drawing.Color.LightGreen;
            this.HeadingLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLbl.Location = new System.Drawing.Point(356, 98);
            this.HeadingLbl.Name = "HeadingLbl";
            this.HeadingLbl.Size = new System.Drawing.Size(740, 126);
            this.HeadingLbl.TabIndex = 0;
            this.HeadingLbl.Text = "Bacteria Infection Rate";
            this.HeadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadingLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.LightGreen;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(997, 342);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(99, 54);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "N&ext";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bacteria Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bacteria Count:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Time:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 824);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Message:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdLblBox
            // 
            this.IdLblBox.BackColor = System.Drawing.Color.White;
            this.IdLblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdLblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLblBox.Location = new System.Drawing.Point(615, 361);
            this.IdLblBox.Name = "IdLblBox";
            this.IdLblBox.Size = new System.Drawing.Size(225, 25);
            this.IdLblBox.TabIndex = 7;
            this.IdLblBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameLblBox
            // 
            this.NameLblBox.BackColor = System.Drawing.Color.White;
            this.NameLblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameLblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLblBox.Location = new System.Drawing.Point(615, 464);
            this.NameLblBox.Name = "NameLblBox";
            this.NameLblBox.Size = new System.Drawing.Size(225, 25);
            this.NameLblBox.TabIndex = 8;
            this.NameLblBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CountLblBox
            // 
            this.CountLblBox.BackColor = System.Drawing.Color.White;
            this.CountLblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CountLblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLblBox.Location = new System.Drawing.Point(615, 557);
            this.CountLblBox.Name = "CountLblBox";
            this.CountLblBox.Size = new System.Drawing.Size(225, 25);
            this.CountLblBox.TabIndex = 9;
            this.CountLblBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLblBox
            // 
            this.TimeLblBox.BackColor = System.Drawing.Color.White;
            this.TimeLblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLblBox.Location = new System.Drawing.Point(615, 663);
            this.TimeLblBox.Name = "TimeLblBox";
            this.TimeLblBox.Size = new System.Drawing.Size(225, 25);
            this.TimeLblBox.TabIndex = 10;
            this.TimeLblBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageLblBox
            // 
            this.MessageLblBox.BackColor = System.Drawing.Color.White;
            this.MessageLblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageLblBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLblBox.Location = new System.Drawing.Point(615, 824);
            this.MessageLblBox.Name = "MessageLblBox";
            this.MessageLblBox.Size = new System.Drawing.Size(225, 25);
            this.MessageLblBox.TabIndex = 11;
            this.MessageLblBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1569, 1036);
            this.Controls.Add(this.MessageLblBox);
            this.Controls.Add(this.TimeLblBox);
            this.Controls.Add(this.CountLblBox);
            this.Controls.Add(this.NameLblBox);
            this.Controls.Add(this.IdLblBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.HeadingLbl);
            this.Name = "MainForm";
            this.Text = "Bacteria";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLbl;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label IdLblBox;
        private System.Windows.Forms.Label NameLblBox;
        private System.Windows.Forms.Label CountLblBox;
        private System.Windows.Forms.Label TimeLblBox;
        private System.Windows.Forms.Label MessageLblBox;
    }
}


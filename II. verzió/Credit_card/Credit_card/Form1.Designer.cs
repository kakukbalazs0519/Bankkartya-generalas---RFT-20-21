namespace Credit_card
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardnumber_textbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ervényessegi_idő = new System.Windows.Forms.TextBox();
            this.Cardtulaj_textBox1 = new System.Windows.Forms.TextBox();
            this.CardNumber_Label = new System.Windows.Forms.Label();
            this.Card4N_label = new System.Windows.Forms.Label();
            this.validlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 351);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cardnumber_textbox
            // 
            this.cardnumber_textbox.Location = new System.Drawing.Point(91, 375);
            this.cardnumber_textbox.Name = "cardnumber_textbox";
            this.cardnumber_textbox.Size = new System.Drawing.Size(100, 20);
            this.cardnumber_textbox.TabIndex = 1;
            this.cardnumber_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(601, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(583, 351);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ervényessegi_idő
            // 
            this.ervényessegi_idő.Location = new System.Drawing.Point(91, 402);
            this.ervényessegi_idő.Name = "ervényessegi_idő";
            this.ervényessegi_idő.Size = new System.Drawing.Size(100, 20);
            this.ervényessegi_idő.TabIndex = 3;
            // 
            // Cardtulaj_textBox1
            // 
            this.Cardtulaj_textBox1.Location = new System.Drawing.Point(91, 429);
            this.Cardtulaj_textBox1.Name = "Cardtulaj_textBox1";
            this.Cardtulaj_textBox1.Size = new System.Drawing.Size(100, 20);
            this.Cardtulaj_textBox1.TabIndex = 4;
            // 
            // CardNumber_Label
            // 
            this.CardNumber_Label.AutoSize = true;
            this.CardNumber_Label.Location = new System.Drawing.Point(42, 219);
            this.CardNumber_Label.Name = "CardNumber_Label";
            this.CardNumber_Label.Size = new System.Drawing.Size(35, 13);
            this.CardNumber_Label.TabIndex = 3;
            this.CardNumber_Label.Text = "label1";
            this.CardNumber_Label.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Card4N_label
            // 
            this.Card4N_label.AutoSize = true;
            this.Card4N_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Card4N_label.ForeColor = System.Drawing.Color.White;
            this.Card4N_label.Location = new System.Drawing.Point(52, 281);
            this.Card4N_label.Name = "Card4N_label";
            this.Card4N_label.Size = new System.Drawing.Size(42, 16);
            this.Card4N_label.TabIndex = 6;
            this.Card4N_label.Text = "label2";
            // 
            // validlabel
            // 
            this.validlabel.AutoSize = true;
            this.validlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.validlabel.ForeColor = System.Drawing.Color.White;
            this.validlabel.Location = new System.Drawing.Point(258, 268);
            this.validlabel.Name = "validlabel";
            this.validlabel.Size = new System.Drawing.Size(102, 37);
            this.validlabel.TabIndex = 7;
            this.validlabel.Text = "label3";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Namelabel.ForeColor = System.Drawing.Color.Orange;
            this.Namelabel.Location = new System.Drawing.Point(45, 310);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(108, 37);
            this.Namelabel.TabIndex = 8;
            this.Namelabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.validlabel);
            this.Controls.Add(this.Card4N_label);
            this.Controls.Add(this.CardNumber_Label);
            this.Controls.Add(this.Cardtulaj_textBox1);
            this.Controls.Add(this.ervényessegi_idő);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cardnumber_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cardnumber_textbox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ervényessegi_idő;
        private System.Windows.Forms.TextBox Cardtulaj_textBox1;
        private System.Windows.Forms.Label CardNumber_Label;
        private System.Windows.Forms.Label Card4N_label;
        private System.Windows.Forms.Label validlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label label5;
    }
}


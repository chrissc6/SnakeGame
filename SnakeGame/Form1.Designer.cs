namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.myPB1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.labelGO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myPB1)).BeginInit();
            this.SuspendLayout();
            // 
            // myPB1
            // 
            this.myPB1.Location = new System.Drawing.Point(12, 12);
            this.myPB1.Name = "myPB1";
            this.myPB1.Size = new System.Drawing.Size(477, 426);
            this.myPB1.TabIndex = 0;
            this.myPB1.TabStop = false;
            this.myPB1.BackColorChanged += new System.EventHandler(this.UpdateScreen);
            this.myPB1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.myPB1.Paint += new System.Windows.Forms.PaintEventHandler(this.myPB1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(513, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(639, 12);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 37);
            this.labelScore.TabIndex = 2;
            // 
            // labelGO
            // 
            this.labelGO.AutoSize = true;
            this.labelGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGO.Location = new System.Drawing.Point(140, 82);
            this.labelGO.Name = "labelGO";
            this.labelGO.Size = new System.Drawing.Size(102, 37);
            this.labelGO.TabIndex = 3;
            this.labelGO.Text = "label2";
            this.labelGO.Visible = false;
            this.labelGO.Click += new System.EventHandler(this.labelGO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGO);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myPB1);
            this.Name = "Form1";
            this.Text = "The Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            ((System.ComponentModel.ISupportInitialize)(this.myPB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myPB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Label labelGO;
    }
}


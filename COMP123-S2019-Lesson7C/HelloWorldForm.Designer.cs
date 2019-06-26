namespace COMP123_S2019_Lesson7C
{
    partial class HelloWorldForm
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
            this.HelloWorldLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.RandonNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloWorldLabel
            // 
            this.HelloWorldLabel.BackColor = System.Drawing.Color.White;
            this.HelloWorldLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.HelloWorldLabel.Location = new System.Drawing.Point(160, 147);
            this.HelloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HelloWorldLabel.Name = "HelloWorldLabel";
            this.HelloWorldLabel.Size = new System.Drawing.Size(240, 43);
            this.HelloWorldLabel.TabIndex = 0;
            this.HelloWorldLabel.Text = "Hello, World!";
            this.HelloWorldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ClickMeButton.Location = new System.Drawing.Point(9, 147);
            this.ClickMeButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(147, 43);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // RandonNumberLabel
            // 
            this.RandonNumberLabel.BackColor = System.Drawing.Color.White;
            this.RandonNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandonNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RandonNumberLabel.Location = new System.Drawing.Point(404, 147);
            this.RandonNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RandonNumberLabel.Name = "RandonNumberLabel";
            this.RandonNumberLabel.Size = new System.Drawing.Size(57, 43);
            this.RandonNumberLabel.TabIndex = 2;
            this.RandonNumberLabel.Text = "00";
            this.RandonNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.RandonNumberLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.HelloWorldLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelloWorldForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelloWorldLabel;
        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.Label RandonNumberLabel;
    }
}


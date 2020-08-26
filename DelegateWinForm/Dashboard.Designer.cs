namespace DelegateWinForm
{
    partial class DelegateDemoForm
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
            this.totalCoursesLabel = new System.Windows.Forms.Label();
            this.totalCreditsLabel = new System.Windows.Forms.Label();
            this.GPALabel = new System.Windows.Forms.Label();
            this.totalCoursesValue = new System.Windows.Forms.TextBox();
            this.totalCreditsValue = new System.Windows.Forms.TextBox();
            this.GPAValue = new System.Windows.Forms.TextBox();
            this.messageBoxButton = new System.Windows.Forms.Button();
            this.textBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalCoursesLabel
            // 
            this.totalCoursesLabel.AutoSize = true;
            this.totalCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCoursesLabel.Location = new System.Drawing.Point(210, 53);
            this.totalCoursesLabel.Name = "totalCoursesLabel";
            this.totalCoursesLabel.Size = new System.Drawing.Size(170, 29);
            this.totalCoursesLabel.TabIndex = 0;
            this.totalCoursesLabel.Text = "Total Courses";
            // 
            // totalCreditsLabel
            // 
            this.totalCreditsLabel.AutoSize = true;
            this.totalCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCreditsLabel.Location = new System.Drawing.Point(210, 113);
            this.totalCreditsLabel.Name = "totalCreditsLabel";
            this.totalCreditsLabel.Size = new System.Drawing.Size(156, 29);
            this.totalCreditsLabel.TabIndex = 1;
            this.totalCreditsLabel.Text = "Total Credits";
            // 
            // GPALabel
            // 
            this.GPALabel.AutoSize = true;
            this.GPALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPALabel.Location = new System.Drawing.Point(210, 172);
            this.GPALabel.Name = "GPALabel";
            this.GPALabel.Size = new System.Drawing.Size(66, 29);
            this.GPALabel.TabIndex = 2;
            this.GPALabel.Text = "GPA";
            // 
            // totalCoursesValue
            // 
            this.totalCoursesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCoursesValue.Location = new System.Drawing.Point(386, 46);
            this.totalCoursesValue.Name = "totalCoursesValue";
            this.totalCoursesValue.Size = new System.Drawing.Size(177, 36);
            this.totalCoursesValue.TabIndex = 3;
            // 
            // totalCreditsValue
            // 
            this.totalCreditsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCreditsValue.Location = new System.Drawing.Point(386, 106);
            this.totalCreditsValue.Name = "totalCreditsValue";
            this.totalCreditsValue.Size = new System.Drawing.Size(177, 36);
            this.totalCreditsValue.TabIndex = 4;
            // 
            // GPAValue
            // 
            this.GPAValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPAValue.Location = new System.Drawing.Point(386, 165);
            this.GPAValue.Name = "GPAValue";
            this.GPAValue.Size = new System.Drawing.Size(177, 36);
            this.GPAValue.TabIndex = 5;
            // 
            // messageBoxButton
            // 
            this.messageBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBoxButton.Location = new System.Drawing.Point(153, 293);
            this.messageBoxButton.Name = "messageBoxButton";
            this.messageBoxButton.Size = new System.Drawing.Size(209, 85);
            this.messageBoxButton.TabIndex = 6;
            this.messageBoxButton.Text = "MessageBox Demo";
            this.messageBoxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.messageBoxButton.UseVisualStyleBackColor = true;
            this.messageBoxButton.Click += new System.EventHandler(this.messageBoxButton_Click);
            // 
            // textBoxButton
            // 
            this.textBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxButton.Location = new System.Drawing.Point(441, 293);
            this.textBoxButton.Name = "textBoxButton";
            this.textBoxButton.Size = new System.Drawing.Size(210, 85);
            this.textBoxButton.TabIndex = 7;
            this.textBoxButton.Text = "TextBox Demo";
            this.textBoxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.textBoxButton.UseVisualStyleBackColor = true;
            this.textBoxButton.Click += new System.EventHandler(this.textBoxButton_Click);
            // 
            // DelegateDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxButton);
            this.Controls.Add(this.messageBoxButton);
            this.Controls.Add(this.GPAValue);
            this.Controls.Add(this.totalCreditsValue);
            this.Controls.Add(this.totalCoursesValue);
            this.Controls.Add(this.GPALabel);
            this.Controls.Add(this.totalCreditsLabel);
            this.Controls.Add(this.totalCoursesLabel);
            this.Name = "DelegateDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DelegateDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCoursesLabel;
        private System.Windows.Forms.Label totalCreditsLabel;
        private System.Windows.Forms.Label GPALabel;
        private System.Windows.Forms.TextBox totalCoursesValue;
        private System.Windows.Forms.TextBox totalCreditsValue;
        private System.Windows.Forms.TextBox GPAValue;
        private System.Windows.Forms.Button messageBoxButton;
        private System.Windows.Forms.Button textBoxButton;
    }
}


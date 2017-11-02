namespace WindowsFormsApp1
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
            this.GetData = new System.Windows.Forms.Button();
            this.ContainerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(0, 0);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(107, 53);
            this.GetData.TabIndex = 0;
            this.GetData.Text = "Get Data";
            this.GetData.UseVisualStyleBackColor = true;
            // 
            // ContainerTextBox
            // 
            this.ContainerTextBox.Location = new System.Drawing.Point(0, 60);
            this.ContainerTextBox.Multiline = true;
            this.ContainerTextBox.Name = "ContainerTextBox";
            this.ContainerTextBox.ReadOnly = true;
            this.ContainerTextBox.Size = new System.Drawing.Size(272, 171);
            this.ContainerTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ContainerTextBox);
            this.Controls.Add(this.GetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.TextBox ContainerTextBox;
    }
}


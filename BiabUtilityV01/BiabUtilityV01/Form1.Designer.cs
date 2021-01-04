
namespace BiabUtilityV01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddMissingFoldersButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddMissingFoldersButton
            // 
            this.AddMissingFoldersButton.AutoSize = true;
            this.AddMissingFoldersButton.Location = new System.Drawing.Point(27, 23);
            this.AddMissingFoldersButton.Name = "AddMissingFoldersButton";
            this.AddMissingFoldersButton.Size = new System.Drawing.Size(185, 35);
            this.AddMissingFoldersButton.TabIndex = 0;
            this.AddMissingFoldersButton.Text = "Add Missing Folders";
            this.AddMissingFoldersButton.UseVisualStyleBackColor = true;
            this.AddMissingFoldersButton.Click += new System.EventHandler(this.AddMissingFoldersButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageTextBox.Location = new System.Drawing.Point(27, 216);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.Size = new System.Drawing.Size(729, 199);
            this.MessageTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.AddMissingFoldersButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMissingFoldersButton;
        private System.Windows.Forms.TextBox MessageTextBox;
    }
}


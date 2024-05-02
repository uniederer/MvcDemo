namespace MvcDemo
{
    partial class TextParameterView
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
            label1 = new Label();
            label2 = new Label();
            CharacterCount = new Label();
            WordCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Character count:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Word count:";
            // 
            // CharacterCount
            // 
            CharacterCount.AutoSize = true;
            CharacterCount.Location = new Point(113, 9);
            CharacterCount.Name = "CharacterCount";
            CharacterCount.Size = new Size(13, 15);
            CharacterCount.TabIndex = 2;
            CharacterCount.Text = "0";
            // 
            // WordCount
            // 
            WordCount.AutoSize = true;
            WordCount.Location = new Point(113, 27);
            WordCount.Name = "WordCount";
            WordCount.Size = new Size(13, 15);
            WordCount.TabIndex = 3;
            WordCount.Text = "0";
            // 
            // TextParameterView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 51);
            Controls.Add(WordCount);
            Controls.Add(CharacterCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TextParameterView";
            Text = "VIEW: Text Parameter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label CharacterCount;
        private Label WordCount;
    }
}
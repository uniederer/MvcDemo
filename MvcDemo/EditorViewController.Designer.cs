
namespace MvcDemo
{
    partial class EditorViewController
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
            Content = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Content
            // 
            Content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Content.Location = new Point(12, 42);
            Content.Multiline = true;
            Content.Name = "Content";
            Content.Size = new Size(485, 271);
            Content.TabIndex = 0;
            Content.TextChanged += Content_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 1;
            label1.Text = "Edit the model's content using this window.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(461, 15);
            label2.TabIndex = 2;
            label2.Text = "Try markdown syntax for headings (#) and emphasis (**, *) and observe what happens.";
            // 
            // EditorViewController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 325);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Content);
            Name = "EditorViewController";
            Text = "VIEW and CONTROLLER: Editor";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox Content;
        private Label label1;
        private Label label2;
    }
}
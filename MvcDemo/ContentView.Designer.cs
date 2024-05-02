namespace MvcDemo
{
    partial class ContentView
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
            Content = new RichTextBox();
            SuspendLayout();
            // 
            // Content
            // 
            Content.BorderStyle = BorderStyle.None;
            Content.Location = new Point(12, 12);
            Content.Name = "Content";
            Content.ReadOnly = true;
            Content.Size = new Size(460, 432);
            Content.TabIndex = 1;
            Content.Text = "";
            // 
            // ContentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 456);
            Controls.Add(Content);
            Name = "ContentView";
            Text = "VIEW: Content";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox Content;
    }
}
namespace MvcDemo
{
    partial class MvcDemoMain
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
            LipsumCommand = new Button();
            ClearCommand = new Button();
            ControllerCommandGroup = new GroupBox();
            MarkdownCommand = new Button();
            ShowWindowsCommand = new Button();
            ControllerCommandGroup.SuspendLayout();
            SuspendLayout();
            // 
            // LipsumCommand
            // 
            LipsumCommand.Location = new Point(6, 22);
            LipsumCommand.Name = "LipsumCommand";
            LipsumCommand.Size = new Size(153, 23);
            LipsumCommand.TabIndex = 0;
            LipsumCommand.Text = "Set Text to Lorem Ipsum";
            LipsumCommand.UseVisualStyleBackColor = true;
            LipsumCommand.Click += OnSetLorem_Click;
            // 
            // ClearCommand
            // 
            ClearCommand.Location = new Point(165, 22);
            ClearCommand.Name = "ClearCommand";
            ClearCommand.Size = new Size(75, 23);
            ClearCommand.TabIndex = 1;
            ClearCommand.Text = "Clear Text";
            ClearCommand.UseVisualStyleBackColor = true;
            ClearCommand.Click += OnClear_Click;
            // 
            // ControllerCommandGroup
            // 
            ControllerCommandGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ControllerCommandGroup.Controls.Add(MarkdownCommand);
            ControllerCommandGroup.Controls.Add(ClearCommand);
            ControllerCommandGroup.Controls.Add(LipsumCommand);
            ControllerCommandGroup.Location = new Point(12, 12);
            ControllerCommandGroup.Name = "ControllerCommandGroup";
            ControllerCommandGroup.Size = new Size(265, 82);
            ControllerCommandGroup.TabIndex = 2;
            ControllerCommandGroup.TabStop = false;
            ControllerCommandGroup.Text = "Controller Commands";
            // 
            // MarkdownCommand
            // 
            MarkdownCommand.Location = new Point(6, 51);
            MarkdownCommand.Name = "MarkdownCommand";
            MarkdownCommand.Size = new Size(153, 23);
            MarkdownCommand.TabIndex = 2;
            MarkdownCommand.Text = "Set markdown demo";
            MarkdownCommand.UseVisualStyleBackColor = true;
            MarkdownCommand.Click += OnSetMarkdown_Click;
            // 
            // ShowWindowsCommand
            // 
            ShowWindowsCommand.Location = new Point(18, 100);
            ShowWindowsCommand.Name = "ShowWindowsCommand";
            ShowWindowsCommand.Size = new Size(234, 23);
            ShowWindowsCommand.TabIndex = 3;
            ShowWindowsCommand.Text = "Show all windows";
            ShowWindowsCommand.UseVisualStyleBackColor = true;
            ShowWindowsCommand.Click += OnShowWindows_Click;
            // 
            // MvcDemoMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 450);
            Controls.Add(ShowWindowsCommand);
            Controls.Add(ControllerCommandGroup);
            Name = "MvcDemoMain";
            Text = "MVC Demonstrator";
            ControllerCommandGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button LipsumCommand;
        private Button ClearCommand;
        private GroupBox ControllerCommandGroup;
        private Button ShowWindowsCommand;
        private Button MarkdownCommand;
    }
}


namespace kursova_rabota
{
    partial class FormScene
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusPerimeter = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuRight = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusArea,
            this.toolStripStatusPerimeter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusArea
            // 
            this.toolStripStatusArea.Name = "toolStripStatusArea";
            this.toolStripStatusArea.Size = new System.Drawing.Size(48, 25);
            this.toolStripStatusArea.Text = "Area";
            // 
            // toolStripStatusPerimeter
            // 
            this.toolStripStatusPerimeter.Name = "toolStripStatusPerimeter";
            this.toolStripStatusPerimeter.Size = new System.Drawing.Size(86, 25);
            this.toolStripStatusPerimeter.Text = "Perimeter";
            // 
            // menuStripMain
            // 
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centerToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 33);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuLeft,
            this.rightToolStripMenuRight});
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.centerToolStripMenuItem.Text = "Select";
            // 
            // leftToolStripMenuLeft
            // 
            this.leftToolStripMenuLeft.Name = "leftToolStripMenuLeft";
            this.leftToolStripMenuLeft.Size = new System.Drawing.Size(270, 34);
            this.leftToolStripMenuLeft.Text = "Left";
            this.leftToolStripMenuLeft.Click += new System.EventHandler(this.leftToolStripMenuLeft_Click);
            // 
            // rightToolStripMenuRight
            // 
            this.rightToolStripMenuRight.Name = "rightToolStripMenuRight";
            this.rightToolStripMenuRight.Size = new System.Drawing.Size(270, 34);
            this.rightToolStripMenuRight.Text = "Right";
            this.rightToolStripMenuRight.Click += new System.EventHandler(this.rightToolStripMenuRight_Click);
            // 
            // FormScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormScene";
            this.Text = "FormScene";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScene_FormClosing);
            this.Load += new System.EventHandler(this.FormScene_Load);
            this.DoubleClick += new System.EventHandler(this.FormScene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScene_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScene_MouseDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusArea;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPerimeter;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuLeft;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuRight;
    }
}


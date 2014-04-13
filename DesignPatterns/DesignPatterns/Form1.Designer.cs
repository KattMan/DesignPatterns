namespace DesignPatterns
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.creationalPatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleFactoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abstractFactoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.behavioralPatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.structuralPatternsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adapterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decoratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(602, 365);
            this.textBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creationalPatternsToolStripMenuItem,
            this.behavioralPatternsToolStripMenuItem,
            this.structuralPatternsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // creationalPatternsToolStripMenuItem
            // 
            this.creationalPatternsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleFactoryToolStripMenuItem,
            this.abstractFactoryToolStripMenuItem,
            this.singletonToolStripMenuItem,
            this.builderToolStripMenuItem});
            this.creationalPatternsToolStripMenuItem.Name = "creationalPatternsToolStripMenuItem";
            this.creationalPatternsToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.creationalPatternsToolStripMenuItem.Text = "Creational Patterns";
            // 
            // simpleFactoryToolStripMenuItem
            // 
            this.simpleFactoryToolStripMenuItem.Name = "simpleFactoryToolStripMenuItem";
            this.simpleFactoryToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.simpleFactoryToolStripMenuItem.Text = "Simple Factory";
            this.simpleFactoryToolStripMenuItem.Click += new System.EventHandler(this.simpleFactoryToolStripMenuItem_Click);
            // 
            // abstractFactoryToolStripMenuItem
            // 
            this.abstractFactoryToolStripMenuItem.Name = "abstractFactoryToolStripMenuItem";
            this.abstractFactoryToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.abstractFactoryToolStripMenuItem.Text = "Abstract Factory";
            this.abstractFactoryToolStripMenuItem.Click += new System.EventHandler(this.abstractFactoryToolStripMenuItem_Click);
            // 
            // singletonToolStripMenuItem
            // 
            this.singletonToolStripMenuItem.Name = "singletonToolStripMenuItem";
            this.singletonToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.singletonToolStripMenuItem.Text = "Singleton";
            this.singletonToolStripMenuItem.Click += new System.EventHandler(this.singletonToolStripMenuItem_Click);
            // 
            // builderToolStripMenuItem
            // 
            this.builderToolStripMenuItem.Name = "builderToolStripMenuItem";
            this.builderToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.builderToolStripMenuItem.Text = "Builder";
            this.builderToolStripMenuItem.Click += new System.EventHandler(this.builderToolStripMenuItem_Click);
            // 
            // behavioralPatternsToolStripMenuItem
            // 
            this.behavioralPatternsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mementoToolStripMenuItem,
            this.commandToolStripMenuItem,
            this.observerToolStripMenuItem});
            this.behavioralPatternsToolStripMenuItem.Name = "behavioralPatternsToolStripMenuItem";
            this.behavioralPatternsToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.behavioralPatternsToolStripMenuItem.Text = "Behavioral Patterns";
            // 
            // mementoToolStripMenuItem
            // 
            this.mementoToolStripMenuItem.Name = "mementoToolStripMenuItem";
            this.mementoToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.mementoToolStripMenuItem.Text = "Memento";
            this.mementoToolStripMenuItem.Click += new System.EventHandler(this.mementoToolStripMenuItem_Click);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.commandToolStripMenuItem.Text = "Command";
            this.commandToolStripMenuItem.Click += new System.EventHandler(this.commandToolStripMenuItem_Click);
            // 
            // observerToolStripMenuItem
            // 
            this.observerToolStripMenuItem.Name = "observerToolStripMenuItem";
            this.observerToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.observerToolStripMenuItem.Text = "Observer";
            this.observerToolStripMenuItem.Click += new System.EventHandler(this.observerToolStripMenuItem_Click);
            // 
            // structuralPatternsToolStripMenuItem
            // 
            this.structuralPatternsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adapterToolStripMenuItem,
            this.facadeToolStripMenuItem,
            this.repositoryToolStripMenuItem,
            this.decoratorToolStripMenuItem});
            this.structuralPatternsToolStripMenuItem.Name = "structuralPatternsToolStripMenuItem";
            this.structuralPatternsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.structuralPatternsToolStripMenuItem.Text = "Structural Patterns";
            // 
            // adapterToolStripMenuItem
            // 
            this.adapterToolStripMenuItem.Name = "adapterToolStripMenuItem";
            this.adapterToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.adapterToolStripMenuItem.Text = "Adapter";
            this.adapterToolStripMenuItem.Click += new System.EventHandler(this.adapterToolStripMenuItem_Click);
            // 
            // facadeToolStripMenuItem
            // 
            this.facadeToolStripMenuItem.Name = "facadeToolStripMenuItem";
            this.facadeToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.facadeToolStripMenuItem.Text = "Facade";
            this.facadeToolStripMenuItem.Click += new System.EventHandler(this.facadeToolStripMenuItem_Click);
            // 
            // repositoryToolStripMenuItem
            // 
            this.repositoryToolStripMenuItem.Name = "repositoryToolStripMenuItem";
            this.repositoryToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.repositoryToolStripMenuItem.Text = "Repository";
            this.repositoryToolStripMenuItem.Click += new System.EventHandler(this.repositoryToolStripMenuItem_Click);
            // 
            // decoratorToolStripMenuItem
            // 
            this.decoratorToolStripMenuItem.Name = "decoratorToolStripMenuItem";
            this.decoratorToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.decoratorToolStripMenuItem.Text = "Decorator";
            this.decoratorToolStripMenuItem.Click += new System.EventHandler(this.decoratorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem creationalPatternsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleFactoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abstractFactoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singletonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem behavioralPatternsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mementoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem structuralPatternsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adapterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decoratorToolStripMenuItem;
    }
}


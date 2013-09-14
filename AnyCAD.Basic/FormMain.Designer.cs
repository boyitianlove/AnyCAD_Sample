namespace AnyCAD.Basic
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cylinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3d = new System.Windows.Forms.Panel();
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.primitiveToolStripMenuItem,
            this.featureToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTLToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // sTLToolStripMenuItem
            // 
            this.sTLToolStripMenuItem.Name = "sTLToolStripMenuItem";
            this.sTLToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sTLToolStripMenuItem.Text = "STL";
            this.sTLToolStripMenuItem.Click += new System.EventHandler(this.sTLToolStripMenuItem_Click);
            // 
            // primitiveToolStripMenuItem
            // 
            this.primitiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sphereToolStripMenuItem,
            this.boxToolStripMenuItem,
            this.cylinderToolStripMenuItem,
            this.coneToolStripMenuItem});
            this.primitiveToolStripMenuItem.Name = "primitiveToolStripMenuItem";
            this.primitiveToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.primitiveToolStripMenuItem.Text = "Primitive";
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.sphereToolStripMenuItem_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // cylinderToolStripMenuItem
            // 
            this.cylinderToolStripMenuItem.Name = "cylinderToolStripMenuItem";
            this.cylinderToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cylinderToolStripMenuItem.Text = "Cylinder";
            this.cylinderToolStripMenuItem.Click += new System.EventHandler(this.cylinderToolStripMenuItem_Click);
            // 
            // coneToolStripMenuItem
            // 
            this.coneToolStripMenuItem.Name = "coneToolStripMenuItem";
            this.coneToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.coneToolStripMenuItem.Text = "Cone";
            this.coneToolStripMenuItem.Click += new System.EventHandler(this.coneToolStripMenuItem_Click);
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrudeToolStripMenuItem,
            this.revoleToolStripMenuItem});
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // extrudeToolStripMenuItem
            // 
            this.extrudeToolStripMenuItem.Name = "extrudeToolStripMenuItem";
            this.extrudeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.extrudeToolStripMenuItem.Text = "Extrude";
            this.extrudeToolStripMenuItem.Click += new System.EventHandler(this.extrudeToolStripMenuItem_Click);
            // 
            // revoleToolStripMenuItem
            // 
            this.revoleToolStripMenuItem.Name = "revoleToolStripMenuItem";
            this.revoleToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.revoleToolStripMenuItem.Text = "Revole";
            this.revoleToolStripMenuItem.Click += new System.EventHandler(this.revoleToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // panel3d
            // 
            this.panel3d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3d.Location = new System.Drawing.Point(0, 24);
            this.panel3d.Name = "panel3d";
            this.panel3d.Size = new System.Drawing.Size(601, 429);
            this.panel3d.TabIndex = 1;
            this.panel3d.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3d_Paint);
            this.panel3d.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pane3d_MouseDown);
            this.panel3d.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pane3d_MouseMove);
            this.panel3d.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pane3d_MouseUp);
            // 
            // timerDraw
            // 
            this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 453);
            this.Controls.Add(this.panel3d);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "AnyCAD.Basic";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.Panel panel3d;
        private System.Windows.Forms.Timer timerDraw;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cylinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTLToolStripMenuItem;
    }
}


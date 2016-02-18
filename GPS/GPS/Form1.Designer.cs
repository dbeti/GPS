namespace GPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NodeCoordinateY = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CoordinateY = new System.Windows.Forms.Label();
            this.LabelCoordinateY = new System.Windows.Forms.Label();
            this.CoordinateX = new System.Windows.Forms.Label();
            this.LabelCoordinateX = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAddNode = new System.Windows.Forms.ToolStripButton();
            this.toolConnectNodes = new System.Windows.Forms.ToolStripButton();
            this.toolShowInformation = new System.Windows.Forms.ToolStripButton();
            this.NodeCoordinateX = new System.Windows.Forms.TextBox();
            this.NodeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolDefaultAction = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NodeName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NodeCoordinateY);
            this.panel1.Controls.Add(this.NodeCoordinateX);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordinate Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordinate X";
            // 
            // NodeCoordinateY
            // 
            this.NodeCoordinateY.Location = new System.Drawing.Point(87, 51);
            this.NodeCoordinateY.Name = "NodeCoordinateY";
            this.NodeCoordinateY.Size = new System.Drawing.Size(100, 20);
            this.NodeCoordinateY.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 867);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CoordinateY);
            this.panel3.Controls.Add(this.LabelCoordinateY);
            this.panel3.Controls.Add(this.CoordinateX);
            this.panel3.Controls.Add(this.LabelCoordinateX);
            this.panel3.Controls.Add(this.Label);
            this.panel3.Controls.Add(this.LabelName);
            this.panel3.Location = new System.Drawing.Point(704, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 100);
            this.panel3.TabIndex = 2;
            // 
            // CoordinateY
            // 
            this.CoordinateY.AutoSize = true;
            this.CoordinateY.Location = new System.Drawing.Point(87, 44);
            this.CoordinateY.Name = "CoordinateY";
            this.CoordinateY.Size = new System.Drawing.Size(0, 13);
            this.CoordinateY.TabIndex = 5;
            // 
            // LabelCoordinateY
            // 
            this.LabelCoordinateY.AutoSize = true;
            this.LabelCoordinateY.Location = new System.Drawing.Point(16, 44);
            this.LabelCoordinateY.Name = "LabelCoordinateY";
            this.LabelCoordinateY.Size = new System.Drawing.Size(65, 13);
            this.LabelCoordinateY.TabIndex = 4;
            this.LabelCoordinateY.Text = "CoordinateY";
            this.LabelCoordinateY.Visible = false;
            // 
            // CoordinateX
            // 
            this.CoordinateX.AutoSize = true;
            this.CoordinateX.Location = new System.Drawing.Point(87, 27);
            this.CoordinateX.Name = "CoordinateX";
            this.CoordinateX.Size = new System.Drawing.Size(0, 13);
            this.CoordinateX.TabIndex = 3;
            // 
            // LabelCoordinateX
            // 
            this.LabelCoordinateX.AutoSize = true;
            this.LabelCoordinateX.Location = new System.Drawing.Point(16, 27);
            this.LabelCoordinateX.Name = "LabelCoordinateX";
            this.LabelCoordinateX.Size = new System.Drawing.Size(65, 13);
            this.LabelCoordinateX.TabIndex = 2;
            this.LabelCoordinateX.Text = "CoordinateX";
            this.LabelCoordinateX.Visible = false;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(87, 10);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 13);
            this.Label.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(16, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name";
            this.LabelName.Visible = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(960, 1020);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(960, 1045);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDefaultAction,
            this.toolAddNode,
            this.toolConnectNodes,
            this.toolShowInformation});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolAddNode
            // 
            this.toolAddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddNode.Image = ((System.Drawing.Image)(resources.GetObject("toolAddNode.Image")));
            this.toolAddNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddNode.Name = "toolAddNode";
            this.toolAddNode.Size = new System.Drawing.Size(23, 22);
            this.toolAddNode.Text = "toolStripButton1";
            this.toolAddNode.ToolTipText = "Add node";
            // 
            // toolConnectNodes
            // 
            this.toolConnectNodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolConnectNodes.Image = ((System.Drawing.Image)(resources.GetObject("toolConnectNodes.Image")));
            this.toolConnectNodes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolConnectNodes.Name = "toolConnectNodes";
            this.toolConnectNodes.Size = new System.Drawing.Size(23, 22);
            this.toolConnectNodes.Text = "toolStripButton2";
            this.toolConnectNodes.ToolTipText = "Connect nodes";
            // 
            // toolShowInformation
            // 
            this.toolShowInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolShowInformation.Image = ((System.Drawing.Image)(resources.GetObject("toolShowInformation.Image")));
            this.toolShowInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShowInformation.Name = "toolShowInformation";
            this.toolShowInformation.Size = new System.Drawing.Size(23, 22);
            this.toolShowInformation.Text = "toolStripButton1";
            this.toolShowInformation.ToolTipText = "Show information";
            // 
            // NodeCoordinateX
            // 
            this.NodeCoordinateX.Location = new System.Drawing.Point(87, 27);
            this.NodeCoordinateX.Name = "NodeCoordinateX";
            this.NodeCoordinateX.Size = new System.Drawing.Size(100, 20);
            this.NodeCoordinateX.TabIndex = 0;
            // 
            // NodeName
            // 
            this.NodeName.Location = new System.Drawing.Point(87, 3);
            this.NodeName.Name = "NodeName";
            this.NodeName.Size = new System.Drawing.Size(100, 20);
            this.NodeName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // toolDefaultAction
            // 
            this.toolDefaultAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDefaultAction.Image = ((System.Drawing.Image)(resources.GetObject("toolDefaultAction.Image")));
            this.toolDefaultAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDefaultAction.Name = "toolDefaultAction";
            this.toolDefaultAction.Size = new System.Drawing.Size(23, 22);
            this.toolDefaultAction.Text = "Default action";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 1045);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NodeCoordinateY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CoordinateY;
        private System.Windows.Forms.Label LabelCoordinateY;
        private System.Windows.Forms.Label CoordinateX;
        private System.Windows.Forms.Label LabelCoordinateX;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAddNode;
        private System.Windows.Forms.ToolStripButton toolConnectNodes;
        private System.Windows.Forms.ToolStripButton toolShowInformation;
        private System.Windows.Forms.TextBox NodeCoordinateX;
        private System.Windows.Forms.TextBox NodeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolDefaultAction;
    }
}


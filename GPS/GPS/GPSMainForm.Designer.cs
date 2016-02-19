namespace GPS
{
    partial class GPSMainForm
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
            GPS.Models.Node node2 = new GPS.Models.Node();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPSMainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.NodeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NodeCoordinateY = new System.Windows.Forms.TextBox();
            this.NodeCoordinateX = new System.Windows.Forms.TextBox();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.pathSelectionPanel = new System.Windows.Forms.Panel();
            this.infoSplit = new System.Windows.Forms.SplitContainer();
            this.graphContainer = new GPS.GraphDisplay.PlanarGraphDrawer();
            this.graphObjectEditor = new GPS.GraphObjectEditor();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolDefaultAction = new System.Windows.Forms.ToolStripButton();
            this.toolAddNode = new System.Windows.Forms.ToolStripButton();
            this.toolConnectNodes = new System.Windows.Forms.ToolStripButton();
            this.toolShowInformation = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.pathSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSplit)).BeginInit();
            this.infoSplit.Panel1.SuspendLayout();
            this.infoSplit.Panel2.SuspendLayout();
            this.infoSplit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // NodeName
            // 
            this.NodeName.Location = new System.Drawing.Point(80, 6);
            this.NodeName.Name = "NodeName";
            this.NodeName.Size = new System.Drawing.Size(100, 20);
            this.NodeName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 80);
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
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordinate Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coordinate X";
            // 
            // NodeCoordinateY
            // 
            this.NodeCoordinateY.Location = new System.Drawing.Point(80, 54);
            this.NodeCoordinateY.Name = "NodeCoordinateY";
            this.NodeCoordinateY.Size = new System.Drawing.Size(100, 20);
            this.NodeCoordinateY.TabIndex = 1;
            // 
            // NodeCoordinateX
            // 
            this.NodeCoordinateX.Location = new System.Drawing.Point(80, 30);
            this.NodeCoordinateX.Name = "NodeCoordinateX";
            this.NodeCoordinateX.Size = new System.Drawing.Size(100, 20);
            this.NodeCoordinateX.TabIndex = 0;
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.AutoScroll = true;
            this.toolStripContainer.ContentPanel.Controls.Add(this.mainSplit);
            this.toolStripContainer.ContentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(784, 536);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(784, 561);
            this.toolStripContainer.TabIndex = 3;
            this.toolStripContainer.Text = "toolStripContainer";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // mainSplit
            // 
            this.mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplit.Location = new System.Drawing.Point(5, 5);
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.AutoScroll = true;
            this.mainSplit.Panel1.Controls.Add(this.pathSelectionPanel);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.infoSplit);
            this.mainSplit.Size = new System.Drawing.Size(774, 526);
            this.mainSplit.SplitterDistance = 200;
            this.mainSplit.TabIndex = 3;
            // 
            // pathSelectionPanel
            // 
            this.pathSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathSelectionPanel.Controls.Add(this.label3);
            this.pathSelectionPanel.Controls.Add(this.label1);
            this.pathSelectionPanel.Controls.Add(this.NodeName);
            this.pathSelectionPanel.Controls.Add(this.NodeCoordinateY);
            this.pathSelectionPanel.Controls.Add(this.button1);
            this.pathSelectionPanel.Controls.Add(this.label2);
            this.pathSelectionPanel.Controls.Add(this.NodeCoordinateX);
            this.pathSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.pathSelectionPanel.Name = "pathSelectionPanel";
            this.pathSelectionPanel.Size = new System.Drawing.Size(200, 526);
            this.pathSelectionPanel.TabIndex = 7;
            // 
            // infoSplit
            // 
            this.infoSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.infoSplit.Location = new System.Drawing.Point(0, 0);
            this.infoSplit.Name = "infoSplit";
            // 
            // infoSplit.Panel1
            // 
            this.infoSplit.Panel1.Controls.Add(this.graphContainer);
            // 
            // infoSplit.Panel2
            // 
            this.infoSplit.Panel2.Controls.Add(this.graphObjectEditor);
            this.infoSplit.Panel2Collapsed = true;
            this.infoSplit.Size = new System.Drawing.Size(570, 526);
            this.infoSplit.SplitterDistance = 386;
            this.infoSplit.TabIndex = 0;
            // 
            // graphContainer
            // 
            this.graphContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphContainer.DbContext = null;
            this.graphContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphContainer.Location = new System.Drawing.Point(0, 0);
            this.graphContainer.Name = "graphContainer";
            this.graphContainer.Size = new System.Drawing.Size(570, 526);
            this.graphContainer.TabIndex = 0;
            this.graphContainer.GraphMouseClick += new System.EventHandler<GPS.GraphDisplay.PlanarGraphDrawer.GraphMouseEventArgs>(this.graphContainer_GraphMouseClick);
            // 
            // graphObjectEditor
            // 
            this.graphObjectEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphObjectEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            node2.CoordinateX = 0;
            node2.CoordinateY = 0;
            node2.Features = null;
            node2.GraphObjectId = 0;
            node2.InArcs = null;
            node2.Name = null;
            node2.OutArcs = null;
            node2.Point = new System.Drawing.Point(0, 0);
            this.graphObjectEditor.GraphObject = node2;
            this.graphObjectEditor.Location = new System.Drawing.Point(0, 0);
            this.graphObjectEditor.Name = "graphObjectEditor";
            this.graphObjectEditor.Size = new System.Drawing.Size(96, 100);
            this.graphObjectEditor.TabIndex = 6;
            this.graphObjectEditor.GraphObjectUpdated += new System.EventHandler<GPS.GraphObjectEditor.GraphObjectEventArgs>(this.graphObjectEditor_GraphObjectUpdated);
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
            // toolDefaultAction
            // 
            this.toolDefaultAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDefaultAction.Image = ((System.Drawing.Image)(resources.GetObject("toolDefaultAction.Image")));
            this.toolDefaultAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDefaultAction.Name = "toolDefaultAction";
            this.toolDefaultAction.Size = new System.Drawing.Size(23, 22);
            this.toolDefaultAction.Text = "Default action";
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
            // GPSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStripContainer);
            this.Name = "GPSMainForm";
            this.Text = "GPS";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.pathSelectionPanel.ResumeLayout(false);
            this.pathSelectionPanel.PerformLayout();
            this.infoSplit.Panel1.ResumeLayout(false);
            this.infoSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSplit)).EndInit();
            this.infoSplit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NodeCoordinateY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAddNode;
        private System.Windows.Forms.ToolStripButton toolConnectNodes;
        private System.Windows.Forms.ToolStripButton toolShowInformation;
        private System.Windows.Forms.TextBox NodeCoordinateX;
        private System.Windows.Forms.TextBox NodeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolDefaultAction;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.SplitContainer infoSplit;
        private System.Windows.Forms.Panel pathSelectionPanel;
        private GraphObjectEditor graphObjectEditor;
        private GraphDisplay.PlanarGraphDrawer graphContainer;
    }
}


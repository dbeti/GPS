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
            GPS.Models.Node node1 = new GPS.Models.Node();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPSMainForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.pathSelectionPanel = new System.Windows.Forms.Panel();
            this.pathConstraintsEditor = new GPS.PathConstraintsEditor();
            this.infoSplit = new System.Windows.Forms.SplitContainer();
            this.graphContainer = new GPS.GraphDisplay.PlanarGraphDrawer();
            this.graphObjectEditor = new GPS.GraphObjectEditor();
            this.graphTools = new System.Windows.Forms.ToolStrip();
            this.toolShowInformation = new System.Windows.Forms.ToolStripButton();
            this.toolAddNode = new System.Windows.Forms.ToolStripButton();
            this.toolConnectNodes = new System.Windows.Forms.ToolStripButton();
            this.toolShortestPath = new System.Windows.Forms.ToolStripButton();
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
            this.graphTools.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.graphTools);
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
            this.pathSelectionPanel.Controls.Add(this.pathConstraintsEditor);
            this.pathSelectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.pathSelectionPanel.Name = "pathSelectionPanel";
            this.pathSelectionPanel.Size = new System.Drawing.Size(200, 526);
            this.pathSelectionPanel.TabIndex = 7;
            // 
            // pathConstraintsEditor
            // 
            this.pathConstraintsEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathConstraintsEditor.EndNode = null;
            this.pathConstraintsEditor.Location = new System.Drawing.Point(0, 0);
            this.pathConstraintsEditor.Name = "pathConstraintsEditor";
            this.pathConstraintsEditor.Size = new System.Drawing.Size(198, 524);
            this.pathConstraintsEditor.StartNode = null;
            this.pathConstraintsEditor.TabIndex = 0;
            this.pathConstraintsEditor.PathFound += new System.EventHandler<GPS.PathConstraintsEditor.PathFoundEvenArgs>(this.pathConstraintsEditor_PathFound);
            this.pathConstraintsEditor.Closed += new System.EventHandler(this.pathConstraintsEditor_Closed);
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
            this.infoSplit.Size = new System.Drawing.Size(570, 526);
            this.infoSplit.SplitterDistance = 382;
            this.infoSplit.TabIndex = 0;
            // 
            // graphContainer
            // 
            this.graphContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphContainer.Location = new System.Drawing.Point(0, 0);
            this.graphContainer.Name = "graphContainer";
            this.graphContainer.Size = new System.Drawing.Size(382, 526);
            this.graphContainer.TabIndex = 0;
            this.graphContainer.GraphMouseClick += new System.EventHandler<GPS.GraphDisplay.GraphMouseEventArgs>(this.graphContainer_GraphMouseClick);
            // 
            // graphObjectEditor
            // 
            this.graphObjectEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphObjectEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            node1.CoordinateX = 0;
            node1.CoordinateY = 0;
            node1.Features = null;
            node1.GraphObjectId = 0;
            node1.InArcs = null;
            node1.Name = null;
            node1.OutArcs = null;
            node1.Point = new System.Drawing.Point(0, 0);
            this.graphObjectEditor.GraphObject = node1;
            this.graphObjectEditor.Location = new System.Drawing.Point(0, 0);
            this.graphObjectEditor.Name = "graphObjectEditor";
            this.graphObjectEditor.Size = new System.Drawing.Size(184, 526);
            this.graphObjectEditor.TabIndex = 6;
            this.graphObjectEditor.GraphObjectUpdated += new System.EventHandler<GPS.GraphObjectEditor.GraphObjectEventArgs>(this.graphObjectEditor_GraphObjectUpdated);
            // 
            // graphTools
            // 
            this.graphTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphTools.Dock = System.Windows.Forms.DockStyle.None;
            this.graphTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShowInformation,
            this.toolAddNode,
            this.toolConnectNodes,
            this.toolShortestPath});
            this.graphTools.Location = new System.Drawing.Point(3, 0);
            this.graphTools.Name = "graphTools";
            this.graphTools.Size = new System.Drawing.Size(104, 25);
            this.graphTools.TabIndex = 0;
            // 
            // toolShowInformation
            // 
            this.toolShowInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolShowInformation.Image = ((System.Drawing.Image)(resources.GetObject("toolShowInformation.Image")));
            this.toolShowInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShowInformation.Name = "toolShowInformation";
            this.toolShowInformation.Size = new System.Drawing.Size(23, 22);
            this.toolShowInformation.Tag = "";
            this.toolShowInformation.Text = "toolStripButton1";
            this.toolShowInformation.ToolTipText = "Show information";
            this.toolShowInformation.Click += new System.EventHandler(this.toolAction_Click);
            // 
            // toolAddNode
            // 
            this.toolAddNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddNode.Image = ((System.Drawing.Image)(resources.GetObject("toolAddNode.Image")));
            this.toolAddNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddNode.Name = "toolAddNode";
            this.toolAddNode.Size = new System.Drawing.Size(23, 22);
            this.toolAddNode.Tag = "";
            this.toolAddNode.Text = "toolStripButton1";
            this.toolAddNode.ToolTipText = "Add node";
            this.toolAddNode.Click += new System.EventHandler(this.toolAction_Click);
            // 
            // toolConnectNodes
            // 
            this.toolConnectNodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolConnectNodes.Image = ((System.Drawing.Image)(resources.GetObject("toolConnectNodes.Image")));
            this.toolConnectNodes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolConnectNodes.Name = "toolConnectNodes";
            this.toolConnectNodes.Size = new System.Drawing.Size(23, 22);
            this.toolConnectNodes.Tag = "";
            this.toolConnectNodes.Text = "toolStripButton2";
            this.toolConnectNodes.ToolTipText = "Connect nodes";
            this.toolConnectNodes.Click += new System.EventHandler(this.toolAction_Click);
            // 
            // toolShortestPath
            // 
            this.toolShortestPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolShortestPath.Image = ((System.Drawing.Image)(resources.GetObject("toolShortestPath.Image")));
            this.toolShortestPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolShortestPath.Name = "toolShortestPath";
            this.toolShortestPath.Size = new System.Drawing.Size(23, 22);
            this.toolShortestPath.Text = "toolStripButton1";
            this.toolShortestPath.ToolTipText = "Calculate shortest path";
            this.toolShortestPath.Click += new System.EventHandler(this.toolAction_Click);
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
            this.infoSplit.Panel1.ResumeLayout(false);
            this.infoSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSplit)).EndInit();
            this.infoSplit.ResumeLayout(false);
            this.graphTools.ResumeLayout(false);
            this.graphTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip graphTools;
        private System.Windows.Forms.ToolStripButton toolAddNode;
        private System.Windows.Forms.ToolStripButton toolConnectNodes;
        private System.Windows.Forms.ToolStripButton toolShowInformation;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.SplitContainer infoSplit;
        private System.Windows.Forms.Panel pathSelectionPanel;
        private GraphObjectEditor graphObjectEditor;
        private GraphDisplay.PlanarGraphDrawer graphContainer;
        private System.Windows.Forms.ToolStripButton toolShortestPath;
        private PathConstraintsEditor pathConstraintsEditor;
    }
}


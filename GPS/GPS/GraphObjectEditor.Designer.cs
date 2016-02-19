namespace GPS
{
    partial class GraphObjectEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.coordSelectorX = new System.Windows.Forms.NumericUpDown();
            this.coordSelectorY = new System.Windows.Forms.NumericUpDown();
            this.editButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nodePanel = new System.Windows.Forms.Panel();
            this.arcPanel = new System.Windows.Forms.Panel();
            this.directedBox = new System.Windows.Forms.CheckBox();
            this.endNodeBox = new System.Windows.Forms.TextBox();
            this.startNodeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.featureView = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeFeatureButton = new System.Windows.Forms.Button();
            this.addFeatureButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.featureNameBox = new System.Windows.Forms.TextBox();
            this.featureTypeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coordSelectorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordSelectorY)).BeginInit();
            this.panel1.SuspendLayout();
            this.nodePanel.SuspendLayout();
            this.arcPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(80, 10);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(80, 20);
            this.nameBox.TabIndex = 3;
            // 
            // idBox
            // 
            this.idBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idBox.Location = new System.Drawing.Point(80, 40);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(80, 20);
            this.idBox.TabIndex = 4;
            // 
            // coordSelectorX
            // 
            this.coordSelectorX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coordSelectorX.Location = new System.Drawing.Point(80, 5);
            this.coordSelectorX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.coordSelectorX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.coordSelectorX.Name = "coordSelectorX";
            this.coordSelectorX.ReadOnly = true;
            this.coordSelectorX.Size = new System.Drawing.Size(80, 20);
            this.coordSelectorX.TabIndex = 5;
            // 
            // coordSelectorY
            // 
            this.coordSelectorY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coordSelectorY.Location = new System.Drawing.Point(80, 35);
            this.coordSelectorY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.coordSelectorY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.coordSelectorY.Name = "coordSelectorY";
            this.coordSelectorY.ReadOnly = true;
            this.coordSelectorY.Size = new System.Drawing.Size(80, 20);
            this.coordSelectorY.TabIndex = 6;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(90, 10);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(70, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 40);
            this.panel1.TabIndex = 8;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(10, 10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(90, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(10, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nodePanel
            // 
            this.nodePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodePanel.Controls.Add(this.label3);
            this.nodePanel.Controls.Add(this.coordSelectorX);
            this.nodePanel.Controls.Add(this.coordSelectorY);
            this.nodePanel.Location = new System.Drawing.Point(0, 65);
            this.nodePanel.Margin = new System.Windows.Forms.Padding(0);
            this.nodePanel.Name = "nodePanel";
            this.nodePanel.Size = new System.Drawing.Size(170, 95);
            this.nodePanel.TabIndex = 9;
            this.nodePanel.Visible = false;
            // 
            // arcPanel
            // 
            this.arcPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.arcPanel.Controls.Add(this.directedBox);
            this.arcPanel.Controls.Add(this.endNodeBox);
            this.arcPanel.Controls.Add(this.startNodeBox);
            this.arcPanel.Controls.Add(this.label5);
            this.arcPanel.Controls.Add(this.label4);
            this.arcPanel.Location = new System.Drawing.Point(0, 65);
            this.arcPanel.Name = "arcPanel";
            this.arcPanel.Size = new System.Drawing.Size(170, 95);
            this.arcPanel.TabIndex = 7;
            this.arcPanel.Visible = false;
            // 
            // directedBox
            // 
            this.directedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directedBox.AutoCheck = false;
            this.directedBox.Location = new System.Drawing.Point(80, 65);
            this.directedBox.Name = "directedBox";
            this.directedBox.Size = new System.Drawing.Size(80, 20);
            this.directedBox.TabIndex = 5;
            this.directedBox.Text = "Directed";
            this.directedBox.UseVisualStyleBackColor = true;
            // 
            // endNodeBox
            // 
            this.endNodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endNodeBox.Location = new System.Drawing.Point(80, 35);
            this.endNodeBox.Name = "endNodeBox";
            this.endNodeBox.ReadOnly = true;
            this.endNodeBox.Size = new System.Drawing.Size(80, 20);
            this.endNodeBox.TabIndex = 4;
            // 
            // startNodeBox
            // 
            this.startNodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startNodeBox.Location = new System.Drawing.Point(80, 5);
            this.startNodeBox.Name = "startNodeBox";
            this.startNodeBox.ReadOnly = true;
            this.startNodeBox.Size = new System.Drawing.Size(80, 20);
            this.startNodeBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "End node";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start node";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(178, 300);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.arcPanel);
            this.tabPage1.Controls.Add(this.idBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nodePanel);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(170, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.featureView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(170, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Features";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // featureView
            // 
            this.featureView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.featureView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.featureView.FullRowSelect = true;
            this.featureView.Location = new System.Drawing.Point(0, 0);
            this.featureView.Name = "featureView";
            this.featureView.Size = new System.Drawing.Size(170, 144);
            this.featureView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.featureView.TabIndex = 0;
            this.featureView.UseCompatibleStateImageBehavior = false;
            this.featureView.View = System.Windows.Forms.View.Details;
            this.featureView.SelectedIndexChanged += new System.EventHandler(this.featureView_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.featureTypeBox);
            this.panel2.Controls.Add(this.featureNameBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addFeatureButton);
            this.panel2.Controls.Add(this.removeFeatureButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 130);
            this.panel2.TabIndex = 1;
            // 
            // removeFeatureButton
            // 
            this.removeFeatureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeFeatureButton.Enabled = false;
            this.removeFeatureButton.Location = new System.Drawing.Point(90, 100);
            this.removeFeatureButton.Name = "removeFeatureButton";
            this.removeFeatureButton.Size = new System.Drawing.Size(70, 23);
            this.removeFeatureButton.TabIndex = 0;
            this.removeFeatureButton.Text = "Remove";
            this.removeFeatureButton.UseVisualStyleBackColor = true;
            this.removeFeatureButton.Click += new System.EventHandler(this.removeFeatureButton_Click);
            // 
            // addFeatureButton
            // 
            this.addFeatureButton.Location = new System.Drawing.Point(10, 100);
            this.addFeatureButton.Name = "addFeatureButton";
            this.addFeatureButton.Size = new System.Drawing.Size(70, 23);
            this.addFeatureButton.TabIndex = 1;
            this.addFeatureButton.Text = "Add";
            this.addFeatureButton.UseVisualStyleBackColor = true;
            this.addFeatureButton.Click += new System.EventHandler(this.addFeatureButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // featureNameBox
            // 
            this.featureNameBox.Location = new System.Drawing.Point(80, 40);
            this.featureNameBox.Name = "featureNameBox";
            this.featureNameBox.Size = new System.Drawing.Size(80, 20);
            this.featureNameBox.TabIndex = 4;
            // 
            // featureTypeBox
            // 
            this.featureTypeBox.Location = new System.Drawing.Point(80, 70);
            this.featureTypeBox.Name = "featureTypeBox";
            this.featureTypeBox.Size = new System.Drawing.Size(80, 20);
            this.featureTypeBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "New Feature";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GraphObjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "GraphObjectEditor";
            this.Size = new System.Drawing.Size(178, 300);
            ((System.ComponentModel.ISupportInitialize)(this.coordSelectorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordSelectorY)).EndInit();
            this.panel1.ResumeLayout(false);
            this.nodePanel.ResumeLayout(false);
            this.arcPanel.ResumeLayout(false);
            this.arcPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.NumericUpDown coordSelectorX;
        private System.Windows.Forms.NumericUpDown coordSelectorY;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel nodePanel;
        private System.Windows.Forms.Panel arcPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox directedBox;
        private System.Windows.Forms.TextBox endNodeBox;
        private System.Windows.Forms.TextBox startNodeBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView featureView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addFeatureButton;
        private System.Windows.Forms.Button removeFeatureButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox featureNameBox;
        private System.Windows.Forms.TextBox featureTypeBox;
        private System.Windows.Forms.Label label8;
    }
}

namespace GPS
{
    partial class ArcDialog
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
            this.labelArcName = new System.Windows.Forms.Label();
            this.labelStartNode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFeature = new System.Windows.Forms.Label();
            this.comboBoxFeature = new System.Windows.Forms.ComboBox();
            this.labelStartNodeValue = new System.Windows.Forms.Label();
            this.labelEndNodeValue = new System.Windows.Forms.Label();
            this.textBoxArcName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelArcName
            // 
            this.labelArcName.AutoSize = true;
            this.labelArcName.Location = new System.Drawing.Point(12, 13);
            this.labelArcName.Name = "labelArcName";
            this.labelArcName.Size = new System.Drawing.Size(54, 13);
            this.labelArcName.TabIndex = 0;
            this.labelArcName.Text = "Arc Name";
            // 
            // labelStartNode
            // 
            this.labelStartNode.AutoSize = true;
            this.labelStartNode.Location = new System.Drawing.Point(12, 37);
            this.labelStartNode.Name = "labelStartNode";
            this.labelStartNode.Size = new System.Drawing.Size(58, 13);
            this.labelStartNode.TabIndex = 1;
            this.labelStartNode.Text = "Start Node";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Node";
            // 
            // labelFeature
            // 
            this.labelFeature.AutoSize = true;
            this.labelFeature.Location = new System.Drawing.Point(12, 84);
            this.labelFeature.Name = "labelFeature";
            this.labelFeature.Size = new System.Drawing.Size(43, 13);
            this.labelFeature.TabIndex = 3;
            this.labelFeature.Text = "Feature";
            // 
            // comboBoxFeature
            // 
            this.comboBoxFeature.FormattingEnabled = true;
            this.comboBoxFeature.Location = new System.Drawing.Point(151, 81);
            this.comboBoxFeature.Name = "comboBoxFeature";
            this.comboBoxFeature.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFeature.TabIndex = 4;
            // 
            // labelStartNodeValue
            // 
            this.labelStartNodeValue.AutoSize = true;
            this.labelStartNodeValue.Location = new System.Drawing.Point(169, 37);
            this.labelStartNodeValue.Name = "labelStartNodeValue";
            this.labelStartNodeValue.Size = new System.Drawing.Size(0, 13);
            this.labelStartNodeValue.TabIndex = 5;
            // 
            // labelEndNodeValue
            // 
            this.labelEndNodeValue.AutoSize = true;
            this.labelEndNodeValue.Location = new System.Drawing.Point(169, 60);
            this.labelEndNodeValue.Name = "labelEndNodeValue";
            this.labelEndNodeValue.Size = new System.Drawing.Size(0, 13);
            this.labelEndNodeValue.TabIndex = 6;
            // 
            // textBoxArcName
            // 
            this.textBoxArcName.Location = new System.Drawing.Point(172, 10);
            this.textBoxArcName.Name = "textBoxArcName";
            this.textBoxArcName.Size = new System.Drawing.Size(100, 20);
            this.textBoxArcName.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(196, 109);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // ArcDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxArcName);
            this.Controls.Add(this.labelEndNodeValue);
            this.Controls.Add(this.labelStartNodeValue);
            this.Controls.Add(this.comboBoxFeature);
            this.Controls.Add(this.labelFeature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelStartNode);
            this.Controls.Add(this.labelArcName);
            this.Name = "ArcDialog";
            this.Text = "ArcDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelArcName;
        private System.Windows.Forms.Label labelStartNode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFeature;
        private System.Windows.Forms.ComboBox comboBoxFeature;
        private System.Windows.Forms.Label labelStartNodeValue;
        private System.Windows.Forms.Label labelEndNodeValue;
        private System.Windows.Forms.TextBox textBoxArcName;
        private System.Windows.Forms.Button buttonAdd;
    }
}
namespace GPS
{
    partial class NodeDialog
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
            this.NodeName = new System.Windows.Forms.Label();
            this.CoordinateX = new System.Windows.Forms.Label();
            this.CoordinateY = new System.Windows.Forms.Label();
            this.Feature = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCoordinateX = new System.Windows.Forms.TextBox();
            this.textBoxCoordinateY = new System.Windows.Forms.TextBox();
            this.comboBoxFeature = new System.Windows.Forms.ComboBox();
            this.featureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.featureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NodeName
            // 
            this.NodeName.AutoSize = true;
            this.NodeName.Location = new System.Drawing.Point(13, 18);
            this.NodeName.Name = "NodeName";
            this.NodeName.Size = new System.Drawing.Size(35, 13);
            this.NodeName.TabIndex = 0;
            this.NodeName.Text = "Name";
            // 
            // CoordinateX
            // 
            this.CoordinateX.AutoSize = true;
            this.CoordinateX.Location = new System.Drawing.Point(13, 44);
            this.CoordinateX.Name = "CoordinateX";
            this.CoordinateX.Size = new System.Drawing.Size(65, 13);
            this.CoordinateX.TabIndex = 1;
            this.CoordinateX.Text = "CoordinateX";
            // 
            // CoordinateY
            // 
            this.CoordinateY.AutoSize = true;
            this.CoordinateY.Location = new System.Drawing.Point(13, 70);
            this.CoordinateY.Name = "CoordinateY";
            this.CoordinateY.Size = new System.Drawing.Size(65, 13);
            this.CoordinateY.TabIndex = 2;
            this.CoordinateY.Text = "CoordinateY";
            // 
            // Feature
            // 
            this.Feature.AutoSize = true;
            this.Feature.Location = new System.Drawing.Point(13, 96);
            this.Feature.Name = "Feature";
            this.Feature.Size = new System.Drawing.Size(43, 13);
            this.Feature.TabIndex = 3;
            this.Feature.Text = "Feature";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(148, 15);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxCoordinateX
            // 
            this.textBoxCoordinateX.Location = new System.Drawing.Point(148, 41);
            this.textBoxCoordinateX.Name = "textBoxCoordinateX";
            this.textBoxCoordinateX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordinateX.TabIndex = 5;
            // 
            // textBoxCoordinateY
            // 
            this.textBoxCoordinateY.Location = new System.Drawing.Point(148, 67);
            this.textBoxCoordinateY.Name = "textBoxCoordinateY";
            this.textBoxCoordinateY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordinateY.TabIndex = 6;
            // 
            // comboBoxFeature
            // 
            this.comboBoxFeature.DataSource = this.featureBindingSource;
            this.comboBoxFeature.FormattingEnabled = true;
            this.comboBoxFeature.Location = new System.Drawing.Point(127, 94);
            this.comboBoxFeature.Name = "comboBoxFeature";
            this.comboBoxFeature.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFeature.TabIndex = 7;
            // 
            // featureBindingSource
            // 
            this.featureBindingSource.DataSource = typeof(global::GPS.Models.Feature);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(172, 122);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // NodeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxFeature);
            this.Controls.Add(this.textBoxCoordinateY);
            this.Controls.Add(this.textBoxCoordinateX);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Feature);
            this.Controls.Add(this.CoordinateY);
            this.Controls.Add(this.CoordinateX);
            this.Controls.Add(this.NodeName);
            this.Name = "NodeDialog";
            this.Text = "NodeDialog";
            ((System.ComponentModel.ISupportInitialize)(this.featureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NodeName;
        private System.Windows.Forms.Label CoordinateX;
        private System.Windows.Forms.Label CoordinateY;
        private System.Windows.Forms.Label Feature;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCoordinateX;
        private System.Windows.Forms.TextBox textBoxCoordinateY;
        private System.Windows.Forms.ComboBox comboBoxFeature;
        private System.Windows.Forms.BindingSource featureBindingSource;
        private System.Windows.Forms.Button buttonAdd;
    }
}
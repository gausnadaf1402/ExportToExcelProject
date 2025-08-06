namespace ExportToExcelProject
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
            this.panelgradeview = new System.Windows.Forms.Panel();
            this.btnexport = new System.Windows.Forms.Button();
            this.lblgrades = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnhide = new System.Windows.Forms.Button();
            this.panelgradeview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelgradeview
            // 
            this.panelgradeview.Controls.Add(this.btnhide);
            this.panelgradeview.Controls.Add(this.btnshow);
            this.panelgradeview.Controls.Add(this.btnexport);
            this.panelgradeview.Controls.Add(this.lblgrades);
            this.panelgradeview.Controls.Add(this.dataGridView1);
            this.panelgradeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgradeview.Location = new System.Drawing.Point(0, 0);
            this.panelgradeview.Name = "panelgradeview";
            this.panelgradeview.Size = new System.Drawing.Size(800, 450);
            this.panelgradeview.TabIndex = 0;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnexport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Location = new System.Drawing.Point(602, 400);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(157, 38);
            this.btnexport.TabIndex = 4;
            this.btnexport.Text = "Export to Excel";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // lblgrades
            // 
            this.lblgrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblgrades.AutoSize = true;
            this.lblgrades.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrades.Location = new System.Drawing.Point(348, 9);
            this.lblgrades.Name = "lblgrades";
            this.lblgrades.Size = new System.Drawing.Size(95, 27);
            this.lblgrades.TabIndex = 1;
            this.lblgrades.Text = "GRADES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(43, 400);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(124, 38);
            this.btnshow.TabIndex = 5;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnhide
            // 
            this.btnhide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnhide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhide.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhide.Location = new System.Drawing.Point(173, 400);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(124, 38);
            this.btnhide.TabIndex = 6;
            this.btnhide.Text = "Hide";
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelgradeview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelgradeview.ResumeLayout(false);
            this.panelgradeview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelgradeview;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblgrades;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnhide;
    }
}


namespace DataOperation
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
            this.btnCreateColumn = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnDeleteColumn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateColumn
            // 
            this.btnCreateColumn.Location = new System.Drawing.Point(191, 139);
            this.btnCreateColumn.Name = "btnCreateColumn";
            this.btnCreateColumn.Size = new System.Drawing.Size(75, 31);
            this.btnCreateColumn.TabIndex = 16;
            this.btnCreateColumn.Text = "Create";
            this.btnCreateColumn.UseVisualStyleBackColor = true;
            this.btnCreateColumn.Click += new System.EventHandler(this.btnCreateColumn_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(110, 53);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteTable.TabIndex = 15;
            this.btnDeleteTable.Text = "TDelete";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnDeleteColumn
            // 
            this.btnDeleteColumn.Location = new System.Drawing.Point(110, 139);
            this.btnDeleteColumn.Name = "btnDeleteColumn";
            this.btnDeleteColumn.Size = new System.Drawing.Size(75, 31);
            this.btnDeleteColumn.TabIndex = 14;
            this.btnDeleteColumn.Text = "CDelete";
            this.btnDeleteColumn.UseVisualStyleBackColor = true;
            this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "CName:";
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(83, 21);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(183, 26);
            this.txtTName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "TName:";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(83, 107);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(183, 26);
            this.txtCName.TabIndex = 10;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(191, 53);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(75, 31);
            this.btnCreateTable.TabIndex = 9;
            this.btnCreateTable.Text = "Create";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 181);
            this.Controls.Add(this.btnCreateColumn);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.btnDeleteColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.btnCreateTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateColumn;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnDeleteColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Button btnCreateTable;
    }
}


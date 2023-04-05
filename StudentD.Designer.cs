namespace CoonectedDemo
{
    partial class StudentD
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
            this.btnShowAllProducts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStudentPercentage = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentRollno = new System.Windows.Forms.TextBox();
            this.lblStudentPercentage = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentRollno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllProducts
            // 
            this.btnShowAllProducts.Location = new System.Drawing.Point(476, 390);
            this.btnShowAllProducts.Name = "btnShowAllProducts";
            this.btnShowAllProducts.Size = new System.Drawing.Size(169, 23);
            this.btnShowAllProducts.TabIndex = 63;
            this.btnShowAllProducts.Text = "Show All Students";
            this.btnShowAllProducts.UseVisualStyleBackColor = true;
            this.btnShowAllProducts.Click += new System.EventHandler(this.btnShowAllProducts_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 242);
            this.dataGridView1.TabIndex = 62;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(354, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(172, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(45, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentPercentage
            // 
            this.txtStudentPercentage.Location = new System.Drawing.Point(164, 141);
            this.txtStudentPercentage.Name = "txtStudentPercentage";
            this.txtStudentPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtStudentPercentage.TabIndex = 57;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(164, 89);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 56;
            // 
            // txtStudentRollno
            // 
            this.txtStudentRollno.Location = new System.Drawing.Point(164, 39);
            this.txtStudentRollno.Name = "txtStudentRollno";
            this.txtStudentRollno.Size = new System.Drawing.Size(100, 22);
            this.txtStudentRollno.TabIndex = 55;
            // 
            // lblStudentPercentage
            // 
            this.lblStudentPercentage.AutoSize = true;
            this.lblStudentPercentage.Location = new System.Drawing.Point(42, 144);
            this.lblStudentPercentage.Name = "lblStudentPercentage";
            this.lblStudentPercentage.Size = new System.Drawing.Size(125, 16);
            this.lblStudentPercentage.TabIndex = 54;
            this.lblStudentPercentage.Text = "Student Percentage";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(42, 92);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(92, 16);
            this.lblStudentName.TabIndex = 53;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblStudentRollno
            // 
            this.lblStudentRollno.AutoSize = true;
            this.lblStudentRollno.Location = new System.Drawing.Point(42, 42);
            this.lblStudentRollno.Name = "lblStudentRollno";
            this.lblStudentRollno.Size = new System.Drawing.Size(94, 16);
            this.lblStudentRollno.TabIndex = 52;
            this.lblStudentRollno.Text = "Student Rollno";
            // 
            // StudentD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowAllProducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStudentPercentage);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentRollno);
            this.Controls.Add(this.lblStudentPercentage);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentRollno);
            this.Name = "StudentD";
            this.Text = "StudentD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStudentPercentage;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentRollno;
        private System.Windows.Forms.Label lblStudentPercentage;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentRollno;
    }
}
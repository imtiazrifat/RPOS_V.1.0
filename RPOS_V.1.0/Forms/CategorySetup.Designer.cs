namespace RPOS_V._1._0.Forms
{
    partial class CategorySetup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCatagory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatagoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatagoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatagoyDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGridEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxCatagoryDetails = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxIsActive = new System.Windows.Forms.CheckBox();
            this.textBoxCatogoryCode = new System.Windows.Forms.TextBox();
            this.textBoxCatagoryName = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblPaging = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatagory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 495);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPaging);
            this.groupBox2.Controls.Add(this.btnPrevious);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.dataGridViewCatagory);
            this.groupBox2.Location = new System.Drawing.Point(3, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 263);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CategorySetup Summery";
            // 
            // dataGridViewCatagory
            // 
            this.dataGridViewCatagory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatagory.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewCatagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatagory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CatagoryCode,
            this.CatagoryName,
            this.CatagoyDetails,
            this.IsActive,
            this.btnGridEdit});
            this.dataGridViewCatagory.Location = new System.Drawing.Point(1, 20);
            this.dataGridViewCatagory.Name = "dataGridViewCatagory";
            this.dataGridViewCatagory.Size = new System.Drawing.Size(685, 213);
            this.dataGridViewCatagory.TabIndex = 0;
            this.dataGridViewCatagory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCatagory_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CatagoryId";
            this.Column1.HeaderText = "CatagoryId";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // CatagoryCode
            // 
            this.CatagoryCode.DataPropertyName = "Code";
            this.CatagoryCode.FillWeight = 60F;
            this.CatagoryCode.HeaderText = "Code";
            this.CatagoryCode.Name = "CatagoryCode";
            // 
            // CatagoryName
            // 
            this.CatagoryName.DataPropertyName = "Name";
            this.CatagoryName.FillWeight = 80F;
            this.CatagoryName.HeaderText = "Name";
            this.CatagoryName.Name = "CatagoryName";
            // 
            // CatagoyDetails
            // 
            this.CatagoyDetails.DataPropertyName = "Details";
            this.CatagoyDetails.FillWeight = 120F;
            this.CatagoyDetails.HeaderText = "Details";
            this.CatagoyDetails.Name = "CatagoyDetails";
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "Status";
            this.IsActive.FillWeight = 50F;
            this.IsActive.HeaderText = "Status";
            this.IsActive.Name = "IsActive";
            // 
            // btnGridEdit
            // 
            this.btnGridEdit.FillWeight = 50F;
            this.btnGridEdit.HeaderText = "Action";
            this.btnGridEdit.MinimumWidth = 3;
            this.btnGridEdit.Name = "btnGridEdit";
            this.btnGridEdit.Text = "Edit";
            this.btnGridEdit.ToolTipText = "Edit";
            this.btnGridEdit.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxCatagoryDetails);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxIsActive);
            this.groupBox1.Controls.Add(this.textBoxCatogoryCode);
            this.groupBox1.Controls.Add(this.textBoxCatagoryName);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update CategorySetup";
            // 
            // richTextBoxCatagoryDetails
            // 
            this.richTextBoxCatagoryDetails.Location = new System.Drawing.Point(268, 68);
            this.richTextBoxCatagoryDetails.Name = "richTextBoxCatagoryDetails";
            this.richTextBoxCatagoryDetails.Size = new System.Drawing.Size(139, 41);
            this.richTextBoxCatagoryDetails.TabIndex = 5;
            this.richTextBoxCatagoryDetails.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(324, 152);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Code";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(233, 152);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Active";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Details";
            // 
            // checkBoxIsActive
            // 
            this.checkBoxIsActive.AutoSize = true;
            this.checkBoxIsActive.Location = new System.Drawing.Point(268, 120);
            this.checkBoxIsActive.Name = "checkBoxIsActive";
            this.checkBoxIsActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsActive.TabIndex = 6;
            this.checkBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // textBoxCatogoryCode
            // 
            this.textBoxCatogoryCode.Location = new System.Drawing.Point(268, 10);
            this.textBoxCatogoryCode.Name = "textBoxCatogoryCode";
            this.textBoxCatogoryCode.Size = new System.Drawing.Size(139, 20);
            this.textBoxCatogoryCode.TabIndex = 3;
            // 
            // textBoxCatagoryName
            // 
            this.textBoxCatagoryName.Location = new System.Drawing.Point(268, 37);
            this.textBoxCatagoryName.Name = "textBoxCatagoryName";
            this.textBoxCatagoryName.Size = new System.Drawing.Size(139, 20);
            this.textBoxCatagoryName.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(646, 236);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(482, 236);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(41, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblPaging
            // 
            this.lblPaging.AutoSize = true;
            this.lblPaging.Location = new System.Drawing.Point(527, 240);
            this.lblPaging.Name = "lblPaging";
            this.lblPaging.Size = new System.Drawing.Size(0, 13);
            this.lblPaging.TabIndex = 4;
            // 
            // CategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 520);
            this.Controls.Add(this.panel1);
            this.Name = "CategorySetup";
            this.Text = "CategorySetup";
            this.Load += new System.EventHandler(this.Catagory_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatagory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCatagoryName;
        private System.Windows.Forms.TextBox textBoxCatogoryCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxCatagoryDetails;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxIsActive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCatagory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatagoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatagoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatagoyDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewButtonColumn btnGridEdit;
        private System.Windows.Forms.Label lblPaging;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}
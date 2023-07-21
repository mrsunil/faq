namespace FAQ
{
    partial class frmFaqSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPrblmStmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ccbRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbModule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ccbEnv = new System.Windows.Forms.ComboBox();
            this.ccbPrblmType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.moduleReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.roleReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.problmStmtReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problmStmtReq)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ccbPrblmType);
            this.groupBox1.Controls.Add(this.ccbEnv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPrblmStmt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ccbRole);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ccbModule);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1329, 180);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(1109, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 29);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPrblmStmt
            // 
            this.txtPrblmStmt.Location = new System.Drawing.Point(210, 118);
            this.txtPrblmStmt.Multiline = true;
            this.txtPrblmStmt.Name = "txtPrblmStmt";
            this.txtPrblmStmt.Size = new System.Drawing.Size(876, 45);
            this.txtPrblmStmt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Problem Statement";
            // 
            // ccbRole
            // 
            this.ccbRole.FormattingEnabled = true;
            this.ccbRole.Location = new System.Drawing.Point(837, 25);
            this.ccbRole.Name = "ccbRole";
            this.ccbRole.Size = new System.Drawing.Size(249, 24);
            this.ccbRole.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Module";
            // 
            // ccbModule
            // 
            this.ccbModule.FormattingEnabled = true;
            this.ccbModule.Location = new System.Drawing.Point(210, 21);
            this.ccbModule.Name = "ccbModule";
            this.ccbModule.Size = new System.Drawing.Size(249, 24);
            this.ccbModule.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "User Role";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1326, 567);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1313, 528);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Envirnoment";
            // 
            // ccbEnv
            // 
            this.ccbEnv.FormattingEnabled = true;
            this.ccbEnv.Location = new System.Drawing.Point(210, 73);
            this.ccbEnv.Name = "ccbEnv";
            this.ccbEnv.Size = new System.Drawing.Size(249, 24);
            this.ccbEnv.TabIndex = 24;
            // 
            // ccbPrblmType
            // 
            this.ccbPrblmType.FormattingEnabled = true;
            this.ccbPrblmType.Location = new System.Drawing.Point(837, 73);
            this.ccbPrblmType.Name = "ccbPrblmType";
            this.ccbPrblmType.Size = new System.Drawing.Size(249, 24);
            this.ccbPrblmType.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Problem Type";
            // 
            // moduleReq
            // 
            this.moduleReq.ContainerControl = this;
            // 
            // roleReq
            // 
            this.roleReq.ContainerControl = this;
            // 
            // problmStmtReq
            // 
            this.problmStmtReq.ContainerControl = this;
            // 
            // frmFaqSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFaqSearch";
            this.Text = "frmFaqSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problmStmtReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ccbRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPrblmStmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ccbPrblmType;
        private System.Windows.Forms.ComboBox ccbEnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider moduleReq;
        private System.Windows.Forms.ErrorProvider roleReq;
        private System.Windows.Forms.ErrorProvider problmStmtReq;
    }
}
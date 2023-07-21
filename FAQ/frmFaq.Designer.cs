namespace FAQ
{
    partial class frmFaq
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSol = new System.Windows.Forms.RichTextBox();
            this.txtprblmStmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ccbProblmType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ccbEnv = new System.Windows.Forms.ComboBox();
            this.Envirnoment = new System.Windows.Forms.Label();
            this.ccbUserRole = new System.Windows.Forms.ComboBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.ccbModule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.moduleReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.userRoleReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.prblmStmtReq = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prblmStmtReq)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(1033, 496);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 29);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Location = new System.Drawing.Point(1172, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 29);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Solution";
            // 
            // txtSol
            // 
            this.txtSol.Location = new System.Drawing.Point(193, 110);
            this.txtSol.Name = "txtSol";
            this.txtSol.Size = new System.Drawing.Size(1109, 369);
            this.txtSol.TabIndex = 14;
            this.txtSol.Text = "";
            // 
            // txtprblmStmt
            // 
            this.txtprblmStmt.Location = new System.Drawing.Point(193, 14);
            this.txtprblmStmt.Multiline = true;
            this.txtprblmStmt.Name = "txtprblmStmt";
            this.txtprblmStmt.Size = new System.Drawing.Size(1109, 74);
            this.txtprblmStmt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Problem Statement";
            // 
            // ccbProblmType
            // 
            this.ccbProblmType.FormattingEnabled = true;
            this.ccbProblmType.Location = new System.Drawing.Point(772, 66);
            this.ccbProblmType.Name = "ccbProblmType";
            this.ccbProblmType.Size = new System.Drawing.Size(249, 24);
            this.ccbProblmType.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Problem Type";
            // 
            // ccbEnv
            // 
            this.ccbEnv.FormattingEnabled = true;
            this.ccbEnv.Location = new System.Drawing.Point(193, 66);
            this.ccbEnv.Name = "ccbEnv";
            this.ccbEnv.Size = new System.Drawing.Size(249, 24);
            this.ccbEnv.TabIndex = 21;
            // 
            // Envirnoment
            // 
            this.Envirnoment.AutoSize = true;
            this.Envirnoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Envirnoment.Location = new System.Drawing.Point(73, 66);
            this.Envirnoment.Name = "Envirnoment";
            this.Envirnoment.Size = new System.Drawing.Size(102, 20);
            this.Envirnoment.TabIndex = 20;
            this.Envirnoment.Text = "Envirnoment";
            // 
            // ccbUserRole
            // 
            this.ccbUserRole.FormattingEnabled = true;
            this.ccbUserRole.Location = new System.Drawing.Point(772, 21);
            this.ccbUserRole.Name = "ccbUserRole";
            this.ccbUserRole.Size = new System.Drawing.Size(249, 24);
            this.ccbUserRole.TabIndex = 19;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.Location = new System.Drawing.Point(664, 25);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(84, 20);
            this.lblUserRole.TabIndex = 18;
            this.lblUserRole.Text = "User Role";
            // 
            // ccbModule
            // 
            this.ccbModule.FormattingEnabled = true;
            this.ccbModule.Location = new System.Drawing.Point(193, 21);
            this.ccbModule.Name = "ccbModule";
            this.ccbModule.Size = new System.Drawing.Size(249, 24);
            this.ccbModule.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Module";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveMsg);
            this.groupBox1.Controls.Add(this.ccbUserRole);
            this.groupBox1.Controls.Add(this.ccbProblmType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ccbModule);
            this.groupBox1.Controls.Add(this.ccbEnv);
            this.groupBox1.Controls.Add(this.lblUserRole);
            this.groupBox1.Controls.Add(this.Envirnoment);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1349, 136);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSol);
            this.groupBox2.Controls.Add(this.txtprblmStmt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(11, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1349, 564);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(894, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // moduleReq
            // 
            this.moduleReq.ContainerControl = this;
            // 
            // userRoleReq
            // 
            this.userRoleReq.ContainerControl = this;
            // 
            // prblmStmtReq
            // 
            this.prblmStmtReq.ContainerControl = this;
            // 
            // saveMsg
            // 
            this.saveMsg.AutoSize = true;
            this.saveMsg.BackColor = System.Drawing.Color.AliceBlue;
            this.saveMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMsg.ForeColor = System.Drawing.Color.Blue;
            this.saveMsg.Location = new System.Drawing.Point(195, 101);
            this.saveMsg.Name = "saveMsg";
            this.saveMsg.Size = new System.Drawing.Size(64, 25);
            this.saveMsg.TabIndex = 24;
            this.saveMsg.Text = "label2";
            this.saveMsg.Visible = false;
            // 
            // frmFaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1372, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFaq";
            this.Text = "Faq Master";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prblmStmtReq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtSol;
        private System.Windows.Forms.TextBox txtprblmStmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ccbProblmType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ccbEnv;
        private System.Windows.Forms.Label Envirnoment;
        private System.Windows.Forms.ComboBox ccbUserRole;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.ComboBox ccbModule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider moduleReq;
        private System.Windows.Forms.ErrorProvider userRoleReq;
        private System.Windows.Forms.ErrorProvider prblmStmtReq;
        private System.Windows.Forms.Label saveMsg;
    }
}
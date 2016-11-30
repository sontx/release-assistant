namespace ReleaseAssistant
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuicklyRevision = new System.Windows.Forms.Button();
            this.btnQuicklyBuild = new System.Windows.Forms.Button();
            this.btnQuicklyMinor = new System.Windows.Forms.Button();
            this.btnQuicklyMajor = new System.Windows.Forms.Button();
            this.txtReleaseNotes = new ReleaseAssistant.XTextBox();
            this.btnRevision = new ReleaseAssistant.XButton();
            this.btnMinor = new ReleaseAssistant.XButton();
            this.txtFriendlyVersion = new ReleaseAssistant.XTextBox();
            this.btnBuild = new ReleaseAssistant.XButton();
            this.btnMajor = new ReleaseAssistant.XButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Friendly Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Major";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Minor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Build";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Revision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Release Notes:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(245, 459);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(164, 459);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnQuicklyRevision);
            this.groupBox1.Controls.Add(this.btnQuicklyBuild);
            this.groupBox1.Controls.Add(this.btnQuicklyMinor);
            this.groupBox1.Controls.Add(this.btnQuicklyMajor);
            this.groupBox1.Location = new System.Drawing.Point(15, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 147);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quickly?";
            // 
            // btnQuicklyRevision
            // 
            this.btnQuicklyRevision.Location = new System.Drawing.Point(10, 111);
            this.btnQuicklyRevision.Name = "btnQuicklyRevision";
            this.btnQuicklyRevision.Size = new System.Drawing.Size(286, 23);
            this.btnQuicklyRevision.TabIndex = 3;
            this.btnQuicklyRevision.Text = "Fixes a security hole or bugs in a previously release";
            this.btnQuicklyRevision.UseVisualStyleBackColor = true;
            this.btnQuicklyRevision.Click += new System.EventHandler(this.btnQuicklyRevision_Click);
            // 
            // btnQuicklyBuild
            // 
            this.btnQuicklyBuild.Location = new System.Drawing.Point(10, 82);
            this.btnQuicklyBuild.Name = "btnQuicklyBuild";
            this.btnQuicklyBuild.Size = new System.Drawing.Size(286, 23);
            this.btnQuicklyBuild.TabIndex = 2;
            this.btnQuicklyBuild.Text = "Changes processor, flatform or compiler(same source)";
            this.btnQuicklyBuild.UseVisualStyleBackColor = true;
            this.btnQuicklyBuild.Click += new System.EventHandler(this.btnQuicklyBuild_Click);
            // 
            // btnQuicklyMinor
            // 
            this.btnQuicklyMinor.Location = new System.Drawing.Point(10, 53);
            this.btnQuicklyMinor.Name = "btnQuicklyMinor";
            this.btnQuicklyMinor.Size = new System.Drawing.Size(286, 23);
            this.btnQuicklyMinor.TabIndex = 1;
            this.btnQuicklyMinor.Text = "New or changes feature, still backward compatible";
            this.btnQuicklyMinor.UseVisualStyleBackColor = true;
            this.btnQuicklyMinor.Click += new System.EventHandler(this.btnQuicklyMinor_Click);
            // 
            // btnQuicklyMajor
            // 
            this.btnQuicklyMajor.Location = new System.Drawing.Point(10, 24);
            this.btnQuicklyMajor.Name = "btnQuicklyMajor";
            this.btnQuicklyMajor.Size = new System.Drawing.Size(286, 23);
            this.btnQuicklyMajor.TabIndex = 0;
            this.btnQuicklyMajor.Text = "Not backward compatible";
            this.btnQuicklyMajor.UseVisualStyleBackColor = true;
            this.btnQuicklyMajor.Click += new System.EventHandler(this.btnQuicklyMajor_Click);
            // 
            // txtReleaseNotes
            // 
            this.txtReleaseNotes.AcceptsReturn = true;
            this.txtReleaseNotes.AcceptsTab = true;
            this.txtReleaseNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReleaseNotes.Hint = "Release Notes";
            this.txtReleaseNotes.Location = new System.Drawing.Point(102, 99);
            this.txtReleaseNotes.Multiline = true;
            this.txtReleaseNotes.Name = "txtReleaseNotes";
            this.txtReleaseNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReleaseNotes.Size = new System.Drawing.Size(218, 161);
            this.txtReleaseNotes.TabIndex = 5;
            // 
            // btnRevision
            // 
            this.btnRevision.IncreaseOnClick = true;
            this.btnRevision.Location = new System.Drawing.Point(278, 12);
            this.btnRevision.Name = "btnRevision";
            this.btnRevision.Size = new System.Drawing.Size(42, 23);
            this.btnRevision.TabIndex = 3;
            this.btnRevision.Text = "0";
            this.btnRevision.UseVisualStyleBackColor = true;
            this.btnRevision.Value = 0;
            // 
            // btnMinor
            // 
            this.btnMinor.IncreaseOnClick = true;
            this.btnMinor.Location = new System.Drawing.Point(161, 12);
            this.btnMinor.Name = "btnMinor";
            this.btnMinor.Size = new System.Drawing.Size(42, 23);
            this.btnMinor.TabIndex = 1;
            this.btnMinor.Text = "0";
            this.btnMinor.UseVisualStyleBackColor = true;
            this.btnMinor.Value = 0;
            // 
            // txtFriendlyVersion
            // 
            this.txtFriendlyVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFriendlyVersion.Hint = "1.0 RC1";
            this.txtFriendlyVersion.Location = new System.Drawing.Point(102, 64);
            this.txtFriendlyVersion.Name = "txtFriendlyVersion";
            this.txtFriendlyVersion.Size = new System.Drawing.Size(218, 20);
            this.txtFriendlyVersion.TabIndex = 4;
            // 
            // btnBuild
            // 
            this.btnBuild.IncreaseOnClick = true;
            this.btnBuild.Location = new System.Drawing.Point(219, 12);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(42, 23);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "0";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Value = 0;
            // 
            // btnMajor
            // 
            this.btnMajor.IncreaseOnClick = true;
            this.btnMajor.Location = new System.Drawing.Point(102, 12);
            this.btnMajor.Name = "btnMajor";
            this.btnMajor.Size = new System.Drawing.Size(42, 23);
            this.btnMajor.TabIndex = 0;
            this.btnMajor.Text = "0";
            this.btnMajor.UseVisualStyleBackColor = true;
            this.btnMajor.Value = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(336, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReleaseNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRevision);
            this.Controls.Add(this.btnMinor);
            this.Controls.Add(this.txtFriendlyVersion);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnMajor);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Assistant";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private XTextBox txtFriendlyVersion;
        private XButton btnMajor;
        private XButton btnBuild;
        private XButton btnRevision;
        private XButton btnMinor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private XTextBox txtReleaseNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuicklyMajor;
        private System.Windows.Forms.Button btnQuicklyMinor;
        private System.Windows.Forms.Button btnQuicklyBuild;
        private System.Windows.Forms.Button btnQuicklyRevision;
    }
}


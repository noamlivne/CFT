﻿namespace CFT
{
    partial class EncryptionMethodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionMethodForm));
            this.cbTrunkSystem = new System.Windows.Forms.CheckBox();
            this.cbMfid = new System.Windows.Forms.CheckBox();
            this.cbFrequency = new System.Windows.Forms.CheckBox();
            this.cbColorCode = new System.Windows.Forms.CheckBox();
            this.cbTgid = new System.Windows.Forms.CheckBox();
            this.cbTimeSlot = new System.Windows.Forms.CheckBox();
            this.cbEncryptionValue = new System.Windows.Forms.CheckBox();
            this.cbbTrunkSystem = new System.Windows.Forms.ComboBox();
            this.cbbMfid = new System.Windows.Forms.ComboBox();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.cbbColorCode = new System.Windows.Forms.ComboBox();
            this.cbbTimeSlot = new System.Windows.Forms.ComboBox();
            this.cbbEncryptionValue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbEncryptionMethod = new System.Windows.Forms.ComboBox();
            this.lblKeyExt = new System.Windows.Forms.Label();
            this.tbTgid = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbbKeyLength = new System.Windows.Forms.ComboBox();
            this.lblLen = new System.Windows.Forms.Label();
            this.nudMotoKey = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMotoKey)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTrunkSystem
            // 
            this.cbTrunkSystem.AutoSize = true;
            this.cbTrunkSystem.Location = new System.Drawing.Point(31, 41);
            this.cbTrunkSystem.Name = "cbTrunkSystem";
            this.cbTrunkSystem.Size = new System.Drawing.Size(103, 21);
            this.cbTrunkSystem.TabIndex = 4;
            this.cbTrunkSystem.Text = "Trunk System";
            this.cbTrunkSystem.UseVisualStyleBackColor = true;
            this.cbTrunkSystem.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbMfid
            // 
            this.cbMfid.AutoSize = true;
            this.cbMfid.Location = new System.Drawing.Point(31, 72);
            this.cbMfid.Name = "cbMfid";
            this.cbMfid.Size = new System.Drawing.Size(57, 21);
            this.cbMfid.TabIndex = 6;
            this.cbMfid.Text = "MFID";
            this.cbMfid.UseVisualStyleBackColor = true;
            this.cbMfid.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbFrequency
            // 
            this.cbFrequency.AutoSize = true;
            this.cbFrequency.Checked = true;
            this.cbFrequency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFrequency.Enabled = false;
            this.cbFrequency.Location = new System.Drawing.Point(31, 103);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(125, 21);
            this.cbFrequency.TabIndex = 8;
            this.cbFrequency.Text = "Frequency (MHz)";
            this.cbFrequency.UseVisualStyleBackColor = true;
            this.cbFrequency.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbColorCode
            // 
            this.cbColorCode.AutoSize = true;
            this.cbColorCode.Location = new System.Drawing.Point(31, 134);
            this.cbColorCode.Name = "cbColorCode";
            this.cbColorCode.Size = new System.Drawing.Size(94, 21);
            this.cbColorCode.TabIndex = 10;
            this.cbColorCode.Text = "Color Code";
            this.cbColorCode.UseVisualStyleBackColor = true;
            this.cbColorCode.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbTgid
            // 
            this.cbTgid.AutoSize = true;
            this.cbTgid.Location = new System.Drawing.Point(31, 165);
            this.cbTgid.Name = "cbTgid";
            this.cbTgid.Size = new System.Drawing.Size(88, 21);
            this.cbTgid.TabIndex = 12;
            this.cbTgid.Text = "TGID (Dec)";
            this.cbTgid.UseVisualStyleBackColor = true;
            this.cbTgid.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbTimeSlot
            // 
            this.cbTimeSlot.AutoSize = true;
            this.cbTimeSlot.Location = new System.Drawing.Point(31, 196);
            this.cbTimeSlot.Name = "cbTimeSlot";
            this.cbTimeSlot.Size = new System.Drawing.Size(81, 21);
            this.cbTimeSlot.TabIndex = 14;
            this.cbTimeSlot.Text = "Time Slot";
            this.cbTimeSlot.UseVisualStyleBackColor = true;
            this.cbTimeSlot.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbEncryptionValue
            // 
            this.cbEncryptionValue.AutoSize = true;
            this.cbEncryptionValue.Location = new System.Drawing.Point(31, 227);
            this.cbEncryptionValue.Name = "cbEncryptionValue";
            this.cbEncryptionValue.Size = new System.Drawing.Size(123, 21);
            this.cbEncryptionValue.TabIndex = 16;
            this.cbEncryptionValue.Text = "Encryption Value";
            this.toolTip.SetToolTip(this.cbEncryptionValue, resources.GetString("cbEncryptionValue.ToolTip"));
            this.cbEncryptionValue.UseVisualStyleBackColor = true;
            this.cbEncryptionValue.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cbbTrunkSystem
            // 
            this.cbbTrunkSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrunkSystem.FormattingEnabled = true;
            this.cbbTrunkSystem.Location = new System.Drawing.Point(191, 39);
            this.cbbTrunkSystem.Name = "cbbTrunkSystem";
            this.cbbTrunkSystem.Size = new System.Drawing.Size(179, 25);
            this.cbbTrunkSystem.TabIndex = 5;
            // 
            // cbbMfid
            // 
            this.cbbMfid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMfid.FormattingEnabled = true;
            this.cbbMfid.Location = new System.Drawing.Point(191, 70);
            this.cbbMfid.Name = "cbbMfid";
            this.cbbMfid.Size = new System.Drawing.Size(179, 25);
            this.cbbMfid.TabIndex = 7;
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(191, 101);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(179, 25);
            this.tbFrequency.TabIndex = 9;
            // 
            // cbbColorCode
            // 
            this.cbbColorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColorCode.FormattingEnabled = true;
            this.cbbColorCode.Location = new System.Drawing.Point(191, 132);
            this.cbbColorCode.Name = "cbbColorCode";
            this.cbbColorCode.Size = new System.Drawing.Size(179, 25);
            this.cbbColorCode.TabIndex = 11;
            // 
            // cbbTimeSlot
            // 
            this.cbbTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimeSlot.FormattingEnabled = true;
            this.cbbTimeSlot.Location = new System.Drawing.Point(191, 194);
            this.cbbTimeSlot.Name = "cbbTimeSlot";
            this.cbbTimeSlot.Size = new System.Drawing.Size(179, 25);
            this.cbbTimeSlot.TabIndex = 15;
            // 
            // cbbEncryptionValue
            // 
            this.cbbEncryptionValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEncryptionValue.FormattingEnabled = true;
            this.cbbEncryptionValue.Location = new System.Drawing.Point(191, 225);
            this.cbbEncryptionValue.Name = "cbbEncryptionValue";
            this.cbbEncryptionValue.Size = new System.Drawing.Size(179, 25);
            this.cbbEncryptionValue.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Encryption Method:";
            // 
            // cbbEncryptionMethod
            // 
            this.cbbEncryptionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEncryptionMethod.FormattingEnabled = true;
            this.cbbEncryptionMethod.Location = new System.Drawing.Point(145, 18);
            this.cbbEncryptionMethod.Name = "cbbEncryptionMethod";
            this.cbbEncryptionMethod.Size = new System.Drawing.Size(179, 25);
            this.cbbEncryptionMethod.TabIndex = 1;
            this.cbbEncryptionMethod.SelectedIndexChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // lblKeyExt
            // 
            this.lblKeyExt.AutoSize = true;
            this.lblKeyExt.Location = new System.Drawing.Point(64, 52);
            this.lblKeyExt.Name = "lblKeyExt";
            this.lblKeyExt.Size = new System.Drawing.Size(75, 17);
            this.lblKeyExt.TabIndex = 16;
            this.lblKeyExt.Text = "Key Length:";
            // 
            // tbTgid
            // 
            this.tbTgid.Location = new System.Drawing.Point(191, 163);
            this.tbTgid.Name = "tbTgid";
            this.tbTgid.Size = new System.Drawing.Size(179, 25);
            this.tbTgid.TabIndex = 13;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(145, 80);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(282, 49);
            this.tbKey.TabIndex = 3;
            this.tbKey.Tag = "";
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(71, 80);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(66, 17);
            this.lblKey.TabIndex = 19;
            this.lblKey.Text = "Key (Hex):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbEncryptionValue);
            this.groupBox1.Controls.Add(this.cbbTimeSlot);
            this.groupBox1.Controls.Add(this.tbTgid);
            this.groupBox1.Controls.Add(this.cbbColorCode);
            this.groupBox1.Controls.Add(this.tbFrequency);
            this.groupBox1.Controls.Add(this.cbbMfid);
            this.groupBox1.Controls.Add(this.cbbTrunkSystem);
            this.groupBox1.Controls.Add(this.cbEncryptionValue);
            this.groupBox1.Controls.Add(this.cbTimeSlot);
            this.groupBox1.Controls.Add(this.cbTgid);
            this.groupBox1.Controls.Add(this.cbColorCode);
            this.groupBox1.Controls.Add(this.cbFrequency);
            this.groupBox1.Controls.Add(this.cbMfid);
            this.groupBox1.Controls.Add(this.cbTrunkSystem);
            this.groupBox1.Location = new System.Drawing.Point(20, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 278);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options for activate encryption method (AND)";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(20, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 35);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(273, 510);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(154, 35);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbbKeyLength
            // 
            this.cbbKeyLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKeyLength.FormattingEnabled = true;
            this.cbbKeyLength.Location = new System.Drawing.Point(145, 49);
            this.cbbKeyLength.Name = "cbbKeyLength";
            this.cbbKeyLength.Size = new System.Drawing.Size(179, 25);
            this.cbbKeyLength.TabIndex = 23;
            // 
            // lblLen
            // 
            this.lblLen.Location = new System.Drawing.Point(371, 49);
            this.lblLen.Name = "lblLen";
            this.lblLen.Size = new System.Drawing.Size(56, 25);
            this.lblLen.TabIndex = 24;
            this.lblLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMotoKey
            // 
            this.nudMotoKey.Location = new System.Drawing.Point(145, 50);
            this.nudMotoKey.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMotoKey.Name = "nudMotoKey";
            this.nudMotoKey.Size = new System.Drawing.Size(179, 25);
            this.nudMotoKey.TabIndex = 2;
            this.nudMotoKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMotoKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(20, 462);
            this.tbNotes.MaxLength = 32;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(407, 25);
            this.tbNotes.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Notes:";
            // 
            // EncryptionMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(450, 557);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMotoKey);
            this.Controls.Add(this.lblLen);
            this.Controls.Add(this.cbbKeyLength);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lblKeyExt);
            this.Controls.Add(this.cbbEncryptionMethod);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptionMethodForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set DMR Encryption Method";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMotoKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTrunkSystem;
        private System.Windows.Forms.CheckBox cbMfid;
        private System.Windows.Forms.CheckBox cbFrequency;
        private System.Windows.Forms.CheckBox cbColorCode;
        private System.Windows.Forms.CheckBox cbTgid;
        private System.Windows.Forms.CheckBox cbTimeSlot;
        private System.Windows.Forms.CheckBox cbEncryptionValue;
        private System.Windows.Forms.ComboBox cbbTrunkSystem;
        private System.Windows.Forms.ComboBox cbbMfid;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.ComboBox cbbColorCode;
        private System.Windows.Forms.ComboBox cbbTimeSlot;
        private System.Windows.Forms.ComboBox cbbEncryptionValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbEncryptionMethod;
        private System.Windows.Forms.Label lblKeyExt;
        private System.Windows.Forms.TextBox tbTgid;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbbKeyLength;
        private System.Windows.Forms.Label lblLen;
        private System.Windows.Forms.NumericUpDown nudMotoKey;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label label2;
    }
}
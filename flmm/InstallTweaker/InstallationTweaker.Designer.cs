﻿namespace Fomm.InstallTweaker {
    partial class InstallationTweaker {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbDisableLive = new System.Windows.Forms.CheckBox();
            this.cbShrinkTextures = new System.Windows.Forms.CheckBox();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbStripGeck = new System.Windows.Forms.CheckBox();
            this.cbRemoveClutter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDisableLive
            // 
            this.cbDisableLive.AutoSize = true;
            this.cbDisableLive.Location = new System.Drawing.Point(12, 47);
            this.cbDisableLive.Name = "cbDisableLive";
            this.cbDisableLive.Size = new System.Drawing.Size(84, 17);
            this.cbDisableLive.TabIndex = 0;
            this.cbDisableLive.Text = "Disable Live";
            this.cbDisableLive.UseVisualStyleBackColor = true;
            this.cbDisableLive.CheckedChanged += new System.EventHandler(this.cbDisableLive_CheckedChanged);
            // 
            // cbShrinkTextures
            // 
            this.cbShrinkTextures.AutoSize = true;
            this.cbShrinkTextures.Location = new System.Drawing.Point(12, 70);
            this.cbShrinkTextures.Name = "cbShrinkTextures";
            this.cbShrinkTextures.Size = new System.Drawing.Size(96, 17);
            this.cbShrinkTextures.TabIndex = 1;
            this.cbShrinkTextures.Text = "Shrink textures";
            this.cbShrinkTextures.UseVisualStyleBackColor = true;
            this.cbShrinkTextures.CheckedChanged += new System.EventHandler(this.cbShrinkTextures_CheckedChanged);
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.Location = new System.Drawing.Point(205, 208);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 2;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.Location = new System.Drawing.Point(124, 208);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescription.Location = new System.Drawing.Point(12, 93);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(268, 109);
            this.tbDescription.TabIndex = 4;
            // 
            // cbStripGeck
            // 
            this.cbStripGeck.AutoSize = true;
            this.cbStripGeck.Location = new System.Drawing.Point(151, 70);
            this.cbStripGeck.Name = "cbStripGeck";
            this.cbStripGeck.Size = new System.Drawing.Size(98, 17);
            this.cbStripGeck.TabIndex = 5;
            this.cbStripGeck.Text = "Geck data strip";
            this.cbStripGeck.UseVisualStyleBackColor = true;
            this.cbStripGeck.CheckedChanged += new System.EventHandler(this.cbStripGeck_CheckedChanged);
            // 
            // cbRemoveClutter
            // 
            this.cbRemoveClutter.AutoSize = true;
            this.cbRemoveClutter.Location = new System.Drawing.Point(151, 47);
            this.cbRemoveClutter.Name = "cbRemoveClutter";
            this.cbRemoveClutter.Size = new System.Drawing.Size(98, 17);
            this.cbRemoveClutter.TabIndex = 6;
            this.cbRemoveClutter.Text = "Remove clutter";
            this.cbRemoveClutter.UseVisualStyleBackColor = true;
            this.cbRemoveClutter.CheckedChanged += new System.EventHandler(this.cbRemoveClutter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Always uncheck all items on this page before installing any official patches!";
            // 
            // InstallationTweaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRemoveClutter);
            this.Controls.Add(this.cbStripGeck);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.cbShrinkTextures);
            this.Controls.Add(this.cbDisableLive);
            this.Name = "InstallationTweaker";
            this.Text = "InstallationTweaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDisableLive;
        private System.Windows.Forms.CheckBox cbShrinkTextures;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.CheckBox cbStripGeck;
        private System.Windows.Forms.CheckBox cbRemoveClutter;
        private System.Windows.Forms.Label label1;
    }
}
﻿namespace s3piwrappers.RigEditor
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

        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grannySkeletonControl1 = new s3piwrappers.RigEditor.GrannySkeletonControl();
            this.SuspendLayout();
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCommit.Location = new System.Drawing.Point(699, 527);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(618, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grannySkeletonControl1
            // 
            this.grannySkeletonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grannySkeletonControl1.Location = new System.Drawing.Point(5, 12);
            this.grannySkeletonControl1.Name = "grannySkeletonControl1";
            this.grannySkeletonControl1.Size = new System.Drawing.Size(769, 509);
            this.grannySkeletonControl1.TabIndex = 3;
            this.grannySkeletonControl1.Value = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grannySkeletonControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCommit);
            this.MinimumSize = new System.Drawing.Size(690, 340);
            this.Name = "MainForm";
            this.Text = "Rig Editor";
            this.ResumeLayout(false);

        }

        

        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnCancel;
        private GrannySkeletonControl grannySkeletonControl1;

    }
}
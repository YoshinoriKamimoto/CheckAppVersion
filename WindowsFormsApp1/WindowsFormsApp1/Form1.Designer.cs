﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClickOnceVersionLabel = new System.Windows.Forms.Label();
            this.AssemblyVersionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClickOnceバージョン";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assemblyバージョン";
            // 
            // ClickOnceVersionLabel
            // 
            this.ClickOnceVersionLabel.AutoSize = true;
            this.ClickOnceVersionLabel.Location = new System.Drawing.Point(169, 71);
            this.ClickOnceVersionLabel.Name = "ClickOnceVersionLabel";
            this.ClickOnceVersionLabel.Size = new System.Drawing.Size(35, 12);
            this.ClickOnceVersionLabel.TabIndex = 2;
            this.ClickOnceVersionLabel.Text = "1.0.0.0";
            // 
            // AssemblyVersionLabel
            // 
            this.AssemblyVersionLabel.AutoSize = true;
            this.AssemblyVersionLabel.Location = new System.Drawing.Point(169, 112);
            this.AssemblyVersionLabel.Name = "AssemblyVersionLabel";
            this.AssemblyVersionLabel.Size = new System.Drawing.Size(35, 12);
            this.AssemblyVersionLabel.TabIndex = 3;
            this.AssemblyVersionLabel.Text = "1.0.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 204);
            this.Controls.Add(this.AssemblyVersionLabel);
            this.Controls.Add(this.ClickOnceVersionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClickOnceVersionLabel;
        private System.Windows.Forms.Label AssemblyVersionLabel;
    }
}


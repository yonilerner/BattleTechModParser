namespace FoxBattletechPatcher
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
            this.file_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select_file = new System.Windows.Forms.Button();
            this.patch_button = new System.Windows.Forms.Button();
            this.unpatch_button = new System.Windows.Forms.Button();
            this.use_default_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // file_input
            // 
            this.file_input.Location = new System.Drawing.Point(74, 28);
            this.file_input.Name = "file_input";
            this.file_input.Size = new System.Drawing.Size(357, 20);
            this.file_input.TabIndex = 1;
            this.file_input.TextChanged += new System.EventHandler(this.file_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ModFile:";
            // 
            // select_file
            // 
            this.select_file.Location = new System.Drawing.Point(438, 28);
            this.select_file.Name = "select_file";
            this.select_file.Size = new System.Drawing.Size(75, 23);
            this.select_file.TabIndex = 3;
            this.select_file.Text = "Select File";
            this.select_file.UseVisualStyleBackColor = true;
            this.select_file.Click += new System.EventHandler(this.select_file_Click);
            // 
            // patch_button
            // 
            this.patch_button.Location = new System.Drawing.Point(128, 245);
            this.patch_button.Name = "patch_button";
            this.patch_button.Size = new System.Drawing.Size(75, 23);
            this.patch_button.TabIndex = 4;
            this.patch_button.Text = "Patch";
            this.patch_button.UseVisualStyleBackColor = true;
            this.patch_button.Click += new System.EventHandler(this.patch_button_Click);
            // 
            // unpatch_button
            // 
            this.unpatch_button.Location = new System.Drawing.Point(352, 245);
            this.unpatch_button.Name = "unpatch_button";
            this.unpatch_button.Size = new System.Drawing.Size(75, 23);
            this.unpatch_button.TabIndex = 5;
            this.unpatch_button.Text = "Unpatch";
            this.unpatch_button.UseVisualStyleBackColor = true;
            this.unpatch_button.Click += new System.EventHandler(this.unpatch_button_Click);
            // 
            // use_default_button
            // 
            this.use_default_button.Location = new System.Drawing.Point(438, 69);
            this.use_default_button.Name = "use_default_button";
            this.use_default_button.Size = new System.Drawing.Size(75, 23);
            this.use_default_button.TabIndex = 6;
            this.use_default_button.Text = "Use Default";
            this.use_default_button.UseVisualStyleBackColor = true;
            this.use_default_button.Click += new System.EventHandler(this.use_default_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 365);
            this.Controls.Add(this.use_default_button);
            this.Controls.Add(this.unpatch_button);
            this.Controls.Add(this.patch_button);
            this.Controls.Add(this.select_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.file_input);
            this.Name = "Form1";
            this.Text = "[FOX] Battletech Patcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox file_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_file;
        private System.Windows.Forms.Button patch_button;
        private System.Windows.Forms.Button unpatch_button;
        private System.Windows.Forms.Button use_default_button;
    }
}


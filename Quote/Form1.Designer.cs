namespace Quote
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quote_label = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.color_btn = new System.Windows.Forms.Button();
            this.panel_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quote_label
            // 
            this.quote_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quote_label.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.quote_label.Location = new System.Drawing.Point(12, 50);
            this.quote_label.Name = "quote_label";
            this.quote_label.Size = new System.Drawing.Size(716, 64);
            this.quote_label.TabIndex = 0;
            this.quote_label.Text = "Цитата";
            this.quote_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // next_btn
            // 
            this.next_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next_btn.Location = new System.Drawing.Point(35, 167);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(126, 34);
            this.next_btn.TabIndex = 1;
            this.next_btn.Text = "Наступна";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // color_btn
            // 
            this.color_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.color_btn.Location = new System.Drawing.Point(216, 167);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(126, 34);
            this.color_btn.TabIndex = 2;
            this.color_btn.Text = "Колір";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // panel_btn
            // 
            this.panel_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_btn.Location = new System.Drawing.Point(397, 167);
            this.panel_btn.Name = "panel_btn";
            this.panel_btn.Size = new System.Drawing.Size(126, 34);
            this.panel_btn.TabIndex = 3;
            this.panel_btn.Text = "Панель";
            this.panel_btn.UseVisualStyleBackColor = true;
            this.panel_btn.Click += new System.EventHandler(this.panel_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exit_btn.Location = new System.Drawing.Point(578, 167);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(126, 34);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Вихід";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 227);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.panel_btn);
            this.Controls.Add(this.color_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.quote_label);
            this.Name = "Form1";
            this.Text = "Цитати";
            this.ResumeLayout(false);

        }

        #endregion

        private Label quote_label;
        private Button next_btn;
        private Button color_btn;
        private Button panel_btn;
        private Button exit_btn;
    }
}
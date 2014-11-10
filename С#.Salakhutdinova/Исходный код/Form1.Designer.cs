namespace TestTaskSalakhutdinova
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.opentxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.opendic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fileplace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opentxt
            // 
            this.opentxt.Location = new System.Drawing.Point(64, 45);
            this.opentxt.Name = "opentxt";
            this.opentxt.Size = new System.Drawing.Size(111, 23);
            this.opentxt.TabIndex = 0;
            this.opentxt.Text = "Open txtword";
            this.opentxt.UseVisualStyleBackColor = true;
            this.opentxt.Click += new System.EventHandler(this.open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Working with files";
            // 
            // opendic
            // 
            this.opendic.Location = new System.Drawing.Point(64, 95);
            this.opendic.Name = "opendic";
            this.opendic.Size = new System.Drawing.Size(111, 23);
            this.opendic.TabIndex = 2;
            this.opendic.Text = "Open txtdic";
            this.opendic.UseVisualStyleBackColor = true;
            this.opendic.Click += new System.EventHandler(this.opendic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Open HTML-Document in WEB";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(505, 45);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(135, 73);
            this.create.TabIndex = 5;
            this.create.Text = "Try";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create Html";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "Do it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileplace
            // 
            this.fileplace.AutoEllipsis = true;
            this.fileplace.AutoSize = true;
            this.fileplace.Location = new System.Drawing.Point(61, 139);
            this.fileplace.MaximumSize = new System.Drawing.Size(600, 50);
            this.fileplace.Name = "fileplace";
            this.fileplace.Size = new System.Drawing.Size(0, 13);
            this.fileplace.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 187);
            this.Controls.Add(this.fileplace);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opendic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opentxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opentxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opendic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fileplace;
    }
}


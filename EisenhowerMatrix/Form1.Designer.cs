namespace EisenhowerMatrix
{
    partial class EisenhowerMatrix
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ToDoBox = new System.Windows.Forms.ListBox();
            this.ToDelegateBox = new System.Windows.Forms.ListBox();
            this.ToEliminateBox = new System.Windows.Forms.ListBox();
            this.ToDecideBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 292);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(186, 108);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "AddButton";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(204, 292);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(186, 108);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ToDoBox
            // 
            this.ToDoBox.FormattingEnabled = true;
            this.ToDoBox.Location = new System.Drawing.Point(12, 12);
            this.ToDoBox.Name = "ToDoBox";
            this.ToDoBox.Size = new System.Drawing.Size(186, 134);
            this.ToDoBox.TabIndex = 2;
            // 
            // ToDelegateBox
            // 
            this.ToDelegateBox.FormattingEnabled = true;
            this.ToDelegateBox.Location = new System.Drawing.Point(12, 152);
            this.ToDelegateBox.Name = "ToDelegateBox";
            this.ToDelegateBox.Size = new System.Drawing.Size(186, 134);
            this.ToDelegateBox.TabIndex = 3;
            // 
            // ToEliminateBox
            // 
            this.ToEliminateBox.FormattingEnabled = true;
            this.ToEliminateBox.Location = new System.Drawing.Point(204, 152);
            this.ToEliminateBox.Name = "ToEliminateBox";
            this.ToEliminateBox.Size = new System.Drawing.Size(186, 134);
            this.ToEliminateBox.TabIndex = 4;
            // 
            // ToDecideBox
            // 
            this.ToDecideBox.FormattingEnabled = true;
            this.ToDecideBox.Location = new System.Drawing.Point(204, 12);
            this.ToDecideBox.Name = "ToDecideBox";
            this.ToDecideBox.Size = new System.Drawing.Size(186, 134);
            this.ToDecideBox.TabIndex = 5;
            // 
            // EisenhowerMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 409);
            this.Controls.Add(this.ToDecideBox);
            this.Controls.Add(this.ToEliminateBox);
            this.Controls.Add(this.ToDelegateBox);
            this.Controls.Add(this.ToDoBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Name = "EisenhowerMatrix";
            this.Text = "EisenhowerMatrix";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox ToDoBox;
        private System.Windows.Forms.ListBox ToDelegateBox;
        private System.Windows.Forms.ListBox ToEliminateBox;
        private System.Windows.Forms.ListBox ToDecideBox;
    }
}


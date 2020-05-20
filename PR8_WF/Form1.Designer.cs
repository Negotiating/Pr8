namespace PR8_WF
{
	partial class Form1
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
			this.task1 = new System.Windows.Forms.GroupBox();
			this.text_label = new System.Windows.Forms.Label();
			this.text_box = new System.Windows.Forms.RichTextBox();
			this.result_label = new System.Windows.Forms.Label();
			this.result_box = new System.Windows.Forms.RichTextBox();
			this.task1.SuspendLayout();
			this.SuspendLayout();
			// 
			// task1
			// 
			this.task1.Controls.Add(this.result_box);
			this.task1.Controls.Add(this.result_label);
			this.task1.Controls.Add(this.text_box);
			this.task1.Controls.Add(this.text_label);
			this.task1.Location = new System.Drawing.Point(8, 15);
			this.task1.Name = "task1";
			this.task1.Size = new System.Drawing.Size(331, 311);
			this.task1.TabIndex = 0;
			this.task1.TabStop = false;
			this.task1.Text = "Задание 1";
			// 
			// text_label
			// 
			this.text_label.AutoSize = true;
			this.text_label.Location = new System.Drawing.Point(6, 33);
			this.text_label.Name = "text_label";
			this.text_label.Size = new System.Drawing.Size(50, 17);
			this.text_label.TabIndex = 0;
			this.text_label.Text = "Текст:";
			// 
			// text_box
			// 
			this.text_box.Location = new System.Drawing.Point(62, 33);
			this.text_box.Name = "text_box";
			this.text_box.Size = new System.Drawing.Size(263, 122);
			this.text_box.TabIndex = 1;
			this.text_box.Text = "";
			this.text_box.TextChanged += new System.EventHandler(this.text_box_TextChanged);
			// 
			// result_label
			// 
			this.result_label.AutoSize = true;
			this.result_label.Location = new System.Drawing.Point(6, 180);
			this.result_label.Name = "result_label";
			this.result_label.Size = new System.Drawing.Size(80, 17);
			this.result_label.TabIndex = 2;
			this.result_label.Text = "Результат:";
			// 
			// result_box
			// 
			this.result_box.Location = new System.Drawing.Point(92, 180);
			this.result_box.Name = "result_box";
			this.result_box.Size = new System.Drawing.Size(233, 125);
			this.result_box.TabIndex = 3;
			this.result_box.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 338);
			this.Controls.Add(this.task1);
			this.Name = "Form1";
			this.Text = "Практика 8";
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox task1;
		private System.Windows.Forms.RichTextBox result_box;
		private System.Windows.Forms.Label result_label;
		private System.Windows.Forms.RichTextBox text_box;
		private System.Windows.Forms.Label text_label;
	}
}


namespace calc
{
    public class DisabledRichTextBox : System.Windows.Forms.RichTextBox
    {
        private const int WM_SETFOCUS = 0x07;
        private const int WM_ENABLE = 0x0A;
        private const int WM_SETCURSOR = 0x20;

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (!(m.Msg == WM_SETFOCUS || m.Msg == WM_ENABLE || m.Msg == WM_SETCURSOR))
                base.WndProc(ref m);
        }
    }
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
            this.textanswer = new System.Windows.Forms.RichTextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.plusminus = new System.Windows.Forms.Button();
            this.razd = new System.Windows.Forms.Button();
            this.ymn = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plusic = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Button();
            this.Mem = new System.Windows.Forms.RichTextBox();
            this.kostyl = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textanswer
            // 
            this.textanswer.CausesValidation = false;
            this.textanswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textanswer.Location = new System.Drawing.Point(9, 12);
            this.textanswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textanswer.Name = "textanswer";
            this.textanswer.Size = new System.Drawing.Size(291, 66);
            this.textanswer.TabIndex = 0;
            this.textanswer.TabStop = false;
            this.textanswer.Text = "";
            this.textanswer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textanswer_MouseClick);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b0.Location = new System.Drawing.Point(60, 268);
            this.b0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(43, 40);
            this.b0.TabIndex = 1;
            this.b0.TabStop = false;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.Location = new System.Drawing.Point(10, 222);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(41, 40);
            this.b1.TabIndex = 2;
            this.b1.TabStop = false;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.Location = new System.Drawing.Point(60, 222);
            this.b2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(43, 40);
            this.b2.TabIndex = 3;
            this.b2.TabStop = false;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.Location = new System.Drawing.Point(111, 222);
            this.b3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(41, 40);
            this.b3.TabIndex = 4;
            this.b3.TabStop = false;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b4.Location = new System.Drawing.Point(10, 176);
            this.b4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(42, 40);
            this.b4.TabIndex = 5;
            this.b4.TabStop = false;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b5.Location = new System.Drawing.Point(60, 176);
            this.b5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(43, 40);
            this.b5.TabIndex = 6;
            this.b5.TabStop = false;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b6.Location = new System.Drawing.Point(111, 176);
            this.b6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(41, 40);
            this.b6.TabIndex = 7;
            this.b6.TabStop = false;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b7.Location = new System.Drawing.Point(10, 130);
            this.b7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(42, 40);
            this.b7.TabIndex = 8;
            this.b7.TabStop = false;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b8.Location = new System.Drawing.Point(60, 130);
            this.b8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(43, 40);
            this.b8.TabIndex = 9;
            this.b8.TabStop = false;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b9.Location = new System.Drawing.Point(111, 130);
            this.b9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(41, 40);
            this.b9.TabIndex = 10;
            this.b9.TabStop = false;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left.Location = new System.Drawing.Point(9, 84);
            this.left.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(42, 40);
            this.left.TabIndex = 11;
            this.left.TabStop = false;
            this.left.Text = "←";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // ce
            // 
            this.ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ce.Location = new System.Drawing.Point(60, 84);
            this.ce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(41, 40);
            this.ce.TabIndex = 12;
            this.ce.TabStop = false;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // c
            // 
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c.Location = new System.Drawing.Point(111, 84);
            this.c.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(41, 40);
            this.c.TabIndex = 13;
            this.c.TabStop = false;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // plusminus
            // 
            this.plusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusminus.Location = new System.Drawing.Point(160, 84);
            this.plusminus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plusminus.Name = "plusminus";
            this.plusminus.Size = new System.Drawing.Size(41, 40);
            this.plusminus.TabIndex = 14;
            this.plusminus.TabStop = false;
            this.plusminus.Text = "±";
            this.plusminus.UseVisualStyleBackColor = true;
            this.plusminus.Click += new System.EventHandler(this.plusminus_Click);
            // 
            // razd
            // 
            this.razd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razd.Location = new System.Drawing.Point(160, 130);
            this.razd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.razd.Name = "razd";
            this.razd.Size = new System.Drawing.Size(41, 40);
            this.razd.TabIndex = 15;
            this.razd.TabStop = false;
            this.razd.Text = "/";
            this.razd.UseVisualStyleBackColor = true;
            this.razd.Click += new System.EventHandler(this.razd_Click);
            // 
            // ymn
            // 
            this.ymn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ymn.Location = new System.Drawing.Point(160, 176);
            this.ymn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ymn.Name = "ymn";
            this.ymn.Size = new System.Drawing.Size(41, 40);
            this.ymn.TabIndex = 16;
            this.ymn.TabStop = false;
            this.ymn.Text = "*";
            this.ymn.UseVisualStyleBackColor = true;
            this.ymn.Click += new System.EventHandler(this.ymn_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(160, 222);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(41, 40);
            this.minus.TabIndex = 17;
            this.minus.TabStop = false;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plusic
            // 
            this.plusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusic.Location = new System.Drawing.Point(160, 268);
            this.plusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plusic.Name = "plusic";
            this.plusic.Size = new System.Drawing.Size(41, 40);
            this.plusic.TabIndex = 18;
            this.plusic.TabStop = false;
            this.plusic.Text = "+";
            this.plusic.UseVisualStyleBackColor = true;
            this.plusic.Click += new System.EventHandler(this.plusic_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(260, 84);
            this.answer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(41, 224);
            this.answer.TabIndex = 19;
            this.answer.TabStop = false;
            this.answer.Text = "=";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // Mem
            // 
            this.Mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mem.Location = new System.Drawing.Point(336, 12);
            this.Mem.Name = "Mem";
            this.Mem.ReadOnly = true;
            this.Mem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mem.Size = new System.Drawing.Size(212, 296);
            this.Mem.TabIndex = 22;
            this.Mem.TabStop = false;
            this.Mem.Text = "";
            this.Mem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mem_MouseClick);
            // 
            // kostyl
            // 
            this.kostyl.Location = new System.Drawing.Point(62, 269);
            this.kostyl.Name = "kostyl";
            this.kostyl.Size = new System.Drawing.Size(41, 40);
            this.kostyl.TabIndex = 0;
            this.kostyl.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.up.Location = new System.Drawing.Point(209, 84);
            this.up.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(43, 107);
            this.up.TabIndex = 23;
            this.up.TabStop = false;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.down.Location = new System.Drawing.Point(209, 197);
            this.down.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(43, 111);
            this.down.TabIndex = 24;
            this.down.TabStop = false;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 316);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.Mem);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.plusic);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.ymn);
            this.Controls.Add(this.razd);
            this.Controls.Add(this.plusminus);
            this.Controls.Add(this.c);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.left);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.textanswer);
            this.Controls.Add(this.kostyl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Калькулятор для длинных целых чисел";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textanswer;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button plusminus;
        private System.Windows.Forms.Button razd;
        private System.Windows.Forms.Button ymn;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plusic;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.RichTextBox Mem;
        private System.Windows.Forms.Button kostyl;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
    }
}


namespace WinFormsApp1
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
            Aceptar = new Button();
            SuspendLayout();
            // 
            // Aceptar
            // 
            Aceptar.BackColor = SystemColors.ActiveCaptionText;
            Aceptar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Aceptar.ForeColor = SystemColors.HotTrack;
            Aceptar.Location = new Point(552, 340);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(183, 85);
            Aceptar.TabIndex = 0;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = false;
            Aceptar.Click += Aceptar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Aceptar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Aceptar;
    }
}

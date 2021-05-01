
namespace project.UserInterface
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.optionTable1 = new System.Windows.Forms.RadioButton();
            this.optionTable3 = new System.Windows.Forms.RadioButton();
            this.optionTable4 = new System.Windows.Forms.RadioButton();
            this.title2 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.numberInsertsTX = new System.Windows.Forms.TextBox();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionTable1
            // 
            this.optionTable1.AutoSize = true;
            this.optionTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTable1.Location = new System.Drawing.Point(292, 67);
            this.optionTable1.Name = "optionTable1";
            this.optionTable1.Size = new System.Drawing.Size(154, 19);
            this.optionTable1.TabIndex = 0;
            this.optionTable1.TabStop = true;
            this.optionTable1.Text = "Employee / Department";
            this.optionTable1.UseVisualStyleBackColor = true;
            // 
            // optionTable3
            // 
            this.optionTable3.AutoSize = true;
            this.optionTable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTable3.Location = new System.Drawing.Point(292, 116);
            this.optionTable3.Name = "optionTable3";
            this.optionTable3.Size = new System.Drawing.Size(63, 19);
            this.optionTable3.TabIndex = 2;
            this.optionTable3.TabStop = true;
            this.optionTable3.Text = "Project";
            this.optionTable3.UseVisualStyleBackColor = true;
            // 
            // optionTable4
            // 
            this.optionTable4.AutoSize = true;
            this.optionTable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTable4.Location = new System.Drawing.Point(292, 169);
            this.optionTable4.Name = "optionTable4";
            this.optionTable4.Size = new System.Drawing.Size(75, 19);
            this.optionTable4.TabIndex = 3;
            this.optionTable4.TabStop = true;
            this.optionTable4.Text = "WorksOn";
            this.optionTable4.UseVisualStyleBackColor = true;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.Location = new System.Drawing.Point(306, 9);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(124, 16);
            this.title2.TabIndex = 4;
            this.title2.Text = "Tablas disponibles";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(12, 9);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(120, 16);
            this.title1.TabIndex = 5;
            this.title1.Text = "Numero de Inserts:";
            // 
            // numberInsertsTX
            // 
            this.numberInsertsTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInsertsTX.Location = new System.Drawing.Point(138, 6);
            this.numberInsertsTX.Name = "numberInsertsTX";
            this.numberInsertsTX.Size = new System.Drawing.Size(100, 21);
            this.numberInsertsTX.TabIndex = 6;
            // 
            // image1
            // 
            this.image1.Image = ((System.Drawing.Image)(resources.GetObject("image1.Image")));
            this.image1.Location = new System.Drawing.Point(-32, 67);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(207, 123);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 7;
            this.image1.TabStop = false;
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(163, 112);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Generar";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 200);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.numberInsertsTX);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.optionTable4);
            this.Controls.Add(this.optionTable3);
            this.Controls.Add(this.optionTable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autogenerate Inserts SQL";
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optionTable1;
        private System.Windows.Forms.RadioButton optionTable3;
        private System.Windows.Forms.RadioButton optionTable4;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.TextBox numberInsertsTX;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button generateButton;
    }
}
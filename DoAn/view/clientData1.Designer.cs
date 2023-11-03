namespace DoAn.view
{
    partial class clientData1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientData1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientName = new System.Windows.Forms.Label();
            this.clientPhone = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.clientAdress = new System.Windows.Forms.Label();
            this.clientBook = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // clientName
            // 
            this.clientName.AutoEllipsis = true;
            this.clientName.AutoSize = true;
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(113, 13);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(145, 29);
            this.clientName.TabIndex = 1;
            this.clientName.Text = "clientName";
            // 
            // clientPhone
            // 
            this.clientPhone.AutoEllipsis = true;
            this.clientPhone.AutoSize = true;
            this.clientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPhone.Location = new System.Drawing.Point(125, 62);
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.Size = new System.Drawing.Size(115, 22);
            this.clientPhone.TabIndex = 2;
            this.clientPhone.Text = "clientPhone";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(639, 39);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 3;
            this.view.Text = "viewMore";
            this.view.UseVisualStyleBackColor = true;
            // 
            // clientAdress
            // 
            this.clientAdress.AutoEllipsis = true;
            this.clientAdress.AutoSize = true;
            this.clientAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAdress.Location = new System.Drawing.Point(297, 62);
            this.clientAdress.Name = "clientAdress";
            this.clientAdress.Size = new System.Drawing.Size(120, 22);
            this.clientAdress.TabIndex = 4;
            this.clientAdress.Text = "clientAdress";
            // 
            // clientBook
            // 
            this.clientBook.AutoEllipsis = true;
            this.clientBook.AutoSize = true;
            this.clientBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBook.Location = new System.Drawing.Point(494, 62);
            this.clientBook.Name = "clientBook";
            this.clientBook.Size = new System.Drawing.Size(103, 22);
            this.clientBook.TabIndex = 5;
            this.clientBook.Text = "clientBook";
            // 
            // clientData1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.clientBook);
            this.Controls.Add(this.clientAdress);
            this.Controls.Add(this.view);
            this.Controls.Add(this.clientPhone);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "clientData1";
            this.Size = new System.Drawing.Size(723, 109);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.Label clientPhone;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label clientAdress;
        private System.Windows.Forms.Label clientBook;
    }
}

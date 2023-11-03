namespace DoAn.view
{
    partial class adminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.clientLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clientData11 = new DoAn.view.clientData1();
            this.loadMorebtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.pageCountLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.clientLayout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 92);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(342, 4);
            this.Title.Margin = new System.Windows.Forms.Padding(3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(299, 84);
            this.Title.TabIndex = 1;
            this.Title.Text = "Library Manager";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientLayout
            // 
            this.clientLayout.AutoScroll = true;
            this.clientLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientLayout.Controls.Add(this.panel2);
            this.clientLayout.Location = new System.Drawing.Point(12, 115);
            this.clientLayout.Name = "clientLayout";
            this.clientLayout.Size = new System.Drawing.Size(771, 526);
            this.clientLayout.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prevBtn);
            this.panel2.Controls.Add(this.pageCountLabel);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 54);
            this.panel2.TabIndex = 4;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(515, 16);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clientData11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 526);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // clientData11
            // 
            this.clientData11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientData11.CustomerName = "clientName";
            this.clientData11.CustomerPhone = "clientPhone";
            this.clientData11.Location = new System.Drawing.Point(3, 3);
            this.clientData11.Name = "clientData11";
            this.clientData11.RentedBooksCount = "clientBook";
            this.clientData11.Size = new System.Drawing.Size(723, 109);
            this.clientData11.TabIndex = 0;
            // 
            // loadMorebtn
            // 
            this.loadMorebtn.Location = new System.Drawing.Point(333, 16);
            this.loadMorebtn.Name = "loadMorebtn";
            this.loadMorebtn.Size = new System.Drawing.Size(75, 23);
            this.loadMorebtn.TabIndex = 0;
            this.loadMorebtn.Text = "loadMorebtn";
            this.loadMorebtn.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(596, 16);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 1;
            this.prevBtn.Text = "prevBtn";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // pageCountLabel
            // 
            this.pageCountLabel.AutoSize = true;
            this.pageCountLabel.Location = new System.Drawing.Point(687, 23);
            this.pageCountLabel.Name = "pageCountLabel";
            this.pageCountLabel.Size = new System.Drawing.Size(39, 16);
            this.pageCountLabel.TabIndex = 5;
            this.pageCountLabel.Text = "count";
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.clientLayout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.clientLayout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel clientLayout;
        private clientData1 clientData11;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loadMorebtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Label pageCountLabel;
    }
}
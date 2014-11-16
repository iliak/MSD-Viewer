namespace OBM
{
	partial class MainForm
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ouvrirToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.enregistrerToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.copierToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.t_header = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.t_subheader = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.t_width = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.t_height = new System.Windows.Forms.TextBox();
			this.t_binary = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.t_name = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.t_size = new System.Windows.Forms.TextBox();
			this.pixelformat = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(664, 490);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripButton,
            this.enregistrerToolStripButton,
            this.toolStripSeparator,
            this.copierToolStripButton,
            this.toolStripSeparator1,
            this.ToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1190, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// ouvrirToolStripButton
			// 
			this.ouvrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ouvrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripButton.Image")));
			this.ouvrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ouvrirToolStripButton.Name = "ouvrirToolStripButton";
			this.ouvrirToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.ouvrirToolStripButton.Text = "&Ouvrir";
			this.ouvrirToolStripButton.Click += new System.EventHandler(this.ouvrirToolStripButton_Click);
			// 
			// enregistrerToolStripButton
			// 
			this.enregistrerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.enregistrerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripButton.Image")));
			this.enregistrerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.enregistrerToolStripButton.Name = "enregistrerToolStripButton";
			this.enregistrerToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.enregistrerToolStripButton.Text = "&Enregistrer";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// copierToolStripButton
			// 
			this.copierToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.copierToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripButton.Image")));
			this.copierToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copierToolStripButton.Name = "copierToolStripButton";
			this.copierToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.copierToolStripButton.Text = "Co&pier";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripButton
			// 
			this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
			this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripButton.Name = "ToolStripButton";
			this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.ToolStripButton.Text = "&?";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(296, 31);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(882, 695);
			this.panel1.TabIndex = 2;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 31);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(155, 693);
			this.listBox1.TabIndex = 3;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// t_header
			// 
			this.t_header.Location = new System.Drawing.Point(252, 104);
			this.t_header.Name = "t_header";
			this.t_header.ReadOnly = true;
			this.t_header.Size = new System.Drawing.Size(41, 20);
			this.t_header.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(170, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Header :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(170, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Sub Header :";
			// 
			// t_subheader
			// 
			this.t_subheader.Location = new System.Drawing.Point(252, 130);
			this.t_subheader.Name = "t_subheader";
			this.t_subheader.ReadOnly = true;
			this.t_subheader.Size = new System.Drawing.Size(41, 20);
			this.t_subheader.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(170, 223);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Width :";
			// 
			// t_width
			// 
			this.t_width.Location = new System.Drawing.Point(249, 220);
			this.t_width.Name = "t_width";
			this.t_width.ReadOnly = true;
			this.t_width.Size = new System.Drawing.Size(41, 20);
			this.t_width.TabIndex = 9;
			this.t_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(170, 249);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Height :";
			// 
			// t_height
			// 
			this.t_height.Location = new System.Drawing.Point(249, 246);
			this.t_height.Name = "t_height";
			this.t_height.ReadOnly = true;
			this.t_height.Size = new System.Drawing.Size(41, 20);
			this.t_height.TabIndex = 11;
			this.t_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// t_binary
			// 
			this.t_binary.Location = new System.Drawing.Point(188, 156);
			this.t_binary.Name = "t_binary";
			this.t_binary.ReadOnly = true;
			this.t_binary.Size = new System.Drawing.Size(105, 20);
			this.t_binary.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(173, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Name :";
			// 
			// t_name
			// 
			this.t_name.Location = new System.Drawing.Point(173, 52);
			this.t_name.Name = "t_name";
			this.t_name.ReadOnly = true;
			this.t_name.Size = new System.Drawing.Size(120, 20);
			this.t_name.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(173, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 13);
			this.label7.TabIndex = 19;
			this.label7.Text = "Size :";
			// 
			// t_size
			// 
			this.t_size.Location = new System.Drawing.Point(212, 78);
			this.t_size.Name = "t_size";
			this.t_size.ReadOnly = true;
			this.t_size.Size = new System.Drawing.Size(81, 20);
			this.t_size.TabIndex = 18;
			this.t_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// pixelformat
			// 
			this.pixelformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.pixelformat.FormattingEnabled = true;
			this.pixelformat.Location = new System.Drawing.Point(173, 376);
			this.pixelformat.Name = "pixelformat";
			this.pixelformat.Size = new System.Drawing.Size(117, 21);
			this.pixelformat.Sorted = true;
			this.pixelformat.TabIndex = 22;
			this.pixelformat.SelectedIndexChanged += new System.EventHandler(this.pixelformat_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(173, 360);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Pixel format :";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(173, 703);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "UPDATE !";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1190, 738);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pixelformat);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.t_size);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.t_name);
			this.Controls.Add(this.t_binary);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.t_height);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.t_width);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.t_subheader);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.t_header);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "Metal Slug Defense ripper";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton ouvrirToolStripButton;
		private System.Windows.Forms.ToolStripButton enregistrerToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton copierToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton ToolStripButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox t_header;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox t_subheader;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox t_width;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox t_height;
		private System.Windows.Forms.TextBox t_binary;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox t_name;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox t_size;
		private System.Windows.Forms.ComboBox pixelformat;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
	}
}


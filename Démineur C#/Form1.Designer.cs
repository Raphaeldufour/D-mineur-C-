namespace Démineur_C_
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
			components = new System.ComponentModel.Container();
			TableLayoutPanel1 = new TableLayoutPanel();
			timer1 = new System.Windows.Forms.Timer(components);
			tempsEcoule = new Label();
			minesRestantes = new Label();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// TableLayoutPanel1
			// 
			TableLayoutPanel1.Anchor = AnchorStyles.None;
			TableLayoutPanel1.AutoSize = true;
			TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			TableLayoutPanel1.Location = new Point(275, 117);
			TableLayoutPanel1.Margin = new Padding(0);
			TableLayoutPanel1.Name = "TableLayoutPanel1";
			TableLayoutPanel1.Size = new Size(20, 0);
			TableLayoutPanel1.TabIndex = 0;
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// tempsEcoule
			// 
			tempsEcoule.AutoSize = true;
			tempsEcoule.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
			tempsEcoule.Location = new Point(0, 0);
			tempsEcoule.Margin = new Padding(7, 0, 7, 0);
			tempsEcoule.Name = "tempsEcoule";
			tempsEcoule.Size = new Size(0, 40);
			tempsEcoule.TabIndex = 1;
			// 
			// minesRestantes
			// 
			minesRestantes.AutoSize = true;
			minesRestantes.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point);
			minesRestantes.Location = new Point(0, 74);
			minesRestantes.Margin = new Padding(7, 0, 7, 0);
			minesRestantes.Name = "minesRestantes";
			minesRestantes.Size = new Size(55, 40);
			minesRestantes.TabIndex = 2;
			minesRestantes.Text = "40";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.minesweeper___icon_by_glassjester128_dei6h4b_fullview;
			pictureBox1.Location = new Point(47, 63);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(52, 54);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.Location = new Point(0, 136);
			button1.Name = "button1";
			button1.Size = new Size(131, 47);
			button1.TabIndex = 4;
			button1.Text = "Quitter";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(126, 213, 255);
			ClientSize = new Size(1904, 1055);
			Controls.Add(button1);
			Controls.Add(pictureBox1);
			Controls.Add(minesRestantes);
			Controls.Add(tempsEcoule);
			Controls.Add(TableLayoutPanel1);
			Font = new Font("Arial", 20F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(7, 6, 7, 6);
			Name = "Form1";
			Text = "Form1";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel TableLayoutPanel1;
		private Label timer;
		private System.Windows.Forms.Timer timer1;
		private Label tempsEcoule;
		private Label minesRestantes;
		private PictureBox pictureBox1;
		private Button button1;
	}
}
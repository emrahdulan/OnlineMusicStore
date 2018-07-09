namespace OnlineMusicStore.UI.SalesOrderForms
{
	partial class OrderHistoryForm
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
			this.SOGridView = new System.Windows.Forms.DataGridView();
			this.DetailsButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SOGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// SOGridView
			// 
			this.SOGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SOGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SOGridView.Location = new System.Drawing.Point(0, 41);
			this.SOGridView.Name = "SOGridView";
			this.SOGridView.Size = new System.Drawing.Size(800, 409);
			this.SOGridView.TabIndex = 0;
			// 
			// DetailsButton
			// 
			this.DetailsButton.Location = new System.Drawing.Point(672, 12);
			this.DetailsButton.Name = "DetailsButton";
			this.DetailsButton.Size = new System.Drawing.Size(116, 23);
			this.DetailsButton.TabIndex = 1;
			this.DetailsButton.Text = "Details";
			this.DetailsButton.UseVisualStyleBackColor = true;
			this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
			// 
			// OrderHistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DetailsButton);
			this.Controls.Add(this.SOGridView);
			this.Name = "OrderHistoryForm";
			this.Text = "OrderHistoryForm";
			this.Load += new System.EventHandler(this.OrderHistoryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.SOGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView SOGridView;
		private System.Windows.Forms.Button DetailsButton;
	}
}
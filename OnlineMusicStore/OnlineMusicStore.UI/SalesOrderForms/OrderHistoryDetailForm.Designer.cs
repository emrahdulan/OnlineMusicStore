namespace OnlineMusicStore.UI.SalesOrderForms
{
	partial class OrderHistoryDetailForm
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
			this.PriceLabel = new System.Windows.Forms.Label();
			this.TotalLabel = new System.Windows.Forms.Label();
			this.SODGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.SODGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PriceLabel.Location = new System.Drawing.Point(109, 9);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(0, 31);
			this.PriceLabel.TabIndex = 4;
			// 
			// TotalLabel
			// 
			this.TotalLabel.AutoSize = true;
			this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TotalLabel.Location = new System.Drawing.Point(12, 9);
			this.TotalLabel.Name = "TotalLabel";
			this.TotalLabel.Size = new System.Drawing.Size(90, 31);
			this.TotalLabel.TabIndex = 3;
			this.TotalLabel.Text = "Total: ";
			// 
			// SODGridView
			// 
			this.SODGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SODGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SODGridView.Location = new System.Drawing.Point(0, 43);
			this.SODGridView.Name = "SODGridView";
			this.SODGridView.Size = new System.Drawing.Size(800, 407);
			this.SODGridView.TabIndex = 5;
			// 
			// OrderHistoryDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SODGridView);
			this.Controls.Add(this.PriceLabel);
			this.Controls.Add(this.TotalLabel);
			this.Name = "OrderHistoryDetailForm";
			this.Text = "OrderHistoryDetailForm";
			((System.ComponentModel.ISupportInitialize)(this.SODGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.Label TotalLabel;
		private System.Windows.Forms.DataGridView SODGridView;
	}
}
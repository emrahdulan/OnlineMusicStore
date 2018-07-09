namespace OnlineMusicStore.UI.SalesOrderForms
{
	partial class CartDetailForm
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
			this.SODGridView = new System.Windows.Forms.DataGridView();
			this.TotalLabel = new System.Windows.Forms.Label();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.DeleteAllButton = new System.Windows.Forms.Button();
			this.BuyButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SODGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// SODGridView
			// 
			this.SODGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SODGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SODGridView.Location = new System.Drawing.Point(0, 69);
			this.SODGridView.MultiSelect = false;
			this.SODGridView.Name = "SODGridView";
			this.SODGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.SODGridView.Size = new System.Drawing.Size(800, 381);
			this.SODGridView.TabIndex = 0;
			// 
			// TotalLabel
			// 
			this.TotalLabel.AutoSize = true;
			this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TotalLabel.Location = new System.Drawing.Point(13, 13);
			this.TotalLabel.Name = "TotalLabel";
			this.TotalLabel.Size = new System.Drawing.Size(90, 31);
			this.TotalLabel.TabIndex = 1;
			this.TotalLabel.Text = "Total: ";
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.PriceLabel.Location = new System.Drawing.Point(110, 13);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(0, 31);
			this.PriceLabel.TabIndex = 2;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(540, 23);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(76, 23);
			this.DeleteButton.TabIndex = 32;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// DeleteAllButton
			// 
			this.DeleteAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteAllButton.Location = new System.Drawing.Point(622, 23);
			this.DeleteAllButton.Name = "DeleteAllButton";
			this.DeleteAllButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteAllButton.TabIndex = 31;
			this.DeleteAllButton.Text = "Delete All";
			this.DeleteAllButton.UseVisualStyleBackColor = true;
			this.DeleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
			// 
			// BuyButton
			// 
			this.BuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BuyButton.Location = new System.Drawing.Point(703, 23);
			this.BuyButton.Name = "BuyButton";
			this.BuyButton.Size = new System.Drawing.Size(75, 23);
			this.BuyButton.TabIndex = 30;
			this.BuyButton.Text = "Buy";
			this.BuyButton.UseVisualStyleBackColor = true;
			this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
			// 
			// CartDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.DeleteAllButton);
			this.Controls.Add(this.BuyButton);
			this.Controls.Add(this.PriceLabel);
			this.Controls.Add(this.TotalLabel);
			this.Controls.Add(this.SODGridView);
			this.Name = "CartDetailForm";
			this.Text = "CartDetailForm";
			this.Load += new System.EventHandler(this.CartDetailForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.SODGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView SODGridView;
		private System.Windows.Forms.Label TotalLabel;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button DeleteAllButton;
		private System.Windows.Forms.Button BuyButton;
	}
}
namespace FrmKinect
{
	partial class Form1
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
			this.bStream = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblConnectionID = new System.Windows.Forms.Label();
			this.pbKinectStream = new System.Windows.Forms.PictureBox();
			this.lblPosition = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbKinectStream)).BeginInit();
			this.SuspendLayout();
			// 
			// bStream
			// 
			this.bStream.Location = new System.Drawing.Point(608, 476);
			this.bStream.Name = "bStream";
			this.bStream.Size = new System.Drawing.Size(75, 23);
			this.bStream.TabIndex = 0;
			this.bStream.Text = "stream";
			this.bStream.UseVisualStyleBackColor = true;
			this.bStream.Click += new System.EventHandler(this.bStream_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Statut :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Connection ID :";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(53, 9);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(10, 13);
			this.lblStatus.TabIndex = 3;
			this.lblStatus.Text = "-";
			// 
			// lblConnectionID
			// 
			this.lblConnectionID.AutoSize = true;
			this.lblConnectionID.Location = new System.Drawing.Point(99, 38);
			this.lblConnectionID.Name = "lblConnectionID";
			this.lblConnectionID.Size = new System.Drawing.Size(10, 13);
			this.lblConnectionID.TabIndex = 4;
			this.lblConnectionID.Text = "-";
			// 
			// pbKinectStream
			// 
			this.pbKinectStream.Location = new System.Drawing.Point(13, 64);
			this.pbKinectStream.Name = "pbKinectStream";
			this.pbKinectStream.Size = new System.Drawing.Size(699, 394);
			this.pbKinectStream.TabIndex = 5;
			this.pbKinectStream.TabStop = false;
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Location = new System.Drawing.Point(448, 38);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(13, 13);
			this.lblPosition.TabIndex = 6;
			this.lblPosition.Text = "--";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 525);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.pbKinectStream);
			this.Controls.Add(this.lblConnectionID);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bStream);
			this.Name = "Form1";
			this.Text = "Kinect Stream";
			((System.ComponentModel.ISupportInitialize)(this.pbKinectStream)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bStream;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblConnectionID;
		private System.Windows.Forms.PictureBox pbKinectStream;
		private System.Windows.Forms.Label lblPosition;
	}
}


﻿namespace CampingAdventure
{
    partial class campingAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(campingAdventure));
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.blueImage = new System.Windows.Forms.PictureBox();
            this.redImage = new System.Windows.Forms.PictureBox();
            this.yellowImage = new System.Windows.Forms.PictureBox();
            this.yellowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(36, 43);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(509, 396);
            this.outputLabel.TabIndex = 2;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.ForeColor = System.Drawing.Color.White;
            this.redLabel.Location = new System.Drawing.Point(101, 481);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(386, 35);
            this.redLabel.TabIndex = 3;
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.ForeColor = System.Drawing.Color.White;
            this.blueLabel.Location = new System.Drawing.Point(101, 537);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(386, 35);
            this.blueLabel.TabIndex = 4;
            // 
            // blueImage
            // 
            this.blueImage.Image = global::CampingAdventure.Properties.Resources.blue_50x50;
            this.blueImage.Location = new System.Drawing.Point(36, 522);
            this.blueImage.Name = "blueImage";
            this.blueImage.Size = new System.Drawing.Size(59, 50);
            this.blueImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueImage.TabIndex = 1;
            this.blueImage.TabStop = false;
            // 
            // redImage
            // 
            this.redImage.Image = global::CampingAdventure.Properties.Resources.red_50x50;
            this.redImage.Location = new System.Drawing.Point(36, 466);
            this.redImage.Name = "redImage";
            this.redImage.Size = new System.Drawing.Size(59, 50);
            this.redImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redImage.TabIndex = 0;
            this.redImage.TabStop = false;
            // 
            // yellowImage
            // 
            this.yellowImage.Image = global::CampingAdventure.Properties.Resources.yellow_50x50;
            this.yellowImage.Location = new System.Drawing.Point(36, 578);
            this.yellowImage.Name = "yellowImage";
            this.yellowImage.Size = new System.Drawing.Size(59, 50);
            this.yellowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowImage.TabIndex = 5;
            this.yellowImage.TabStop = false;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.ForeColor = System.Drawing.Color.White;
            this.yellowLabel.Location = new System.Drawing.Point(101, 593);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(386, 35);
            this.yellowLabel.TabIndex = 6;
            // 
            // campingAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(579, 649);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.yellowImage);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueImage);
            this.Controls.Add(this.redImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "campingAdventure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost in a Forest";
//            this.Load += new System.EventHandler(this.campingAdventure_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.blueImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redImage;
        private System.Windows.Forms.PictureBox blueImage;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.PictureBox yellowImage;
        private System.Windows.Forms.Label yellowLabel;
    }
}


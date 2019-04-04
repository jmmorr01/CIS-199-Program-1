namespace Prog1
{
    partial class Program1
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
            this.wallSpaceInput = new System.Windows.Forms.TextBox();
            this.coatsOfPaintInput = new System.Windows.Forms.TextBox();
            this.pricePerGallonInput = new System.Windows.Forms.TextBox();
            this.pricePerGallonLabel = new System.Windows.Forms.Label();
            this.coatsOfPaintLabel = new System.Windows.Forms.Label();
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.squareFeetOutput = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.gallonsOutput = new System.Windows.Forms.Label();
            this.hoursOfLaborOutput = new System.Windows.Forms.Label();
            this.costOfPaintOutput = new System.Windows.Forms.Label();
            this.costOfLaborOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.totalSqFtLabel = new System.Windows.Forms.Label();
            this.gallonsOfPaintTotalLabel = new System.Windows.Forms.Label();
            this.hoursOfLaborLabel = new System.Windows.Forms.Label();
            this.costOfPaintLabel = new System.Windows.Forms.Label();
            this.costOfLaborLabel = new System.Windows.Forms.Label();
            this.totalCostOfJobLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallSpaceInput
            // 
            this.wallSpaceInput.Location = new System.Drawing.Point(164, 12);
            this.wallSpaceInput.Name = "wallSpaceInput";
            this.wallSpaceInput.Size = new System.Drawing.Size(100, 20);
            this.wallSpaceInput.TabIndex = 0;
            // 
            // coatsOfPaintInput
            // 
            this.coatsOfPaintInput.Location = new System.Drawing.Point(164, 53);
            this.coatsOfPaintInput.Name = "coatsOfPaintInput";
            this.coatsOfPaintInput.Size = new System.Drawing.Size(100, 20);
            this.coatsOfPaintInput.TabIndex = 1;
            // 
            // pricePerGallonInput
            // 
            this.pricePerGallonInput.Location = new System.Drawing.Point(164, 97);
            this.pricePerGallonInput.Name = "pricePerGallonInput";
            this.pricePerGallonInput.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonInput.TabIndex = 2;
            // 
            // pricePerGallonLabel
            // 
            this.pricePerGallonLabel.AutoSize = true;
            this.pricePerGallonLabel.Location = new System.Drawing.Point(58, 104);
            this.pricePerGallonLabel.Name = "pricePerGallonLabel";
            this.pricePerGallonLabel.Size = new System.Drawing.Size(86, 13);
            this.pricePerGallonLabel.TabIndex = 3;
            this.pricePerGallonLabel.Text = "Price Per Gallon:";
            // 
            // coatsOfPaintLabel
            // 
            this.coatsOfPaintLabel.AutoSize = true;
            this.coatsOfPaintLabel.Location = new System.Drawing.Point(29, 60);
            this.coatsOfPaintLabel.Name = "coatsOfPaintLabel";
            this.coatsOfPaintLabel.Size = new System.Drawing.Size(115, 13);
            this.coatsOfPaintLabel.TabIndex = 4;
            this.coatsOfPaintLabel.Text = "Coats of Paint Desired:";
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.AutoSize = true;
            this.wallSpaceLabel.Location = new System.Drawing.Point(53, 19);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(91, 13);
            this.wallSpaceLabel.TabIndex = 5;
            this.wallSpaceLabel.Text = "Wall Space (sqft):";
            // 
            // squareFeetOutput
            // 
            this.squareFeetOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.squareFeetOutput.Location = new System.Drawing.Point(164, 223);
            this.squareFeetOutput.Name = "squareFeetOutput";
            this.squareFeetOutput.Size = new System.Drawing.Size(100, 23);
            this.squareFeetOutput.TabIndex = 6;
            this.squareFeetOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(101, 158);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // gallonsOutput
            // 
            this.gallonsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsOutput.Location = new System.Drawing.Point(164, 265);
            this.gallonsOutput.Name = "gallonsOutput";
            this.gallonsOutput.Size = new System.Drawing.Size(100, 23);
            this.gallonsOutput.TabIndex = 8;
            this.gallonsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursOfLaborOutput
            // 
            this.hoursOfLaborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOfLaborOutput.Location = new System.Drawing.Point(164, 306);
            this.hoursOfLaborOutput.Name = "hoursOfLaborOutput";
            this.hoursOfLaborOutput.Size = new System.Drawing.Size(100, 23);
            this.hoursOfLaborOutput.TabIndex = 9;
            this.hoursOfLaborOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costOfPaintOutput
            // 
            this.costOfPaintOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfPaintOutput.Location = new System.Drawing.Point(164, 349);
            this.costOfPaintOutput.Name = "costOfPaintOutput";
            this.costOfPaintOutput.Size = new System.Drawing.Size(100, 23);
            this.costOfPaintOutput.TabIndex = 10;
            this.costOfPaintOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costOfLaborOutput
            // 
            this.costOfLaborOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costOfLaborOutput.Location = new System.Drawing.Point(164, 388);
            this.costOfLaborOutput.Name = "costOfLaborOutput";
            this.costOfLaborOutput.Size = new System.Drawing.Size(100, 23);
            this.costOfLaborOutput.TabIndex = 11;
            this.costOfLaborOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(164, 428);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(100, 23);
            this.totalCostOutput.TabIndex = 12;
            this.totalCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSqFtLabel
            // 
            this.totalSqFtLabel.AutoSize = true;
            this.totalSqFtLabel.Location = new System.Drawing.Point(63, 233);
            this.totalSqFtLabel.Name = "totalSqFtLabel";
            this.totalSqFtLabel.Size = new System.Drawing.Size(95, 13);
            this.totalSqFtLabel.TabIndex = 13;
            this.totalSqFtLabel.Text = "Total Square Feet:";
            // 
            // gallonsOfPaintTotalLabel
            // 
            this.gallonsOfPaintTotalLabel.AutoSize = true;
            this.gallonsOfPaintTotalLabel.Location = new System.Drawing.Point(28, 275);
            this.gallonsOfPaintTotalLabel.Name = "gallonsOfPaintTotalLabel";
            this.gallonsOfPaintTotalLabel.Size = new System.Drawing.Size(130, 13);
            this.gallonsOfPaintTotalLabel.TabIndex = 14;
            this.gallonsOfPaintTotalLabel.Text = "Gallons of Paint Required:";
            // 
            // hoursOfLaborLabel
            // 
            this.hoursOfLaborLabel.AutoSize = true;
            this.hoursOfLaborLabel.Location = new System.Drawing.Point(26, 316);
            this.hoursOfLaborLabel.Name = "hoursOfLaborLabel";
            this.hoursOfLaborLabel.Size = new System.Drawing.Size(132, 13);
            this.hoursOfLaborLabel.TabIndex = 15;
            this.hoursOfLaborLabel.Text = "Hours of Labour Required:";
            // 
            // costOfPaintLabel
            // 
            this.costOfPaintLabel.AutoSize = true;
            this.costOfPaintLabel.Location = new System.Drawing.Point(88, 359);
            this.costOfPaintLabel.Name = "costOfPaintLabel";
            this.costOfPaintLabel.Size = new System.Drawing.Size(70, 13);
            this.costOfPaintLabel.TabIndex = 16;
            this.costOfPaintLabel.Text = "Cost of Paint:";
            // 
            // costOfLaborLabel
            // 
            this.costOfLaborLabel.AutoSize = true;
            this.costOfLaborLabel.Location = new System.Drawing.Point(85, 398);
            this.costOfLaborLabel.Name = "costOfLaborLabel";
            this.costOfLaborLabel.Size = new System.Drawing.Size(73, 13);
            this.costOfLaborLabel.TabIndex = 17;
            this.costOfLaborLabel.Text = "Cost of Labor:";
            // 
            // totalCostOfJobLabel
            // 
            this.totalCostOfJobLabel.AutoSize = true;
            this.totalCostOfJobLabel.Location = new System.Drawing.Point(100, 438);
            this.totalCostOfJobLabel.Name = "totalCostOfJobLabel";
            this.totalCostOfJobLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostOfJobLabel.TabIndex = 18;
            this.totalCostOfJobLabel.Text = "Total Cost:";
            // 
            // Program1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 463);
            this.Controls.Add(this.totalCostOfJobLabel);
            this.Controls.Add(this.costOfLaborLabel);
            this.Controls.Add(this.costOfPaintLabel);
            this.Controls.Add(this.hoursOfLaborLabel);
            this.Controls.Add(this.gallonsOfPaintTotalLabel);
            this.Controls.Add(this.totalSqFtLabel);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.costOfLaborOutput);
            this.Controls.Add(this.costOfPaintOutput);
            this.Controls.Add(this.hoursOfLaborOutput);
            this.Controls.Add(this.gallonsOutput);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.squareFeetOutput);
            this.Controls.Add(this.wallSpaceLabel);
            this.Controls.Add(this.coatsOfPaintLabel);
            this.Controls.Add(this.pricePerGallonLabel);
            this.Controls.Add(this.pricePerGallonInput);
            this.Controls.Add(this.coatsOfPaintInput);
            this.Controls.Add(this.wallSpaceInput);
            this.Name = "Program1";
            this.Text = "Program1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wallSpaceInput;
        private System.Windows.Forms.TextBox coatsOfPaintInput;
        private System.Windows.Forms.TextBox pricePerGallonInput;
        private System.Windows.Forms.Label pricePerGallonLabel;
        private System.Windows.Forms.Label coatsOfPaintLabel;
        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.Label squareFeetOutput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label gallonsOutput;
        private System.Windows.Forms.Label hoursOfLaborOutput;
        private System.Windows.Forms.Label costOfPaintOutput;
        private System.Windows.Forms.Label costOfLaborOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label totalSqFtLabel;
        private System.Windows.Forms.Label gallonsOfPaintTotalLabel;
        private System.Windows.Forms.Label hoursOfLaborLabel;
        private System.Windows.Forms.Label costOfPaintLabel;
        private System.Windows.Forms.Label costOfLaborLabel;
        private System.Windows.Forms.Label totalCostOfJobLabel;
    }
}


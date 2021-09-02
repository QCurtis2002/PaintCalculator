
namespace PaintCalculator
{
    partial class PaintCalculator
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
            this.grpMeasurement = new System.Windows.Forms.GroupBox();
            this.rdoFeetInches = new System.Windows.Forms.RadioButton();
            this.rdoMeters = new System.Windows.Forms.RadioButton();
            this.rdoCentimeters = new System.Windows.Forms.RadioButton();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblLengthInches = new System.Windows.Forms.Label();
            this.lblHeightInches = new System.Windows.Forms.Label();
            this.lblWidthInches = new System.Windows.Forms.Label();
            this.txtLengthInches = new System.Windows.Forms.TextBox();
            this.txtHeightInches = new System.Windows.Forms.TextBox();
            this.txtWidthInches = new System.Windows.Forms.TextBox();
            this.lblLengthMeasurement = new System.Windows.Forms.Label();
            this.lblHeightMeasurement = new System.Windows.Forms.Label();
            this.lblWidthMeasurement = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtRoomVolume = new System.Windows.Forms.TextBox();
            this.txtPaintRequired = new System.Windows.Forms.TextBox();
            this.txtFloorArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupCoats = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDisplayUnits = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdoDisplayFeetInches = new System.Windows.Forms.RadioButton();
            this.rdoDisplayInches = new System.Windows.Forms.RadioButton();
            this.rdoDisplayFeet = new System.Windows.Forms.RadioButton();
            this.grpMeasurement.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoats)).BeginInit();
            this.grpDisplayUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMeasurement
            // 
            this.grpMeasurement.Controls.Add(this.rdoFeetInches);
            this.grpMeasurement.Controls.Add(this.rdoMeters);
            this.grpMeasurement.Controls.Add(this.rdoCentimeters);
            this.grpMeasurement.Location = new System.Drawing.Point(38, 80);
            this.grpMeasurement.Name = "grpMeasurement";
            this.grpMeasurement.Size = new System.Drawing.Size(201, 133);
            this.grpMeasurement.TabIndex = 0;
            this.grpMeasurement.TabStop = false;
            this.grpMeasurement.Text = "Measurement";
            // 
            // rdoFeetInches
            // 
            this.rdoFeetInches.AutoSize = true;
            this.rdoFeetInches.Location = new System.Drawing.Point(54, 98);
            this.rdoFeetInches.Name = "rdoFeetInches";
            this.rdoFeetInches.Size = new System.Drawing.Size(86, 19);
            this.rdoFeetInches.TabIndex = 2;
            this.rdoFeetInches.TabStop = true;
            this.rdoFeetInches.Text = "Feet/Inches";
            this.rdoFeetInches.UseVisualStyleBackColor = true;
            this.rdoFeetInches.CheckedChanged += new System.EventHandler(this.rdoFeetInches_CheckedChanged);
            // 
            // rdoMeters
            // 
            this.rdoMeters.AutoSize = true;
            this.rdoMeters.Location = new System.Drawing.Point(54, 50);
            this.rdoMeters.Name = "rdoMeters";
            this.rdoMeters.Size = new System.Drawing.Size(61, 19);
            this.rdoMeters.TabIndex = 1;
            this.rdoMeters.TabStop = true;
            this.rdoMeters.Text = "Meters";
            this.rdoMeters.UseVisualStyleBackColor = true;
            this.rdoMeters.CheckedChanged += new System.EventHandler(this.rdoMeters_CheckedChanged);
            // 
            // rdoCentimeters
            // 
            this.rdoCentimeters.AutoSize = true;
            this.rdoCentimeters.Location = new System.Drawing.Point(54, 25);
            this.rdoCentimeters.Name = "rdoCentimeters";
            this.rdoCentimeters.Size = new System.Drawing.Size(89, 19);
            this.rdoCentimeters.TabIndex = 0;
            this.rdoCentimeters.TabStop = true;
            this.rdoCentimeters.Text = "Centimeters";
            this.rdoCentimeters.UseVisualStyleBackColor = true;
            this.rdoCentimeters.CheckedChanged += new System.EventHandler(this.rdoCentimeters_CheckedChanged);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblLengthInches);
            this.grpInput.Controls.Add(this.lblHeightInches);
            this.grpInput.Controls.Add(this.lblWidthInches);
            this.grpInput.Controls.Add(this.txtLengthInches);
            this.grpInput.Controls.Add(this.txtHeightInches);
            this.grpInput.Controls.Add(this.txtWidthInches);
            this.grpInput.Controls.Add(this.lblLengthMeasurement);
            this.grpInput.Controls.Add(this.lblHeightMeasurement);
            this.grpInput.Controls.Add(this.lblWidthMeasurement);
            this.grpInput.Controls.Add(this.txtLength);
            this.grpInput.Controls.Add(this.txtHeight);
            this.grpInput.Controls.Add(this.txtWidth);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Location = new System.Drawing.Point(285, 67);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(271, 172);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input:";
            // 
            // lblLengthInches
            // 
            this.lblLengthInches.AutoSize = true;
            this.lblLengthInches.Location = new System.Drawing.Point(247, 107);
            this.lblLengthInches.Name = "lblLengthInches";
            this.lblLengthInches.Size = new System.Drawing.Size(17, 15);
            this.lblLengthInches.TabIndex = 14;
            this.lblLengthInches.Text = "In";
            this.lblLengthInches.Visible = false;
            // 
            // lblHeightInches
            // 
            this.lblHeightInches.AutoSize = true;
            this.lblHeightInches.Location = new System.Drawing.Point(247, 75);
            this.lblHeightInches.Name = "lblHeightInches";
            this.lblHeightInches.Size = new System.Drawing.Size(17, 15);
            this.lblHeightInches.TabIndex = 13;
            this.lblHeightInches.Text = "In";
            this.lblHeightInches.Visible = false;
            // 
            // lblWidthInches
            // 
            this.lblWidthInches.AutoSize = true;
            this.lblWidthInches.Location = new System.Drawing.Point(247, 39);
            this.lblWidthInches.Name = "lblWidthInches";
            this.lblWidthInches.Size = new System.Drawing.Size(17, 15);
            this.lblWidthInches.TabIndex = 12;
            this.lblWidthInches.Text = "In";
            this.lblWidthInches.Visible = false;
            // 
            // txtLengthInches
            // 
            this.txtLengthInches.Location = new System.Drawing.Point(195, 99);
            this.txtLengthInches.Name = "txtLengthInches";
            this.txtLengthInches.Size = new System.Drawing.Size(51, 23);
            this.txtLengthInches.TabIndex = 11;
            this.txtLengthInches.Visible = false;
            // 
            // txtHeightInches
            // 
            this.txtHeightInches.Location = new System.Drawing.Point(195, 67);
            this.txtHeightInches.Name = "txtHeightInches";
            this.txtHeightInches.Size = new System.Drawing.Size(51, 23);
            this.txtHeightInches.TabIndex = 10;
            this.txtHeightInches.Visible = false;
            // 
            // txtWidthInches
            // 
            this.txtWidthInches.Location = new System.Drawing.Point(195, 31);
            this.txtWidthInches.Name = "txtWidthInches";
            this.txtWidthInches.Size = new System.Drawing.Size(51, 23);
            this.txtWidthInches.TabIndex = 9;
            this.txtWidthInches.Visible = false;
            // 
            // lblLengthMeasurement
            // 
            this.lblLengthMeasurement.AutoSize = true;
            this.lblLengthMeasurement.Location = new System.Drawing.Point(165, 107);
            this.lblLengthMeasurement.Name = "lblLengthMeasurement";
            this.lblLengthMeasurement.Size = new System.Drawing.Size(24, 15);
            this.lblLengthMeasurement.TabIndex = 8;
            this.lblLengthMeasurement.Text = "cm";
            // 
            // lblHeightMeasurement
            // 
            this.lblHeightMeasurement.AutoSize = true;
            this.lblHeightMeasurement.Location = new System.Drawing.Point(165, 75);
            this.lblHeightMeasurement.Name = "lblHeightMeasurement";
            this.lblHeightMeasurement.Size = new System.Drawing.Size(24, 15);
            this.lblHeightMeasurement.TabIndex = 7;
            this.lblHeightMeasurement.Text = "cm";
            // 
            // lblWidthMeasurement
            // 
            this.lblWidthMeasurement.AutoSize = true;
            this.lblWidthMeasurement.Location = new System.Drawing.Point(165, 39);
            this.lblWidthMeasurement.Name = "lblWidthMeasurement";
            this.lblWidthMeasurement.Size = new System.Drawing.Size(24, 15);
            this.lblWidthMeasurement.TabIndex = 6;
            this.lblWidthMeasurement.Text = "cm";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(89, 99);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(74, 23);
            this.txtLength.TabIndex = 5;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(89, 67);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(74, 23);
            this.txtHeight.TabIndex = 4;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(89, 31);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(74, 23);
            this.txtWidth.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width:";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.txtRoomVolume);
            this.grpOutput.Controls.Add(this.txtPaintRequired);
            this.grpOutput.Controls.Add(this.txtFloorArea);
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.label6);
            this.grpOutput.Controls.Add(this.label5);
            this.grpOutput.Location = new System.Drawing.Point(310, 291);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(246, 172);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output:";
            // 
            // txtRoomVolume
            // 
            this.txtRoomVolume.Location = new System.Drawing.Point(135, 94);
            this.txtRoomVolume.Name = "txtRoomVolume";
            this.txtRoomVolume.ReadOnly = true;
            this.txtRoomVolume.Size = new System.Drawing.Size(100, 23);
            this.txtRoomVolume.TabIndex = 5;
            // 
            // txtPaintRequired
            // 
            this.txtPaintRequired.Location = new System.Drawing.Point(135, 65);
            this.txtPaintRequired.Name = "txtPaintRequired";
            this.txtPaintRequired.ReadOnly = true;
            this.txtPaintRequired.Size = new System.Drawing.Size(100, 23);
            this.txtPaintRequired.TabIndex = 4;
            // 
            // txtFloorArea
            // 
            this.txtFloorArea.Location = new System.Drawing.Point(135, 36);
            this.txtFloorArea.Name = "txtFloorArea";
            this.txtFloorArea.ReadOnly = true;
            this.txtFloorArea.Size = new System.Drawing.Size(100, 23);
            this.txtFloorArea.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Volume of the room:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Paint Required (liters):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Floor Area:";
            // 
            // nupCoats
            // 
            this.nupCoats.Location = new System.Drawing.Point(688, 101);
            this.nupCoats.Name = "nupCoats";
            this.nupCoats.Size = new System.Drawing.Size(32, 23);
            this.nupCoats.TabIndex = 3;
            this.nupCoats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(607, 161);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Coats:";
            // 
            // grpDisplayUnits
            // 
            this.grpDisplayUnits.Controls.Add(this.label9);
            this.grpDisplayUnits.Controls.Add(this.label8);
            this.grpDisplayUnits.Controls.Add(this.rdoDisplayFeetInches);
            this.grpDisplayUnits.Controls.Add(this.rdoDisplayInches);
            this.grpDisplayUnits.Controls.Add(this.rdoDisplayFeet);
            this.grpDisplayUnits.Location = new System.Drawing.Point(581, 245);
            this.grpDisplayUnits.Name = "grpDisplayUnits";
            this.grpDisplayUnits.Size = new System.Drawing.Size(170, 158);
            this.grpDisplayUnits.TabIndex = 6;
            this.grpDisplayUnits.TabStop = false;
            this.grpDisplayUnits.Text = "Display Units:";
            this.grpDisplayUnits.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = " 1 Ft³ = 1728 In³";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "1 Ft² = 144 In²";
            // 
            // rdoDisplayFeetInches
            // 
            this.rdoDisplayFeetInches.AutoSize = true;
            this.rdoDisplayFeetInches.Location = new System.Drawing.Point(26, 71);
            this.rdoDisplayFeetInches.Name = "rdoDisplayFeetInches";
            this.rdoDisplayFeetInches.Size = new System.Drawing.Size(107, 19);
            this.rdoDisplayFeetInches.TabIndex = 2;
            this.rdoDisplayFeetInches.Text = "Feet and Inches";
            this.rdoDisplayFeetInches.UseVisualStyleBackColor = true;
            // 
            // rdoDisplayInches
            // 
            this.rdoDisplayInches.AutoSize = true;
            this.rdoDisplayInches.Location = new System.Drawing.Point(26, 46);
            this.rdoDisplayInches.Name = "rdoDisplayInches";
            this.rdoDisplayInches.Size = new System.Drawing.Size(59, 19);
            this.rdoDisplayInches.TabIndex = 1;
            this.rdoDisplayInches.Text = "Inches";
            this.rdoDisplayInches.UseVisualStyleBackColor = true;
            // 
            // rdoDisplayFeet
            // 
            this.rdoDisplayFeet.AutoSize = true;
            this.rdoDisplayFeet.Checked = true;
            this.rdoDisplayFeet.Location = new System.Drawing.Point(26, 22);
            this.rdoDisplayFeet.Name = "rdoDisplayFeet";
            this.rdoDisplayFeet.Size = new System.Drawing.Size(47, 19);
            this.rdoDisplayFeet.TabIndex = 0;
            this.rdoDisplayFeet.TabStop = true;
            this.rdoDisplayFeet.Text = "Feet";
            this.rdoDisplayFeet.UseVisualStyleBackColor = true;
            // 
            // PaintCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.grpDisplayUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nupCoats);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpMeasurement);
            this.Name = "PaintCalculator";
            this.Text = "Paint Calculator";
            this.Load += new System.EventHandler(this.PaintCalculator_Load);
            this.grpMeasurement.ResumeLayout(false);
            this.grpMeasurement.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoats)).EndInit();
            this.grpDisplayUnits.ResumeLayout(false);
            this.grpDisplayUnits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMeasurement;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.NumericUpDown nupCoats;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rdoFeetInches;
        private System.Windows.Forms.RadioButton rdoMeters;
        private System.Windows.Forms.RadioButton rdoCentimeters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLengthMeasurement;
        private System.Windows.Forms.Label lblHeightMeasurement;
        private System.Windows.Forms.Label lblWidthMeasurement;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblLengthInches;
        private System.Windows.Forms.Label lblHeightInches;
        private System.Windows.Forms.Label lblWidthInches;
        private System.Windows.Forms.TextBox txtLengthInches;
        private System.Windows.Forms.TextBox txtHeightInches;
        private System.Windows.Forms.TextBox txtWidthInches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRoomVolume;
        private System.Windows.Forms.TextBox txtPaintRequired;
        private System.Windows.Forms.TextBox txtFloorArea;
        private System.Windows.Forms.GroupBox grpDisplayUnits;
        private System.Windows.Forms.RadioButton rdoDisplayFeetInches;
        private System.Windows.Forms.RadioButton rdoDisplayInches;
        private System.Windows.Forms.RadioButton rdoDisplayFeet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}


namespace Card_Store
{
    partial class frmCardStore
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
            lblOccasions = new Label();
            lblStyles = new Label();
            lblTotalCost = new Label();
            chkEnvelope = new CheckBox();
            chkStamp = new CheckBox();
            chkCustomMessage = new CheckBox();
            txtCustomMessage = new RichTextBox();
            ddlOccasions = new ComboBox();
            ddlStyles = new ComboBox();
            pbCard = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCard).BeginInit();
            SuspendLayout();
            // 
            // lblOccasions
            // 
            lblOccasions.AutoSize = true;
            lblOccasions.Location = new Point(9, 17);
            lblOccasions.Name = "lblOccasions";
            lblOccasions.Size = new Size(61, 15);
            lblOccasions.TabIndex = 0;
            lblOccasions.Text = "Occasions";
            // 
            // lblStyles
            // 
            lblStyles.AutoSize = true;
            lblStyles.Location = new Point(9, 59);
            lblStyles.Name = "lblStyles";
            lblStyles.Size = new Size(32, 15);
            lblStyles.TabIndex = 1;
            lblStyles.Text = "Style";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 12F);
            lblTotalCost.Location = new Point(9, 407);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(80, 21);
            lblTotalCost.TabIndex = 2;
            lblTotalCost.Text = "Total Cost:";
            // 
            // chkEnvelope
            // 
            chkEnvelope.AutoSize = true;
            chkEnvelope.Location = new Point(9, 118);
            chkEnvelope.Name = "chkEnvelope";
            chkEnvelope.Size = new Size(112, 19);
            chkEnvelope.TabIndex = 3;
            chkEnvelope.Text = "Envelope ($0.25)";
            chkEnvelope.UseVisualStyleBackColor = true;
            chkEnvelope.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkStamp
            // 
            chkStamp.AutoSize = true;
            chkStamp.Location = new Point(9, 153);
            chkStamp.Name = "chkStamp";
            chkStamp.Size = new Size(98, 19);
            chkStamp.TabIndex = 4;
            chkStamp.Text = "Stamp ($0.50)";
            chkStamp.UseVisualStyleBackColor = true;
            chkStamp.CheckedChanged += chkBox_CheckedChanged;
            // 
            // chkCustomMessage
            // 
            chkCustomMessage.AutoSize = true;
            chkCustomMessage.Location = new Point(9, 191);
            chkCustomMessage.Name = "chkCustomMessage";
            chkCustomMessage.Size = new Size(155, 19);
            chkCustomMessage.TabIndex = 5;
            chkCustomMessage.Text = "Custom Message ($0.30)";
            chkCustomMessage.UseVisualStyleBackColor = true;
            chkCustomMessage.CheckedChanged += chkCustomMessage_CheckedChanged;
            // 
            // txtCustomMessage
            // 
            txtCustomMessage.Location = new Point(10, 216);
            txtCustomMessage.Name = "txtCustomMessage";
            txtCustomMessage.Size = new Size(233, 169);
            txtCustomMessage.TabIndex = 6;
            txtCustomMessage.Text = "";
            txtCustomMessage.TextChanged += txtCustomMessage_TextChanged;
            // 
            // ddlOccasions
            // 
            ddlOccasions.FormattingEnabled = true;
            ddlOccasions.Location = new Point(77, 17);
            ddlOccasions.Name = "ddlOccasions";
            ddlOccasions.Size = new Size(121, 23);
            ddlOccasions.TabIndex = 7;
            ddlOccasions.SelectedIndexChanged += ddlOccasions_SelectedIndexChanged;
            // 
            // ddlStyles
            // 
            ddlStyles.FormattingEnabled = true;
            ddlStyles.Location = new Point(77, 59);
            ddlStyles.Name = "ddlStyles";
            ddlStyles.Size = new Size(121, 23);
            ddlStyles.TabIndex = 8;
            ddlStyles.SelectedIndexChanged += ddlStyles_SelectedIndexChanged;
            // 
            // pbCard
            // 
            pbCard.Location = new Point(274, 17);
            pbCard.Name = "pbCard";
            pbCard.Size = new Size(514, 397);
            pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCard.TabIndex = 9;
            pbCard.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(193, 405);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmCardStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(pbCard);
            Controls.Add(ddlStyles);
            Controls.Add(ddlOccasions);
            Controls.Add(txtCustomMessage);
            Controls.Add(chkCustomMessage);
            Controls.Add(chkStamp);
            Controls.Add(chkEnvelope);
            Controls.Add(lblTotalCost);
            Controls.Add(lblStyles);
            Controls.Add(lblOccasions);
            Name = "frmCardStore";
            Text = "Card Designer";
            Load += frmCardStore_Load;
            ((System.ComponentModel.ISupportInitialize)pbCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOccasions;
        private Label lblStyles;
        private Label lblTotalCost;
        private CheckBox chkEnvelope;
        private CheckBox chkStamp;
        private CheckBox chkCustomMessage;
        private RichTextBox txtCustomMessage;
        private ComboBox ddlOccasions;
        private ComboBox ddlStyles;
        private PictureBox pbCard;
        private Button btnExit;
    }
}

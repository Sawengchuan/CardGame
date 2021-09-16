
namespace WinFormsTestClient
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
            this.lbSuit = new System.Windows.Forms.ListBox();
            this.lbRank = new System.Windows.Forms.ListBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSelectedText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSuit
            // 
            this.lbSuit.FormattingEnabled = true;
            this.lbSuit.ItemHeight = 15;
            this.lbSuit.Items.AddRange(new object[] {
            "Heart",
            "Spade",
            "Diamond",
            "Club"});
            this.lbSuit.Location = new System.Drawing.Point(47, 102);
            this.lbSuit.Name = "lbSuit";
            this.lbSuit.Size = new System.Drawing.Size(120, 79);
            this.lbSuit.TabIndex = 0;
            // 
            // lbRank
            // 
            this.lbRank.FormattingEnabled = true;
            this.lbRank.ItemHeight = 15;
            this.lbRank.Items.AddRange(new object[] {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K"});
            this.lbRank.Location = new System.Drawing.Point(47, 187);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(120, 229);
            this.lbRank.TabIndex = 1;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(608, 102);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(124, 23);
            this.btnEvaluate.TabIndex = 2;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(497, 73);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbSelected
            // 
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.ItemHeight = 15;
            this.lbSelected.Location = new System.Drawing.Point(301, 102);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(271, 319);
            this.lbSelected.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(201, 157);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 189);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = ">>";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(608, 128);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(236, 79);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(301, 71);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 25);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSelectedText
            // 
            this.lblSelectedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedText.Location = new System.Drawing.Point(608, 220);
            this.lblSelectedText.Name = "lblSelectedText";
            this.lblSelectedText.Size = new System.Drawing.Size(236, 196);
            this.lblSelectedText.TabIndex = 8;
            this.lblSelectedText.Text = "selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 483);
            this.Controls.Add(this.lblSelectedText);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.lbSuit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSuit;
        private System.Windows.Forms.ListBox lbRank;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lbSelected;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSelectedText;
    }
}


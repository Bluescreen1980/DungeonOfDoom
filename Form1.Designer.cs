namespace DungeonOfDoom
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.goNorth = new System.Windows.Forms.Button();
            this.goWest = new System.Windows.Forms.Button();
            this.goSouth = new System.Windows.Forms.Button();
            this.goEast = new System.Windows.Forms.Button();
            this.xyLabel = new System.Windows.Forms.Label();
            this.textField = new System.Windows.Forms.Label();
            this.actionLook = new System.Windows.Forms.Button();
            this.actionUse = new System.Windows.Forms.Button();
            this.actionItem = new System.Windows.Forms.Button();
            this.itemBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageFrame = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.goNorth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.goWest, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.goSouth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.goEast, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.xyLabel, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(766, 530);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.60241F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // goNorth
            // 
            this.goNorth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.goNorth.AutoSize = true;
            this.goNorth.Location = new System.Drawing.Point(88, 13);
            this.goNorth.Name = "goNorth";
            this.goNorth.Size = new System.Drawing.Size(75, 26);
            this.goNorth.TabIndex = 0;
            this.goNorth.Text = "North";
            this.goNorth.UseVisualStyleBackColor = true;
            this.goNorth.Click += new System.EventHandler(this.goNorth_Click);
            // 
            // goWest
            // 
            this.goWest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.goWest.AutoSize = true;
            this.goWest.Enabled = false;
            this.goWest.Location = new System.Drawing.Point(6, 49);
            this.goWest.Name = "goWest";
            this.goWest.Size = new System.Drawing.Size(75, 26);
            this.goWest.TabIndex = 1;
            this.goWest.Text = "West";
            this.goWest.UseVisualStyleBackColor = true;
            this.goWest.Click += new System.EventHandler(this.goWest_Click);
            // 
            // goSouth
            // 
            this.goSouth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.goSouth.AutoSize = true;
            this.goSouth.Enabled = false;
            this.goSouth.Location = new System.Drawing.Point(88, 86);
            this.goSouth.Name = "goSouth";
            this.goSouth.Size = new System.Drawing.Size(75, 26);
            this.goSouth.TabIndex = 2;
            this.goSouth.Text = "South";
            this.goSouth.UseVisualStyleBackColor = true;
            this.goSouth.Click += new System.EventHandler(this.goSouth_Click);
            // 
            // goEast
            // 
            this.goEast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.goEast.AutoSize = true;
            this.goEast.Enabled = false;
            this.goEast.Location = new System.Drawing.Point(171, 49);
            this.goEast.Name = "goEast";
            this.goEast.Size = new System.Drawing.Size(75, 26);
            this.goEast.TabIndex = 3;
            this.goEast.Text = "East";
            this.goEast.UseVisualStyleBackColor = true;
            this.goEast.Click += new System.EventHandler(this.goEast_Click);
            // 
            // xyLabel
            // 
            this.xyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xyLabel.AutoSize = true;
            this.xyLabel.Location = new System.Drawing.Point(114, 54);
            this.xyLabel.Name = "xyLabel";
            this.xyLabel.Size = new System.Drawing.Size(23, 16);
            this.xyLabel.TabIndex = 4;
            this.xyLabel.Text = "x,y";
            this.xyLabel.Click += new System.EventHandler(this.xyLabel_Click);
            // 
            // textField
            // 
            this.textField.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textField.Location = new System.Drawing.Point(12, 527);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(729, 73);
            this.textField.TabIndex = 2;
            this.textField.Text = resources.GetString("textField.Text");
            this.textField.Click += new System.EventHandler(this.textField_Click);
            // 
            // actionLook
            // 
            this.actionLook.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLook.Location = new System.Drawing.Point(16, 605);
            this.actionLook.Name = "actionLook";
            this.actionLook.Size = new System.Drawing.Size(85, 49);
            this.actionLook.TabIndex = 3;
            this.actionLook.Text = "Look";
            this.actionLook.UseVisualStyleBackColor = true;
            this.actionLook.Click += new System.EventHandler(this.button1_Click);
            // 
            // actionUse
            // 
            this.actionUse.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionUse.Location = new System.Drawing.Point(107, 605);
            this.actionUse.Name = "actionUse";
            this.actionUse.Size = new System.Drawing.Size(89, 49);
            this.actionUse.TabIndex = 4;
            this.actionUse.Text = "Loot";
            this.actionUse.UseVisualStyleBackColor = true;
            this.actionUse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // actionItem
            // 
            this.actionItem.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionItem.Location = new System.Drawing.Point(330, 605);
            this.actionItem.Name = "actionItem";
            this.actionItem.Size = new System.Drawing.Size(138, 49);
            this.actionItem.TabIndex = 5;
            this.actionItem.Text = "Use item";
            this.actionItem.UseVisualStyleBackColor = true;
            this.actionItem.Click += new System.EventHandler(this.actionItem_Click);
            // 
            // itemBox
            // 
            this.itemBox.Font = new System.Drawing.Font("Noto Naskh Arabic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemBox.Location = new System.Drawing.Point(474, 605);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(322, 49);
            this.itemBox.TabIndex = 6;
            this.itemBox.Text = "Items: -";
            this.itemBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Noto Sans Armenian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Examine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // imageFrame
            // 
            this.imageFrame.Location = new System.Drawing.Point(77, 3);
            this.imageFrame.Name = "imageFrame";
            this.imageFrame.Size = new System.Drawing.Size(830, 512);
            this.imageFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageFrame.TabIndex = 8;
            this.imageFrame.TabStop = false;
            this.imageFrame.Click += new System.EventHandler(this.imageFrame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 666);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.imageFrame);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.actionItem);
            this.Controls.Add(this.actionUse);
            this.Controls.Add(this.actionLook);
            this.Name = "Form1";
            this.Text = "Dungeon of Doom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button goNorth;
        private System.Windows.Forms.Button goWest;
        private System.Windows.Forms.Button goSouth;
        private System.Windows.Forms.Button goEast;
        private System.Windows.Forms.Label textField;
        private System.Windows.Forms.Button actionLook;
        private System.Windows.Forms.Button actionUse;
        private System.Windows.Forms.Button actionItem;
        private System.Windows.Forms.Label itemBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label xyLabel;
        private System.Windows.Forms.PictureBox imageFrame;
    }
}


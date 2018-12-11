namespace SketchPad
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
            this.drawPanel = new System.Windows.Forms.Panel();
            this.blackButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.colourLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.freeHandButton = new System.Windows.Forms.Button();
            this.straightButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.Window;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.CausesValidation = false;
            this.drawPanel.Location = new System.Drawing.Point(16, 25);
            this.drawPanel.MinimumSize = new System.Drawing.Size(200, 267);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(592, 279);
            this.drawPanel.TabIndex = 1;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            this.drawPanel.DoubleClick += new System.EventHandler(this.drawPanel_DoubleClick);
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // blackButton
            // 
            this.blackButton.AccessibleName = "Black";
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.FlatAppearance.BorderSize = 0;
            this.blackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackButton.Location = new System.Drawing.Point(1, 3);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(46, 41);
            this.blackButton.TabIndex = 8;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // redButton
            // 
            this.redButton.AccessibleName = "Red";
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatAppearance.BorderSize = 0;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(55, 3);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(44, 40);
            this.redButton.TabIndex = 10;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.AccessibleName = "Green";
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.FlatAppearance.BorderSize = 0;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Location = new System.Drawing.Point(105, 3);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(42, 40);
            this.greenButton.TabIndex = 12;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(44, 409);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(148, 13);
            this.modeLabel.TabIndex = 19;
            this.modeLabel.Text = "Current Mode: None Selected";
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(369, 409);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(107, 13);
            this.colourLabel.TabIndex = 20;
            this.colourLabel.Text = "Current Colour: Black";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(120, 0);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.freeHandButton);
            this.panel1.Controls.Add(this.straightButton);
            this.panel1.Controls.Add(this.polygonButton);
            this.panel1.Controls.Add(this.rectangleButton);
            this.panel1.Controls.Add(this.ellipseButton);
            this.panel1.Location = new System.Drawing.Point(295, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 53);
            this.panel1.TabIndex = 0;
            // 
            // freeHandButton
            // 
            this.freeHandButton.BackColor = System.Drawing.Color.White;
            this.freeHandButton.BackgroundImage = global::SketchPad.Properties.Resources.Squiggle1;
            this.freeHandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.freeHandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeHandButton.FlatAppearance.BorderSize = 0;
            this.freeHandButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.freeHandButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.freeHandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.freeHandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeHandButton.Location = new System.Drawing.Point(3, 8);
            this.freeHandButton.Name = "freeHandButton";
            this.freeHandButton.Size = new System.Drawing.Size(45, 35);
            this.freeHandButton.TabIndex = 2;
            this.freeHandButton.UseVisualStyleBackColor = false;
            this.freeHandButton.Click += new System.EventHandler(this.freeHandButton_Click);
            // 
            // straightButton
            // 
            this.straightButton.BackColor = System.Drawing.Color.White;
            this.straightButton.BackgroundImage = global::SketchPad.Properties.Resources.Straight;
            this.straightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.straightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.straightButton.FlatAppearance.BorderSize = 0;
            this.straightButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.straightButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.straightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.straightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.straightButton.Location = new System.Drawing.Point(65, 8);
            this.straightButton.Name = "straightButton";
            this.straightButton.Size = new System.Drawing.Size(45, 35);
            this.straightButton.TabIndex = 3;
            this.straightButton.UseVisualStyleBackColor = false;
            this.straightButton.Click += new System.EventHandler(this.straightButton_Click);
            // 
            // polygonButton
            // 
            this.polygonButton.BackColor = System.Drawing.Color.White;
            this.polygonButton.BackgroundImage = global::SketchPad.Properties.Resources.Polygon;
            this.polygonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.polygonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.polygonButton.FlatAppearance.BorderSize = 0;
            this.polygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.polygonButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.polygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polygonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polygonButton.Location = new System.Drawing.Point(258, 8);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(45, 35);
            this.polygonButton.TabIndex = 6;
            this.polygonButton.UseVisualStyleBackColor = false;
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackColor = System.Drawing.Color.White;
            this.rectangleButton.BackgroundImage = global::SketchPad.Properties.Resources.Rectangle3;
            this.rectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleButton.FlatAppearance.BorderSize = 0;
            this.rectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.rectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangleButton.Location = new System.Drawing.Point(131, 5);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(45, 35);
            this.rectangleButton.TabIndex = 4;
            this.rectangleButton.UseVisualStyleBackColor = false;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.BackColor = System.Drawing.Color.White;
            this.ellipseButton.BackgroundImage = global::SketchPad.Properties.Resources.Ellipse1;
            this.ellipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseButton.FlatAppearance.BorderSize = 0;
            this.ellipseButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.ellipseButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipseButton.Location = new System.Drawing.Point(198, 8);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(45, 35);
            this.ellipseButton.TabIndex = 5;
            this.ellipseButton.UseVisualStyleBackColor = false;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.blackButton);
            this.panel2.Controls.Add(this.greenButton);
            this.panel2.Controls.Add(this.redButton);
            this.panel2.Location = new System.Drawing.Point(141, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 53);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.copyButton);
            this.panel3.Controls.Add(this.moveButton);
            this.panel3.Location = new System.Drawing.Point(12, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 53);
            this.panel3.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.BackgroundImage = global::SketchPad.Properties.Resources.eraser;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(8, 8);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(30, 30);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.White;
            this.copyButton.BackgroundImage = global::SketchPad.Properties.Resources.copy;
            this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.copyButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Location = new System.Drawing.Point(44, 8);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(30, 30);
            this.copyButton.TabIndex = 22;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.BackColor = System.Drawing.Color.White;
            this.moveButton.BackgroundImage = global::SketchPad.Properties.Resources.Move;
            this.moveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveButton.FlatAppearance.BorderSize = 0;
            this.moveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.moveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(80, 8);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(30, 30);
            this.moveButton.TabIndex = 21;
            this.moveButton.UseVisualStyleBackColor = false;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(627, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.drawPanel);
            this.Name = "Form1";
            this.Text = "Simple Sketcher";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button freeHandButton;
        private System.Windows.Forms.Button straightButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}


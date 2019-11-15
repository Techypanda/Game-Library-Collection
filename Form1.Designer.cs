namespace Game_Collection
{
    partial class GameCollectionLibrary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCollectionLibrary));
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.platformText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.platformLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.searchL = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.binaryS = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.TextBox();
            this.Records = new System.Windows.Forms.Label();
            this.filenameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // gameListBox
            // 
            this.gameListBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 15;
            this.gameListBox.Location = new System.Drawing.Point(5, 5);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(267, 424);
            this.gameListBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.gameListBox, "List of games");
            this.gameListBox.SelectedIndexChanged += new System.EventHandler(this.gameListBox_SelectedIndexChanged);
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(619, 12);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(169, 23);
            this.nameText.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nameText, "Name To Input");
            // 
            // platformText
            // 
            this.platformText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformText.Location = new System.Drawing.Point(619, 38);
            this.platformText.Name = "platformText";
            this.platformText.Size = new System.Drawing.Size(169, 23);
            this.platformText.TabIndex = 2;
            this.toolTip1.SetToolTip(this.platformText, "Platform to input");
            // 
            // genreText
            // 
            this.genreText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreText.Location = new System.Drawing.Point(619, 64);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(169, 23);
            this.genreText.TabIndex = 3;
            this.toolTip1.SetToolTip(this.genreText, "Genre to input");
            // 
            // nameLabel
            // 
            this.nameLabel.AccessibleName = "";
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(564, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 18);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name: ";
            // 
            // platformLabel
            // 
            this.platformLabel.AccessibleName = "";
            this.platformLabel.AutoSize = true;
            this.platformLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platformLabel.Location = new System.Drawing.Point(545, 38);
            this.platformLabel.Name = "platformLabel";
            this.platformLabel.Size = new System.Drawing.Size(64, 18);
            this.platformLabel.TabIndex = 5;
            this.platformLabel.Text = "Platform:";
            this.platformLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.AccessibleName = "";
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(561, 64);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 18);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genre: ";
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(289, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(123, 39);
            this.add.TabIndex = 7;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(418, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 39);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(289, 47);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(123, 39);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(418, 47);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(123, 39);
            this.reset.TabIndex = 10;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // searchL
            // 
            this.searchL.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchL.Location = new System.Drawing.Point(418, 133);
            this.searchL.Name = "searchL";
            this.searchL.Size = new System.Drawing.Size(123, 39);
            this.searchL.TabIndex = 14;
            this.searchL.Text = "Linear Search";
            this.searchL.UseVisualStyleBackColor = true;
            this.searchL.Click += new System.EventHandler(this.searchL_Click);
            // 
            // sort
            // 
            this.sort.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.Location = new System.Drawing.Point(289, 133);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(123, 39);
            this.sort.TabIndex = 13;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // binaryS
            // 
            this.binaryS.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryS.Location = new System.Drawing.Point(418, 90);
            this.binaryS.Name = "binaryS";
            this.binaryS.Size = new System.Drawing.Size(123, 39);
            this.binaryS.TabIndex = 12;
            this.binaryS.Text = "Binary Search";
            this.binaryS.UseVisualStyleBackColor = true;
            this.binaryS.Click += new System.EventHandler(this.binaryS_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(289, 90);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(123, 39);
            this.update.TabIndex = 11;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.Location = new System.Drawing.Point(665, 176);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(123, 39);
            this.open.TabIndex = 16;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(289, 176);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 39);
            this.save.TabIndex = 15;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // countBox
            // 
            this.countBox.Enabled = false;
            this.countBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBox.Location = new System.Drawing.Point(767, 90);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(21, 23);
            this.countBox.TabIndex = 17;
            this.countBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.countBox, "Records in Arrays");
            // 
            // Records
            // 
            this.Records.AutoSize = true;
            this.Records.Location = new System.Drawing.Point(718, 93);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(47, 13);
            this.Records.TabIndex = 18;
            this.Records.Text = "Records";
            this.Records.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // filenameText
            // 
            this.filenameText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameText.Location = new System.Drawing.Point(619, 149);
            this.filenameText.Name = "filenameText";
            this.filenameText.Size = new System.Drawing.Size(169, 23);
            this.filenameText.TabIndex = 19;
            this.toolTip1.SetToolTip(this.filenameText, "Filename to open");
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filename:";
            // 
            // GameCollectionLibrary
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filenameText);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.searchL);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.binaryS);
            this.Controls.Add(this.update);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.platformLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.platformText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.gameListBox);
            this.Name = "GameCollectionLibrary";
            this.Text = "Game Collection Library";
            this.Load += new System.EventHandler(this.GameCollectionLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox gameListBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox platformText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label platformLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button searchL;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button binaryS;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Label Records;
        private System.Windows.Forms.TextBox filenameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


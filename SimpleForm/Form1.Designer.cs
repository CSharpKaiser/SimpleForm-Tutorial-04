namespace SimpleForm
{
    partial class fMain
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
            this.lvPeople = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colForename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvPeople
            // 
            this.lvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colForename,
            this.colSurname});
            this.lvPeople.HideSelection = false;
            this.lvPeople.Location = new System.Drawing.Point(12, 24);
            this.lvPeople.Name = "lvPeople";
            this.lvPeople.Size = new System.Drawing.Size(331, 271);
            this.lvPeople.TabIndex = 7;
            this.lvPeople.UseCompatibleStateImageBehavior = false;
            this.lvPeople.View = System.Windows.Forms.View.Details;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Title";
            // 
            // colForename
            // 
            this.colForename.Text = "Forename";
            this.colForename.Width = 100;
            // 
            // colSurname
            // 
            this.colSurname.Text = "Surname";
            this.colSurname.Width = 100;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(376, 39);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(96, 41);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Add Person";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 378);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lvPeople);
            this.Name = "fMain";
            this.Text = "Simple Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvPeople;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colForename;
        private System.Windows.Forms.ColumnHeader colSurname;
        private System.Windows.Forms.Button bAdd;
    }
}


namespace SamPad
{
    partial class SamPadWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SamPadWindow));
            this.ToolLine = new System.Windows.Forms.ToolStrip();
            this.Archive = new System.Windows.Forms.ToolStripSplitButton();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripSplitButton();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripSplitButton();
            this.WebSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.Properties = new System.Windows.Forms.ToolStripMenuItem();
            this.Visible = new System.Windows.Forms.ToolStripMenuItem();
            this.Hided = new System.Windows.Forms.ToolStripMenuItem();
            this.OnlyReading = new System.Windows.Forms.ToolStripMenuItem();
            this.Print = new System.Windows.Forms.ToolStripMenuItem();
            this.BackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Writing = new System.Windows.Forms.ToolStripMenuItem();
            this.Aplication = new System.Windows.Forms.ToolStripMenuItem();
            this.writeBox = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ToolLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolLine
            // 
            this.ToolLine.BackColor = System.Drawing.Color.White;
            this.ToolLine.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolLine.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archive,
            this.Edit,
            this.Tools});
            this.ToolLine.Location = new System.Drawing.Point(0, 0);
            this.ToolLine.Name = "ToolLine";
            this.ToolLine.Size = new System.Drawing.Size(763, 28);
            this.ToolLine.TabIndex = 1;
            this.ToolLine.Text = "toolStrip1";
            // 
            // Archive
            // 
            this.Archive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Archive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save,
            this.SaveAs,
            this.Format});
            this.Archive.Image = ((System.Drawing.Image)(resources.GetObject("Archive.Image")));
            this.Archive.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.Archive.Name = "Archive";
            this.Archive.Size = new System.Drawing.Size(88, 25);
            this.Archive.Text = "Archive";
            // 
            // New
            // 
            this.New.Image = global::SamPad.Properties.Resources.New;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(224, 26);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Open
            // 
            this.Open.Image = global::SamPad.Properties.Resources.Open;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(224, 26);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Image = global::SamPad.Properties.Resources.Save;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(224, 26);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.Image = global::SamPad.Properties.Resources.Save_as;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(224, 26);
            this.SaveAs.Text = "Save as...";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Format
            // 
            this.Format.Image = global::SamPad.Properties.Resources.Format;
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(224, 26);
            this.Format.Text = "Format";
            this.Format.Click += new System.EventHandler(this.Format_Click);
            // 
            // Edit
            // 
            this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cut,
            this.Copy,
            this.Paste,
            this.clearToolStripMenuItem,
            this.Redo,
            this.Undo});
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(60, 25);
            this.Edit.Text = "Edit";
            // 
            // Cut
            // 
            this.Cut.Image = global::SamPad.Properties.Resources.Cut;
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(224, 26);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Image = global::SamPad.Properties.Resources.Copy;
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(224, 26);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Image = global::SamPad.Properties.Resources.Paste;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(224, 26);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::SamPad.Properties.Resources.Clear;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Redo
            // 
            this.Redo.Enabled = false;
            this.Redo.Image = global::SamPad.Properties.Resources.Redo;
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(224, 26);
            this.Redo.Text = "Redo";
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // Undo
            // 
            this.Undo.Enabled = false;
            this.Undo.Image = global::SamPad.Properties.Resources.Undo;
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(224, 26);
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Tools
            // 
            this.Tools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WebSearch,
            this.Properties,
            this.Print,
            this.BackColor});
            this.Tools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(72, 25);
            this.Tools.Text = "Tools";
            this.Tools.ButtonClick += new System.EventHandler(this.Tools_ButtonClick);
            // 
            // WebSearch
            // 
            this.WebSearch.Image = global::SamPad.Properties.Resources.Web_Search;
            this.WebSearch.Name = "WebSearch";
            this.WebSearch.Size = new System.Drawing.Size(224, 26);
            this.WebSearch.Text = "Web searching";
            this.WebSearch.Click += new System.EventHandler(this.WebSearch_Click);
            // 
            // Properties
            // 
            this.Properties.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Visible,
            this.Hided,
            this.OnlyReading});
            this.Properties.Image = global::SamPad.Properties.Resources.Properties;
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(224, 26);
            this.Properties.Text = "Add properties";
            // 
            // Visible
            // 
            this.Visible.Image = global::SamPad.Properties.Resources.Visible;
            this.Visible.Name = "Visible";
            this.Visible.Size = new System.Drawing.Size(196, 26);
            this.Visible.Text = "Visible";
            this.Visible.Click += new System.EventHandler(this.Visible_Click);
            // 
            // Hided
            // 
            this.Hided.Image = global::SamPad.Properties.Resources.Hidden;
            this.Hided.Name = "Hided";
            this.Hided.Size = new System.Drawing.Size(196, 26);
            this.Hided.Text = "Hidden";
            this.Hided.Click += new System.EventHandler(this.Hided_Click);
            // 
            // OnlyReading
            // 
            this.OnlyReading.Image = global::SamPad.Properties.Resources.Read_only;
            this.OnlyReading.Name = "OnlyReading";
            this.OnlyReading.Size = new System.Drawing.Size(196, 26);
            this.OnlyReading.Text = "Only reading";
            this.OnlyReading.Click += new System.EventHandler(this.OnlyReading_Click);
            // 
            // Print
            // 
            this.Print.Image = global::SamPad.Properties.Resources.Print;
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(224, 26);
            this.Print.Text = "Print";
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // BackColor
            // 
            this.BackColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Writing,
            this.Aplication});
            this.BackColor.Image = global::SamPad.Properties.Resources.Back_color;
            this.BackColor.Name = "BackColor";
            this.BackColor.Size = new System.Drawing.Size(224, 26);
            this.BackColor.Text = "Back color";
            // 
            // Writing
            // 
            this.Writing.Image = global::SamPad.Properties.Resources.Writing;
            this.Writing.Name = "Writing";
            this.Writing.Size = new System.Drawing.Size(171, 26);
            this.Writing.Text = "Writing";
            this.Writing.Click += new System.EventHandler(this.Writing_Click);
            // 
            // Aplication
            // 
            this.Aplication.Image = global::SamPad.Properties.Resources.Aplication;
            this.Aplication.Name = "Aplication";
            this.Aplication.Size = new System.Drawing.Size(171, 26);
            this.Aplication.Text = "Aplication";
            this.Aplication.Click += new System.EventHandler(this.Aplication_Click);
            // 
            // writeBox
            // 
            this.writeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeBox.Location = new System.Drawing.Point(0, 27);
            this.writeBox.Multiline = true;
            this.writeBox.Name = "writeBox";
            this.writeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.writeBox.Size = new System.Drawing.Size(763, 552);
            this.writeBox.TabIndex = 2;
            this.writeBox.TextChanged += new System.EventHandler(this.writeBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // SamPadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 578);
            this.Controls.Add(this.writeBox);
            this.Controls.Add(this.ToolLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SamPadWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sam Pad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SamPadWindow_FormClosed);
            this.Load += new System.EventHandler(this.SamPadWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SamPadWindow_KeyDown);
            this.Resize += new System.EventHandler(this.SamPadWindow_Resize);
            this.ToolLine.ResumeLayout(false);
            this.ToolLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripSplitButton Archive;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripSplitButton Edit;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStrip ToolLine;
        private System.Windows.Forms.TextBox writeBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton Tools;
        private System.Windows.Forms.ToolStripMenuItem WebSearch;
        private System.Windows.Forms.ToolStripMenuItem Properties;
        private System.Windows.Forms.ToolStripMenuItem Visible;
        private System.Windows.Forms.ToolStripMenuItem Hided;
        private System.Windows.Forms.ToolStripMenuItem OnlyReading;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem Print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem BackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem Writing;
        private System.Windows.Forms.ToolStripMenuItem Aplication;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.ToolStripMenuItem Redo;
        private System.Windows.Forms.ToolStripMenuItem Undo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


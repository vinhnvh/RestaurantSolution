namespace Restaurant.UI
{
    partial class TableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTable = new Button();
            SuspendLayout();
            // 
            // btnTable
            // 
            btnTable.Dock = DockStyle.Fill;
            btnTable.Location = new Point(0, 0);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(150, 150);
            btnTable.TabIndex = 0;
            btnTable.Text = "button1";
            btnTable.UseVisualStyleBackColor = true;
            btnTable.Click += btnTable_Click;
            // 
            // TableControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTable);
            Name = "TableControl";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTable;
    }
}

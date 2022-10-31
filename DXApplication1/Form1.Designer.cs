namespace DXApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            this.spreadsheetFormulaBarPanel = new System.Windows.Forms.Panel();
            this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.splitterControl = new DevExpress.XtraEditors.SplitterControl();
            this.formulaBarNameBoxSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.spreadsheetNameBoxControl = new DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl();
            this.spreadsheetFormulaBarControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();


            ((System.ComponentModel.ISupportInitialize)(this.formulaBarNameBoxSplitContainerControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl.Properties)).BeginInit();


            this.SuspendLayout();

            this.spreadsheetFormulaBarPanel.SuspendLayout();
            this.spreadsheetFormulaBarPanel.Controls.Add(this.spreadsheetControl);
            this.spreadsheetFormulaBarPanel.Controls.Add(this.splitterControl);
            this.spreadsheetFormulaBarPanel.Controls.Add(this.formulaBarNameBoxSplitContainerControl);
            this.spreadsheetFormulaBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetFormulaBarPanel.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetFormulaBarPanel.Name = "spreadsheetFormulaBarPanel";
            this.spreadsheetFormulaBarPanel.Size = new System.Drawing.Size(499, 375);
            this.spreadsheetFormulaBarPanel.TabIndex = 3;
            this.spreadsheetFormulaBarPanel.ResumeLayout(false);
            this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl.Location = new System.Drawing.Point(0, 25);
            this.spreadsheetControl.Name = "spreadsheetControl";
            this.spreadsheetControl.Size = new System.Drawing.Size(499, 350);
            this.spreadsheetControl.TabIndex = 1;
            this.spreadsheetControl.Text = "spreadsheetControl1";
            this.splitterControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl.Location = new System.Drawing.Point(0, 20);
            this.splitterControl.MinSize = 20;
            this.splitterControl.Name = "splitterControl";
            this.splitterControl.Size = new System.Drawing.Size(499, 5);
            this.splitterControl.TabIndex = 2;
            this.splitterControl.TabStop = false;
            this.formulaBarNameBoxSplitContainerControl.SuspendLayout();
            this.formulaBarNameBoxSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.formulaBarNameBoxSplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.formulaBarNameBoxSplitContainerControl.Name = "formulaBarNameBoxSplitContainerControl";
            this.formulaBarNameBoxSplitContainerControl.Panel1.Controls.Add(this.spreadsheetNameBoxControl);
            this.formulaBarNameBoxSplitContainerControl.Panel2.Controls.Add(this.spreadsheetFormulaBarControl1);
            this.formulaBarNameBoxSplitContainerControl.Size = new System.Drawing.Size(499, 20);
            this.formulaBarNameBoxSplitContainerControl.SplitterPosition = 145;
            this.formulaBarNameBoxSplitContainerControl.TabIndex = 3;
            this.formulaBarNameBoxSplitContainerControl.ResumeLayout(false);
            this.spreadsheetNameBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetNameBoxControl.EditValue = "A1";
            this.spreadsheetNameBoxControl.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetNameBoxControl.Name = "spreadsheetNameBoxControl";
            this.spreadsheetNameBoxControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            this.spreadsheetNameBoxControl.Size = new System.Drawing.Size(145, 20);
            this.spreadsheetNameBoxControl.SpreadsheetControl = this.spreadsheetControl;
            this.spreadsheetNameBoxControl.TabIndex = 0;
            this.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetFormulaBarControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetFormulaBarControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1";
            this.spreadsheetFormulaBarControl1.Size = new System.Drawing.Size(349, 20);
            this.spreadsheetFormulaBarControl1.SpreadsheetControl = this.spreadsheetControl;
            this.spreadsheetFormulaBarControl1.TabIndex = 0;


            this.Name = "Form1";
            this.Text = "Form1";
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Controls.Add(this.spreadsheetFormulaBarPanel);



            ((System.ComponentModel.ISupportInitialize)(this.formulaBarNameBoxSplitContainerControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl.Properties)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel spreadsheetFormulaBarPanel;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl;
        private DevExpress.XtraEditors.SplitterControl splitterControl;
        private DevExpress.XtraEditors.SplitContainerControl formulaBarNameBoxSplitContainerControl;
        private DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl spreadsheetNameBoxControl;
        private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl spreadsheetFormulaBarControl1;

    }
}

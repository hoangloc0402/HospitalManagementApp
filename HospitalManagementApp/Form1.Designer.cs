namespace HospitalManagementApp
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
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab1 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon1");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup1 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("AAA");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab2 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon2");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab3 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon3");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab4 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon4");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("AAA");
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._Form1_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._Form1_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraToolbarsManager1
            // 
            this.ultraToolbarsManager1.DesignerFlags = 1;
            this.ultraToolbarsManager1.DockWithinContainer = this;
            this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            ribbonTab1.Caption = "ribbon1";
            ribbonGroup1.Caption = "ribbonGroup1";
            ribbonGroup1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1});
            ribbonTab1.Groups.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonGroup[] {
            ribbonGroup1});
            ribbonTab2.Caption = "ribbon2";
            ribbonTab3.Caption = "ribbon3";
            ribbonTab4.Caption = "ribbon4";
            this.ultraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonTab[] {
            ribbonTab1,
            ribbonTab2,
            ribbonTab3,
            ribbonTab4});
            this.ultraToolbarsManager1.Ribbon.Visible = true;
            buttonTool2.SharedPropsInternal.Caption = "AAA";
            this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool2});
            // 
            // _Form1_Toolbars_Dock_Area_Left
            // 
            this._Form1_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._Form1_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 8;
            this._Form1_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 187);
            this._Form1_Toolbars_Dock_Area_Left.Name = "_Form1_Toolbars_Dock_Area_Left";
            this._Form1_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(8, 271);
            this._Form1_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _Form1_Toolbars_Dock_Area_Right
            // 
            this._Form1_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._Form1_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 8;
            this._Form1_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(950, 187);
            this._Form1_Toolbars_Dock_Area_Right.Name = "_Form1_Toolbars_Dock_Area_Right";
            this._Form1_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(8, 271);
            this._Form1_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _Form1_Toolbars_Dock_Area_Top
            // 
            this._Form1_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._Form1_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._Form1_Toolbars_Dock_Area_Top.Name = "_Form1_Toolbars_Dock_Area_Top";
            this._Form1_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(958, 187);
            this._Form1_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _Form1_Toolbars_Dock_Area_Bottom
            // 
            this._Form1_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._Form1_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._Form1_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._Form1_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Form1_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 8;
            this._Form1_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 458);
            this._Form1_Toolbars_Dock_Area_Bottom.Name = "_Form1_Toolbars_Dock_Area_Bottom";
            this._Form1_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(958, 8);
            this._Form1_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 466);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this._Form1_Toolbars_Dock_Area_Top);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _Form1_Toolbars_Dock_Area_Top;
    }
}


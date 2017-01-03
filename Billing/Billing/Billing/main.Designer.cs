namespace Billing
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            this.Lable_Tip1 = new Infragistics.Win.Misc.UltraLabel();
            this.Text_Tip1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.Text_Tip2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.Lable_Tip2 = new Infragistics.Win.Misc.UltraLabel();
            this.Text_Tip3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.Lable_Tip3 = new Infragistics.Win.Misc.UltraLabel();
            this.search = new Infragistics.Win.Misc.UltraButton();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.save = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.Text_Tip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text_Tip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text_Tip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lable_Tip1
            // 
            this.Lable_Tip1.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Tip1.Location = new System.Drawing.Point(72, 48);
            this.Lable_Tip1.Name = "Lable_Tip1";
            this.Lable_Tip1.Size = new System.Drawing.Size(69, 25);
            this.Lable_Tip1.TabIndex = 0;
            this.Lable_Tip1.Text = "Tip1";
            // 
            // Text_Tip1
            // 
            this.Text_Tip1.Location = new System.Drawing.Point(120, 50);
            this.Text_Tip1.Name = "Text_Tip1";
            this.Text_Tip1.Size = new System.Drawing.Size(100, 21);
            this.Text_Tip1.TabIndex = 1;
            // 
            // Text_Tip2
            // 
            this.Text_Tip2.Location = new System.Drawing.Point(120, 90);
            this.Text_Tip2.Name = "Text_Tip2";
            this.Text_Tip2.Size = new System.Drawing.Size(100, 21);
            this.Text_Tip2.TabIndex = 3;
            // 
            // Lable_Tip2
            // 
            this.Lable_Tip2.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Tip2.Location = new System.Drawing.Point(72, 88);
            this.Lable_Tip2.Name = "Lable_Tip2";
            this.Lable_Tip2.Size = new System.Drawing.Size(69, 25);
            this.Lable_Tip2.TabIndex = 2;
            this.Lable_Tip2.Text = "Tip2";
            // 
            // Text_Tip3
            // 
            this.Text_Tip3.Location = new System.Drawing.Point(120, 126);
            this.Text_Tip3.Name = "Text_Tip3";
            this.Text_Tip3.Size = new System.Drawing.Size(100, 21);
            this.Text_Tip3.TabIndex = 5;
            // 
            // Lable_Tip3
            // 
            this.Lable_Tip3.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_Tip3.Location = new System.Drawing.Point(72, 124);
            this.Lable_Tip3.Name = "Lable_Tip3";
            this.Lable_Tip3.Size = new System.Drawing.Size(69, 25);
            this.Lable_Tip3.TabIndex = 4;
            this.Lable_Tip3.Text = "Tip3";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(120, 317);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 6;
            this.search.Text = "search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ultraGrid1
            // 
            appearance4.BackColor = System.Drawing.SystemColors.Window;
            appearance4.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance4;
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance1.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance1;
            appearance2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance2;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackColor2 = System.Drawing.SystemColors.Control;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            appearance12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance12;
            appearance7.BackColor = System.Drawing.SystemColors.Highlight;
            appearance7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance7;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance6.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance6;
            appearance5.BorderColor = System.Drawing.Color.Silver;
            appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance5;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance11.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance10.BackColor = System.Drawing.SystemColors.Window;
            appearance10.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance10;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid1.Location = new System.Drawing.Point(310, 50);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(735, 446);
            this.ultraGrid1.TabIndex = 7;
            this.ultraGrid1.Text = "ultraGrid1";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(120, 180);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 8;
            this.save.Text = "save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 614);
            this.Controls.Add(this.save);
            this.Controls.Add(this.ultraGrid1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Text_Tip3);
            this.Controls.Add(this.Lable_Tip3);
            this.Controls.Add(this.Text_Tip2);
            this.Controls.Add(this.Lable_Tip2);
            this.Controls.Add(this.Text_Tip1);
            this.Controls.Add(this.Lable_Tip1);
            this.Name = "Form_Main";
            this.Text = "main";
            ((System.ComponentModel.ISupportInitialize)(this.Text_Tip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text_Tip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text_Tip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel Lable_Tip1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor Text_Tip1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor Text_Tip2;
        private Infragistics.Win.Misc.UltraLabel Lable_Tip2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor Text_Tip3;
        private Infragistics.Win.Misc.UltraLabel Lable_Tip3;
        private Infragistics.Win.Misc.UltraButton search;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private Infragistics.Win.Misc.UltraButton save;
    }
}


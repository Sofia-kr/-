namespace ОБЗД
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableDoslid = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableDoslidnyk = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTableRoslyny = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціБДToolStripMenuItem,
            this.адмініструванняToolStripMenuItem,
            this.ToolStripMenuItem,
            this.проПрограмуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціБДToolStripMenuItem
            // 
            this.таблиціБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTableDoslid,
            this.OpenTableDoslidnyk,
            this.OpenTableRoslyny});
            this.таблиціБДToolStripMenuItem.Name = "таблиціБДToolStripMenuItem";
            this.таблиціБДToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.таблиціБДToolStripMenuItem.Text = "Таблиці БД";
            this.таблиціБДToolStripMenuItem.Click += new System.EventHandler(this.таблиціБДToolStripMenuItem_Click);
            // 
            // OpenTableDoslid
            // 
            this.OpenTableDoslid.Image = global::ОБЗД.Properties.Resources.Probirka;
            this.OpenTableDoslid.Name = "OpenTableDoslid";
            this.OpenTableDoslid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.OpenTableDoslid.Size = new System.Drawing.Size(233, 26);
            this.OpenTableDoslid.Text = "Дослідження";
            this.OpenTableDoslid.Click += new System.EventHandler(this.OpenTableDoslid_Click);
            // 
            // OpenTableDoslidnyk
            // 
            this.OpenTableDoslidnyk.Image = global::ОБЗД.Properties.Resources.Doslidnyk1;
            this.OpenTableDoslidnyk.Name = "OpenTableDoslidnyk";
            this.OpenTableDoslidnyk.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.OpenTableDoslidnyk.Size = new System.Drawing.Size(233, 26);
            this.OpenTableDoslidnyk.Text = "Дослідник";
            this.OpenTableDoslidnyk.Click += new System.EventHandler(this.OpenTableDoslidnyk_Click);
            // 
            // OpenTableRoslyny
            // 
            this.OpenTableRoslyny.Image = global::ОБЗД.Properties.Resources.Roslyny1;
            this.OpenTableRoslyny.Name = "OpenTableRoslyny";
            this.OpenTableRoslyny.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.OpenTableRoslyny.Size = new System.Drawing.Size(233, 26);
            this.OpenTableRoslyny.Text = "Рослини";
            this.OpenTableRoslyny.Click += new System.EventHandler(this.OpenTableRoslyny_Click);
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.ToolStripMenuItem.Text = "Калькулятор";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTableDoslid;
        private System.Windows.Forms.ToolStripMenuItem OpenTableDoslidnyk;
        private System.Windows.Forms.ToolStripMenuItem OpenTableRoslyny;
    }
}


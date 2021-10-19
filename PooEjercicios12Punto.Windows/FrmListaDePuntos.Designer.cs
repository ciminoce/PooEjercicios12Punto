
namespace PooEjercicios12Punto.Windows
{
    partial class FrmListaDePuntos
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.CantidadRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraHerramientasToolStrip = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ladoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MayorIgualLadoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenorIgualLadoMayorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IgualLadoMayorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.queToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascendentePorLadoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendentePorLadoMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendentePorSuperficieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrazo2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuadrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.BarraHerramientasToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CantidadRegistrosLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 566);
            this.splitContainer1.SplitterDistance = 444;
            this.splitContainer1.TabIndex = 7;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.AllowUserToResizeColumns = false;
            this.DatosDataGridView.AllowUserToResizeRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colX,
            this.colY,
            this.colTrazo,
            this.colTrazo2,
            this.colColor,
            this.colCuadrante});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1075, 444);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // CantidadRegistrosLabel
            // 
            this.CantidadRegistrosLabel.AutoSize = true;
            this.CantidadRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRegistrosLabel.Location = new System.Drawing.Point(142, 25);
            this.CantidadRegistrosLabel.Name = "CantidadRegistrosLabel";
            this.CantidadRegistrosLabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadRegistrosLabel.TabIndex = 0;
            this.CantidadRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // BarraHerramientasToolStrip
            // 
            this.BarraHerramientasToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.OrdenarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton});
            this.BarraHerramientasToolStrip.Location = new System.Drawing.Point(0, 0);
            this.BarraHerramientasToolStrip.Name = "BarraHerramientasToolStrip";
            this.BarraHerramientasToolStrip.Size = new System.Drawing.Size(1075, 58);
            this.BarraHerramientasToolStrip.TabIndex = 6;
            this.BarraHerramientasToolStrip.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.add_file_36px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.delete_file_36px;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.create_36px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladoMayorToolStripMenuItem});
            this.FiltrarToolStripButton.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.conversion_36px;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(50, 55);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ladoMayorToolStripMenuItem
            // 
            this.ladoMayorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MayorIgualLadoMayorToolStripMenuItem,
            this.MenorIgualLadoMayorToolStripMenuItem1,
            this.IgualLadoMayorToolStripMenuItem2,
            this.queToolStripMenuItem3});
            this.ladoMayorToolStripMenuItem.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.conversion_36px;
            this.ladoMayorToolStripMenuItem.Name = "ladoMayorToolStripMenuItem";
            this.ladoMayorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ladoMayorToolStripMenuItem.Text = "Lado Mayor";
            // 
            // MayorIgualLadoMayorToolStripMenuItem
            // 
            this.MayorIgualLadoMayorToolStripMenuItem.Name = "MayorIgualLadoMayorToolStripMenuItem";
            this.MayorIgualLadoMayorToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.MayorIgualLadoMayorToolStripMenuItem.Text = ">= Que";
            // 
            // MenorIgualLadoMayorToolStripMenuItem1
            // 
            this.MenorIgualLadoMayorToolStripMenuItem1.Name = "MenorIgualLadoMayorToolStripMenuItem1";
            this.MenorIgualLadoMayorToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.MenorIgualLadoMayorToolStripMenuItem1.Text = "<= Que";
            // 
            // IgualLadoMayorToolStripMenuItem2
            // 
            this.IgualLadoMayorToolStripMenuItem2.Name = "IgualLadoMayorToolStripMenuItem2";
            this.IgualLadoMayorToolStripMenuItem2.Size = new System.Drawing.Size(115, 22);
            this.IgualLadoMayorToolStripMenuItem2.Text = "= Que";
            // 
            // queToolStripMenuItem3
            // 
            this.queToolStripMenuItem3.Name = "queToolStripMenuItem3";
            this.queToolStripMenuItem3.Size = new System.Drawing.Size(115, 22);
            this.queToolStripMenuItem3.Text = "<> Que";
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendentePorLadoMayorToolStripMenuItem,
            this.descendentePorLadoMayorToolStripMenuItem,
            this.descendentePorSuperficieToolStripMenuItem});
            this.OrdenarToolStripButton.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.up_down_arrow_36px;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ascendentePorLadoMayorToolStripMenuItem
            // 
            this.ascendentePorLadoMayorToolStripMenuItem.Name = "ascendentePorLadoMayorToolStripMenuItem";
            this.ascendentePorLadoMayorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.ascendentePorLadoMayorToolStripMenuItem.Text = "Ascendente por Lado Mayor";
            // 
            // descendentePorLadoMayorToolStripMenuItem
            // 
            this.descendentePorLadoMayorToolStripMenuItem.Name = "descendentePorLadoMayorToolStripMenuItem";
            this.descendentePorLadoMayorToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.descendentePorLadoMayorToolStripMenuItem.Text = "Descendente por Lado Mayor";
            // 
            // descendentePorSuperficieToolStripMenuItem
            // 
            this.descendentePorSuperficieToolStripMenuItem.Name = "descendentePorSuperficieToolStripMenuItem";
            this.descendentePorSuperficieToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.descendentePorSuperficieToolStripMenuItem.Text = "Descendente por Superficie";
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.restart_36px;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 55);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = global::PooEjercicios12Punto.Windows.Properties.Resources.close_pane_36px;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(40, 55);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // colX
            // 
            this.colX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colX.HeaderText = "Coord X";
            this.colX.Name = "colX";
            this.colX.ReadOnly = true;
            // 
            // colY
            // 
            this.colY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colY.HeaderText = "Coord Y";
            this.colY.Name = "colY";
            this.colY.ReadOnly = true;
            // 
            // colTrazo
            // 
            this.colTrazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrazo.HeaderText = "Trazo";
            this.colTrazo.Name = "colTrazo";
            this.colTrazo.ReadOnly = true;
            // 
            // colTrazo2
            // 
            this.colTrazo2.HeaderText = "Trazo Fino";
            this.colTrazo2.Name = "colTrazo2";
            this.colTrazo2.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            // 
            // colCuadrante
            // 
            this.colCuadrante.HeaderText = "Cuadrante";
            this.colCuadrante.Name = "colCuadrante";
            this.colCuadrante.ReadOnly = true;
            // 
            // FrmListaDePuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 624);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.BarraHerramientasToolStrip);
            this.Name = "FrmListaDePuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmListaDePuntos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.BarraHerramientasToolStrip.ResumeLayout(false);
            this.BarraHerramientasToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Label CantidadRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip BarraHerramientasToolStrip;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ladoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MayorIgualLadoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenorIgualLadoMayorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem IgualLadoMayorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem queToolStripMenuItem3;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ascendentePorLadoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendentePorLadoMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendentePorSuperficieToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrazo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrazo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuadrante;
    }
}


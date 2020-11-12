namespace Ejercicio11dePOOPunto2.View
{
    partial class FormListaCircunferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaCircunferencias));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BotonNueva = new System.Windows.Forms.ToolStripButton();
            this.BotonBorrar = new System.Windows.Forms.ToolStripButton();
            this.BotonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DropDownOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.radioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarRadioAsc = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarRadioDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarCentroCerca = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarOrigenLejos = new System.Windows.Forms.ToolStripMenuItem();
            this.DropDownFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.porBordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxBorde = new System.Windows.Forms.ToolStripComboBox();
            this.porRellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxRelleno = new System.Windows.Forms.ToolStripComboBox();
            this.BotonRestaurar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColCentro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRelleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotonNueva,
            this.BotonBorrar,
            this.BotonEditar,
            this.toolStripSeparator1,
            this.DropDownOrdenar,
            this.DropDownFiltrar,
            this.BotonRestaurar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(644, 52);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // BotonNueva
            // 
            this.BotonNueva.Image = ((System.Drawing.Image)(resources.GetObject("BotonNueva.Image")));
            this.BotonNueva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonNueva.Name = "BotonNueva";
            this.BotonNueva.Size = new System.Drawing.Size(45, 49);
            this.BotonNueva.Text = "Nueva";
            this.BotonNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonNueva.Click += new System.EventHandler(this.BotonNueva_Click);
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BotonBorrar.Image")));
            this.BotonBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.Size = new System.Drawing.Size(43, 49);
            this.BotonBorrar.Text = "Borrar";
            this.BotonBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonBorrar.Click += new System.EventHandler(this.BotonBorrar_Click);
            // 
            // BotonEditar
            // 
            this.BotonEditar.Image = ((System.Drawing.Image)(resources.GetObject("BotonEditar.Image")));
            this.BotonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonEditar.Name = "BotonEditar";
            this.BotonEditar.Size = new System.Drawing.Size(41, 49);
            this.BotonEditar.Text = "Editar";
            this.BotonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // DropDownOrdenar
            // 
            this.DropDownOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radioToolStripMenuItem,
            this.centroToolStripMenuItem});
            this.DropDownOrdenar.Image = ((System.Drawing.Image)(resources.GetObject("DropDownOrdenar.Image")));
            this.DropDownOrdenar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DropDownOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownOrdenar.Name = "DropDownOrdenar";
            this.DropDownOrdenar.Size = new System.Drawing.Size(63, 49);
            this.DropDownOrdenar.Text = "Ordenar";
            this.DropDownOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // radioToolStripMenuItem
            // 
            this.radioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenarRadioAsc,
            this.OrdenarRadioDesc});
            this.radioToolStripMenuItem.Name = "radioToolStripMenuItem";
            this.radioToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.radioToolStripMenuItem.Text = "Radio";
            // 
            // OrdenarRadioAsc
            // 
            this.OrdenarRadioAsc.Name = "OrdenarRadioAsc";
            this.OrdenarRadioAsc.Size = new System.Drawing.Size(155, 22);
            this.OrdenarRadioAsc.Text = "Menor a mayor";
            this.OrdenarRadioAsc.Click += new System.EventHandler(this.OrdenarRadioAsc_Click);
            // 
            // OrdenarRadioDesc
            // 
            this.OrdenarRadioDesc.Name = "OrdenarRadioDesc";
            this.OrdenarRadioDesc.Size = new System.Drawing.Size(155, 22);
            this.OrdenarRadioDesc.Text = "Mayor a menor";
            this.OrdenarRadioDesc.Click += new System.EventHandler(this.OrdenarRadioDesc_Click);
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrdenarCentroCerca,
            this.OrdenarOrigenLejos});
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.centroToolStripMenuItem.Text = "Centro";
            // 
            // OrdenarCentroCerca
            // 
            this.OrdenarCentroCerca.Name = "OrdenarCentroCerca";
            this.OrdenarCentroCerca.Size = new System.Drawing.Size(235, 22);
            this.OrdenarCentroCerca.Text = "Más cercano al orígen primero";
            this.OrdenarCentroCerca.Click += new System.EventHandler(this.OrdenarCentroCerca_Click);
            // 
            // OrdenarOrigenLejos
            // 
            this.OrdenarOrigenLejos.Name = "OrdenarOrigenLejos";
            this.OrdenarOrigenLejos.Size = new System.Drawing.Size(235, 22);
            this.OrdenarOrigenLejos.Text = "Más lejano al orígen primero";
            this.OrdenarOrigenLejos.Click += new System.EventHandler(this.OrdenarOrigenLejos_Click);
            // 
            // DropDownFiltrar
            // 
            this.DropDownFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porBordeToolStripMenuItem,
            this.porRellenoToolStripMenuItem});
            this.DropDownFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("DropDownFiltrar.Image")));
            this.DropDownFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DropDownFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownFiltrar.Name = "DropDownFiltrar";
            this.DropDownFiltrar.Size = new System.Drawing.Size(50, 49);
            this.DropDownFiltrar.Text = "Filtrar";
            this.DropDownFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // porBordeToolStripMenuItem
            // 
            this.porBordeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboBoxBorde});
            this.porBordeToolStripMenuItem.Name = "porBordeToolStripMenuItem";
            this.porBordeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.porBordeToolStripMenuItem.Text = "Por borde";
            // 
            // ComboBoxBorde
            // 
            this.ComboBoxBorde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBorde.Name = "ComboBoxBorde";
            this.ComboBoxBorde.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxBorde.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBorde_SelectedIndexChanged);
            // 
            // porRellenoToolStripMenuItem
            // 
            this.porRellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboBoxRelleno});
            this.porRellenoToolStripMenuItem.Name = "porRellenoToolStripMenuItem";
            this.porRellenoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.porRellenoToolStripMenuItem.Text = "Por relleno";
            // 
            // ComboBoxRelleno
            // 
            this.ComboBoxRelleno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRelleno.Name = "ComboBoxRelleno";
            this.ComboBoxRelleno.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxRelleno.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRelleno_SelectedIndexChanged);
            // 
            // BotonRestaurar
            // 
            this.BotonRestaurar.Enabled = false;
            this.BotonRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BotonRestaurar.Image")));
            this.BotonRestaurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BotonRestaurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotonRestaurar.Name = "BotonRestaurar";
            this.BotonRestaurar.Size = new System.Drawing.Size(60, 49);
            this.BotonRestaurar.Text = "Restaurar";
            this.BotonRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonRestaurar.Click += new System.EventHandler(this.BotonRestaurar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCentro,
            this.ColRadio,
            this.ColBorde,
            this.ColRelleno,
            this.ColPerimetro,
            this.ColSuperficie});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 56);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(644, 336);
            this.dataGridView.TabIndex = 1;
            // 
            // ColCentro
            // 
            this.ColCentro.Frozen = true;
            this.ColCentro.HeaderText = "Centro";
            this.ColCentro.Name = "ColCentro";
            this.ColCentro.ReadOnly = true;
            this.ColCentro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColRadio
            // 
            this.ColRadio.Frozen = true;
            this.ColRadio.HeaderText = "Radio";
            this.ColRadio.Name = "ColRadio";
            this.ColRadio.ReadOnly = true;
            this.ColRadio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColBorde
            // 
            this.ColBorde.Frozen = true;
            this.ColBorde.HeaderText = "Borde";
            this.ColBorde.Name = "ColBorde";
            this.ColBorde.ReadOnly = true;
            this.ColBorde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColRelleno
            // 
            this.ColRelleno.Frozen = true;
            this.ColRelleno.HeaderText = "Relleno";
            this.ColRelleno.Name = "ColRelleno";
            this.ColRelleno.ReadOnly = true;
            this.ColRelleno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPerimetro
            // 
            this.ColPerimetro.Frozen = true;
            this.ColPerimetro.HeaderText = "Perímetro";
            this.ColPerimetro.Name = "ColPerimetro";
            this.ColPerimetro.ReadOnly = true;
            this.ColPerimetro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColSuperficie
            // 
            this.ColSuperficie.Frozen = true;
            this.ColSuperficie.HeaderText = "Superficie";
            this.ColSuperficie.Name = "ColSuperficie";
            this.ColSuperficie.ReadOnly = true;
            this.ColSuperficie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormListaCircunferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 391);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 430);
            this.Name = "FormListaCircunferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de circunferencias";
            this.Load += new System.EventHandler(this.FormListaCircunferencias_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BotonEditar;
        private System.Windows.Forms.ToolStripButton BotonNueva;
        private System.Windows.Forms.ToolStripButton BotonBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton DropDownOrdenar;
        private System.Windows.Forms.ToolStripDropDownButton DropDownFiltrar;
        private System.Windows.Forms.ToolStripButton BotonRestaurar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem radioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenarRadioAsc;
        private System.Windows.Forms.ToolStripMenuItem OrdenarRadioDesc;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenarCentroCerca;
        private System.Windows.Forms.ToolStripMenuItem OrdenarOrigenLejos;
        private System.Windows.Forms.ToolStripMenuItem porBordeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ComboBoxBorde;
        private System.Windows.Forms.ToolStripMenuItem porRellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ComboBoxRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCentro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSuperficie;
    }
}


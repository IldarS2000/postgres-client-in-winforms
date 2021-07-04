
namespace courseProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv_availability_of_details = new System.Windows.Forms.DataGridView();
            this.responsible_person = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.warehousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new courseProject.myDataSet();
            this.detail_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idwarehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddetailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitofmeasurementDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoflastoperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityofdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.iddetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitofmeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_warehouses = new System.Windows.Forms.DataGridView();
            this.idwarehouseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsiblepersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.availability_of_detailsTableAdapter = new courseProject.myDataSetTableAdapters.availability_of_detailsTableAdapter();
            this.detailsTableAdapter = new courseProject.myDataSetTableAdapters.detailsTableAdapter();
            this.warehousesTableAdapter = new courseProject.myDataSetTableAdapters.warehousesTableAdapter();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.iddetailfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idwarehousefkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTable = new System.Windows.Forms.Label();
            this.btnProc = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.inputData = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.основнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.представлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задача1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задача2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.задача3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.вариант2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_availability_of_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityofdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iddetailfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idwarehousefkBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_availability_of_details
            // 
            this.dgv_availability_of_details.AutoGenerateColumns = false;
            this.dgv_availability_of_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_availability_of_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.responsible_person,
            this.detail_name,
            this.idwarehouseDataGridViewTextBoxColumn,
            this.iddetailDataGridViewTextBoxColumn1,
            this.unitofmeasurementDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.dateoflastoperationDataGridViewTextBoxColumn});
            this.dgv_availability_of_details.DataSource = this.availabilityofdetailsBindingSource;
            this.dgv_availability_of_details.Location = new System.Drawing.Point(26, 375);
            this.dgv_availability_of_details.Name = "dgv_availability_of_details";
            this.dgv_availability_of_details.RowHeadersWidth = 51;
            this.dgv_availability_of_details.RowTemplate.Height = 24;
            this.dgv_availability_of_details.Size = new System.Drawing.Size(1027, 150);
            this.dgv_availability_of_details.TabIndex = 0;
            this.dgv_availability_of_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availability_of_details_CellContentClick);
            this.dgv_availability_of_details.CurrentCellChanged += new System.EventHandler(this.availability_dataGridView_CurrentCellChanged);
            this.dgv_availability_of_details.Click += new System.EventHandler(this.dgv_availability_of_details_Click);
            // 
            // responsible_person
            // 
            this.responsible_person.DataPropertyName = "id_warehouse";
            this.responsible_person.DataSource = this.warehousesBindingSource;
            this.responsible_person.DisplayMember = "responsible_person";
            this.responsible_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.responsible_person.HeaderText = "Ответственный за склад";
            this.responsible_person.MinimumWidth = 6;
            this.responsible_person.Name = "responsible_person";
            this.responsible_person.ValueMember = "id_warehouse";
            this.responsible_person.Width = 125;
            // 
            // warehousesBindingSource
            // 
            this.warehousesBindingSource.DataMember = "warehouses";
            this.warehousesBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail_name
            // 
            this.detail_name.DataPropertyName = "id_detail";
            this.detail_name.DataSource = this.detailsBindingSource;
            this.detail_name.DisplayMember = "name";
            this.detail_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail_name.HeaderText = "Наименование детали";
            this.detail_name.MinimumWidth = 6;
            this.detail_name.Name = "detail_name";
            this.detail_name.ValueMember = "id_detail";
            this.detail_name.Width = 125;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "details";
            this.detailsBindingSource.DataSource = this.myDataSet;
            // 
            // idwarehouseDataGridViewTextBoxColumn
            // 
            this.idwarehouseDataGridViewTextBoxColumn.DataPropertyName = "id_warehouse";
            this.idwarehouseDataGridViewTextBoxColumn.HeaderText = "id_warehouse";
            this.idwarehouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idwarehouseDataGridViewTextBoxColumn.Name = "idwarehouseDataGridViewTextBoxColumn";
            this.idwarehouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // iddetailDataGridViewTextBoxColumn1
            // 
            this.iddetailDataGridViewTextBoxColumn1.DataPropertyName = "id_detail";
            this.iddetailDataGridViewTextBoxColumn1.HeaderText = "id_detail";
            this.iddetailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iddetailDataGridViewTextBoxColumn1.Name = "iddetailDataGridViewTextBoxColumn1";
            this.iddetailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // unitofmeasurementDataGridViewTextBoxColumn1
            // 
            this.unitofmeasurementDataGridViewTextBoxColumn1.DataPropertyName = "unit_of_measurement";
            this.unitofmeasurementDataGridViewTextBoxColumn1.HeaderText = "unit_of_measurement";
            this.unitofmeasurementDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.unitofmeasurementDataGridViewTextBoxColumn1.Name = "unitofmeasurementDataGridViewTextBoxColumn1";
            this.unitofmeasurementDataGridViewTextBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateoflastoperationDataGridViewTextBoxColumn
            // 
            this.dateoflastoperationDataGridViewTextBoxColumn.DataPropertyName = "date_of_last_operation";
            this.dateoflastoperationDataGridViewTextBoxColumn.HeaderText = "date_of_last_operation";
            this.dateoflastoperationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateoflastoperationDataGridViewTextBoxColumn.Name = "dateoflastoperationDataGridViewTextBoxColumn";
            this.dateoflastoperationDataGridViewTextBoxColumn.Width = 125;
            // 
            // availabilityofdetailsBindingSource
            // 
            this.availabilityofdetailsBindingSource.DataMember = "availability_of_details";
            this.availabilityofdetailsBindingSource.DataSource = this.myDataSet;
            // 
            // dgv_details
            // 
            this.dgv_details.AutoGenerateColumns = false;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetailDataGridViewTextBoxColumn,
            this.detailtypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitofmeasurementDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgv_details.DataSource = this.detailsBindingSource;
            this.dgv_details.Location = new System.Drawing.Point(26, 63);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.RowHeadersWidth = 51;
            this.dgv_details.RowTemplate.Height = 24;
            this.dgv_details.Size = new System.Drawing.Size(767, 150);
            this.dgv_details.TabIndex = 1;
            this.dgv_details.Click += new System.EventHandler(this.dgv_details_Click);
            // 
            // iddetailDataGridViewTextBoxColumn
            // 
            this.iddetailDataGridViewTextBoxColumn.DataPropertyName = "id_detail";
            this.iddetailDataGridViewTextBoxColumn.HeaderText = "id_detail";
            this.iddetailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddetailDataGridViewTextBoxColumn.Name = "iddetailDataGridViewTextBoxColumn";
            this.iddetailDataGridViewTextBoxColumn.Width = 125;
            // 
            // detailtypeDataGridViewTextBoxColumn
            // 
            this.detailtypeDataGridViewTextBoxColumn.DataPropertyName = "detail_type";
            this.detailtypeDataGridViewTextBoxColumn.HeaderText = "detail_type";
            this.detailtypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detailtypeDataGridViewTextBoxColumn.Name = "detailtypeDataGridViewTextBoxColumn";
            this.detailtypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitofmeasurementDataGridViewTextBoxColumn
            // 
            this.unitofmeasurementDataGridViewTextBoxColumn.DataPropertyName = "unit_of_measurement";
            this.unitofmeasurementDataGridViewTextBoxColumn.HeaderText = "unit_of_measurement";
            this.unitofmeasurementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitofmeasurementDataGridViewTextBoxColumn.Name = "unitofmeasurementDataGridViewTextBoxColumn";
            this.unitofmeasurementDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dgv_warehouses
            // 
            this.dgv_warehouses.AutoGenerateColumns = false;
            this.dgv_warehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_warehouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwarehouseDataGridViewTextBoxColumn1,
            this.responsiblepersonDataGridViewTextBoxColumn});
            this.dgv_warehouses.DataSource = this.warehousesBindingSource;
            this.dgv_warehouses.Location = new System.Drawing.Point(26, 219);
            this.dgv_warehouses.Name = "dgv_warehouses";
            this.dgv_warehouses.RowHeadersWidth = 51;
            this.dgv_warehouses.RowTemplate.Height = 24;
            this.dgv_warehouses.Size = new System.Drawing.Size(767, 150);
            this.dgv_warehouses.TabIndex = 2;
            this.dgv_warehouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.warehouses_CellContentClick);
            this.dgv_warehouses.Click += new System.EventHandler(this.dgv_warehouses_Click);
            // 
            // idwarehouseDataGridViewTextBoxColumn1
            // 
            this.idwarehouseDataGridViewTextBoxColumn1.DataPropertyName = "id_warehouse";
            this.idwarehouseDataGridViewTextBoxColumn1.HeaderText = "id_warehouse";
            this.idwarehouseDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idwarehouseDataGridViewTextBoxColumn1.Name = "idwarehouseDataGridViewTextBoxColumn1";
            this.idwarehouseDataGridViewTextBoxColumn1.Width = 125;
            // 
            // responsiblepersonDataGridViewTextBoxColumn
            // 
            this.responsiblepersonDataGridViewTextBoxColumn.DataPropertyName = "responsible_person";
            this.responsiblepersonDataGridViewTextBoxColumn.HeaderText = "responsible_person";
            this.responsiblepersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.responsiblepersonDataGridViewTextBoxColumn.Name = "responsiblepersonDataGridViewTextBoxColumn";
            this.responsiblepersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.detailsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 28);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1065, 27);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // availability_of_detailsTableAdapter
            // 
            this.availability_of_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // warehousesTableAdapter
            // 
            this.warehousesTableAdapter.ClearBeforeFill = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(146, 544);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 32);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(481, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(26, 544);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(114, 32);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "Предыдущая";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(582, 544);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(87, 32);
            this.btnDiscard.TabIndex = 7;
            this.btnDiscard.Text = "Сбросить";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(267, 544);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(99, 32);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "Первая";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(372, 544);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(103, 32);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "Последняя";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // iddetailfkBindingSource
            // 
            this.iddetailfkBindingSource.DataMember = "id_detail_fk";
            this.iddetailfkBindingSource.DataSource = this.detailsBindingSource;
            // 
            // idwarehousefkBindingSource
            // 
            this.idwarehousefkBindingSource.DataMember = "id_warehouse_fk";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(339, 37);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(70, 23);
            this.lblTable.TabIndex = 10;
            this.lblTable.Text = "Детали";
            this.lblTable.Click += new System.EventHandler(this.lblTable_Click);
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(862, 140);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(122, 50);
            this.btnProc.TabIndex = 12;
            this.btnProc.Text = "Исполнить процедуру";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswer.Location = new System.Drawing.Point(859, 193);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(88, 23);
            this.lblAnswer.TabIndex = 13;
            this.lblAnswer.Text = "Результат";
            // 
            // inputData
            // 
            this.inputData.FormattingEnabled = true;
            this.inputData.Items.AddRange(new object[] {
            "own",
            "bought"});
            this.inputData.Location = new System.Drawing.Point(863, 105);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(121, 24);
            this.inputData.TabIndex = 15;
            this.inputData.Text = "own";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаяToolStripMenuItem,
            this.задача1ToolStripMenuItem,
            this.задача2ToolStripMenuItem,
            this.задача3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основнаяToolStripMenuItem
            // 
            this.основнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.альтернативнаяToolStripMenuItem,
            this.альтернативнаяToolStripMenuItem1,
            this.представлениеToolStripMenuItem});
            this.основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            this.основнаяToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.основнаяToolStripMenuItem.Text = " Формы";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            this.альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            this.альтернативнаяToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.альтернативнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem1
            // 
            this.альтернативнаяToolStripMenuItem1.Name = "альтернативнаяToolStripMenuItem1";
            this.альтернативнаяToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.альтернативнаяToolStripMenuItem1.Text = "Альтернативная";
            this.альтернативнаяToolStripMenuItem1.Click += new System.EventHandler(this.альтернативнаяToolStripMenuItem1_Click);
            // 
            // представлениеToolStripMenuItem
            // 
            this.представлениеToolStripMenuItem.Name = "представлениеToolStripMenuItem";
            this.представлениеToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.представлениеToolStripMenuItem.Text = "Представление";
            this.представлениеToolStripMenuItem.Click += new System.EventHandler(this.представлениеToolStripMenuItem_Click);
            // 
            // задача1ToolStripMenuItem
            // 
            this.задача1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вариант1ToolStripMenuItem,
            this.вариант2ToolStripMenuItem,
            this.вариант3ToolStripMenuItem,
            this.вариант4ToolStripMenuItem,
            this.вариант5ToolStripMenuItem1});
            this.задача1ToolStripMenuItem.Name = "задача1ToolStripMenuItem";
            this.задача1ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.задача1ToolStripMenuItem.Text = "Задача 1";
            // 
            // вариант1ToolStripMenuItem
            // 
            this.вариант1ToolStripMenuItem.Name = "вариант1ToolStripMenuItem";
            this.вариант1ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.вариант1ToolStripMenuItem.Text = "вариант 1";
            this.вариант1ToolStripMenuItem.Click += new System.EventHandler(this.вариант1ToolStripMenuItem_Click);
            // 
            // вариант2ToolStripMenuItem
            // 
            this.вариант2ToolStripMenuItem.Name = "вариант2ToolStripMenuItem";
            this.вариант2ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.вариант2ToolStripMenuItem.Text = "вариант 2";
            this.вариант2ToolStripMenuItem.Click += new System.EventHandler(this.вариант2ToolStripMenuItem_Click);
            // 
            // вариант3ToolStripMenuItem
            // 
            this.вариант3ToolStripMenuItem.Name = "вариант3ToolStripMenuItem";
            this.вариант3ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.вариант3ToolStripMenuItem.Text = "вариант 3";
            this.вариант3ToolStripMenuItem.Click += new System.EventHandler(this.вариант3ToolStripMenuItem_Click);
            // 
            // вариант4ToolStripMenuItem
            // 
            this.вариант4ToolStripMenuItem.Name = "вариант4ToolStripMenuItem";
            this.вариант4ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.вариант4ToolStripMenuItem.Text = "вариант 4";
            this.вариант4ToolStripMenuItem.Click += new System.EventHandler(this.вариант4ToolStripMenuItem_Click);
            // 
            // вариант5ToolStripMenuItem1
            // 
            this.вариант5ToolStripMenuItem1.Name = "вариант5ToolStripMenuItem1";
            this.вариант5ToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.вариант5ToolStripMenuItem1.Text = "вариант 5";
            this.вариант5ToolStripMenuItem1.Click += new System.EventHandler(this.вариант5ToolStripMenuItem1_Click);
            // 
            // задача2ToolStripMenuItem
            // 
            this.задача2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вариант1ToolStripMenuItem1,
            this.вариант2ToolStripMenuItem1});
            this.задача2ToolStripMenuItem.Name = "задача2ToolStripMenuItem";
            this.задача2ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.задача2ToolStripMenuItem.Text = "Задача 2";
            // 
            // вариант1ToolStripMenuItem1
            // 
            this.вариант1ToolStripMenuItem1.Name = "вариант1ToolStripMenuItem1";
            this.вариант1ToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.вариант1ToolStripMenuItem1.Text = "Вариант 1";
            this.вариант1ToolStripMenuItem1.Click += new System.EventHandler(this.вариант1ToolStripMenuItem1_Click_1);
            // 
            // вариант2ToolStripMenuItem1
            // 
            this.вариант2ToolStripMenuItem1.Name = "вариант2ToolStripMenuItem1";
            this.вариант2ToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.вариант2ToolStripMenuItem1.Text = "Вариант 2";
            this.вариант2ToolStripMenuItem1.Click += new System.EventHandler(this.вариант2ToolStripMenuItem1_Click);
            // 
            // задача3ToolStripMenuItem
            // 
            this.задача3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вариант1ToolStripMenuItem2,
            this.вариант2ToolStripMenuItem2});
            this.задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            this.задача3ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.задача3ToolStripMenuItem.Text = "Задача 3";
            // 
            // вариант1ToolStripMenuItem2
            // 
            this.вариант1ToolStripMenuItem2.Name = "вариант1ToolStripMenuItem2";
            this.вариант1ToolStripMenuItem2.Size = new System.Drawing.Size(162, 26);
            this.вариант1ToolStripMenuItem2.Text = "Вариант 1";
            this.вариант1ToolStripMenuItem2.Click += new System.EventHandler(this.вариант1ToolStripMenuItem2_Click);
            // 
            // вариант2ToolStripMenuItem2
            // 
            this.вариант2ToolStripMenuItem2.Name = "вариант2ToolStripMenuItem2";
            this.вариант2ToolStripMenuItem2.Size = new System.Drawing.Size(162, 26);
            this.вариант2ToolStripMenuItem2.Text = "Вариант 2";
            this.вариант2ToolStripMenuItem2.Click += new System.EventHandler(this.вариант2ToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 628);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv_warehouses);
            this.Controls.Add(this.dgv_details);
            this.Controls.Add(this.dgv_availability_of_details);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_availability_of_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityofdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_warehouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iddetailfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idwarehousefkBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_availability_of_details;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.DataGridView dgv_warehouses;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource availabilityofdetailsBindingSource;
        private myDataSetTableAdapters.availability_of_detailsTableAdapter availability_of_detailsTableAdapter;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private myDataSetTableAdapters.detailsTableAdapter detailsTableAdapter;
        private myDataSetTableAdapters.warehousesTableAdapter warehousesTableAdapter;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.BindingSource iddetailfkBindingSource;
        private System.Windows.Forms.BindingSource idwarehousefkBindingSource;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ComboBox inputData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem задача1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem основнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitofmeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwarehouseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsiblepersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource warehousesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn responsible_person;
        private System.Windows.Forms.DataGridViewComboBoxColumn detail_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwarehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitofmeasurementDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoflastoperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem представлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вариант2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem задача3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вариант1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem вариант2ToolStripMenuItem2;
    }
}


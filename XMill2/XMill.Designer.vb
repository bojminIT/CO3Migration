<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class XMill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XMill))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tscbEnvironment = New System.Windows.Forms.ToolStripComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.bTestConnection = New System.Windows.Forms.Button()
        Me.bRun = New System.Windows.Forms.Button()
        Me.bPreview = New System.Windows.Forms.Button()
        Me.bChoose = New System.Windows.Forms.Button()
        Me.lFilePath = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lInsertView = New System.Windows.Forms.Label()
        Me.lStorageView = New System.Windows.Forms.Label()
        Me.dgvInsert = New System.Windows.Forms.DataGridView()
        Me.dgvStorage = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPreview = New System.Windows.Forms.DataGridView()
        Me.XMLFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentObjectTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentObjectType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjectTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjectType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BvValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BvNodeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeNow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bwParser = New System.ComponentModel.BackgroundWorker()
        Me.OverrideParsedData = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgvInsert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgvPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 531)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(936, 26)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.ForeColor = System.Drawing.Color.DimGray
        Me.tsslStatus.Image = CType(resources.GetObject("tsslStatus.Image"), System.Drawing.Image)
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(93, 20)
        Me.tsslStatus.Text = "Working..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tscbEnvironment})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(936, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(95, 36)
        Me.ToolStripLabel1.Text = "Environment:"
        '
        'tscbEnvironment
        '
        Me.tscbEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscbEnvironment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tscbEnvironment.Name = "tscbEnvironment"
        Me.tscbEnvironment.Size = New System.Drawing.Size(200, 39)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvPreview, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(936, 503)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.bTestConnection, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.bRun, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.bPreview, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.bChoose, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lFilePath, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(930, 97)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'bTestConnection
        '
        Me.bTestConnection.AutoSize = True
        Me.bTestConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bTestConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bTestConnection.Image = CType(resources.GetObject("bTestConnection.Image"), System.Drawing.Image)
        Me.bTestConnection.Location = New System.Drawing.Point(794, 3)
        Me.bTestConnection.Name = "bTestConnection"
        Me.bTestConnection.Size = New System.Drawing.Size(133, 26)
        Me.bTestConnection.TabIndex = 4
        Me.bTestConnection.Text = "Test Connection"
        Me.bTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bTestConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bTestConnection.UseVisualStyleBackColor = True
        '
        'bRun
        '
        Me.bRun.AutoSize = True
        Me.bRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bRun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bRun.Image = CType(resources.GetObject("bRun.Image"), System.Drawing.Image)
        Me.bRun.Location = New System.Drawing.Point(3, 67)
        Me.bRun.Name = "bRun"
        Me.bRun.Size = New System.Drawing.Size(134, 26)
        Me.bRun.TabIndex = 2
        Me.bRun.Text = "Run"
        Me.bRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bRun.UseVisualStyleBackColor = True
        '
        'bPreview
        '
        Me.bPreview.AutoSize = True
        Me.bPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bPreview.Image = CType(resources.GetObject("bPreview.Image"), System.Drawing.Image)
        Me.bPreview.Location = New System.Drawing.Point(3, 35)
        Me.bPreview.Name = "bPreview"
        Me.bPreview.Size = New System.Drawing.Size(134, 26)
        Me.bPreview.TabIndex = 1
        Me.bPreview.Text = "Parse && Preview"
        Me.bPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bPreview.UseVisualStyleBackColor = True
        '
        'bChoose
        '
        Me.bChoose.AutoSize = True
        Me.bChoose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bChoose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bChoose.Image = CType(resources.GetObject("bChoose.Image"), System.Drawing.Image)
        Me.bChoose.Location = New System.Drawing.Point(3, 3)
        Me.bChoose.Name = "bChoose"
        Me.bChoose.Size = New System.Drawing.Size(134, 26)
        Me.bChoose.TabIndex = 0
        Me.bChoose.Text = "Choose Folder..."
        Me.bChoose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bChoose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bChoose.UseVisualStyleBackColor = True
        '
        'lFilePath
        '
        Me.lFilePath.AutoSize = True
        Me.lFilePath.BackColor = System.Drawing.Color.White
        Me.lFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lFilePath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lFilePath.Location = New System.Drawing.Point(143, 3)
        Me.lFilePath.Margin = New System.Windows.Forms.Padding(3)
        Me.lFilePath.Name = "lFilePath"
        Me.lFilePath.Size = New System.Drawing.Size(645, 26)
        Me.lFilePath.TabIndex = 6
        Me.lFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lInsertView, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lStorageView, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.dgvInsert, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.dgvStorage, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 106)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(930, 178)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'lInsertView
        '
        Me.lInsertView.AutoSize = True
        Me.lInsertView.BackColor = System.Drawing.Color.SteelBlue
        Me.lInsertView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lInsertView.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lInsertView.ForeColor = System.Drawing.Color.White
        Me.lInsertView.Location = New System.Drawing.Point(3, 3)
        Me.lInsertView.Margin = New System.Windows.Forms.Padding(3)
        Me.lInsertView.Name = "lInsertView"
        Me.lInsertView.Size = New System.Drawing.Size(459, 20)
        Me.lInsertView.TabIndex = 0
        Me.lInsertView.Text = "Insert View"
        Me.lInsertView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lStorageView
        '
        Me.lStorageView.AutoSize = True
        Me.lStorageView.BackColor = System.Drawing.Color.IndianRed
        Me.lStorageView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lStorageView.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStorageView.ForeColor = System.Drawing.Color.White
        Me.lStorageView.Location = New System.Drawing.Point(468, 3)
        Me.lStorageView.Margin = New System.Windows.Forms.Padding(3)
        Me.lStorageView.Name = "lStorageView"
        Me.lStorageView.Size = New System.Drawing.Size(459, 20)
        Me.lStorageView.TabIndex = 1
        Me.lStorageView.Text = "Storage View"
        Me.lStorageView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvInsert
        '
        Me.dgvInsert.AllowUserToAddRows = False
        Me.dgvInsert.AllowUserToDeleteRows = False
        Me.dgvInsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInsert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInsert.Location = New System.Drawing.Point(3, 29)
        Me.dgvInsert.Name = "dgvInsert"
        Me.dgvInsert.ReadOnly = True
        Me.dgvInsert.RowHeadersWidth = 51
        Me.dgvInsert.Size = New System.Drawing.Size(459, 146)
        Me.dgvInsert.TabIndex = 5
        '
        'dgvStorage
        '
        Me.dgvStorage.AllowUserToAddRows = False
        Me.dgvStorage.AllowUserToDeleteRows = False
        Me.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStorage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStorage.Location = New System.Drawing.Point(468, 29)
        Me.dgvStorage.Name = "dgvStorage"
        Me.dgvStorage.ReadOnly = True
        Me.dgvStorage.RowHeadersWidth = 51
        Me.dgvStorage.Size = New System.Drawing.Size(459, 146)
        Me.dgvStorage.TabIndex = 6
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.OverrideParsedData, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 290)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(930, 26)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PARSED PREVIEW"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvPreview
        '
        Me.dgvPreview.AllowUserToAddRows = False
        Me.dgvPreview.AllowUserToDeleteRows = False
        Me.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPreview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.XMLFileName, Me.ParentObjectTypeId, Me.ParentObjectType, Me.ObjectTypeId, Me.ObjectType, Me.BvId, Me.BvValue, Me.BvNodeName, Me.DateTimeNow})
        Me.dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPreview.Location = New System.Drawing.Point(6, 322)
        Me.dgvPreview.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.dgvPreview.Name = "dgvPreview"
        Me.dgvPreview.ReadOnly = True
        Me.dgvPreview.RowHeadersWidth = 51
        Me.dgvPreview.Size = New System.Drawing.Size(924, 178)
        Me.dgvPreview.TabIndex = 9
        '
        'XMLFileName
        '
        Me.XMLFileName.DataPropertyName = "XMLFileName"
        Me.XMLFileName.HeaderText = "XML File Name"
        Me.XMLFileName.MinimumWidth = 6
        Me.XMLFileName.Name = "XMLFileName"
        Me.XMLFileName.ReadOnly = True
        Me.XMLFileName.Width = 125
        '
        'ParentObjectTypeId
        '
        Me.ParentObjectTypeId.DataPropertyName = "ParentObjectTypeId"
        Me.ParentObjectTypeId.HeaderText = "Parent Object Type ID"
        Me.ParentObjectTypeId.MinimumWidth = 6
        Me.ParentObjectTypeId.Name = "ParentObjectTypeId"
        Me.ParentObjectTypeId.ReadOnly = True
        Me.ParentObjectTypeId.Width = 125
        '
        'ParentObjectType
        '
        Me.ParentObjectType.DataPropertyName = "ParentObjectType"
        Me.ParentObjectType.HeaderText = "Parent Object Type"
        Me.ParentObjectType.MinimumWidth = 6
        Me.ParentObjectType.Name = "ParentObjectType"
        Me.ParentObjectType.ReadOnly = True
        Me.ParentObjectType.Width = 125
        '
        'ObjectTypeId
        '
        Me.ObjectTypeId.DataPropertyName = "ObjectTypeId"
        Me.ObjectTypeId.HeaderText = "Object Type ID"
        Me.ObjectTypeId.MinimumWidth = 6
        Me.ObjectTypeId.Name = "ObjectTypeId"
        Me.ObjectTypeId.ReadOnly = True
        Me.ObjectTypeId.Width = 125
        '
        'ObjectType
        '
        Me.ObjectType.DataPropertyName = "ObjectType"
        Me.ObjectType.HeaderText = "Object Type"
        Me.ObjectType.MinimumWidth = 6
        Me.ObjectType.Name = "ObjectType"
        Me.ObjectType.ReadOnly = True
        Me.ObjectType.Width = 125
        '
        'BvId
        '
        Me.BvId.DataPropertyName = "BvId"
        Me.BvId.HeaderText = "Bv ID"
        Me.BvId.MinimumWidth = 6
        Me.BvId.Name = "BvId"
        Me.BvId.ReadOnly = True
        Me.BvId.Width = 125
        '
        'BvValue
        '
        Me.BvValue.DataPropertyName = "BvValue"
        Me.BvValue.HeaderText = "Bv Value"
        Me.BvValue.MinimumWidth = 6
        Me.BvValue.Name = "BvValue"
        Me.BvValue.ReadOnly = True
        Me.BvValue.Width = 125
        '
        'BvNodeName
        '
        Me.BvNodeName.DataPropertyName = "BvNodeName"
        Me.BvNodeName.HeaderText = "Bv Node Name"
        Me.BvNodeName.MinimumWidth = 6
        Me.BvNodeName.Name = "BvNodeName"
        Me.BvNodeName.ReadOnly = True
        Me.BvNodeName.Width = 125
        '
        'DateTimeNow
        '
        Me.DateTimeNow.DataPropertyName = "DateTimeNow"
        Me.DateTimeNow.HeaderText = "Date"
        Me.DateTimeNow.MinimumWidth = 6
        Me.DateTimeNow.Name = "DateTimeNow"
        Me.DateTimeNow.ReadOnly = True
        Me.DateTimeNow.Width = 125
        '
        'bwParser
        '
        '
        'OverrideParsedData
        '
        Me.OverrideParsedData.AutoSize = True
        Me.OverrideParsedData.Location = New System.Drawing.Point(133, 3)
        Me.OverrideParsedData.Name = "OverrideParsedData"
        Me.OverrideParsedData.Size = New System.Drawing.Size(162, 20)
        Me.OverrideParsedData.TabIndex = 1
        Me.OverrideParsedData.Text = "Override Parsed Data"
        Me.OverrideParsedData.UseVisualStyleBackColor = True
        '
        'XMill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 557)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "XMill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CO3 to Dragon - Renewal Migration"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.dgvInsert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStorage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.dgvPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tscbEnvironment As ToolStripComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents bPreview As Button
    Friend WithEvents bRun As Button
    Friend WithEvents bTestConnection As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents bChoose As Button
    Friend WithEvents lFilePath As Label
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents lInsertView As Label
    Friend WithEvents lStorageView As Label
    Friend WithEvents dgvInsert As DataGridView
    Friend WithEvents dgvStorage As DataGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPreview As DataGridView
    Friend WithEvents bwParser As System.ComponentModel.BackgroundWorker
    Friend WithEvents XMLFileName As DataGridViewTextBoxColumn
    Friend WithEvents ParentObjectTypeId As DataGridViewTextBoxColumn
    Friend WithEvents ParentObjectType As DataGridViewTextBoxColumn
    Friend WithEvents ObjectTypeId As DataGridViewTextBoxColumn
    Friend WithEvents ObjectType As DataGridViewTextBoxColumn
    Friend WithEvents BvId As DataGridViewTextBoxColumn
    Friend WithEvents BvValue As DataGridViewTextBoxColumn
    Friend WithEvents BvNodeName As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeNow As DataGridViewTextBoxColumn
    Friend WithEvents OverrideParsedData As CheckBox
End Class

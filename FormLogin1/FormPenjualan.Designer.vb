<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.DataBarang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.TextBayar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextKembalian = New System.Windows.Forms.TextBox()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(12, 39)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(187, 30)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "Tambah Barang +"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'DataBarang
        '
        Me.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Nama, Me.Harga, Me.Jumlah, Me.STotal})
        Me.DataBarang.Location = New System.Drawing.Point(12, 84)
        Me.DataBarang.Name = "DataBarang"
        Me.DataBarang.RowTemplate.Height = 24
        Me.DataBarang.Size = New System.Drawing.Size(544, 150)
        Me.DataBarang.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Bayar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bayar"
        '
        'TextTotal
        '
        Me.TextTotal.Enabled = False
        Me.TextTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotal.Location = New System.Drawing.Point(117, 263)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(100, 30)
        Me.TextTotal.TabIndex = 4
        '
        'TextBayar
        '
        Me.TextBayar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBayar.Location = New System.Drawing.Point(117, 299)
        Me.TextBayar.Name = "TextBayar"
        Me.TextBayar.Size = New System.Drawing.Size(100, 30)
        Me.TextBayar.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kembalian"
        '
        'TextKembalian
        '
        Me.TextKembalian.Enabled = False
        Me.TextKembalian.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextKembalian.Location = New System.Drawing.Point(117, 335)
        Me.TextKembalian.Name = "TextKembalian"
        Me.TextKembalian.Size = New System.Drawing.Size(100, 30)
        Me.TextKembalian.TabIndex = 7
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(13, 9)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(147, 23)
        Me.LabelJudul.TabIndex = 8
        Me.LabelJudul.Text = "Menu Penjualan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Selamat Datang"
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(147, 388)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(90, 22)
        Me.LabelUser.TabIndex = 10
        Me.LabelUser.Text = "________"
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode Barang"
        Me.Kode.Name = "Kode"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama Barang"
        Me.Nama.Name = "Nama"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga Satuan"
        Me.Harga.Name = "Harga"
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah Beli"
        Me.Jumlah.Name = "Jumlah"
        '
        'STotal
        '
        Me.STotal.HeaderText = "Sub Total"
        Me.STotal.Name = "STotal"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 499)
        Me.Controls.Add(Me.LabelUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelJudul)
        Me.Controls.Add(Me.TextKembalian)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBayar)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataBarang)
        Me.Controls.Add(Me.BtnTambah)
        Me.Name = "FormPenjualan"
        Me.Text = "FormPenjualan"
        CType(Me.DataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents DataBarang As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextKembalian As System.Windows.Forms.TextBox
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelUser As System.Windows.Forms.Label
    Friend WithEvents Kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

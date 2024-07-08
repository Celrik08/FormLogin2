<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TextKode = New System.Windows.Forms.TextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.TextHarga = New System.Windows.Forms.TextBox()
        Me.TextJumlah = New System.Windows.Forms.TextBox()
        Me.TextSub = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 130)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah Beli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SubTotal"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(101, 225)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(103, 32)
        Me.BtnSimpan.TabIndex = 10
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TextKode
        '
        Me.TextKode.Location = New System.Drawing.Point(134, 13)
        Me.TextKode.Name = "TextKode"
        Me.TextKode.Size = New System.Drawing.Size(100, 30)
        Me.TextKode.TabIndex = 11
        '
        'TextNama
        '
        Me.TextNama.Enabled = False
        Me.TextNama.Location = New System.Drawing.Point(134, 51)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(100, 30)
        Me.TextNama.TabIndex = 12
        '
        'TextHarga
        '
        Me.TextHarga.Enabled = False
        Me.TextHarga.Location = New System.Drawing.Point(134, 89)
        Me.TextHarga.Name = "TextHarga"
        Me.TextHarga.Size = New System.Drawing.Size(100, 30)
        Me.TextHarga.TabIndex = 13
        '
        'TextJumlah
        '
        Me.TextJumlah.Location = New System.Drawing.Point(134, 127)
        Me.TextJumlah.Name = "TextJumlah"
        Me.TextJumlah.Size = New System.Drawing.Size(100, 30)
        Me.TextJumlah.TabIndex = 14
        '
        'TextSub
        '
        Me.TextSub.Enabled = False
        Me.TextSub.Location = New System.Drawing.Point(134, 165)
        Me.TextSub.Name = "TextSub"
        Me.TextSub.Size = New System.Drawing.Size(100, 30)
        Me.TextSub.TabIndex = 15
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 284)
        Me.Controls.Add(Me.TextSub)
        Me.Controls.Add(Me.TextJumlah)
        Me.Controls.Add(Me.TextHarga)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.TextKode)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormKasir"
        Me.Text = "FormKasir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents TextKode As System.Windows.Forms.TextBox
    Friend WithEvents TextNama As System.Windows.Forms.TextBox
    Friend WithEvents TextHarga As System.Windows.Forms.TextBox
    Friend WithEvents TextJumlah As System.Windows.Forms.TextBox
    Friend WithEvents TextSub As System.Windows.Forms.TextBox
End Class

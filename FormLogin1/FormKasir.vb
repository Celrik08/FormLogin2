Public Class FormKasir

    Private Sub TextKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextKode.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextJumlah.Focus()
        End If
    End Sub
    Private Sub TextKode_TextChanged(sender As Object, e As EventArgs) Handles TextKode.TextChanged
        Dim kode As String = TextKode.Text

        If kode = "1000" Then
            TextNama.Text = "Shampo Sunslik"
            TextHarga.Text = "Rp. 390.000"
        ElseIf kode = "1001" Then
            TextNama.Text = "Jazz1"
            TextHarga.Text = "Rp. 221.000"
        ElseIf kode = "1002" Then
            TextNama.Text = "Downy Passion"
            TextHarga.Text = "Rp. 280.500"
        Else
            TextNama.Text = ""
            TextHarga.Text = ""
        End If
    End Sub

    Private Sub TextJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextJumlah.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            CalculateSubTotal()
            e.Handled = True
        End If
    End Sub

    Private Sub CalculateSubTotal()
        Dim jumlah As Integer = Convert.ToInt32(TextJumlah.Text)
        Dim harga As Decimal = Convert.ToDecimal(TextHarga.Text.Replace("Rp. ", "").Replace(".", ""))
        Dim subTotal As Decimal = harga * jumlah
        TextSub.Text = subTotal.ToString("C")
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim kode As String = TextKode.Text
        Dim nama As String = TextNama.Text
        Dim harga As String = TextHarga.Text
        Dim jumlah As String = TextJumlah.Text
        Dim subTotal As String = TextSub.Text

        Dim formPenjualan As FormPenjualan = CType(Application.OpenForms("FormPenjualan"), FormPenjualan)
        If formPenjualan IsNot Nothing Then
            formPenjualan.AddDataToDataGridView(kode, nama, harga, jumlah, subTotal)
            formPenjualan.UpdateTotal(subTotal) ' Update total pada FormPenjualan
            formPenjualan.Show() ' Buka FormPenjualan
            Me.Hide() ' Sembunyikan FormKasir
        End If
    End Sub
End Class
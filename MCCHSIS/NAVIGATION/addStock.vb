Imports System.ComponentModel

Public Class AddStock
    Private controller As New stockcontroller()

    ' Example: assumes form contains these controls: txtName, txtBarcode, txtCategory,
    ' txtDescription, txtPrice and a button btnSave.
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim err As String = String.Empty

        If controller.TryAddItem(txtName.Text, txtBarcode.Text, txtCategory.Text, txtDescription.Text, txtPrice.Text, err) Then
            MessageBox.Show("Item added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Optionally clear inputs
            txtStocksItemName.Clear()
            txtStocksBarcode.Clear()
            txtCategory.Clear()
            txtDescription.Clear()
            txtPrice.Clear()
        Else
            MessageBox.Show(If(String.IsNullOrEmpty(err), "Could not add item.", err),
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
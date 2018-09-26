Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EditCheckStock = New DataTable
        EditCheckStock = SQLCommand($"SELECT SUM(Qtyroll) AS Sum FROM Tdyedcomdetxp WHERE Knittcomid = 'VC180900008' and Clothid= '10002'")
        CheckStock.DataSource = EditCheckStock
        TbqtyrollTemp.Text = If(IsDBNull(CheckStock.Rows(0).Cells("Sum").Value), "", CheckStock.Rows(0).Cells("Sum").Value)
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.CheckStock = New System.Windows.Forms.DataGridView()
        Me.TbqtyrollTemp = New Inttextbox.Inttextbox()
        CType(Me.CheckStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckStock
        '
        Me.CheckStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CheckStock.Location = New System.Drawing.Point(109, 65)
        Me.CheckStock.Name = "CheckStock"
        Me.CheckStock.Size = New System.Drawing.Size(240, 150)
        Me.CheckStock.TabIndex = 0
        '
        'TbqtyrollTemp
        '
        Me.TbqtyrollTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbqtyrollTemp.Location = New System.Drawing.Point(109, 263)
        Me.TbqtyrollTemp.MaxLength = 10
        Me.TbqtyrollTemp.Name = "TbqtyrollTemp"
        Me.TbqtyrollTemp.Size = New System.Drawing.Size(123, 24)
        Me.TbqtyrollTemp.TabIndex = 130
        Me.TbqtyrollTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 371)
        Me.Controls.Add(Me.TbqtyrollTemp)
        Me.Controls.Add(Me.CheckStock)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.CheckStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckStock As DataGridView
    Friend WithEvents TbqtyrollTemp As Inttextbox.Inttextbox
End Class

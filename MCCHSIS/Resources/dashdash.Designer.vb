<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashdash
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
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.ShadowDecoration.Enabled = True
        Me.pnlHeader.Size = New System.Drawing.Size(800, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 70)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.ShadowDecoration.Enabled = True
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 380)
        Me.pnlSidebar.TabIndex = 1
        '
        'dashdash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "dashdash"
        Me.Text = "dashdash"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
End Class

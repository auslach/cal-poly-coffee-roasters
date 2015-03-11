<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSummary
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
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.lblgrandTotal = New System.Windows.Forms.Label()
        Me.panSummary = New System.Windows.Forms.Panel()
        Me.panOrdSumHeader = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.panSummary.SuspendLayout()
        Me.panOrdSumHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(3, 3)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(47, 13)
        Me.lblOrderID.TabIndex = 0
        Me.lblOrderID.Text = "Order ID"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(105, 3)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(82, 13)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "Customer Name"
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(267, 3)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(30, 13)
        Me.lblOrderDate.TabIndex = 2
        Me.lblOrderDate.Text = "Date"
        '
        'lblgrandTotal
        '
        Me.lblgrandTotal.AutoSize = True
        Me.lblgrandTotal.Location = New System.Drawing.Point(363, 3)
        Me.lblgrandTotal.Name = "lblgrandTotal"
        Me.lblgrandTotal.Size = New System.Drawing.Size(60, 13)
        Me.lblgrandTotal.TabIndex = 3
        Me.lblgrandTotal.Text = "Order Total"
        '
        'panSummary
        '
        Me.panSummary.AutoScroll = True
        Me.panSummary.Controls.Add(Me.panOrdSumHeader)
        Me.panSummary.Location = New System.Drawing.Point(12, 12)
        Me.panSummary.Name = "panSummary"
        Me.panSummary.Size = New System.Drawing.Size(483, 300)
        Me.panSummary.TabIndex = 4
        '
        'panOrdSumHeader
        '
        Me.panOrdSumHeader.Controls.Add(Me.lblOrderID)
        Me.panOrdSumHeader.Controls.Add(Me.lblServer)
        Me.panOrdSumHeader.Controls.Add(Me.lblgrandTotal)
        Me.panOrdSumHeader.Controls.Add(Me.lblOrderDate)
        Me.panOrdSumHeader.Location = New System.Drawing.Point(23, 14)
        Me.panOrdSumHeader.Name = "panOrdSumHeader"
        Me.panOrdSumHeader.Size = New System.Drawing.Size(426, 20)
        Me.panOrdSumHeader.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(420, 323)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(334, 323)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(75, 23)
        Me.btnReload.TabIndex = 6
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'frmOrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 358)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.panSummary)
        Me.Name = "frmOrderSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrderSummary"
        Me.panSummary.ResumeLayout(False)
        Me.panOrdSumHeader.ResumeLayout(False)
        Me.panOrdSumHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblOrderID As System.Windows.Forms.Label
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents lblOrderDate As System.Windows.Forms.Label
    Friend WithEvents lblgrandTotal As System.Windows.Forms.Label
    Friend WithEvents panSummary As System.Windows.Forms.Panel
    Friend WithEvents panOrdSumHeader As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReload As System.Windows.Forms.Button
End Class

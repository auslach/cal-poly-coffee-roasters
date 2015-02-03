<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.grpOrderSummary = New System.Windows.Forms.GroupBox()
        Me.panOrderSummary = New System.Windows.Forms.Panel()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.grpOrderTotal = New System.Windows.Forms.GroupBox()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.txtFoodTotal = New System.Windows.Forms.TextBox()
        Me.lblFoodTotal = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dtpDateTime = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpOrderSummary.SuspendLayout()
        Me.panOrderSummary.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOrderTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order #:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date/Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(342, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cal Poly Coffee Roasters"
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.Location = New System.Drawing.Point(82, 48)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.Size = New System.Drawing.Size(62, 20)
        Me.txtOrderNumber.TabIndex = 4
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(82, 79)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(121, 20)
        Me.txtServer.TabIndex = 5
        '
        'grpMenu
        '
        Me.grpMenu.Location = New System.Drawing.Point(18, 138)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(185, 295)
        Me.grpMenu.TabIndex = 8
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Coffee Flavors"
        '
        'grpOrderSummary
        '
        Me.grpOrderSummary.Controls.Add(Me.panOrderSummary)
        Me.grpOrderSummary.Location = New System.Drawing.Point(218, 45)
        Me.grpOrderSummary.Name = "grpOrderSummary"
        Me.grpOrderSummary.Size = New System.Drawing.Size(389, 263)
        Me.grpOrderSummary.TabIndex = 9
        Me.grpOrderSummary.TabStop = False
        Me.grpOrderSummary.Text = "Order Summary"
        '
        'panOrderSummary
        '
        Me.panOrderSummary.AutoScroll = True
        Me.panOrderSummary.Controls.Add(Me.cboItem)
        Me.panOrderSummary.Controls.Add(Me.lblTotal)
        Me.panOrderSummary.Controls.Add(Me.txtPrice)
        Me.panOrderSummary.Controls.Add(Me.lblQuantity)
        Me.panOrderSummary.Controls.Add(Me.txtTotal)
        Me.panOrderSummary.Controls.Add(Me.lblPrice)
        Me.panOrderSummary.Controls.Add(Me.nudQuantity)
        Me.panOrderSummary.Controls.Add(Me.lblItem)
        Me.panOrderSummary.Location = New System.Drawing.Point(6, 16)
        Me.panOrderSummary.Name = "panOrderSummary"
        Me.panOrderSummary.Size = New System.Drawing.Size(377, 241)
        Me.panOrderSummary.TabIndex = 8
        '
        'cboItem
        '
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(8, 22)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(142, 21)
        Me.cboItem.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(290, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(156, 23)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(61, 20)
        Me.txtPrice.TabIndex = 1
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(227, 9)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(286, 22)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(61, 20)
        Me.txtTotal.TabIndex = 2
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(157, 9)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Price"
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(223, 22)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(57, 20)
        Me.nudQuantity.TabIndex = 3
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(11, 6)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(27, 13)
        Me.lblItem.TabIndex = 4
        Me.lblItem.Text = "Item"
        '
        'grpOrderTotal
        '
        Me.grpOrderTotal.Controls.Add(Me.txtOrderTotal)
        Me.grpOrderTotal.Controls.Add(Me.lblOrderTotal)
        Me.grpOrderTotal.Controls.Add(Me.txtSalesTax)
        Me.grpOrderTotal.Controls.Add(Me.lblSalesTax)
        Me.grpOrderTotal.Controls.Add(Me.txtFoodTotal)
        Me.grpOrderTotal.Controls.Add(Me.lblFoodTotal)
        Me.grpOrderTotal.Location = New System.Drawing.Point(218, 314)
        Me.grpOrderTotal.Name = "grpOrderTotal"
        Me.grpOrderTotal.Size = New System.Drawing.Size(204, 119)
        Me.grpOrderTotal.TabIndex = 10
        Me.grpOrderTotal.TabStop = False
        Me.grpOrderTotal.Text = "OrderTotal"
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Location = New System.Drawing.Point(81, 90)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.Size = New System.Drawing.Size(102, 20)
        Me.txtOrderTotal.TabIndex = 7
        Me.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.Location = New System.Drawing.Point(15, 94)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(63, 13)
        Me.lblOrderTotal.TabIndex = 6
        Me.lblOrderTotal.Text = "Order Total:"
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Location = New System.Drawing.Point(81, 54)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.Size = New System.Drawing.Size(102, 20)
        Me.txtSalesTax.TabIndex = 5
        Me.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(21, 57)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(57, 13)
        Me.lblSalesTax.TabIndex = 4
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'txtFoodTotal
        '
        Me.txtFoodTotal.Location = New System.Drawing.Point(81, 18)
        Me.txtFoodTotal.Name = "txtFoodTotal"
        Me.txtFoodTotal.Size = New System.Drawing.Size(102, 20)
        Me.txtFoodTotal.TabIndex = 3
        Me.txtFoodTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFoodTotal
        '
        Me.lblFoodTotal.AutoSize = True
        Me.lblFoodTotal.Location = New System.Drawing.Point(17, 21)
        Me.lblFoodTotal.Name = "lblFoodTotal"
        Me.lblFoodTotal.Size = New System.Drawing.Size(61, 13)
        Me.lblFoodTotal.TabIndex = 0
        Me.lblFoodTotal.Text = "Food Total:"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(433, 338)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 11
        Me.btnTotal.Text = "&Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(433, 367)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnNewOrder.TabIndex = 12
        Me.btnNewOrder.Text = "&New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(433, 396)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtpDateTime
        '
        Me.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTime.Location = New System.Drawing.Point(82, 110)
        Me.dtpDateTime.Name = "dtpDateTime"
        Me.dtpDateTime.Size = New System.Drawing.Size(121, 20)
        Me.dtpDateTime.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(532, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "+ Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 445)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtpDateTime)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.grpOrderTotal)
        Me.Controls.Add(Me.grpOrderSummary)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrder"
        Me.Text = "frmOrder"
        Me.grpOrderSummary.ResumeLayout(False)
        Me.panOrderSummary.ResumeLayout(False)
        Me.panOrderSummary.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOrderTotal.ResumeLayout(False)
        Me.grpOrderTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents grpMenu As System.Windows.Forms.GroupBox
    Friend WithEvents grpOrderSummary As System.Windows.Forms.GroupBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents cboItem As System.Windows.Forms.ComboBox
    Friend WithEvents grpOrderTotal As System.Windows.Forms.GroupBox
    Friend WithEvents txtFoodTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblFoodTotal As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtOrderTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderTotal As System.Windows.Forms.Label
    Friend WithEvents txtSalesTax As System.Windows.Forms.TextBox
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents dtpDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents panOrderSummary As System.Windows.Forms.Panel
End Class

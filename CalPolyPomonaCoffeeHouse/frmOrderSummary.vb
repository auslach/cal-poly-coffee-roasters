Imports CalPolyPomonaCoffeeHouseBM

Public Class frmOrderSummary

    Private Sub frmOrderSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Loading Order Summary Form")
        Dim orders As Collection = frmMain.ctrl.getAllOrders()
        Dim positionFromTop As Integer = panOrdSumHeader.Top + 0

        For Each order As Order In orders
            positionFromTop += 25

            Dim panOrder As New Panel
            panOrder.Width = panOrdSumHeader.Width
            panOrder.Height = panOrdSumHeader.Height
            panOrder.Left = panOrdSumHeader.Left
            panOrder.Top = positionFromTop
            panOrder.Tag = order.ID
            panOrder.BorderStyle = BorderStyle.FixedSingle
            panSummary.Controls.Add(panOrder)

            Dim lblOrderIDVal As New Label
            lblOrderIDVal.Text = order.ID
            lblOrderIDVal.Left = lblOrderID.Left
            lblOrderIDVal.Width = lblOrderID.Width
            lblOrderIDVal.Tag = order.ID
            lblOrderIDVal.TextAlign = HorizontalAlignment.Center

            Dim lblServerVal As New Label
            lblServerVal.Text = order.server
            lblServerVal.Left = lblServer.Left
            lblServerVal.Width = lblServer.Width
            lblServerVal.Tag = order.ID
            lblServerVal.TextAlign = HorizontalAlignment.Center

            Dim lblDateVal As New Label
            lblDateVal.Text = order.orderDate
            lblDateVal.Left = lblOrderDate.Left
            lblDateVal.Width = lblOrderDate.Width
            lblDateVal.Tag = order.ID
            lblDateVal.TextAlign = HorizontalAlignment.Center

            Dim lblgrandTotalVal As New Label
            lblgrandTotalVal.Text = FormatCurrency(order.grandTotal, 2)
            lblgrandTotalVal.Left = lblgrandTotal.Left
            lblgrandTotalVal.Width = lblgrandTotal.Width
            lblgrandTotalVal.Tag = order.ID
            lblgrandTotalVal.TextAlign = HorizontalAlignment.Center


            Console.WriteLine("Order ID " & order.ID)
            Console.WriteLine("Order ID " & order.server)
            Console.WriteLine("Order ID " & order.orderDate)
            Console.WriteLine("Order ID " & order.grandTotal)
            Console.WriteLine("position from top " & positionFromTop)
            Console.WriteLine("position from left " & lblOrderID.Left)
            Console.WriteLine("width " & lblOrderIDVal.Width)

            panOrder.Controls.Add(lblOrderIDVal)
            panOrder.Controls.Add(lblServerVal)
            panOrder.Controls.Add(lblDateVal)
            panOrder.Controls.Add(lblgrandTotalVal)
            AddHandler lblOrderIDVal.DoubleClick, AddressOf panel_Click
            AddHandler lblServerVal.DoubleClick, AddressOf panel_Click
            AddHandler lblDateVal.DoubleClick, AddressOf panel_Click
            AddHandler lblgrandTotalVal.DoubleClick, AddressOf panel_Click
            AddHandler panOrder.DoubleClick, AddressOf panel_Click
        Next
    End Sub


    Private Sub panel_Click(sender As Object, e As EventArgs) Handles panOrdSumHeader.DoubleClick
        Dim index As Integer = sender.tag
        frmMain.openOrder(sender.tag)
        Console.WriteLine("tag #: " & sender.tag)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Me.Close()
        frmMain.mnuOpenOrderSummary.PerformClick()
    End Sub
End Class
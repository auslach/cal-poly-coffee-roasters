Imports System.Windows.Forms
Imports CalPolyPomonaCoffeeHouseBM

Public Class frmMain

    Public ctrl As New Controller

    Private m_ChildFormNumber As Integer = 0

    Private Sub mnuFile_DropDownOpening(sender As Object, e As EventArgs) Handles mnuFile.DropDownOpening
        If Me.ActiveMdiChild IsNot Nothing Then
            mnuFileClose.Enabled = True
            mnuFileSave.Enabled = True
            mnuFileDelete.Enabled = True
            If Me.ActiveMdiChild Is frmOrderSummary Then
                mnuFileSave.Enabled = False
                mnuFileDelete.Enabled = False
            End If
        Else
            mnuFileClose.Enabled = False
            mnuFileSave.Enabled = False
            mnuFileDelete.Enabled = False
        End If
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        ' New instance of the order form
        Dim frm As New frmOrder
        frm.MdiParent = Me
        m_ChildFormNumber += 1
        frm.Text = "Order #" & m_ChildFormNumber
        frm.Show()
    End Sub

    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        ' Close the active order form
        Me.ActiveMdiChild.Close()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuWindowTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowArrangeIcons_Click(sender As Object, e As EventArgs) Handles mnuWindowArrangeIcons.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Public Sub CheckEditMenu()
        mnuEditCut.Enabled = False
        mnuEditCopy.Enabled = False
        mnuEditPaste.Enabled = False

        If Not ActiveMdiChild Is Nothing Then
            If Not ActiveMdiChild.ActiveControl Is Nothing Then
                ' check if active control is text
                ' if active control is textbox
                If TypeOf ActiveMdiChild.ActiveControl Is TextBox Then
                    If CType(ActiveMdiChild.ActiveControl, TextBox).SelectedText <> "" Then
                        mnuEditCut.Enabled = True
                        mnuEditCopy.Enabled = True
                    End If
                End If

                ' if clipboard contains text & active control is textbox
                If TypeOf ActiveMdiChild.ActiveControl Is TextBox Then
                    If Clipboard.ContainsText() Then
                        mnuEditPaste.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        CheckEditMenu()
        If mnuEditCut.Enabled = True Then
            ' Cut text, add to clipboard
            ' Check for textbox
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText())
                CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText = ""
            End If
        End If
    End Sub

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        CheckEditMenu()
        If mnuEditCopy.Enabled = True Then
            ' copy text, add to clipboard
            ' check for textbox
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                Clipboard.SetText(CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText())
            End If
        End If
    End Sub

    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        CheckEditMenu()
        If mnuEditPaste.Enabled = True Then
            ' paste text from clipboard to active control
            ' must be textbox
            If TypeOf Me.ActiveMdiChild.ActiveControl Is TextBox Then
                CType(Me.ActiveMdiChild.ActiveControl, TextBox).SelectedText() = Clipboard.GetText()
            End If
        End If
    End Sub

    Private Sub mnuEdit_DropDownOpening(sender As Object, e As EventArgs) Handles mnuEdit.DropDownOpening
        CheckEditMenu()
    End Sub

    Private Sub OrderSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderSummaryToolStripMenuItem.Click
        frmOrderSummary.MdiParent = Me
        frmOrderSummary.Text = "Order Summary"
        frmOrderSummary.Show()
    End Sub

    Private Sub OrderFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderFormToolStripMenuItem.Click
        mnuFileNew.PerformClick()
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click

    End Sub
End Class

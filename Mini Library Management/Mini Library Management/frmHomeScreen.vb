Public Class frmHomeScreen
    Private Sub GenreBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GenreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)

    End Sub

    Private Sub GenreBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GenreBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.MiniLibraryDataSet1)

    End Sub

    Private Sub btnGenre_Click(sender As Object, e As EventArgs) Handles btnGenre.Click
        frmGenre.Show()
        frmBook.Close()
        frmBookDetails.Close()
        frmReturnBook.Close()
        frmNewBorrower.Close()
        frmTotalBook.Close()
        frmTotalUnreturn.Close()
        Me.Hide()
    End Sub

    Private Sub btnTitle_Click(sender As Object, e As EventArgs) Handles btnTitle.Click
        frmBookDetails.Show()
        frmBook.Close()
        frmGenre.Close()
        frmReturnBook.Close()
        frmNewBorrower.Close()
        frmTotalBook.Close()
        frmTotalUnreturn.Close()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
        SplashScreen1.Close()
    End Sub

    Private Sub btnAddNewBook_Click(sender As Object, e As EventArgs) Handles btnAddNewBook.Click
        frmBook.Show()
        frmGenre.Close()
        frmBookDetails.Close()
        frmReturnBook.Close()
        frmNewBorrower.Close()
        frmTotalBook.Close()
        frmTotalUnreturn.Close()
        Me.Hide()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmNewBorrower.Show()
        frmBook.Close()
        frmGenre.Close()
        frmBookDetails.Close()
        frmReturnBook.Close()
        frmTotalBook.Close()
        frmTotalUnreturn.Close()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmReturnBook.show()
        frmNewBorrower.Close()
        frmBook.Close()
        frmGenre.Close()
        frmBookDetails.Close()
        frmTotalBook.Close()
        frmTotalUnreturn.Close()
        Me.Hide()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        frmTotalBook.Show()
        frmReturnBook.Close()
        frmNewBorrower.Close()
        frmBook.Close()
        frmGenre.Close()
        frmBookDetails.Close()
        frmTotalUnreturn.Close()
        Me.Hide()
    End Sub

    Private Sub btnUnreturn_Click(sender As Object, e As EventArgs) Handles btnUnreturn.Click
        Me.Hide()
        frmTotalUnreturn.Show()
        frmTotalBook.Close()
        frmReturnBook.Close()
        frmNewBorrower.Close()
        frmBook.Close()
        frmGenre.Close()
        frmBookDetails.Close()
    End Sub

    Private Sub mnuBookGenre_Click(sender As Object, e As EventArgs) Handles mnuBookGenre.Click
        btnGenre_Click(sender, e)
    End Sub

    Private Sub frmBookAddNew_Click(sender As Object, e As EventArgs) Handles frmBookAddNew.Click
        btnAddNewBook_Click(sender, e)
    End Sub

    Private Sub mnuBookInformation_Click(sender As Object, e As EventArgs) Handles mnuBookInformation.Click
        btnTitle_Click(sender, e)
    End Sub

    Private Sub mnuBorrowerAdd_Click(sender As Object, e As EventArgs) Handles mnuBorrowerAdd.Click
        btnAddNew_Click(sender, e)
    End Sub

    Private Sub mnuBorrowerReturn_Click(sender As Object, e As EventArgs) Handles mnuBorrowerReturn.Click
        btnReturn_Click(sender, e)
    End Sub

    Private Sub mnuReportTotalBook_Click(sender As Object, e As EventArgs) Handles mnuReportTotalBook.Click
        btnTotal_Click(sender, e)
    End Sub

    Private Sub mnuReportUnreturned_Click(sender As Object, e As EventArgs) Handles mnuReportUnreturned.Click
        btnUnreturn_Click(sender, e)
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        btnExit_Click(sender, e)
    End Sub
End Class
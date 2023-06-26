Public Class frmReturnBook
    Private Sub BorrowBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BorrowBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)

    End Sub

    Private Sub frmReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MiniLibraryDataSet.Borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.MiniLibraryDataSet.Borrow)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomeScreen.Show()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Borrow_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Borrow_IDTextBox.TextChanged

    End Sub

    Private Sub Borrow_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Borrow_NameTextBox.TextChanged

    End Sub

    Private Sub Borrow_PnumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles Borrow_PnumberTextBox.TextChanged

    End Sub

    Private Sub Borrow_BNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Borrow_BNameTextBox.TextChanged

    End Sub

    Private Sub Book_CodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles Book_CodeTextBox.TextChanged

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BorrowBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BorrowBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BorrowBindingSource.RemoveCurrent()
        BorrowTableAdapter.Update(MiniLibraryDataSet.Borrow)
        MsgBox("Deleted")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)
        MsgBox("Saved")
    End Sub
End Class
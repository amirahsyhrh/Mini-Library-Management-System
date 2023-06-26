Public Class frmBookDetails
    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)

    End Sub

    Private Sub frmBookDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MiniLibraryDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.MiniLibraryDataSet.Book)

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BookBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BookBindingSource.MoveNext()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)
        MsgBox("Saved")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        BookBindingSource.RemoveCurrent()
        BookTableAdapter.Update(MiniLibraryDataSet.Book)
        MsgBox("Deleted")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomeScreen.Show()
    End Sub
End Class
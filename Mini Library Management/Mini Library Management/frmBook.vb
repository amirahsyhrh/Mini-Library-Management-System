Public Class frmBook
    Private Sub GenreBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GenreBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GenreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)

    End Sub

    Private Sub frmBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MiniLibraryDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.MiniLibraryDataSet.Book)
        'TODO: This line of code loads data into the 'MiniLibraryDataSet.Genre' table. You can move, or remove it, as needed.
        Me.GenreTableAdapter.Fill(Me.MiniLibraryDataSet.Genre)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomeScreen.Show()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.GenreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)
        MsgBox("Saved")
    End Sub

    Private Sub btnPrevious_Click_1(sender As Object, e As EventArgs) Handles btnPrevious.Click
        GenreBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        GenreBindingSource.MoveNext()
    End Sub
End Class
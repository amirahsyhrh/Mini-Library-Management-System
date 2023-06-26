Public Class frmGenre
    Private Sub GenreBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GenreBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GenreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)

    End Sub

    Private Sub frmGenre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MiniLibraryDataSet.Genre' table. You can move, or remove it, as needed.
        Me.GenreTableAdapter.Fill(Me.MiniLibraryDataSet.Genre)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomeScreen.Show()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        GenreBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        GenreBindingSource.MoveNext()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, Button4.Click, Button1.Click
        GenreBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click, Button6.Click, Button3.Click
        Me.GenreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)
        MsgBox("Saved")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click, Button5.Click, Button2.Click
        GenreBindingSource.RemoveCurrent()
        GenreTableAdapter.Update(MiniLibraryDataSet.Genre)
        MsgBox("Deleted")
    End Sub
End Class
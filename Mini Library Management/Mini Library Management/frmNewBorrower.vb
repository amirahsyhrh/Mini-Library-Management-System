Public Class frmNewBorrower
    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)

    End Sub

    Private Sub BorrowBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BorrowBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)

    End Sub

    Private Sub frmNewBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MiniLibraryDataSet.Borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.MiniLibraryDataSet.Borrow)
        'procedure to insert book title to List box'
        getListBook()
    End Sub

    Private Function getListBook()
        Dim strSql As String = "SELECT * FROM BOOK"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user10\Desktop\CSC301 VISUAL PROGRAMMING\Group project\Mini Library Management System\MiniLibrary.accdb"
        Dim odaPop As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim intCountBook As Integer
        odaPop.Fill(datValue)
        odaPop.Dispose()


        For intCount = 0 To datValue.Rows.Count - 1
            lstBook.Items.Add(datValue.Rows(intCount)("Book Title"))
        Next
        intCountBook = lstBook.Items.Count
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'procedure get Book Code and Book Title for textbox'
        getTextBox()
    End Sub

    Private Function getTextBox()
        Dim strTitle As String
        strTitle = lstBook.SelectedItem.ToString()
        txtBookName.Text = strTitle
        Dim strSql2 As String = "SELECT * FROM BOOK"
        Dim strPath2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user10\Desktop\CSC301 VISUAL PROGRAMMING\Group project\Mini Library Management System\MiniLibrary.accdb"
        Dim odaPop2 As New OleDb.OleDbDataAdapter(strSql2, strPath2)
        Dim datValue2 As New DataTable
        Dim intCount As Integer
        Dim strTitleNew As String
        Dim strCode As String

        odaPop2.Fill(datValue2)
        odaPop2.Dispose()

        For intCount = 0 To datValue2.Rows.Count - 1
            strTitleNew = datValue2.Rows(intCount)("Book Title")
            strCode = datValue2.Rows(intCount)("Book Code")
            If strTitle = strTitleNew Then
                Book_CodeTextBox.Text = strCode
            End If
        Next
    End Function

    Private Sub chkSort_CheckedChanged(sender As Object, e As EventArgs) Handles chkSort.CheckedChanged
        lstBook.Sorted = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomeScreen.Show()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BorrowBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BorrowBindingSource.MoveNext()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MiniLibraryDataSet)
        MsgBox("Saved")
    End Sub

    Private Sub btnAd_Click(sender As Object, e As EventArgs) Handles btnAd.Click
        BorrowBindingSource.AddNew()
    End Sub
End Class
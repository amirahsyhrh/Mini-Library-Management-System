Public Class frmTotalUnreturn
    Private Sub frmTotalUnreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inttotalUnreturn As Integer
        'function to get the total of unreturned book'
        inttotalUnreturn = calculateUnreturned()
        lblDisplay.Text = "Total of Unreturned Book: " & inttotalUnreturn.ToString()
    End Sub

    Private Function calculateUnreturned() As Integer
        Dim intTotal As Integer = 0
        Dim strSqlBook As String = "SELECT * FROM BORROW"
        Dim strPathBook As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user10\Desktop\CSC301 VISUAL PROGRAMMING\Group project\Mini Library Management System\MiniLibrary.accdb"
        Dim odaPopBook As New OleDb.OleDbDataAdapter(strSqlBook, strPathBook)
        Dim datValueBook As New DataTable
        Dim intCount As Integer
        odaPopBook.Fill(datValueBook)
        odaPopBook.Dispose()

        For intCount = 0 To datValueBook.Rows.Count - 1
            intTotal += 1
        Next
        Return intTotal
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
        frmHomeScreen.Show()
    End Sub

End Class
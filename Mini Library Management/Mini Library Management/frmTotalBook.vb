Public Class frmTotalBook
    Private Sub frmTotalBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'procedure to insert genre into combo box and list box'
        getComboBox()
    End Sub

    Private Function getComboBox()
        Dim strSql As String = "SELECT * FROM GENRE"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user10\Desktop\CSC301 VISUAL PROGRAMMING\Group project\Mini Library Management System\MiniLibrary.accdb"
        Dim odaPop As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim strGen As String
        Dim strName As String
        odaPop.Fill(datValue)
        odaPop.Dispose()


        For intCount = 0 To datValue.Rows.Count - 1
            strGen = datValue.Rows(intCount)("Genre Code")
            strName = datValue.Rows(intCount)("Genre Name")
            cboGenre.Items.Add(strGen)
            lstGenre.Items.Add(strGen & " - " & strName)
        Next
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intTotal As Integer
        'function to calculate the total book for each genre'
        intTotal = calculateGenre()
        lblTotal.Text = "Total Book for this Genre: " & intTotal.ToString()
    End Sub

    Private Function calculateGenre() As Integer
        Dim intTotal As Integer
        Dim strSqlBook As String = "SELECT * FROM BOOK"
        Dim strPathBook As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user10\Desktop\CSC301 VISUAL PROGRAMMING\Group project\Mini Library Management System\MiniLibrary.accdb"
        Dim odaPopBook As New OleDb.OleDbDataAdapter(strSqlBook, strPathBook)
        Dim datValueBook As New DataTable
        Dim intCount As Integer
        Dim strGenre As String
        odaPopBook.Fill(datValueBook)
        odaPopBook.Dispose()
        strGenre = cboGenre.SelectedItem.ToString()

        For intCount = 0 To datValueBook.Rows.Count - 1
            If strGenre = datValueBook.Rows(intCount)("Genre Code") Then
                intTotal += 1
                lstBook.Items.Add(datValueBook.Rows(intCount)("Book Title"))
            End If
        Next
        Return intTotal
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstBook.Items.Clear()
        lblTotal.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHomeScreen.Show()
    End Sub
End Class
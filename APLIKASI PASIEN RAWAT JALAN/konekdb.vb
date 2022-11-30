Imports System.Data.Odbc
Module konekdb
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader
    Public MyDB As String
    Sub koneksi()
        MyDB = "Driver={Mysql ODBC 3.51 Driver};Database=db_prj;server=localhost;uid=root"
        conn = New OdbcConnection(MyDB)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module

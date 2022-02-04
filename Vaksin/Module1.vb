Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data.OleDb

Module Module1
    Public konek As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DR As OdbcDataReader
    Public DS As DataSet
    Public CMD As OdbcCommand

    Sub bukaDB()
        Try
            konek = New OdbcConnection("DSN=covid19;MultipleActiveResultSets=True")
            If konek.State = ConnectionState.Closed Then
                konek.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Database bermasalah, Silahkan periksa ODBC anda")
        End Try
    End Sub

End Module

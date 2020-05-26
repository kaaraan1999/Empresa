Imports System.Data.SqlClient

Public Class Application

    '=== Module Program
    '=== Sub Main
    Public Shared Sub Main(args As String())

        'Create ADO.NET objects.
        Dim myConn As SqlConnection
        Dim myCmd As SqlCommand
        Dim row As String
        Dim connectionString As String = "Server=DESKTOP-MTNSN4B\SQLEXPRESS;Database=dbo.EMPRESAPF;Trusted_Connection=True;"

        Console.OutputEncoding = Text.Encoding.UTF8 'Para permitir el €
        Console.WriteLine("Hello SQL-World!!!")
        Console.WriteLine(connectionString)


        'Connection y abrimos
        myConn = New SqlConnection(connectionString)
        myConn.Open()

        'Comando a ejecutar
        myCmd = myConn.CreateCommand

        'Create TABLE
        myCmd.CommandText = "
        DROP TABLE IF EXISTS ARTICULOS
        CREATE TABLE EJEMPLO(
            IDARTICULO INT IDENTITY,
            NOMBRE NVARCHAR(30),
            PRECIO NUMERIC(5,2)
        )"
        myCmd.ExecuteNonQuery()
        myCmd.Dispose()
        myConn.Close()



    End Sub

    '=== End Module
End Class
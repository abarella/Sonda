Namespace AcessoDados

    Public Class Conexao
        Implements IDisposable
        Dim sqlConn As New SqlClient.SqlConnection

        Protected disposed As Boolean = False

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            Try
                If Not Me.disposed Then
                    If disposing Then
                        ' Insert code to free unmanaged resources.
                    End If
                    If sqlConn.State <> ConnectionState.Closed Then
                        sqlConn.Close()
                        sqlConn.Dispose()
                    End If
                End If

            Catch ex As Exception

            End Try
            Me.disposed = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
        Protected Overrides Sub Finalize()
            Dispose(False)
            MyBase.Finalize()
        End Sub

        Protected ReadOnly Property StringConexaoSGCR() As String
            Get
                'Return "Persist Security Info=False; User ID=crsa;Password=cr9537; Initial Catalog=SGCR; Data Source=UIRAPURU"
                Return "Persist Security Info=False; User ID=crsa;Password=cr9537; Initial Catalog=SGCR; Data Source=TICOTECO"
            End Get

        End Property

        Protected ReadOnly Property StringConexaoVendasPelicano() As String
            Get
                'Return "Persist Security Info=False; User ID=crsa;Password=cr9537; Initial Catalog=VENDASPELICANO; Data Source=UIRAPURU"
                Return "Persist Security Info=False; User ID=crsa;Password=cr9537; Initial Catalog=VENDASPELICANO; Data Source=TICOTECO"
            End Get
        End Property

        Protected ReadOnly Property StringConexaoVendasInternet() As String
            Get
                'Return "Persist Security Info=False; User ID=crsa;Password=cr9537; Initial Catalog=VENDASINTERNET; Data Source=UIRAPURU"
                Return "Persist Security Info=False; User ID=crsa;Password=cr9537; Initial Catalog=VENDASINTERNET; Data Source=TICOTECO"
            End Get
        End Property

        Protected Function EfetuarConexao(ByVal eConexaoBanco As String) As SqlClient.SqlConnection
            If disposed Then sqlConn = New SqlClient.SqlConnection

            If eConexaoBanco = "SGCR" Then
                sqlConn.ConnectionString = StringConexaoSGCR
            ElseIf eConexaoBanco = "VendasInternet" Then
                sqlConn.ConnectionString = StringConexaoVendasInternet
            Else
                sqlConn.ConnectionString = StringConexaoVendasPelicano
            End If

            sqlConn.Open()
            disposed = False
            Return sqlConn

        End Function
    End Class
End Namespace

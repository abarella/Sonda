Namespace AcessoDados

    Public Class clsAbrirMonitoracao

        Dim varPlano As String
        Dim varVariacao As Integer
        Dim varMonitor As Integer


        Public Property Plano() As String
            Get
                Return varPlano
            End Get

            Set(ByVal Value As String)
                varPlano = Trim(Value)
            End Set

        End Property

        Public Property Variacao() As Integer
            Get
                Return varVariacao
            End Get

            Set(ByVal Value As Integer)
                varVariacao = Value
            End Set

        End Property

        Public Property Monitor() As Integer
            Get
                Return varMonitor
            End Get

            Set(ByVal Value As Integer)
                varMonitor = Value
            End Set

        End Property


        Public Function CarregarPagina()
            Dim Executor As New AcessoDados.Executar

            Try
                Executor.SQLComando = "crsa.MONITORAREMBALADO_PRODUCAO"
                Executor.addParametros("xml", 1, Executar.TipoDirecao.eTPEntrada, SqlDbType.SmallInt, 1)
                Executor.ExecutarOperacao(Executar.TipoRetorno.eDataSet, "SGCR")

                Return Executor.RetornoDataSet

            Catch ex As Exception

            Finally
                Executor.Dispose()
            End Try

        End Function

        Public Function CarregarPlano()
            Dim Executor As New AcessoDados.Executar

            Try
                Executor.SQLComando = "dbo.MONITORAREMBALADO_PLANO"
                Executor.addParametros("xml", 1, Executar.TipoDirecao.eTPEntrada, SqlDbType.SmallInt, 1)
                Executor.ExecutarOperacao(Executar.TipoRetorno.eDataSet, "VENDASPELICANO")

                Return Executor.RetornoDataSet

            Catch ex As Exception

            Finally
                Executor.Dispose()
            End Try

        End Function

        Public Function CarregarDetector()
            Dim Executor As New AcessoDados.Executar

            Try
                Executor.SQLComando = "dbo.MONITORAREMBALADO_MONITOR"
                Executor.ExecutarOperacao(Executar.TipoRetorno.eDataSet, "VENDASPELICANO")

                Return Executor.RetornoDataSet

            Catch ex As Exception

            Finally
                Executor.Dispose()
            End Try

        End Function

        Public Function CarregarVariacao()
            Dim Executor As New AcessoDados.Executar

            Try
                Executor.SQLComando = "dbo.MONITORAREMBALADO_VARIACAO"
                Executor.addParametros("xml", 1, Executar.TipoDirecao.eTPEntrada, SqlDbType.SmallInt, 1)
                Executor.ExecutarOperacao(Executar.TipoRetorno.eDataSet, "VENDASPELICANO")

                Return Executor.RetornoDataSet

            Catch ex As Exception

            Finally
                Executor.Dispose()
            End Try

        End Function

        Public Function Salvar()
            Dim Executor As New AcessoDados.Executar

            Try
                Executor.SQLComando = "crsa.MONITORAREMBALADO_PRODUCAO_INCLUIR"
                Executor.addParametros("p280_id", 1, Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                Executor.addParametros("p283_variacao", Variacao, Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                Executor.addParametros("p395_planoid", Plano, Executar.TipoDirecao.eTPEntrada, SqlDbType.Char, 1)
                Executor.addParametros("p396_monitorid", Monitor, Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                Executor.addParametros("cdusuario", Usuario, Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                Executor.ExecutarOperacao(Executar.TipoRetorno.eDataSet, "SGCR")

                Return Executor.RetornoDataSet

            Catch ex As Exception

            Finally
                Executor.Dispose()
            End Try

        End Function


    End Class

End Namespace

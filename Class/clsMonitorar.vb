Namespace AcessoDados

    Public Class clsMonitorar
        Dim varChave As String
        'Dim varDose1m As Integer
        Dim varDosecx As Integer
        Dim varIt As Object
        Dim varEtq As Integer
        Dim varP110fisc As Integer
        Dim varP110id As Integer
        Dim varNotafis_oid As Integer

        Public Property Chave() As String
            Get
                Return varChave
            End Get

            Set(ByVal Value As String)
                varChave = Trim(Value)
            End Set

        End Property

        'Public Property Dose1m() As Integer
        '    Get
        '        Return varDose1m
        '    End Get

        '    Set(ByVal Value As Integer)
        '        varDose1m = Value
        '    End Set

        'End Property

        Public Property Dosecx() As Integer
            Get
                Return varDosecx
            End Get

            Set(ByVal Value As Integer)
                varDosecx = Value
            End Set

        End Property

        Public Property It() As String
            Get
                Return varIt
            End Get

            Set(ByVal Value As String)
                varIt = Value
            End Set

        End Property

        Public Property Etq() As Integer
            Get
                Return varEtq
            End Get

            Set(ByVal Value As Integer)
                varEtq = Value
            End Set

        End Property

        Public Property P110id() As Integer
            Get
                Return varP110id
            End Get

            Set(ByVal Value As Integer)
                varP110id = Value
            End Set

        End Property

        Public Property P110fisc() As Integer
            Get
                Return varP110fisc
            End Get

            Set(ByVal Value As Integer)
                varP110fisc = Value
            End Set

        End Property

        Public Property Notafis_oid() As Integer
            Get
                Return varNotafis_oid
            End Get

            Set(ByVal Value As Integer)
                varNotafis_oid = Value
            End Set

        End Property

        Public Function BuscaChave()
            Dim executor As New MONITORACAO_EMBALADO.AcessoDados.Executar

            Try
                executor.SQLComando = "crsa.MONITORAREMBALADO_LISTA"
                executor.addParametros("p283_id", p283id, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.addParametros("p110chve", Chave, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 9)
                executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "SGCR")

                Return executor.RetornoDataSet

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            Finally
                executor.Dispose()
            End Try
        End Function


        'Public Function GravaChave() As DataSet
        '    Dim executor As New AcessoDados.Executar

        '    Try
        '        executor.SQLComando = "dbo.P0110_PEDIDO_IT3_NET"
        '        executor.addParametros("p110chve", Chave, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 9)
        '        executor.addParametros("dose1m", Dose1m, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
        '        executor.addParametros("dosecx", Dosecx, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
        '        executor.addParametros("it", It, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Float, 4)
        '        executor.addParametros("etq", Etq, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
        '        executor.addParametros("p283_id", p283id, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
        '        executor.addParametros("cdusuario", Usuario, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
        '        executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "VendasPelicano")

        '        Return executor.RetornoDataSet

        '    Catch ex As Exception

        '    Finally
        '        executor.Dispose()
        '    End Try

        'End Function


        Public Function EmitirNotaDataSheet() As DataSet
            Dim executor As New AcessoDados.Executar

            Try
                'Grava Nota Fiscal Eletrônica
                executor.SQLComando = "dbo.PNFE_GRAVA"
                executor.addParametros("notafis_oid", Notafis_oid, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.addParametros("nf", P110fisc, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "VendasInternet")

                executor.Dispose()

                'Inicia geração de datasheet
                executor.SQLComando = "dbo.MONITORAREMBALADO_GERAR_NOTA"
                executor.addParametros("p110chve", Chave, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 9)
                executor.addParametros("tipo", 4, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "VendasPelicano")

                Return executor.RetornoDataSet


            Catch ex As Exception

            Finally
                executor.Dispose()
            End Try

        End Function

        Public Function EmitirGuia() As DataSet
            Dim executor As New AcessoDados.Executar

            Try
                'Emitir guia de monitoração
                executor.SQLComando = "dbo.MONITORAREMBALADO_GERAR_NOTA_NFE_REEMISSAO"
                executor.addParametros("p110chve", Chave, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 9)
                'executor.addParametros("p110chve", "010FL0087", AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 9)
                executor.addParametros("tipo", 4, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "VendasPelicano")

                Return executor.RetornoDataSet


            Catch ex As Exception

            Finally
                executor.Dispose()
            End Try

        End Function


        Public Function GravaNotaEmitida() As DataSet
            Dim executor As New AcessoDados.Executar

            Try
                'GRAVA A INFORMAÇÃO DE QUE A NOTA FISCAL FOI IMPRESSA
                executor.SQLComando = "dbo.MONITORAREMBALADO_GRAVA_GERAR_NOTA"
                executor.addParametros("p110fisc", P110fisc, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.addParametros("p110id", P110id, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "VendasPelicano")
                'FIM DE INSTRUÇÃO ---A INFORMAÇÃO DE QUE A NOTA FISCAL FOI IMPRESSA JÁ FOI GRAVADA

                Return executor.RetornoDataSet

            Catch ex As Exception

            Finally
                executor.Dispose()
            End Try

        End Function

        Public Function GravaChave() As DataSet
            Dim executor As New AcessoDados.Executar

            Try
                executor.SQLComando = "dbo.MONITORAREMBALADO_PEDIDO_IT"
                executor.addParametros("p110chve", Chave, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 9)
                executor.addParametros("dosecx", Dosecx, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.addParametros("it", CObj(It), AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Char, 4)
                executor.addParametros("etq", Etq, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.addParametros("p283_id", p283id, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.addParametros("cdusuario", Usuario, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Int, 4)
                executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "VendasPelicano")

                Return executor.RetornoDataSet

            Catch ex As Exception

            Finally
                executor.Dispose()
            End Try

        End Function

    End Class

End Namespace
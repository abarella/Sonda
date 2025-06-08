Public Class frmReemissaoDatasheet

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtLote.Text = ""
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Dim Executor As New AcessoDados.clsMonitorar
        Dim rsTabela As New DataSet
        Dim Documento As String
        Dim i As Integer
        Dim CaminhoGravarTxt As String
        Dim ImpressoraEsteira As String
        Dim xChave As String
        Dim Formato As System.Text.Encoding
        Formato = System.Text.Encoding.Default
        Dim Texto


        CaminhoGravarTxt = "C:\TXT\"
        ImpressoraEsteira = "\\SAURA\ENTRADA_ESTEIRA"

        Try

            If Trim(txtLote.Text) = "" Then
                txtLote.Text = ""
                txtLote.Focus()
                Exit Sub
            End If

            xChave = txtLote.Text.Substring(0, 9).ToString.ToUpper

            Executor.Chave = xChave

            rsTabela = Nothing

            'IMPRIMIR A DATASHEET(ESTEIRA) E GUIA DE MONITORAÇÃO
            rsTabela = Executor.EmitirGuia()

            Documento = ""

            i = 0
            For Each Texto In rsTabela.Tables(0).Rows
                Documento = Documento & rsTabela.Tables(0).Rows(i).Item(0).ToString() & vbCrLf
                i = i + 1
            Next


            If Documento <> "" Then
                Dim ArquivoDeclaracao As System.IO.File
                ArquivoDeclaracao.WriteAllText(CaminhoGravarTxt & xChave & "D.txt", Documento, Formato)
                Threading.Thread.Sleep(100)
                System.IO.File.Copy(CaminhoGravarTxt & xChave & "D.txt", ImpressoraEsteira)
            End If
            'Finaliza geração de datasheet

            rsTabela = Nothing

        Catch ex As Exception

        Finally
            txtLote.Text = ""
            txtLote.Focus()
        End Try
    End Sub

    Private Sub btnZerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZerar.Click
        Dim executor As New AcessoDados.Executar

        Try

            If Trim(txtLote.Text) = "" Then
                txtLote.Text = ""
                txtLote.Focus()
                Exit Sub
            End If

            If MsgBox("TEM CERTEZA DE QUE DESEJA REALMENTE PASSAR ESTE BALDE NOVAMENTE?", MsgBoxStyle.OkCancel, "ZERAR BALDE") = MsgBoxResult.Cancel Then
                txtLote.Focus()
                Exit Sub
            Else
                executor.SQLComando = "crsa.REINICIAR_EMBALADO"
                executor.addParametros("p110chve", txtLote.Text.Substring(0, 9).ToString.ToUpper, AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 9)
                executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "SGCR")
            End If

        Catch ex As Exception

        Finally
            executor.Dispose()
        End Try


    End Sub

    Private Sub frmReemissaoDatasheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtLote.Focus()
    End Sub
End Class

Public Class frmAbrirMonitaracao

    Private Sub cmdSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSair.Click
        Me.Close()
    End Sub

    Private Sub cmdLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpar.Click
        cmbDetector.SelectedIndex = 0
        cmbPlano.SelectedIndex = 0
        cmbVariacao.SelectedIndex = 0
    End Sub

    Private Sub frmAbrirMonitaracao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CarregarDetector()
        Call CarregarPlano()
        Call CarregarVariacao()
        Call CarregarPortaSerial()
        Call CarregarNumeroContagem()
        Threading.Thread.Sleep(100)

        Call CarregarPagina()
    End Sub

    
    Private Sub CarregarPagina()
        Dim xPagina As New AcessoDados.clsAbrirMonitoracao
        Dim rsTabela As New DataSet

        Try

            With rsTabela
                rsTabela = xPagina.CarregarPagina
                cmbDetector.SelectedValue = CInt(rsTabela.Tables("PRODUCAO").Rows(0).Item("p396_monitorid").ToString())
                cmbPlano.SelectedValue = Trim(rsTabela.Tables("PRODUCAO").Rows(0).Item("p395_planoid").ToString())
                cmbVariacao.SelectedValue = CInt(rsTabela.Tables("PRODUCAO").Rows(0).Item("p283_variacao").ToString())
                p280id = CInt(rsTabela.Tables("PRODUCAO").Rows(0).Item("p280_id").ToString())
                p283id = CInt(rsTabela.Tables("PRODUCAO").Rows(0).Item("p283_id").ToString())
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CarregarDetector()
        Dim xDetector As New AcessoDados.clsAbrirMonitoracao
        Dim rsTabela As New DataSet

        Try

            With rsTabela
                rsTabela = xDetector.CarregarDetector
                cmbDetector.Items.Clear()
                cmbDetector.DataSource = rsTabela.Tables("MONITOR")
                cmbDetector.ValueMember = "p396_monitorid"
                cmbDetector.DisplayMember = "p396_monitor"
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CarregarPlano()
        Dim xPlano As New AcessoDados.clsAbrirMonitoracao
        Dim rsTabela As New DataSet

        Try

            With rsTabela
                rsTabela = xPlano.CarregarPlano
                cmbPlano.Items.Clear()
                cmbPlano.DataSource = rsTabela.Tables("PLANO")
                cmbPlano.ValueMember = "p395_planoid"
                cmbPlano.DisplayMember = "p395_plano"
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CarregarVariacao()
        Dim xVariacao As New AcessoDados.clsAbrirMonitoracao
        Dim rsTabela As New DataSet

        Try

            With rsTabela
                rsTabela = xVariacao.CarregarVariacao
                cmbVariacao.Items.Clear()
                cmbVariacao.DataSource = rsTabela.Tables("VARIACAO")
                cmbVariacao.ValueMember = "variacao"
                cmbVariacao.DisplayMember = "variacao"
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirmar.Click
        Dim xSalvar As New AcessoDados.clsAbrirMonitoracao
        Dim rsTabela As New DataSet
        Dim oForm As New frmMonitorarEmbalados

        Try


            Monitor = CInt(cmbDetector.SelectedValue)
            Plano = cmbPlano.SelectedValue
            Variacao = CInt(cmbVariacao.SelectedValue)
            xSalvar.Monitor = CInt(cmbDetector.SelectedValue)
            xSalvar.Plano = cmbPlano.SelectedValue
            xSalvar.Variacao = CInt(cmbVariacao.SelectedValue)

            rsTabela = xSalvar.Salvar

            PortaCom = Trim(cmbPortaSerial.SelectedItem)
            NumeroContagem = CInt(cmbNumeroContagem.SelectedItem)


            oForm.MdiParent = mdiPrincipal
            oForm.Show()

            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CarregarPortaSerial()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbPortaSerial.Items.Add(sp)
        Next
        'cmbPortaSerial.SelectedIndex = 1
    End Sub

    Private Sub CarregarNumeroContagem()
        Dim i As Integer

        For i = 5 To 20
            cmbNumeroContagem.Items.Add(i)
        Next

        cmbNumeroContagem.SelectedIndex = 0

    End Sub

End Class


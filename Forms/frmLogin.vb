Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim executor As New MONITORACAO_EMBALADO.AcessoDados.Executar
        Dim Tabela As DataSet

        Usuario = 0

        If Trim(txtUsuario.Text) = "" Then
            MsgBox("ENTRE COM SEU USUÁRIO!", MsgBoxStyle.Exclamation)
            txtUsuario.Focus()
            Exit Sub
        End If

        If Trim(txtSenha.Text) = "" Then
            MsgBox("ENTRE COM SUA SENHA DE USUÁRIO!", MsgBoxStyle.Exclamation)
            txtSenha.Focus()
            Exit Sub
        End If

        Try
            executor.SQLComando = "dbo.P1110_LOGIN"
            executor.addParametros("login", Trim(txtUsuario.Text), AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.VarChar, 100)
            executor.addParametros("p1110_senha", Trim(txtSenha.Text), AcessoDados.Executar.TipoDirecao.eTPEntrada, SqlDbType.Char, 6)
            executor.ExecutarOperacao(AcessoDados.Executar.TipoRetorno.eDataSet, "VENDASPELICANO")

            Tabela = executor.RetornoDataSet

            executor.Dispose()
            If Trim(Tabela.Tables(0).Rows(0).Item(0).ToString()) = "OK" Then
                txtSenha.Text = ""
                txtUsuario.Text = ""
                txtUsuario.Focus()
                Usuario = CInt(Tabela.Tables(0).Rows(0).Item(1).ToString())
                mdiPrincipal.UsuarioID = Usuario
                mdiPrincipal.Show()
                Me.Hide()
            Else
                MsgBox(Trim(Tabela.Tables(0).Rows(0).Item(0).ToString()), MsgBoxStyle.Exclamation, Me.Text)
            End If

        Catch ex As Exception
            If ex.Message = "Não há linha na posição 0." Then
                MsgBox("USUÁRIO OU SENHA INVÁLIDOS!", MsgBoxStyle.Information)
                txtSenha.Text = ""
                txtUsuario.Text = ""
                txtUsuario.Focus()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
        Finally
            executor.Dispose()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

  
End Class

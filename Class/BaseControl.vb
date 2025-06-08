Public Class BaseControl

    Public Function NumeroInteiro(ByVal Numero As String) As Boolean
        If IsNumeric(Numero) = True Then
            If Numero.Contains(",") = True Then Return False
            Return True
        End If
        Return False
    End Function

End Class

Imports System.Data.SqlClient
Public Class LOGIN
    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub
    Private Sub ConsultarDatos()

        Dim comando As New SqlCommand
        Dim Rs As SqlDataReader
        comando.Connection = conectar()
        comando.CommandText = "Select * from Usuario where Usuario=@Usuario and Contraseña =@Contraseña"
        comando.Parameters.AddWithValue("@Usuario", TxtUsuario.Text)
        comando.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text)
        Rs = comando.ExecuteReader()
        If (Rs.Read()) Then
            Me.Hide()
            MsgBox("Bienvenido ")
        Else
            MsgBox("Usuaio o Contraseña incorrectos", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        If TxtUsuario.Text.Length = 0 Then
            ErrorProvider1.SetError(Me.TxtUsuario, "Usuario requerida")
        ElseIf TxtContraseña.Text.Length = 0 Then
            ErrorProvider2.SetError(Me.TxtContraseña, "Contraseña requerida")
        Else
            ConsultarDatos()
        End If
    End Sub

    Private Sub TxtUsuario_Click(sender As Object, e As EventArgs) Handles TxtUsuario.Click
        ErrorProvider1.Clear()
        TxtUsuario.Clear()
    End Sub

    Private Sub Chk_Mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Mostrar.CheckedChanged
        If Chk_Mostrar.Checked = True Then    'aqui la condicion es cuando se presiona el checkbok le decimos muestra lo que haya escrito o desactiva la opcion de passwordchar
            TxtContraseña.PasswordChar = ""
        ElseIf Chk_Mostrar.Checked = False Then ' si la codicion no se cumple entonces solo me mostrara el simbolo o texto quee hayamos asigando,siempre estara activa la opcion password char
            TxtContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub Chk_Mostrar_CheckStateChanged(sender As Object, e As EventArgs) Handles Chk_Mostrar.CheckStateChanged

    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged

    End Sub

    Private Sub TxtContraseña_Click(sender As Object, e As EventArgs) Handles TxtContraseña.Click
        TxtContraseña.Clear()
    End Sub
End Class
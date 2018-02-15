Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Dim Sqlconexion As New SqlConnection
    Dim comando As New SqlCommand



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sqlconexion.ConnectionString = "Data Source=localhost;Initial Catalog=Inventario;Integrated Security=True"
        Sqlconexion.Open()
        comando.Connection = Sqlconexion

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        ttmensaje.SetToolTip(btnnuevo, "Ingresar Nuevo Equipo")
        ttmensaje.ToolTipTitle = "Ingreso de nuevo registro"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
        txtApellido.Clear()
        cbDepartamento.Items.Clear()
        txtDiscoDuro.Clear()
        txtIp.Clear()
        txtLicenciaWindows.Clear()
        txtmarca.Clear()
        txtmodelo.Clear()
        txtNombre.Clear()
        txtProcesador.Clear()
        txtRam.Clear()
        txtSerieMonitor.Clear()
        txtservicetag.Clear()
        txtSO.Clear()
        txtversionOffice.Clear()
        cbTipo.Items.Clear()


    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtservicetag_TextChanged(sender As Object, e As EventArgs) Handles txtservicetag.TextChanged

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim res As Boolean = False

        Try
            If Me.ValidateChildren And txtApellido.Text <> String.Empty And cbDepartamento.Text <> String.Empty And txtDiscoDuro.Text <> String.Empty And txtLicenciaWindows.Text <> String.Empty And txtmarca.Text <> String.Empty And txtmodelo.Text <> String.Empty And txtNombre.Text <> String.Empty And txtProcesador.Text <> String.Empty And txtRam.Text <> String.Empty And txtSerieMonitor.Text <> String.Empty And txtservicetag.Text <> String.Empty And txtSO.Text <> String.Empty And txtversionOffice.Text <> String.Empty And cbTipo.Text <> String.Empty And Val(txtIp.Text) - Int(Val(txtIp.Text)) = 0 <> String.Empty Then
                MessageBox.Show("Datos Registrados Exitosamente", "Registro de Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
            MessageBox.Show("Algunos datos son incorrectos revise", "Registro de Equipos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        comando.CommandText = "insert into Equipo(ServiceTagSerie,Marca,Modelo,SerieMonitor,SistemaOperativo,LicenciaWindows,VersionOffice,LicenciaOffice,MemoriaRam,DiscoDuro,Procesador,Tipo ) VALUES ('" & txtservicetag.Text & "','" & txtmarca.Text & "','" & txtmodelo.Text & "','" & txtSerieMonitor.Text & "','" & txtSO.Text & "','" & txtLicenciaWindows.Text & "','" & txtversionOffice.Text & "','" & txtlicenciaOffice.Text & "','" & txtRam.Text & "','" & txtDiscoDuro.Text & "','" & txtProcesador.Text & "','" & cbTipo.Text & "') "
        comando.CommandText = "insert into Usuario_(Nombre,Apellido,Departamento,Ip,Comentario) values('" & txtNombre.Text & "','" & txtApellido.Text & "','" & cbDepartamento.Text & "','" & txtIp.Text & "','" & txtComentario.Text & "')"
        comando.ExecuteNonQuery()
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ttmensaje.SetToolTip(txtNombre, "Ingrese aqui el nombre del usuario")
        ttmensaje.ToolTipTitle = "Nombre del usuario"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtservicetag_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtservicetag.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el ServiceTag o Serie, es obligatorio")
        End If
    End Sub

End Class

Partial Public Class frmDetalleBug
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Friend Sub mostrarBug(ByVal oBugSelected As Bug)
        txtNroBug.Text = oBugSelected.id_bug.ToString()
        txtTitulo.Text = oBugSelected.titulo
        txtProducto.Text = oBugSelected.n_producto
        txtFechaAlta.Text = oBugSelected.fecha_alta.ToString()
        txtDescripcion.Text = oBugSelected.descripcion
        txtEstado.Text = oBugSelected.estado
        txtPrioridad.Text = oBugSelected.n_prioridad
        txtCriticidad.Text = oBugSelected.n_criticidad
        dgv_historiales.Rows.Clear()

        For Each oHistorialBug As HistorialBug In oBugSelected.historial
            dgv_historiales.Rows.Add(New String() {oHistorialBug.fecha.ToString("dd/MM/yyyy"), oHistorialBug.n_responsable, oHistorialBug.n_estado, oHistorialBug.n_asignado_a})
        Next
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
End Class
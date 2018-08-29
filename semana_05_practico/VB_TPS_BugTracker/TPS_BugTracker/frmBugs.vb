Public Class frmBugs

    Private Sub Frm_Bugs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'Deshabilitar botones
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        btn_comentar.Enabled = False

        'LLenar combos y limpiar grid
        llenarCombo(cbo_estados, BDHelper.getBDHelper().ConsultaSQL("Select * from Estados"), "n_estado", "id_estado")
        llenarCombo(cbo_prioridades, BDHelper.getBDHelper().ConsultaSQL("Select * from Prioridades"), "n_prioridad", "id_prioridad")
        llenarCombo(cbo_criticidades, BDHelper.getBDHelper().ConsultaSQL("Select * from Criticidades"), "n_criticidad", "id_criticidad")
        llenarCombo(cbo_asignadoA, BDHelper.getBDHelper().ConsultaSQL("Select * from users"), "n_usuario", "id_usuario")
        llenarCombo(cbo_productos, BDHelper.getBDHelper().ConsultaSQL("Select * from Productos"), "nombre", "id_producto")

    End Sub




    'Definimos un procedimiento Friend (Amigo) para poder utilizarlo desde otro formulario, que permita cargar un combo a partir de:
    'Componente combo
    'Source, una lista de objetos
    'Nombre de la property a mostrar en el displayMember del componente
    'Nombre de la property a almacenar en el valueMember del componente
    Friend Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        'Recuperar datos actualizar grid...
        Dim filters As New List(Of Object)
        Dim str As String = "SELECT TOP 20 * FROM bugs WHERE 1=1 "

        'Validar campos de fechas. Si son fechas válidas las agregamos. Caso contrario Nothing
        If IsDate(txt_fec_desde.Text) And IsDate(txt_fec_hasta.Text) Then
            filters.Add(txt_fec_desde.Text)
            filters.Add(txt_fec_hasta.Text)
            str += "AND (fecha>=@param1 AND fecha<=@param2) "
        Else
            filters.Add(Nothing)
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Estado' esta seleccionado.
        If Not String.IsNullOrEmpty(cbo_estados.Text) Then
            'Si el cbo tiene un texto no vacìo entonces recuperamos el valor de la propiedad ValueMember
            filters.Add(cbo_estados.SelectedValue)
            str += "AND id_estado=@param3 "
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Asignado a' esta seleccionado.
        If Not String.IsNullOrEmpty(cbo_asignadoA.Text) Then
            filters.Add(cbo_asignadoA.SelectedValue)
            str += "AND asignado_a=@param4 "
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Prioridad' esta seleccionado.
        If Not String.IsNullOrEmpty(cbo_prioridades.Text) Then
            filters.Add(cbo_prioridades.SelectedValue)
            str += "AND id_prioridad=@param5 "
        Else
            filters.Add(Nothing)
        End If



        'Validar si el combo 'Criticidad' a esta seleccionado.
        If Not String.IsNullOrEmpty(cbo_criticidades.Text) Then
            filters.Add(cbo_criticidades.SelectedValue)
            str += "AND id_criticidad=@param6 "
        Else
            filters.Add(Nothing)
        End If

        'Validar si el combo 'Producto' a esta seleccionado.
        If Not String.IsNullOrEmpty(cbo_productos.Text) Then
            filters.Add(cbo_productos.SelectedValue)
            str += "AND id_producto=@param7"
        Else
            filters.Add(Nothing)
        End If
        str += " ORDER BY fecha_alta DESC"

        'Solicitar al BDHelper que ejecuta una consulta con los filtros seleccionados
        dgv_bugs.DataSource = BDHelper.getBDHelper().ConsultarSQLConParametros(str, filters.ToArray())

        If dgv_bugs.Rows.Count = 0 Then
            MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", _
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub
End Class
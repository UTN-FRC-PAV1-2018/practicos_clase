Public Class frmBugs

    Private Sub Frm_Bugs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'Deshabilitar botones
        btn_editar.Enabled = False
        btn_borrar.Enabled = False
        btn_comentar.Enabled = False

        'LLenar combos y limpiar grid
        llenarCombo(cbo_estados, BDHelper.getDBHelper.ConsultaSQL("Select * from Estados"), "n_estado", "id_estado")
        llenarCombo(cbo_prioridades, BDHelper.getDBHelper.ConsultaSQL("Select * from Prioridades"), "n_prioridad", "id_prioridad")
        llenarCombo(cbo_criticidades, BDHelper.getDBHelper.ConsultaSQL("Select * from Criticidades"), "n_criticidad", "id_criticidad")
        llenarCombo(cbo_asignadoA, BDHelper.getDBHelper.ConsultaSQL("Select * from users"), "n_usuario", "id_usuario")
        llenarCombo(cbo_productos, BDHelper.getDBHelper.ConsultaSQL("Select * from Productos"), "nombre", "id_producto")

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

End Class
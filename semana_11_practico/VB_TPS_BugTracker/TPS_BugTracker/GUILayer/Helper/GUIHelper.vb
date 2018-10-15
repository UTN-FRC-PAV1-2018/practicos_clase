Class GUIHelper
    Private Shared instance As GUIHelper

    Public Shared Function getHelper() As GUIHelper
        If instance Is Nothing Then instance = New GUIHelper()
        Return instance
    End Function

    Public Sub llenarCombo(ByVal cbo As ComboBox, ByVal source As Object, ByVal display As String, ByVal value As String)
        cbo.DataSource = source
        cbo.DisplayMember = display
        cbo.ValueMember = value
        cbo.SelectedIndex = -1
    End Sub
End Class
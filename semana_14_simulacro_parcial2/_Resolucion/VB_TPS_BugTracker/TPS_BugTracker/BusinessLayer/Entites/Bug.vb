Public Class Bug
    Public Property id_bug As Integer
    Public Property titulo As String
    Public Property descripcion As String
    Public Property id_producto As Integer
    Public Property n_producto As String
    Public Property id_prioridad As Integer
    Public Property n_prioridad As String
    Public Property id_criticidad As Integer
    Public Property n_criticidad As String
    Public Property id_estado As Integer
    Public Property n_estado As String
    Public Property fecha_alta As DateTime
    Public Property id_asignado_a As Integer
    Public Property n_asignadoa As String
    Public Property historial As List(Of HistorialBug)

    Public Sub New()
        historial = New List(Of HistorialBug)()
    End Sub

    Public Sub addHistorial(ByVal oHistorialBug As HistorialBug)
        historial.Add(oHistorialBug)
    End Sub
End Class
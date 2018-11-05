Partial Public Class frmPrincipal
    Inherits Form

    Private Shared userLogin As Usuario = Nothing

    Public Sub New()
        InitializeComponent()
        toolStripStatusLabel1.Text = ""
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim login As frmLogin = New frmLogin(Me)
        login.ShowDialog()
    End Sub

    Public Sub actualizarUsuarioLogueado(ByVal user As Usuario)
        toolStripStatusLabel1.Text = "Usuario: " & user.nombre & " | Perfil: " + user.perfil
        userLogin = user
        Mnu_principal.Visible = True
    End Sub

    Private Sub ConsultaDeBugsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeBugsToolStripMenuItem.Click
        Dim Bugs As frmBugs = New frmBugs()
        Bugs.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim usuarios As frmUsuarios = New frmUsuarios()
        usuarios.ShowDialog()
    End Sub

    Public Shared Function obtenerUsuarioLogin() As Usuario
        Return userLogin
    End Function

    Private Sub SoporteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    
End Class
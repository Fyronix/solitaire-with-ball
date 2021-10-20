Public Class ClassCaseJeu
    Inherits PictureBox

    Public Property Occupe As Boolean

    ''' <summary>
    ''' Constructeur case du jeu
    ''' </summary>
    ''' <param name="Index"></param>
    ''' <param name="CaseVisible"></param>
    ''' <param name="PointPion"></param>
    Public Sub New(Index As Integer, CaseVisible As String, PointPion As Point)

        Name = "Pictjeux" & Index.ToString
        SizeMode = PictureBoxSizeMode.StretchImage
        Size = New Size(75, 75)
        Location = PointPion
        Visible = CaseVisible = "O"
        Occupe = False

    End Sub

End Class

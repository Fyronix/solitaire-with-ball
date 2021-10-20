Public Class Form1

    Private ReadOnly ListCasesJeu As New List(Of ClassCaseJeu)
    Private ReadOnly ListDeplacements As New List(Of List(Of Integer)) ' voir AjouteListeDeplacements()
    Private ListMouvement As List(Of Integer)
    Private ListMouvements As List(Of List(Of Integer))
    Private TypeSolitaire As String ' F pour français et E pour anglais
    ' les ListCasesVides donnent les cases vides possibles de départ selon le type de solitaire pour avoir une solution toujours possible
    Private ReadOnly ListCasesVidesFrancaises As New List(Of Integer) From {2, 4, 10, 14, 17, 20, 22, 23, 25, 26, 28, 31, 34, 38, 44, 46}
    Private ReadOnly ListCasesVidesAnglaises As New List(Of Integer) From {2, 3, 4, 9, 10, 11, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 37, 38, 39, 44, 45, 46}
    Private ListCasesVides As List(Of Integer)
    Private ReadOnly CasesVisiblesAnglaises As String = "NNOOONNNNOOONNOOOOOOOOOOOOOOOOOOOOONNOOONNNNOOONN" ' N : non visible et O : visible 
    Private ReadOnly CasesVisiblesFrancaises As String = "NNOOONNNOOOOONOOOOOOOOOOOOOOOOOOOOONOOOOONNNOOONN" ' N : non visible et O : visible
    Private IndexPionRouge, IndexPionSaut, IndexCase, IndexSource, NombrePionsRestantes As Integer
    Private ReadOnly Alea As New Random(Date.Now.Millisecond)

    ''' <summary>
    ''' chargement de la form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CaseLeft, CaseTop As Integer
        Dim CaseJeu As ClassCaseJeu
        IndexCase = 0
        CaseTop = 45
        For Ligne = 0 To 6
            CaseLeft = 45
            For Colonne = 0 To 6
                CaseJeu = New ClassCaseJeu(IndexCase, CasesVisiblesAnglaises.Substring(IndexCase, 1), New Point(CaseLeft, CaseTop))
                ListCasesJeu.Add(CaseJeu)
                AddHandler CaseJeu.MouseDown, AddressOf CaseMouseDown
                Controls.Add(CaseJeu)
                CaseLeft += 75
                IndexCase += 1
            Next
            CaseTop += 75
        Next
        TypeSolitaire = "E"
        AjouteListeDeplacements(CasesVisiblesAnglaises)

    End Sub

    ''' <summary>
    ''' Solitaire 36 billes français
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SolitaireFrancais_Click(sender As Object, e As EventArgs) Handles SolitaireFrancais.Click

        TypeSolitaire = "F"
        AjouteListeDeplacements(CasesVisiblesFrancaises)

    End Sub

    ''' <summary>
    ''' Solitaire 32 billes anglais
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SolitaireAnglais_Click(sender As Object, e As EventArgs) Handles SolitaireAnglais.Click

        TypeSolitaire = "E"
        AjouteListeDeplacements(CasesVisiblesAnglaises)

    End Sub

    ''' <summary>
    ''' Ajoute les listes de déplacements selon le type de plateau ( F = français et E = anglais )
    ''' </summary>
    Private Sub AjouteListeDeplacements(CasesVisibles As String)

        ' pour chaque case on détermine 
        ' les cases pouvant être atteintes à partir de cette case ( en position paire dans la liste )
        ' les cases pouvant être sautées depuis cette case ( en position impaire dans la liste )
        ' si on ajoute {0, 0} la case n'est pas visible
        ListDeplacements.Clear()
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 0
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 1
        ListDeplacements.Add(New List(Of Integer) From {4, 3, 16, 9}) ' case 2 ( première case visible en haut à gauche )
        ListDeplacements.Add(New List(Of Integer) From {17, 10}) ' case 3
        ListDeplacements.Add(New List(Of Integer) From {2, 3, 18, 11}) ' case 4
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 5
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 6
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 7
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 8 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {10, 9, 22, 15}) ' case 8 F
        End If
        ListDeplacements.Add(New List(Of Integer) From {11, 10, 23, 16}) ' case 9 
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {24, 17}) ' case 10 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {8, 9, 12, 11, 24, 17}) ' case 10 F
        End If
        ListDeplacements.Add(New List(Of Integer) From {9, 10, 25, 18}) ' case 11
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 12 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {10, 11, 26, 19}) ' case 12 F
        End If
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 13
        ListDeplacements.Add(New List(Of Integer) From {16, 15, 28, 21}) ' case 14
        ListDeplacements.Add(New List(Of Integer) From {17, 16, 29, 22}) ' case 15
        ListDeplacements.Add(New List(Of Integer) From {2, 9, 14, 15, 18, 17, 30, 23}) ' case 16
        ListDeplacements.Add(New List(Of Integer) From {3, 10, 15, 16, 19, 18, 31, 24}) ' case 17
        ListDeplacements.Add(New List(Of Integer) From {4, 11, 16, 17, 20, 19, 32, 25}) ' case 18
        ListDeplacements.Add(New List(Of Integer) From {17, 18, 33, 26}) ' case 19
        ListDeplacements.Add(New List(Of Integer) From {18, 19, 34, 27}) ' case 20
        ListDeplacements.Add(New List(Of Integer) From {23, 22}) ' case 21
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {24, 23}) ' case 22 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {8, 15, 24, 23, 36, 29}) ' case 22 F
        End If
        ListDeplacements.Add(New List(Of Integer) From {9, 16, 21, 22, 25, 24, 37, 30}) ' case 23
        ListDeplacements.Add(New List(Of Integer) From {10, 17, 22, 23, 26, 25, 38, 31}) ' case 24
        ListDeplacements.Add(New List(Of Integer) From {11, 18, 23, 24, 27, 26, 39, 32}) ' case 25
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {24, 25}) ' case 26 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {12, 19, 24, 25, 40, 33}) ' case 26 F
        End If
        ListDeplacements.Add(New List(Of Integer) From {25, 26}) ' case 27
        ListDeplacements.Add(New List(Of Integer) From {14, 21, 30, 29}) ' case 28
        ListDeplacements.Add(New List(Of Integer) From {15, 22, 31, 30}) ' case 29
        ListDeplacements.Add(New List(Of Integer) From {16, 23, 28, 29, 32, 31, 44, 37}) ' case 30
        ListDeplacements.Add(New List(Of Integer) From {17, 24, 29, 30, 33, 32, 45, 38}) ' case 31
        ListDeplacements.Add(New List(Of Integer) From {18, 25, 30, 31, 34, 33, 46, 39}) ' case 32
        ListDeplacements.Add(New List(Of Integer) From {19, 26, 31, 32}) ' case 33
        ListDeplacements.Add(New List(Of Integer) From {20, 27, 32, 33}) ' case 34
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 35
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 36 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {22, 29, 38, 37}) ' case 36 F
        End If
        ListDeplacements.Add(New List(Of Integer) From {23, 30, 39, 38}) ' case 37
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {24, 31}) ' case 38 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {24, 31, 36, 37, 40, 39}) ' case 38 F
        End If
        ListDeplacements.Add(New List(Of Integer) From {25, 32, 37, 38}) ' case 39
        If TypeSolitaire = "E" Then
            ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 40 E
        Else
            ListDeplacements.Add(New List(Of Integer) From {26, 33, 38, 39}) ' case 40 f
        End If
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 41
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 42
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 43
        ListDeplacements.Add(New List(Of Integer) From {30, 37, 46, 45}) ' case 44
        ListDeplacements.Add(New List(Of Integer) From {31, 38}) ' case 45
        ListDeplacements.Add(New List(Of Integer) From {32, 39, 44, 45}) ' case 46
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 47
        ListDeplacements.Add(New List(Of Integer) From {0, 0}) ' case 48
        IndexCase = 0
        ' Case vide aléatoire au départ
        ListCasesVides = If(TypeSolitaire = "E", ListCasesVidesAnglaises, ListCasesVidesFrancaises)
        Dim IndexCaseVideDepart As Integer = Alea.Next(0, ListCasesVides.Count * 1)
        ' On remplit les cases
        For i = 0 To ListCasesJeu.Count - 1
            With ListCasesJeu(i)
                .Visible = CasesVisibles.Substring(i, 1) = "O"
                If .Visible = True Then
                    If i = ListCasesVides(IndexCaseVideDepart) Then
                        .Image = My.Resources.CaseVide
                        .Occupe = False
                    Else
                        .Image = My.Resources.CaseOccupee
                        .Occupe = True
                    End If
                End If
            End With
        Next
        IndexPionRouge = -1
        NombrePionsRestantes = If(TypeSolitaire = "E", 32, 36)
        AfficheNombrePions()
        ListMouvements = New List(Of List(Of Integer))
        RetourArriere.Visible = False
        ' on affiche les drapeaux
        Drapeau1.Image = If(TypeSolitaire = "E", My.Resources.drapeauanglais, My.Resources.drapeaufrance)
        Drapeau2.Image = Drapeau1.Image
        Drapeau3.Image = Drapeau1.Image
        Drapeau4.Image = Drapeau1.Image

    End Sub

    ''' <summary>
    ''' Affiche le nombre de billes qui restent
    ''' </summary>
    Private Sub AfficheNombrePions()

        LabelNombrePions.Text = "Nombre billes restantes : " & NombrePionsRestantes.ToString

    End Sub

    ''' <summary>
    ''' Sélection d'une case Source ou Destination
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CaseMouseDown(sender As Object, e As MouseEventArgs)

        IndexCase = Convert.ToInt32((DirectCast(sender, ClassCaseJeu).Name).Substring(8))
        With ListCasesJeu(IndexCase)
            If ListCasesJeu(IndexCase).Occupe = True Then
                ' on sélectionne une case avec une bille : c'est une case Source
                If IndexPionRouge >= 0 Then ListCasesJeu(IndexPionRouge).Image = My.Resources.CaseOccupee
                .Image = My.Resources.CaseSelectionnee
                .Occupe = True
                IndexSource = IndexCase
                IndexPionRouge = IndexCase
            Else
                ' on sélectionne une case vide : c'est une case Destination
                Dim IndexListe As Integer = ListDeplacements(IndexSource).FindIndex(Function(p) p = IndexCase)
                If IndexListe <> -1 And IndexListe Mod 2 = 0 Then
                    IndexPionSaut = ListDeplacements(IndexSource)(IndexListe + 1)
                    If ListCasesJeu(IndexPionSaut).Occupe = True Then Mouvement(IndexSource, IndexCase, IndexPionSaut)
                End If
            End If
        End With

    End Sub

    ''' <summary>
    ''' Déplacement d'une bille avec suppression de la bille sautée et test fin de jeu
    ''' </summary>
    ''' <param name="SourceIndex"></param>
    ''' <param name="DestinationIndex"></param>
    ''' <param name="SautIndex"></param>
    Private Sub Mouvement(SourceIndex As Integer, DestinationIndex As Integer, SautIndex As Integer)

        MouvementPion(SourceIndex, DestinationIndex, SautIndex, False)
        ListMouvements.Add(New List(Of Integer) From {SourceIndex, DestinationIndex, SautIndex})
        RetourArriere.Visible = ListMouvements.Count > 0
        IndexPionRouge = -1
        If NombrePionsRestantes = 1 Then
            ' test si on a gagné : il ne doit rester qu'une seule bille
            AfficheMessage("BRAVO !!! Vous avez gagné !!!", "Victoire")
        Else
            ' test si des déplacements sont encore possibles : pour chaque bille on teste si on a un coup jouable
            Dim Bloquer As Boolean = True
            For i = 0 To ListCasesJeu.Count - 1
                If ListCasesJeu(i).Occupe = True Then
                    For j = 0 To ListDeplacements(i).Count - 1 Step 2
                        If ListCasesJeu(ListDeplacements(i)(j + 1)).Occupe = True And ListCasesJeu(ListDeplacements(i)(j)).Occupe = False Then
                            Bloquer = False
                            Exit For
                        End If
                    Next
                End If
                If Bloquer = False Then Exit For
            Next
            If Bloquer = True Then AfficheMessage("Le jeu est bloqué : plus de coup possible !!! ", "Désolé")
        End If

    End Sub

    ''' <summary>
    ''' Effectue un mouvement en avant ou en arrière selon Retour ( True si retour arrière ) 
    ''' </summary>
    ''' <param name="SourceIndex"></param>
    ''' <param name="DestinationIndex"></param>
    ''' <param name="SautIndex"></param>
    ''' <param name="Retour"></param>
    Private Sub MouvementPion(SourceIndex As Integer, DestinationIndex As Integer, SautIndex As Integer, Retour As Boolean)

        ' on efface la bille Source
        With ListCasesJeu(SourceIndex)
            .Image = If(Retour = False, My.Resources.CaseVide, My.Resources.CaseOccupee)
            .Occupe = Retour
        End With
        ' on efface la bille que l'on a sautée
        With ListCasesJeu(SautIndex)
            .Image = If(Retour = False, My.Resources.CaseVide, My.Resources.CaseOccupee)
            .Occupe = Retour
        End With
        ' on affiche la bille Destination
        With ListCasesJeu(DestinationIndex)
            .Image = If(Retour = False, My.Resources.CaseOccupee, My.Resources.CaseVide)
            .Occupe = Not Retour
        End With
        NombrePionsRestantes = If(Retour = False, NombrePionsRestantes - 1, NombrePionsRestantes + 1)
        AfficheNombrePions()

    End Sub

    ''' <summary>
    ''' Affiche un message
    ''' </summary>
    ''' <param name="Message"></param>
    ''' <param name="Entete"></param>
    Private Sub AfficheMessage(Message As String, Entete As String)

        MessageBox.Show(Message, Entete, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    ''' <summary>
    ''' bouton "Retour arrière"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RetourArriere_Click(sender As Object, e As EventArgs) Handles RetourArriere.Click

        If ListMouvements.Count > 0 Then
            ListMouvement = ListMouvements.Last
            MouvementPion(ListMouvement(0), ListMouvement(1), ListMouvement(2), True)
            ListMouvements.RemoveAt(ListMouvements.Count - 1)
            RetourArriere.Visible = ListMouvements.Count > 0
        End If

    End Sub

End Class

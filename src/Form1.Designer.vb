<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SolitaireFrancais = New System.Windows.Forms.Button()
        Me.SolitaireAnglais = New System.Windows.Forms.Button()
        Me.Drapeau4 = New System.Windows.Forms.PictureBox()
        Me.Drapeau3 = New System.Windows.Forms.PictureBox()
        Me.Drapeau2 = New System.Windows.Forms.PictureBox()
        Me.Drapeau1 = New System.Windows.Forms.PictureBox()
        Me.LabelNombrePions = New System.Windows.Forms.Button()
        Me.RetourArriere = New System.Windows.Forms.Button()
        CType(Me.Drapeau4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drapeau3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drapeau2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drapeau1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 569)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(549, 51)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SolitaireFrancais
        '
        Me.SolitaireFrancais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolitaireFrancais.Location = New System.Drawing.Point(450, 12)
        Me.SolitaireFrancais.Name = "SolitaireFrancais"
        Me.SolitaireFrancais.Size = New System.Drawing.Size(161, 25)
        Me.SolitaireFrancais.TabIndex = 2
        Me.SolitaireFrancais.TabStop = False
        Me.SolitaireFrancais.Text = "Solitaire français 36 billes"
        Me.SolitaireFrancais.UseVisualStyleBackColor = True
        '
        'SolitaireAnglais
        '
        Me.SolitaireAnglais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolitaireAnglais.Location = New System.Drawing.Point(450, 55)
        Me.SolitaireAnglais.Name = "SolitaireAnglais"
        Me.SolitaireAnglais.Size = New System.Drawing.Size(161, 25)
        Me.SolitaireAnglais.TabIndex = 3
        Me.SolitaireAnglais.TabStop = False
        Me.SolitaireAnglais.Text = "Solitaire anglais 32 billes"
        Me.SolitaireAnglais.UseVisualStyleBackColor = True
        '
        'Drapeau4
        '
        Me.Drapeau4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Drapeau4.Location = New System.Drawing.Point(502, 426)
        Me.Drapeau4.Name = "Drapeau4"
        Me.Drapeau4.Size = New System.Drawing.Size(70, 36)
        Me.Drapeau4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Drapeau4.TabIndex = 8
        Me.Drapeau4.TabStop = False
        '
        'Drapeau3
        '
        Me.Drapeau3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Drapeau3.Location = New System.Drawing.Point(45, 426)
        Me.Drapeau3.Name = "Drapeau3"
        Me.Drapeau3.Size = New System.Drawing.Size(70, 36)
        Me.Drapeau3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Drapeau3.TabIndex = 7
        Me.Drapeau3.TabStop = False
        '
        'Drapeau2
        '
        Me.Drapeau2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Drapeau2.Location = New System.Drawing.Point(502, 149)
        Me.Drapeau2.Name = "Drapeau2"
        Me.Drapeau2.Size = New System.Drawing.Size(70, 36)
        Me.Drapeau2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Drapeau2.TabIndex = 6
        Me.Drapeau2.TabStop = False
        '
        'Drapeau1
        '
        Me.Drapeau1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Drapeau1.Location = New System.Drawing.Point(45, 149)
        Me.Drapeau1.Name = "Drapeau1"
        Me.Drapeau1.Size = New System.Drawing.Size(70, 36)
        Me.Drapeau1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Drapeau1.TabIndex = 5
        Me.Drapeau1.TabStop = False
        '
        'LabelNombrePions
        '
        Me.LabelNombrePions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombrePions.Location = New System.Drawing.Point(211, 12)
        Me.LabelNombrePions.Name = "LabelNombrePions"
        Me.LabelNombrePions.Size = New System.Drawing.Size(188, 25)
        Me.LabelNombrePions.TabIndex = 9
        Me.LabelNombrePions.TabStop = False
        Me.LabelNombrePions.UseVisualStyleBackColor = True
        '
        'RetourArriere
        '
        Me.RetourArriere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetourArriere.Location = New System.Drawing.Point(493, 105)
        Me.RetourArriere.Name = "RetourArriere"
        Me.RetourArriere.Size = New System.Drawing.Size(89, 38)
        Me.RetourArriere.TabIndex = 10
        Me.RetourArriere.TabStop = False
        Me.RetourArriere.Text = "Retour arrière"
        Me.RetourArriere.UseVisualStyleBackColor = True
        Me.RetourArriere.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 629)
        Me.Controls.Add(Me.RetourArriere)
        Me.Controls.Add(Me.LabelNombrePions)
        Me.Controls.Add(Me.Drapeau4)
        Me.Controls.Add(Me.Drapeau3)
        Me.Controls.Add(Me.Drapeau2)
        Me.Controls.Add(Me.Drapeau1)
        Me.Controls.Add(Me.SolitaireAnglais)
        Me.Controls.Add(Me.SolitaireFrancais)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solitaire"
        CType(Me.Drapeau4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drapeau3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drapeau2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drapeau1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents SolitaireFrancais As Button
    Friend WithEvents SolitaireAnglais As Button
    Friend WithEvents Drapeau1 As PictureBox
    Friend WithEvents Drapeau2 As PictureBox
    Friend WithEvents Drapeau3 As PictureBox
    Friend WithEvents Drapeau4 As PictureBox
    Friend WithEvents LabelNombrePions As Button
    Friend WithEvents RetourArriere As Button
End Class

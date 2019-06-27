Public Class Form1

    ' This SoundPlayer plays a sound whenever the player hits a wall.
    Private startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")

    ' This SoundPlayer plays a sound when the player finishes the game.
    Private finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")

    Public Sub New()
        ' This call is required by Windows Forms Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        MoveToStart()
    End Sub

    Private Sub finishLabel_MouseEnter() Handles Label58.MouseEnter
        'Play a sound, show a congratulatory MessageBox, then close the form.
        finishSoundPlayer.Play()
        MessageBox.Show("Congratulations!")
        Close()
    End Sub

    ''' <summary>
    ''' Play a sound, then move the mouse pointer to a point 10 pixels down and to the right of the starting point in the upper-left corner of the maze. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MoveToStart()
        startSoundPlayer.Play()
        Dim startingPoint = Panel1.Location
        startingPoint.Offset(5, 30)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub wall_MouseEnter() Handles Label8.MouseEnter, Label9.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        ' When the mouse pointer hits a wall or enters the panel,
        ' call the MoveToStart() method.
        MoveToStart()
    End Sub
End Class

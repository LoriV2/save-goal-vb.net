Public Class LiveCount
    'difficulty
    Public x As Integer = 1
    'points
    Public points As Integer = 0
    'the lives if it gets to 0 the game ends
    Public lives As String = 3
    'I don't know if it works but I'am too lazy to delete it from code that I wont do it
    Public smooth As Boolean = True
    'random start position of ball
    Public where As New Random
    'to generate 1(drift up) or 2(drift down)
    Public drift As New Random
    'it stores the random drift value(1 or 2)
    Public drift_value As Integer
    'stores the previous height where the ball spawned to make sure the spawn point is not the same as before
    Public heght As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Enabled = False
        Difficulty_1.Enabled = False
        Difficulty_2.Enabled = False
        Difficulty_3.Enabled = False
        Difficulty_4.Enabled = False
        Difficulty_5.Enabled = False
        Difficulty_6.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'ball movement
        PictureBox1.Left -= x
        If PictureBox1.Top < 31 Then
            drift_value = 1

        ElseIf PictureBox1.Top > 202 Then
            drift_value = 2
        End If
        If drift_value = 1 Then
            PictureBox1.Top += x
        Else
            PictureBox1.Top -= x
        End If

        'collision detection
        If PictureBox1.Bounds.IntersectsWith(Picturebox3.bounds) Then
            PictureBox1.Left = 452
            PictureBox1.Top = where.Next(31, 202)
            'to make sure the starting position is not the same as before
            While PictureBox1.Top = heght
                PictureBox1.Top = where.Next(31, 202)
            End While
            lives -= 1
            Counting.Text = lives
            drift_value = drift.Next(1, 2)
            heght = PictureBox1.Top
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox2.bounds) Then
            PictureBox1.Left = 452
            PictureBox1.Top = where.Next(31, 202)
            'to make sure the starting position is not the same as before
            While PictureBox1.Top = heght
                PictureBox1.Top = where.Next(31, 202)
            End While
            points += 1
            point_count.Text = points
            drift_value = drift.Next(1, 2)
            heght = PictureBox1.Top
        End If
        'collision detection

        'if lose
        If lives = 0 Then
            Timer1.Enabled = False
            Label2.Top = 112
            Label2.Left = 201
            Label2.Text = "GAME OVER:press esc to restart"
        End If
        'if lose
    End Sub

    Private Sub PictureBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'saver movement
        If e.KeyCode = Keys.Up And PictureBox2.Top > 34 Then
            PictureBox2.Top += 1
            PictureBox2.Top -= x + 1
            smooth = True
            While smooth = True
                PictureBox2.Top -= 1
                PictureBox2.Top -= 1
                PictureBox2.Top -= 1
                PictureBox2.Top -= 1

                smooth = False
            End While
        ElseIf e.KeyCode = Keys.Down And PictureBox2.Top < 170 Then
            PictureBox2.Top -= 1
            PictureBox2.Top += x + 1
            smooth = True
            While smooth = True
                PictureBox2.Top += 1
                PictureBox2.Top += 1
                PictureBox2.Top += 1
                PictureBox2.Top += 1

                smooth = False
            End While
            'saver movement


            'reset when escape key is entered try holding it after lose ;)
        ElseIf e.KeyCode = Keys.Escape Then
            Timer1.Enabled = False
            Button1.Enabled = True
            Difficulty_1.Enabled = True
            Difficulty_2.Enabled = True
            Difficulty_3.Enabled = True
            Difficulty_4.Enabled = True
            Difficulty_5.Enabled = True
            Difficulty_6.Enabled = True
            points = 0
            point_count.Text = points
            lives = 3
            Counting.Text = lives
            PictureBox1.Left = 452
            PictureBox1.Top = where.Next(31, 202)
            Label2.Text = "press esc to restart"
            Label2.Top = 3
            Label2.Left = 0
        End If
        'reset when escape key is entered try holding it after lose ;)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Counting.Text = lives
    End Sub

    'difficulty changer
    Private Sub Difficulty_1_Click(sender As Object, e As EventArgs) Handles Difficulty_1.Click
        x = 1
        Difficulty.Text = x
        PictureBox2.Height = 82
        PictureBox2.Width = 12

    End Sub

    Private Sub Difficulty_2_Click(sender As Object, e As EventArgs) Handles Difficulty_2.Click
        x = 2
        Difficulty.Text = x
        PictureBox2.Height = 72
        PictureBox2.Width = 12
    End Sub

    Private Sub Difficulty_3_Click(sender As Object, e As EventArgs) Handles Difficulty_3.Click
        x = 3
        Difficulty.Text = x
        PictureBox2.Height = 62
        PictureBox2.Width = 12
    End Sub

    Private Sub Difficulty_4_Click(sender As Object, e As EventArgs) Handles Difficulty_4.Click
        x = 4
        Difficulty.Text = x
        PictureBox2.Height = 52
        PictureBox2.Width = 12
    End Sub

    Private Sub Difficulty_5_Click(sender As Object, e As EventArgs) Handles Difficulty_5.Click
        x = 5
        Difficulty.Text = x
        PictureBox2.Height = 42
        PictureBox2.Width = 12
    End Sub

    Private Sub Difficulty_6_Click(sender As Object, e As EventArgs) Handles Difficulty_6.Click
        If x < 6 Then
            x = 9
            Difficulty.Text = x
            PictureBox2.Height = 42 - x

        Else
            x += 1
            Difficulty.Text = x
            PictureBox2.Height = 42 - x
        End If
    End Sub
    'difficulty changer
End Class

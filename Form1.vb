Public Class Form1
    Public thingy = {0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public winColor = Color.Green
    Public player_One = "V"
    Public player_Two = "Q"

    Public playerOneWin = 0
    Public playerTwoWin = 0
    Public playerOneLose = 0
    Public playerTwoLose = 0
    Public playerDraw = 0

    Public drawChecker = 0

    Public Sub resetsfields()
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
        Return
    End Sub

    Public Sub moveChecker(firstMark, secondMark)
        If (Form1.ActiveForm.Text = firstMark) Then
            Form1.ActiveForm.Text = secondMark
        Else
            Form1.ActiveForm.Text = firstMark
        End If
        Return
    End Sub

    Public Sub increaseWin(playerInvolved)
        If (playerInvolved = player_One) Then
            playerOneWin = playerOneWin + 1
            Label10.Text = playerOneWin.ToString()

        Else
            playerTwoWin = playerTwoWin + 1
            Label9.Text = playerTwoWin.ToString()
        End If
        increaseLose(playerInvolved)
        Return
    End Sub

    Public Sub increaseLose(playerNotInvolved)
        If (playerNotInvolved = player_One) Then
            playerTwoLose = playerTwoLose + 1
            Label13.Text = playerTwoLose.ToString()
        Else
            playerOneLose = playerOneLose + 1
            Label14.Text = playerOneLose.ToString()
        End If
        Return
    End Sub

    Public Sub increaseDraw()
        playerDraw = playerDraw + 1
        Label11.Text = playerDraw.ToString()
        Label12.Text = playerDraw.ToString()
        Return
    End Sub

    Public Sub checkField(checker, colors)
        If (Button1.Text = checker And Button2.Text = checker And Button3.Text = checker) Then
            Button1.BackColor = colors
            Button2.BackColor = colors
            Button3.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
        If (Button4.Text = checker And Button5.Text = checker And Button6.Text = checker) Then
            Button4.BackColor = colors
            Button5.BackColor = colors
            Button6.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
        If (Button7.Text = checker And Button8.Text = checker And Button9.Text = checker) Then
            Button7.BackColor = colors
            Button8.BackColor = colors
            Button9.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
        If (Button1.Text = checker And Button4.Text = checker And Button7.Text = checker) Then
            Button1.BackColor = colors
            Button4.BackColor = colors
            Button7.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
        If (Button2.Text = checker And Button5.Text = checker And Button8.Text = checker) Then
            Button2.BackColor = colors
            Button5.BackColor = colors
            Button8.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
        If (Button3.Text = checker And Button6.Text = checker And Button9.Text = checker) Then
            Button3.BackColor = colors
            Button6.BackColor = colors
            Button9.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
        If (Button1.Text = checker And Button5.Text = checker And Button9.Text = checker) Then
            Button1.BackColor = colors
            Button5.BackColor = colors
            Button9.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
        If (Button3.Text = checker And Button5.Text = checker And Button7.Text = checker) Then
            Button3.BackColor = colors
            Button5.BackColor = colors
            Button7.BackColor = colors
            MessageBox.Show("WINNER: " + checker.ToString)
            resetsfields()
            increaseWin(checker)
            Form1.ActiveForm.Text = "X"
        End If
    End Sub

    Public Sub drawGame()
        If (Button1.Text <> "" And Button2.Text <> "" And Button3.Text <> "" And Button4.Text <> "" And Button5.Text <> "" And Button6.Text <> "" And Button7.Text <> "" And Button8.Text <> "" And Button9.Text <> "") Then
            MessageBox.Show("No One Wins: It is a draw")
            Form1.ActiveForm.Text = "X"
            increaseDraw()
            resetsfields()
        End If
        Return
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "") Then
            Button1.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Button2.Text = "") Then
            Button2.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Button3.Text = "") Then
            Button3.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Button4.Text = "") Then
            Button4.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Button5.Text = "") Then
            Button5.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Button6.Text = "") Then
            Button6.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Button7.Text = "") Then
            Button7.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (Button8.Text = "") Then
            Button8.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (Button9.Text = "") Then
            Button9.Text = Form1.ActiveForm.Text
            checkField(player_One, winColor)
            checkField(player_Two, winColor)
            drawGame()
            moveChecker(player_One, player_Two)
        Else
            MessageBox.Show("You cannot change your move")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Form1.ActiveForm.Text = "X"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.ActiveForm.Text = player_One
    End Sub
End Class


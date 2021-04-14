Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxboard.Click

    End Sub

    Private Sub rdRoll_Click(sender As Object, e As EventArgs) Handles rdRoll.Click
        Dim randomizer As New Random
        Dim dice1, dice2, dice3, dice4 As Integer
        Dim result As Integer
        Dim score As New Integer
        Dim point As Integer
        Dim state As Integer
        score = 0
        dice1 = randomizer.Next(1, 7)
        dice2 = randomizer.Next(1, 7)
        dice3 = randomizer.Next(1, 7)
        dice4 = randomizer.Next(1, 7)
        point = dice1 + dice2


        Select Case dice1
            Case 1
                PictureBoxd1.Visible = True
                PictureBoxd2.Visible = False
                PictureBoxd3.Visible = False
                PictureBoxd4.Visible = False
                PictureBoxd5.Visible = False
                PictureBoxd6.Visible = False
            Case 2
                PictureBoxd1.Visible = False
                PictureBoxd2.Visible = True
                PictureBoxd3.Visible = False
                PictureBoxd4.Visible = False
                PictureBoxd5.Visible = False
                PictureBoxd6.Visible = False
            Case 3
                PictureBoxd1.Visible = False
                PictureBoxd2.Visible = False
                PictureBoxd3.Visible = True
                PictureBoxd4.Visible = False
                PictureBoxd5.Visible = False
                PictureBoxd6.Visible = False
            Case 4
                PictureBoxd1.Visible = False
                PictureBoxd2.Visible = False
                PictureBoxd3.Visible = False
                PictureBoxd4.Visible = True
                PictureBoxd5.Visible = False
                PictureBoxd6.Visible = False
            Case 5
                PictureBoxd1.Visible = False
                PictureBoxd2.Visible = False
                PictureBoxd3.Visible = False
                PictureBoxd4.Visible = False
                PictureBoxd5.Visible = True
                PictureBoxd6.Visible = False
            Case 6
                PictureBoxd1.Visible = False
                PictureBoxd2.Visible = False
                PictureBoxd3.Visible = False
                PictureBoxd4.Visible = False
                PictureBoxd5.Visible = False
                PictureBoxd6.Visible = True
        End Select
        Select Case dice2
            Case 1
                PictureBox1.Visible = True
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            Case 2
                PictureBox1.Visible = False
                PictureBox2.Visible = True
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            Case 3
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = True
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            Case 4
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = True
                PictureBox5.Visible = False
                PictureBox6.Visible = False
            Case 5
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = True
                PictureBox6.Visible = False
            Case 6
                PictureBox1.Visible = False
                PictureBox2.Visible = False
                PictureBox3.Visible = False
                PictureBox4.Visible = False
                PictureBox5.Visible = False
                PictureBox6.Visible = True
        End Select

        Select Case point
            Case 2, 3, 7, 11, 12
                state = 1
            Case 4, 5, 6, 8, 9, 10
                state = 2
        End Select
        If state = 1 Then
            If point = 4 Then
                pic4.Visible = True
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = False
            ElseIf point = 5
                pic4.Visible = False
                pic5.Visible = True
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = False
            ElseIf point = 6
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = True
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = False
            ElseIf point = 8
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = True
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = False
            ElseIf point = 9
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = True
                pic10.Visible = False
                picblack.Visible = False
            ElseIf point = 10
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = True
                picblack.Visible = False
            Else
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = True
            End If
            If point = 7 Then
                score = 1
                lblOutput.Text = "You rolled a " & dice1 & " and a " & dice2 & " Your total is " & point & ". You Win."
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = True
            ElseIf point = 11 Then
                score = 1
                lblOutput.Text = "You rolled a " & dice1 & " and a " & dice2 & " Your total is " & point & ". You Win."
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = True
            ElseIf point = 2 Then
                score = -1
                lblOutput.Text = "You rolled a " & dice1 & " and a " & dice2 & " Your total is " & point & ". You're a loser."
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = True
            ElseIf point = 3 Then
                score = -1
                lblOutput.Text = "You rolled a " & dice1 & " and a " & dice2 & " Your total is " & point & ". You're a loser."
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = True
            ElseIf point = 12 Then
                score = -1
                lblOutput.Text = "You rolled a " & dice1 & " And a " & dice2 & " Your total Is " & point & ". You're a loser."
                pic4.Visible = False
                pic5.Visible = False
                pic6.Visible = False
                pic8.Visible = False
                pic9.Visible = False
                pic10.Visible = False
                picblack.Visible = True
            Else
                state = 2
            End If

        ElseIf state = 2
            Select Case result
                    Case 7
                    lblOutput.Text = "You lose."
                    pic4.Visible = False
                    pic5.Visible = False
                    pic6.Visible = False
                    pic8.Visible = False
                    pic9.Visible = False
                    pic10.Visible = False
                    picblack.Visible = True
                Case 2, 3, 4, 5, 6, 8, 9, 10, 11
                        If result = point Then
                            lblOutput.Text = "Congratulations you rolled a " & result & " and a " & dice4 & " to get " & result & ". You win."
                        Else
                        lblOutput.Text = "You rolled a " & dice3 & " and a " & dice4 & " to get " & result & ". Roll again."
                        state = 2
                    End If
                End Select
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = ""
    End Sub
End Class

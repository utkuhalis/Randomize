Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim say1 As Integer = 0
        Dim say2 As Integer = 0
        Dim say3 As Integer = 0
        Dim say4 As Integer = 0
        Dim say5 As Integer = 0
        Dim say6 As Integer = 0

        say1 = Int(Rnd(1) * (9))
        say2 = Int(Rnd(1) * (9))
        say3 = Int(Rnd(1) * (9))
        say4 = Int(Rnd(1) * (9))
        say5 = Int(Rnd(1) * (9))
        say6 = Int(Rnd(1) * (9))

        Label1.Text = say1 & say2 & say3 & say4 & say5 & say6
    End Sub
End Class

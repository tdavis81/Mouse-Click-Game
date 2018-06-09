Public Class Form1
    Dim x = 0
    Dim time = 0


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x += 1
        Label1.Text = x
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Label2.Text - 1
        time += 1
        If time = 15 Then
            Timer1.Enabled = False
            Button1.Enabled = False

            If Label1.Text > Label10.Text Then
                Label10.Text = Label1.Text
                Label6.Text = TextBox1.Text

            End If
           
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        x = 0
        Label1.Text = x
        Label2.Text = 15
        Button1.Enabled = True
        If Label1.Text > Label10.Text Then
            Label11.Text = Label1.Text
            Label7.Text = TextBox1.Text
            
            
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button1
    End Sub
End Class

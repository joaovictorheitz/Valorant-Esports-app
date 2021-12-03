Imports System.Net
Imports System.IO

Public Class Form1
    Private Sub player_btn_Click(sender As Object, e As EventArgs) Handles player_btn.Click

        label1.Text = "Nome"
        label2.Text = "Time"
        label3.Text = "Data de Nascimento"

        'Joao a ideia das "Tags" é deixar salvo nos componentes em qual banco de dados as
        'alterações vão ser feitas, ai você usar a tag dele como referencia pra fazer o
        'que precisar com base nisso

        input1.Tag = "pla"
        input2.Tag = "pla"
        input3.Tag = "pla"

        linha1.Visible = True
        linha2.Visible = True
        linha3.Visible = True

        label1.Visible = True
        label2.Visible = True
        label3.Visible = True

        input1.Visible = True
        input2.Visible = True
        input3.Visible = True

        input1.Clear()
        input2.Clear()
        input3.Clear()
        id.Clear()
    End Sub

    Private Sub tim_btn_Click(sender As Object, e As EventArgs) Handles tim_btn.Click
        label1.Text = "Nome"
        label2.Text = "Região"

        input1.Tag = "tim"
        input2.Tag = "tim"

        linha1.Visible = True
        linha2.Visible = True
        linha3.Visible = False

        label1.Visible = True
        label2.Visible = True
        label3.Visible = False

        input1.Visible = True
        input2.Visible = True
        input3.Visible = False

        input1.Clear()
        input2.Clear()
        input3.Clear()
        id.Clear()
    End Sub

    Private Sub reg_btn_Click(sender As Object, e As EventArgs) Handles reg_btn.Click
        label1.Text = "Nome"

        input1.Tag = "reg"

        linha1.Visible = True
        linha2.Visible = False
        linha3.Visible = False

        label1.Visible = True
        label2.Visible = False
        label3.Visible = False

        input1.Visible = True
        input2.Visible = False
        input3.Visible = False

        input1.Clear()
        input2.Clear()
        input3.Clear()
        id.Clear()
    End Sub

End Class

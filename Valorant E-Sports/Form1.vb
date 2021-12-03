Imports System.Net
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    Private conexao As New MySqlConnection("server=localhost;database=valorant_esports;uid=root;pwd=;")
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Public Function Tabela(x As String)
        Try
            strSQL = "SELECT * FROM " & x

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexao)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando = Nothing
        End Try
    End Function

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

        'banco 

        tabela("players")

    End Sub

    Private Sub tim_btn_Click(sender As Object, e As EventArgs) Handles tim_btn.Click
        label1.Text = "Nome"
        label2.Text = "Região"
        label3.Text = "Earnings"

        input1.Tag = "tim"
        input2.Tag = "tim"

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

        'data grid

        Tabela("times")
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

        'data grid

        Tabela("regiao")
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click

        Select Case input1.Tag
            Case "pla"
                Try
                    strSQL = "INSERT INTO players (pla_nome, pla_datanasc, tim_id) VALUES (@pla_nome, @pla_datanasc, @tim_id)"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@pla_nome", input1.Text)
                    comando.Parameters.AddWithValue("@tim_id", CInt(input2.Text))
                    comando.Parameters.AddWithValue("@pla_datanasc", input3.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "tim"
                Try
                    strSQL = "INSERT INTO times (tim_nome, tim_earn, reg_id) VALUES (@tim_nome, @tim_earn, @reg_id)"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@tim_nome", input1.Text)
                    comando.Parameters.AddWithValue("@reg_id", input2.Text)
                    comando.Parameters.AddWithValue("@tim_earn", input3.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "reg"
                Try
                    strSQL = "INSERT INTO regiao (reg_nome, reg_id) VALUES (@reg_nome, @reg_id)"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@reg_id", id.Text)
                    comando.Parameters.AddWithValue("@reg_nome", input1.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
        End Select

    End Sub

    Private Sub read_Click(sender As Object, e As EventArgs) Handles read.Click

        Select Case input1.Tag
            Case "pla"
                Try
                    strSQL = "SELECT * FROM players where pla_nome = '" & input1.Text & "'" & " or tim_id =" & input2.Text

                    Dim dt As New DataTable

                    da = New MySqlDataAdapter(strSQL, conexao)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "tim"
                Try
                    strSQL = "SELECT * FROM times where tim_nome = '" & input1.Text & "'" & " or reg_id = '" & input2.Text & "'"

                    Dim dt As New DataTable

                    da = New MySqlDataAdapter(strSQL, conexao)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "reg"
                Try
                    strSQL = "SELECT * FROM regiao where reg_nome = '" & input1.Text & "'"

                    Dim dt As New DataTable

                    da = New MySqlDataAdapter(strSQL, conexao)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
        End Select

    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Select Case input1.Tag
            Case "pla"
                Try
                    strSQL = "update players set pla_nome = @pla_nome, pla_datanasc = @pla_datanasc, tim_id = @tim_id where pla_id = @pla_id"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@pla_nome", input1.Text)
                    comando.Parameters.AddWithValue("@tim_id", input2.Text)
                    comando.Parameters.AddWithValue("@pla_datanasc", input3.Text)
                    comando.Parameters.AddWithValue("@pla_id", id.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "tim"
                Try
                    strSQL = "update times set tim_nome = @tim_nome, tim_earn = @tim_earn, reg_id = @reg_id where tim_id = @tim_id"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@tim_nome", input1.Text)
                    comando.Parameters.AddWithValue("@reg_id", input2.Text)
                    comando.Parameters.AddWithValue("@tim_earn", input3.Text)
                    comando.Parameters.AddWithValue("@tim_id", id.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "reg"
                Try
                    strSQL = "update regiao set reg_nome = @reg_nome, reg_id = @reg_id where reg_id = @reg_id"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@reg_nome", input1.Text)
                    comando.Parameters.AddWithValue("@reg_id", id.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
        End Select
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Select Case input1.Tag
            Case "pla"
                Try
                    strSQL = "delete from players where pla_id = @pla_id"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@pla_id", id.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "tim"
                Try
                    strSQL = "delete from times where tim_id = @tim_id"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@tim_id", id.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
            Case "reg"
                Try
                    strSQL = "delete from regiao where reg_id = @reg_id"

                    comando = New MySqlCommand(strSQL, conexao)
                    comando.Parameters.AddWithValue("@reg_id", id.Text)

                    conexao.Open()
                    comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    conexao.Close()
                    comando = Nothing
                End Try
        End Select
    End Sub

End Class

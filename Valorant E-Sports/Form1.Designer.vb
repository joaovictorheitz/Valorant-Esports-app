<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.delete = New System.Windows.Forms.PictureBox()
        Me.update = New System.Windows.Forms.PictureBox()
        Me.read = New System.Windows.Forms.PictureBox()
        Me.create = New System.Windows.Forms.PictureBox()
        Me.id_label = New System.Windows.Forms.Label()
        Me.linha0 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.linha3 = New System.Windows.Forms.Label()
        Me.player_btn = New System.Windows.Forms.PictureBox()
        Me.input3 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.linha2 = New System.Windows.Forms.Label()
        Me.input2 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.reg_btn = New System.Windows.Forms.PictureBox()
        Me.tim_btn = New System.Windows.Forms.PictureBox()
        Me.linha1 = New System.Windows.Forms.Label()
        Me.input1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.read, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.create, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reg_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tim_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel1.Controls.Add(Me.delete)
        Me.Panel1.Controls.Add(Me.update)
        Me.Panel1.Controls.Add(Me.read)
        Me.Panel1.Controls.Add(Me.create)
        Me.Panel1.Controls.Add(Me.id_label)
        Me.Panel1.Controls.Add(Me.linha0)
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Controls.Add(Me.linha3)
        Me.Panel1.Controls.Add(Me.input3)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.linha2)
        Me.Panel1.Controls.Add(Me.input2)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.linha1)
        Me.Panel1.Controls.Add(Me.input1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(668, -2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 590)
        Me.Panel1.TabIndex = 0
        '
        'delete
        '
        Me.delete.Image = Global.Valorant_E_Sports.My.Resources.Resources.deletar
        Me.delete.Location = New System.Drawing.Point(186, 351)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(24, 24)
        Me.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.delete.TabIndex = 24
        Me.delete.TabStop = False
        '
        'update
        '
        Me.update.Image = Global.Valorant_E_Sports.My.Resources.Resources.atualizar
        Me.update.Location = New System.Drawing.Point(131, 351)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(24, 24)
        Me.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.update.TabIndex = 23
        Me.update.TabStop = False
        '
        'read
        '
        Me.read.Image = Global.Valorant_E_Sports.My.Resources.Resources.ler
        Me.read.Location = New System.Drawing.Point(76, 351)
        Me.read.Name = "read"
        Me.read.Size = New System.Drawing.Size(24, 24)
        Me.read.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.read.TabIndex = 22
        Me.read.TabStop = False
        '
        'create
        '
        Me.create.Image = Global.Valorant_E_Sports.My.Resources.Resources.criar
        Me.create.Location = New System.Drawing.Point(21, 351)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(24, 24)
        Me.create.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.create.TabIndex = 21
        Me.create.TabStop = False
        '
        'id_label
        '
        Me.id_label.AutoSize = True
        Me.id_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_label.ForeColor = System.Drawing.Color.White
        Me.id_label.Location = New System.Drawing.Point(32, 76)
        Me.id_label.Name = "id_label"
        Me.id_label.Size = New System.Drawing.Size(17, 15)
        Me.id_label.TabIndex = 20
        Me.id_label.Text = "Id"
        '
        'linha0
        '
        Me.linha0.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.linha0.Location = New System.Drawing.Point(36, 122)
        Me.linha0.Name = "linha0"
        Me.linha0.Size = New System.Drawing.Size(160, 1)
        Me.linha0.TabIndex = 18
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.id.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.Location = New System.Drawing.Point(36, 97)
        Me.id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(160, 19)
        Me.id.TabIndex = 19
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(33, 272)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(119, 15)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Data de Nascimento"
        '
        'linha3
        '
        Me.linha3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.linha3.Location = New System.Drawing.Point(37, 318)
        Me.linha3.Name = "linha3"
        Me.linha3.Size = New System.Drawing.Size(160, 1)
        Me.linha3.TabIndex = 15
        '
        'player_btn
        '
        Me.player_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.player_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.player_btn.Image = Global.Valorant_E_Sports.My.Resources.Resources.jogador
        Me.player_btn.Location = New System.Drawing.Point(20, 9)
        Me.player_btn.Name = "player_btn"
        Me.player_btn.Size = New System.Drawing.Size(36, 36)
        Me.player_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.player_btn.TabIndex = 5
        Me.player_btn.TabStop = False
        '
        'input3
        '
        Me.input3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.input3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input3.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input3.ForeColor = System.Drawing.Color.White
        Me.input3.Location = New System.Drawing.Point(37, 293)
        Me.input3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.input3.Name = "input3"
        Me.input3.Size = New System.Drawing.Size(160, 19)
        Me.input3.TabIndex = 16
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(32, 202)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(35, 15)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Time"
        '
        'linha2
        '
        Me.linha2.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.linha2.Location = New System.Drawing.Point(36, 248)
        Me.linha2.Name = "linha2"
        Me.linha2.Size = New System.Drawing.Size(160, 1)
        Me.linha2.TabIndex = 12
        '
        'input2
        '
        Me.input2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.input2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input2.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input2.ForeColor = System.Drawing.Color.White
        Me.input2.Location = New System.Drawing.Point(36, 223)
        Me.input2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(160, 19)
        Me.input2.TabIndex = 13
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(33, 139)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 15)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Nome"
        '
        'reg_btn
        '
        Me.reg_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.reg_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reg_btn.Image = CType(resources.GetObject("reg_btn.Image"), System.Drawing.Image)
        Me.reg_btn.Location = New System.Drawing.Point(172, 9)
        Me.reg_btn.Name = "reg_btn"
        Me.reg_btn.Size = New System.Drawing.Size(36, 36)
        Me.reg_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.reg_btn.TabIndex = 6
        Me.reg_btn.TabStop = False
        '
        'tim_btn
        '
        Me.tim_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.tim_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tim_btn.Image = Global.Valorant_E_Sports.My.Resources.Resources.time
        Me.tim_btn.Location = New System.Drawing.Point(96, 9)
        Me.tim_btn.Name = "tim_btn"
        Me.tim_btn.Size = New System.Drawing.Size(36, 36)
        Me.tim_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tim_btn.TabIndex = 4
        Me.tim_btn.TabStop = False
        '
        'linha1
        '
        Me.linha1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.linha1.Location = New System.Drawing.Point(37, 185)
        Me.linha1.Name = "linha1"
        Me.linha1.Size = New System.Drawing.Size(160, 1)
        Me.linha1.TabIndex = 1
        '
        'input1
        '
        Me.input1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.input1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input1.Font = New System.Drawing.Font("Ubuntu", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input1.ForeColor = System.Drawing.Color.White
        Me.input1.Location = New System.Drawing.Point(37, 160)
        Me.input1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(160, 19)
        Me.input1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(26, 30)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(137, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Valorant_E_Sports.My.Resources.Resources.val_logo
        Me.PictureBox1.Location = New System.Drawing.Point(169, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(42, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(577, 418)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.tim_btn)
        Me.Panel2.Controls.Add(Me.reg_btn)
        Me.Panel2.Controls.Add(Me.player_btn)
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 54)
        Me.Panel2.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(894, 473)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "t"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.read, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.create, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reg_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tim_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents input1 As System.Windows.Forms.TextBox
    Friend WithEvents linha1 As System.Windows.Forms.Label
    Friend WithEvents reg_btn As System.Windows.Forms.PictureBox
    Friend WithEvents player_btn As System.Windows.Forms.PictureBox
    Friend WithEvents tim_btn As System.Windows.Forms.PictureBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents linha3 As System.Windows.Forms.Label
    Friend WithEvents input3 As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents linha2 As System.Windows.Forms.Label
    Friend WithEvents input2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents id_label As Label
    Friend WithEvents linha0 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents create As PictureBox
    Friend WithEvents delete As PictureBox
    Friend WithEvents update As PictureBox
    Friend WithEvents read As PictureBox
    Friend WithEvents Panel2 As Panel
End Class

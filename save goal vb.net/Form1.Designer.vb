<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LiveCount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Counting = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Label()
        Me.Difficulty = New System.Windows.Forms.Label()
        Me.Difficulty_6 = New System.Windows.Forms.Button()
        Me.Difficulty_5 = New System.Windows.Forms.Button()
        Me.Difficulty_4 = New System.Windows.Forms.Button()
        Me.Difficulty_3 = New System.Windows.Forms.Button()
        Me.Difficulty_2 = New System.Windows.Forms.Button()
        Me.Difficulty_1 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.point_count = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.ForeColor = System.Drawing.Color.Cyan
        Me.Button1.Location = New System.Drawing.Point(201, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(452, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(11, 15)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Counting)
        Me.GroupBox1.Controls.Add(Me.Count)
        Me.GroupBox1.Controls.Add(Me.Difficulty)
        Me.GroupBox1.Controls.Add(Me.Difficulty_6)
        Me.GroupBox1.Controls.Add(Me.Difficulty_5)
        Me.GroupBox1.Controls.Add(Me.Difficulty_4)
        Me.GroupBox1.Controls.Add(Me.Difficulty_3)
        Me.GroupBox1.Controls.Add(Me.Difficulty_2)
        Me.GroupBox1.Controls.Add(Me.Difficulty_1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(291, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 57)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Difficulty"
        '
        'Counting
        '
        Me.Counting.AutoSize = True
        Me.Counting.Location = New System.Drawing.Point(111, 0)
        Me.Counting.Name = "Counting"
        Me.Counting.Size = New System.Drawing.Size(13, 15)
        Me.Counting.TabIndex = 12
        Me.Counting.Text = "3"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Location = New System.Drawing.Point(77, 0)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(36, 15)
        Me.Count.TabIndex = 5
        Me.Count.Text = "Lives:"
        '
        'Difficulty
        '
        Me.Difficulty.AutoSize = True
        Me.Difficulty.Location = New System.Drawing.Point(58, 0)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(13, 15)
        Me.Difficulty.TabIndex = 11
        Me.Difficulty.Text = "1"
        '
        'Difficulty_6
        '
        Me.Difficulty_6.Location = New System.Drawing.Point(161, 16)
        Me.Difficulty_6.Name = "Difficulty_6"
        Me.Difficulty_6.Size = New System.Drawing.Size(54, 23)
        Me.Difficulty_6.TabIndex = 10
        Me.Difficulty_6.Text = "++++"
        Me.Difficulty_6.UseVisualStyleBackColor = True
        '
        'Difficulty_5
        '
        Me.Difficulty_5.Location = New System.Drawing.Point(130, 16)
        Me.Difficulty_5.Name = "Difficulty_5"
        Me.Difficulty_5.Size = New System.Drawing.Size(25, 23)
        Me.Difficulty_5.TabIndex = 9
        Me.Difficulty_5.Text = "5"
        Me.Difficulty_5.UseVisualStyleBackColor = True
        '
        'Difficulty_4
        '
        Me.Difficulty_4.Location = New System.Drawing.Point(99, 16)
        Me.Difficulty_4.Name = "Difficulty_4"
        Me.Difficulty_4.Size = New System.Drawing.Size(25, 23)
        Me.Difficulty_4.TabIndex = 8
        Me.Difficulty_4.Text = "4"
        Me.Difficulty_4.UseVisualStyleBackColor = True
        '
        'Difficulty_3
        '
        Me.Difficulty_3.Location = New System.Drawing.Point(68, 16)
        Me.Difficulty_3.Name = "Difficulty_3"
        Me.Difficulty_3.Size = New System.Drawing.Size(25, 23)
        Me.Difficulty_3.TabIndex = 7
        Me.Difficulty_3.Text = "3"
        Me.Difficulty_3.UseVisualStyleBackColor = True
        '
        'Difficulty_2
        '
        Me.Difficulty_2.Location = New System.Drawing.Point(37, 16)
        Me.Difficulty_2.Name = "Difficulty_2"
        Me.Difficulty_2.Size = New System.Drawing.Size(25, 23)
        Me.Difficulty_2.TabIndex = 6
        Me.Difficulty_2.Text = "2"
        Me.Difficulty_2.UseVisualStyleBackColor = True
        '
        'Difficulty_1
        '
        Me.Difficulty_1.Location = New System.Drawing.Point(6, 16)
        Me.Difficulty_1.Name = "Difficulty_1"
        Me.Difficulty_1.Size = New System.Drawing.Size(25, 23)
        Me.Difficulty_1.TabIndex = 5
        Me.Difficulty_1.Text = "1"
        Me.Difficulty_1.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.Color.Red
        Me.ProgressBar2.Location = New System.Drawing.Point(-4, 17)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(10, 209)
        Me.ProgressBar2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(458, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Points:"
        '
        'point_count
        '
        Me.point_count.AutoSize = True
        Me.point_count.Location = New System.Drawing.Point(460, 13)
        Me.point_count.Name = "point_count"
        Me.point_count.Size = New System.Drawing.Size(13, 15)
        Me.point_count.TabIndex = 6
        Me.point_count.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(12, 82)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(-4, -3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 272)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.Location = New System.Drawing.Point(-2, 216)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(507, 10)
        Me.ProgressBar1.TabIndex = 9
        '
        'ProgressBar3
        '
        Me.ProgressBar3.BackColor = System.Drawing.Color.White
        Me.ProgressBar3.Location = New System.Drawing.Point(-4, 18)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(511, 13)
        Me.ProgressBar3.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Press esc to restart"
        '
        'LiveCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(503, 266)
        Me.Controls.Add(Me.point_count)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LiveCount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Goal Saver"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Difficulty_6 As Button
    Friend WithEvents Difficulty_5 As Button
    Friend WithEvents Difficulty_4 As Button
    Friend WithEvents Difficulty_3 As Button
    Friend WithEvents Difficulty_2 As Button
    Friend WithEvents Difficulty_1 As Button
    Friend WithEvents Difficulty As Label
    Friend WithEvents Count As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents point_count As Label
    Friend WithEvents Counting As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents Label2 As Label
End Class

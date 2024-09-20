<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        avatar = New PictureBox()
        Timer1 = New Timer(components)
        Enemy = New PictureBox()
        coins = New PictureBox()
        enemy2 = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(coins, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(32, 137)
        avatar.Name = "avatar"
        avatar.Size = New Size(80, 48)
        avatar.SizeMode = PictureBoxSizeMode.StretchImage
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 300
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(141, 137)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(100, 50)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 1
        Enemy.TabStop = False
        ' 
        ' coins
        ' 
        coins.Image = CType(resources.GetObject("coins.Image"), Image)
        coins.Location = New Point(330, 137)
        coins.Name = "coins"
        coins.Size = New Size(100, 50)
        coins.SizeMode = PictureBoxSizeMode.StretchImage
        coins.TabIndex = 2
        coins.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(141, 207)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(100, 50)
        enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        enemy2.TabIndex = 3
        enemy2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(894, 543)
        Controls.Add(enemy2)
        Controls.Add(coins)
        Controls.Add(Enemy)
        Controls.Add(avatar)
        Name = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(coins, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents avatar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents coins As PictureBox
    Friend WithEvents enemy2 As PictureBox

End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.listColor = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listEst = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listNumber = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listBody = New System.Windows.Forms.ListBox()
        Me.listAnimal = New System.Windows.Forms.ListBox()
        Me.listNoun = New System.Windows.Forms.ListBox()
        Me.listPluralNoun = New System.Windows.Forms.ListBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listColor
        '
        Me.listColor.FormattingEnabled = True
        Me.listColor.Items.AddRange(New Object() {"Blue ", "Red", "Yellow", "Green", "Orange", "Pink", "Purple", "Black", "White"})
        Me.listColor.Location = New System.Drawing.Point(28, 25)
        Me.listColor.Name = "listColor"
        Me.listColor.Size = New System.Drawing.Size(120, 95)
        Me.listColor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color"
        '
        'listEst
        '
        Me.listEst.FormattingEnabled = True
        Me.listEst.Items.AddRange(New Object() {"biggest", "smallest", "coolest", "smartest", "dumbest", "fastest", "slowest", "roundest"})
        Me.listEst.Location = New System.Drawing.Point(219, 25)
        Me.listEst.Name = "listEst"
        Me.listEst.Size = New System.Drawing.Size(120, 95)
        Me.listEst.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Word ending in est"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number"
        '
        'listNumber
        '
        Me.listNumber.FormattingEnabled = True
        Me.listNumber.Items.AddRange(New Object() {"1", "2", "3", "10", "100", "101", "1000", "10000", "100000", ""})
        Me.listNumber.Location = New System.Drawing.Point(417, 25)
        Me.listNumber.Name = "listNumber"
        Me.listNumber.Size = New System.Drawing.Size(120, 95)
        Me.listNumber.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Body part"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Animal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Noun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Plural Noun"
        '
        'listBody
        '
        Me.listBody.FormattingEnabled = True
        Me.listBody.Items.AddRange(New Object() {"Head", "Leg", "Toe", "Hand", "Foot", "Finger", "Ear"})
        Me.listBody.Location = New System.Drawing.Point(28, 171)
        Me.listBody.Name = "listBody"
        Me.listBody.Size = New System.Drawing.Size(120, 95)
        Me.listBody.TabIndex = 10
        '
        'listAnimal
        '
        Me.listAnimal.FormattingEnabled = True
        Me.listAnimal.Items.AddRange(New Object() {"Goat", "Dog", "Cat", "Monkey", "Zebra", "Horse", "Cow", "Sheep"})
        Me.listAnimal.Location = New System.Drawing.Point(219, 171)
        Me.listAnimal.Name = "listAnimal"
        Me.listAnimal.Size = New System.Drawing.Size(120, 95)
        Me.listAnimal.TabIndex = 11
        '
        'listNoun
        '
        Me.listNoun.FormattingEnabled = True
        Me.listNoun.Items.AddRange(New Object() {"Car", "Train", "Chair", "Table", "TV", "Computer", "Bag", "Ball"})
        Me.listNoun.Location = New System.Drawing.Point(417, 171)
        Me.listNoun.Name = "listNoun"
        Me.listNoun.Size = New System.Drawing.Size(120, 95)
        Me.listNoun.TabIndex = 12
        '
        'listPluralNoun
        '
        Me.listPluralNoun.FormattingEnabled = True
        Me.listPluralNoun.Items.AddRange(New Object() {"Cars", "Trains", "Chairs", "Tables", "TVs", "Computers", "Bags", "Balls"})
        Me.listPluralNoun.Location = New System.Drawing.Point(28, 308)
        Me.listPluralNoun.Name = "listPluralNoun"
        Me.listPluralNoun.Size = New System.Drawing.Size(120, 95)
        Me.listPluralNoun.TabIndex = 13
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(400, 320)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(90, 47)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(463, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 47)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(344, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 47)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 453)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.listPluralNoun)
        Me.Controls.Add(Me.listNoun)
        Me.Controls.Add(Me.listAnimal)
        Me.Controls.Add(Me.listBody)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.listNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listEst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listColor As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listEst As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents listNumber As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents listBody As System.Windows.Forms.ListBox
    Friend WithEvents listAnimal As System.Windows.Forms.ListBox
    Friend WithEvents listNoun As System.Windows.Forms.ListBox
    Friend WithEvents listPluralNoun As System.Windows.Forms.ListBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class

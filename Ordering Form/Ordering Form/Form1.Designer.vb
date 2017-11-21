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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdRoastBeef = New System.Windows.Forms.RadioButton()
        Me.rdSteak = New System.Windows.Forms.RadioButton()
        Me.rdChicken = New System.Windows.Forms.RadioButton()
        Me.rdHamburger = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbMushrooms = New System.Windows.Forms.CheckBox()
        Me.cbOnions = New System.Windows.Forms.CheckBox()
        Me.cbBBQ = New System.Windows.Forms.CheckBox()
        Me.cbCheese = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdSalad = New System.Windows.Forms.RadioButton()
        Me.rdOnionRings = New System.Windows.Forms.RadioButton()
        Me.rdFries = New System.Windows.Forms.RadioButton()
        Me.btnFinishOrder = New System.Windows.Forms.Button()
        Me.lblFinalMeal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Drew's Delicious Diner"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdRoastBeef)
        Me.GroupBox1.Controls.Add(Me.rdSteak)
        Me.GroupBox1.Controls.Add(Me.rdChicken)
        Me.GroupBox1.Controls.Add(Me.rdHamburger)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 214)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick Your Meat"
        '
        'rdRoastBeef
        '
        Me.rdRoastBeef.AutoSize = True
        Me.rdRoastBeef.Location = New System.Drawing.Point(19, 162)
        Me.rdRoastBeef.Name = "rdRoastBeef"
        Me.rdRoastBeef.Size = New System.Drawing.Size(192, 22)
        Me.rdRoastBeef.TabIndex = 11
        Me.rdRoastBeef.TabStop = True
        Me.rdRoastBeef.Text = "Roast Beef Sandwhich"
        Me.rdRoastBeef.UseVisualStyleBackColor = True
        '
        'rdSteak
        '
        Me.rdSteak.AutoSize = True
        Me.rdSteak.Location = New System.Drawing.Point(19, 117)
        Me.rdSteak.Name = "rdSteak"
        Me.rdSteak.Size = New System.Drawing.Size(151, 22)
        Me.rdSteak.TabIndex = 10
        Me.rdSteak.TabStop = True
        Me.rdSteak.Text = "Steak Sandwhich"
        Me.rdSteak.UseVisualStyleBackColor = True
        '
        'rdChicken
        '
        Me.rdChicken.AutoSize = True
        Me.rdChicken.Location = New System.Drawing.Point(19, 76)
        Me.rdChicken.Name = "rdChicken"
        Me.rdChicken.Size = New System.Drawing.Size(161, 22)
        Me.rdChicken.TabIndex = 9
        Me.rdChicken.TabStop = True
        Me.rdChicken.Text = "Chicken Sandwich"
        Me.rdChicken.UseVisualStyleBackColor = True
        '
        'rdHamburger
        '
        Me.rdHamburger.AutoSize = True
        Me.rdHamburger.Location = New System.Drawing.Point(19, 36)
        Me.rdHamburger.Name = "rdHamburger"
        Me.rdHamburger.Size = New System.Drawing.Size(108, 22)
        Me.rdHamburger.TabIndex = 8
        Me.rdHamburger.TabStop = True
        Me.rdHamburger.Text = "Hamburger"
        Me.rdHamburger.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbMushrooms)
        Me.GroupBox2.Controls.Add(Me.cbOnions)
        Me.GroupBox2.Controls.Add(Me.cbBBQ)
        Me.GroupBox2.Controls.Add(Me.cbCheese)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(269, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 214)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick Your Toppings"
        '
        'cbMushrooms
        '
        Me.cbMushrooms.AutoSize = True
        Me.cbMushrooms.Location = New System.Drawing.Point(18, 162)
        Me.cbMushrooms.Name = "cbMushrooms"
        Me.cbMushrooms.Size = New System.Drawing.Size(111, 22)
        Me.cbMushrooms.TabIndex = 7
        Me.cbMushrooms.Text = "Mushrooms"
        Me.cbMushrooms.UseVisualStyleBackColor = True
        '
        'cbOnions
        '
        Me.cbOnions.AutoSize = True
        Me.cbOnions.Location = New System.Drawing.Point(18, 117)
        Me.cbOnions.Name = "cbOnions"
        Me.cbOnions.Size = New System.Drawing.Size(79, 22)
        Me.cbOnions.TabIndex = 6
        Me.cbOnions.Text = "Onions"
        Me.cbOnions.UseVisualStyleBackColor = True
        '
        'cbBBQ
        '
        Me.cbBBQ.AutoSize = True
        Me.cbBBQ.Location = New System.Drawing.Point(18, 76)
        Me.cbBBQ.Name = "cbBBQ"
        Me.cbBBQ.Size = New System.Drawing.Size(108, 22)
        Me.cbBBQ.TabIndex = 5
        Me.cbBBQ.Text = "BBQ Sauce"
        Me.cbBBQ.UseVisualStyleBackColor = True
        '
        'cbCheese
        '
        Me.cbCheese.AutoSize = True
        Me.cbCheese.Location = New System.Drawing.Point(18, 36)
        Me.cbCheese.Name = "cbCheese"
        Me.cbCheese.Size = New System.Drawing.Size(75, 22)
        Me.cbCheese.TabIndex = 4
        Me.cbCheese.Text = "Cheese"
        Me.cbCheese.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdSalad)
        Me.GroupBox3.Controls.Add(Me.rdOnionRings)
        Me.GroupBox3.Controls.Add(Me.rdFries)
        Me.GroupBox3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(526, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 214)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pick Your Side"
        '
        'rdSalad
        '
        Me.rdSalad.AutoSize = True
        Me.rdSalad.Location = New System.Drawing.Point(23, 149)
        Me.rdSalad.Name = "rdSalad"
        Me.rdSalad.Size = New System.Drawing.Size(66, 22)
        Me.rdSalad.TabIndex = 13
        Me.rdSalad.TabStop = True
        Me.rdSalad.Text = "Salad"
        Me.rdSalad.UseVisualStyleBackColor = True
        '
        'rdOnionRings
        '
        Me.rdOnionRings.AutoSize = True
        Me.rdOnionRings.Location = New System.Drawing.Point(23, 98)
        Me.rdOnionRings.Name = "rdOnionRings"
        Me.rdOnionRings.Size = New System.Drawing.Size(120, 22)
        Me.rdOnionRings.TabIndex = 12
        Me.rdOnionRings.TabStop = True
        Me.rdOnionRings.Text = "Onion Rings"
        Me.rdOnionRings.UseVisualStyleBackColor = True
        '
        'rdFries
        '
        Me.rdFries.AutoSize = True
        Me.rdFries.Location = New System.Drawing.Point(23, 49)
        Me.rdFries.Name = "rdFries"
        Me.rdFries.Size = New System.Drawing.Size(64, 22)
        Me.rdFries.TabIndex = 11
        Me.rdFries.TabStop = True
        Me.rdFries.Text = "Fries"
        Me.rdFries.UseVisualStyleBackColor = True
        '
        'btnFinishOrder
        '
        Me.btnFinishOrder.Location = New System.Drawing.Point(301, 288)
        Me.btnFinishOrder.Name = "btnFinishOrder"
        Me.btnFinishOrder.Size = New System.Drawing.Size(145, 55)
        Me.btnFinishOrder.TabIndex = 4
        Me.btnFinishOrder.Text = "Finish Order"
        Me.btnFinishOrder.UseVisualStyleBackColor = True
        '
        'lblFinalMeal
        '
        Me.lblFinalMeal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalMeal.Location = New System.Drawing.Point(157, 361)
        Me.lblFinalMeal.Name = "lblFinalMeal"
        Me.lblFinalMeal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFinalMeal.Size = New System.Drawing.Size(432, 125)
        Me.lblFinalMeal.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(137, 315)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(125, 29)
        Me.lblTotal.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(574, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 55)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1636, 882)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFinalMeal)
        Me.Controls.Add(Me.btnFinishOrder)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "Drew's Delicious Diner"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdRoastBeef As System.Windows.Forms.RadioButton
    Friend WithEvents rdSteak As System.Windows.Forms.RadioButton
    Friend WithEvents rdChicken As System.Windows.Forms.RadioButton
    Friend WithEvents rdHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents cbOnions As System.Windows.Forms.CheckBox
    Friend WithEvents cbBBQ As System.Windows.Forms.CheckBox
    Friend WithEvents cbCheese As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdSalad As System.Windows.Forms.RadioButton
    Friend WithEvents rdOnionRings As System.Windows.Forms.RadioButton
    Friend WithEvents rdFries As System.Windows.Forms.RadioButton
    Friend WithEvents btnFinishOrder As System.Windows.Forms.Button
    Friend WithEvents lblFinalMeal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

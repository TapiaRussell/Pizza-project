<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaOrder
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
        Me.btnAnotherOrder = New System.Windows.Forms.Button()
        Me.lblTimeOfOrder = New System.Windows.Forms.Label()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblCreditCardNo = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtCreditCardNo = New System.Windows.Forms.TextBox()
        Me.grpbSize = New System.Windows.Forms.GroupBox()
        Me.rdbLarge = New System.Windows.Forms.RadioButton()
        Me.rdbMidium = New System.Windows.Forms.RadioButton()
        Me.rdbSmall = New System.Windows.Forms.RadioButton()
        Me.numPizzaQty = New System.Windows.Forms.NumericUpDown()
        Me.grpbMeatToppings = New System.Windows.Forms.GroupBox()
        Me.ckbHam = New System.Windows.Forms.CheckBox()
        Me.ckbBacon = New System.Windows.Forms.CheckBox()
        Me.ckbSausage = New System.Windows.Forms.CheckBox()
        Me.ckbPepperoni = New System.Windows.Forms.CheckBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.grpbOtherToppings = New System.Windows.Forms.GroupBox()
        Me.ckbOnion = New System.Windows.Forms.CheckBox()
        Me.ckbBellPepper = New System.Windows.Forms.CheckBox()
        Me.ckbMushroom = New System.Windows.Forms.CheckBox()
        Me.ckbCheese = New System.Windows.Forms.CheckBox()
        Me.btbExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpbCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.grpbQty = New System.Windows.Forms.GroupBox()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbCash = New System.Windows.Forms.RadioButton()
        Me.rdbCheck = New System.Windows.Forms.RadioButton()
        Me.rdbCredit = New System.Windows.Forms.RadioButton()
        Me.rdbDelivery = New System.Windows.Forms.RadioButton()
        Me.rdbTakeout = New System.Windows.Forms.RadioButton()
        Me.grpbSize.SuspendLayout()
        CType(Me.numPizzaQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbMeatToppings.SuspendLayout()
        Me.grpbOtherToppings.SuspendLayout()
        Me.grpbCustomerInfo.SuspendLayout()
        Me.grpbQty.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAnotherOrder
        '
        Me.btnAnotherOrder.Location = New System.Drawing.Point(249, 595)
        Me.btnAnotherOrder.Name = "btnAnotherOrder"
        Me.btnAnotherOrder.Size = New System.Drawing.Size(107, 37)
        Me.btnAnotherOrder.TabIndex = 11
        Me.btnAnotherOrder.Text = "&Another Order"
        Me.btnAnotherOrder.UseVisualStyleBackColor = True
        '
        'lblTimeOfOrder
        '
        Me.lblTimeOfOrder.AutoSize = True
        Me.lblTimeOfOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOfOrder.Location = New System.Drawing.Point(166, 158)
        Me.lblTimeOfOrder.Name = "lblTimeOfOrder"
        Me.lblTimeOfOrder.Size = New System.Drawing.Size(109, 20)
        Me.lblTimeOfOrder.TabIndex = 13
        Me.lblTimeOfOrder.Text = "Time of Order:"
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.Location = New System.Drawing.Point(442, 158)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(81, 20)
        Me.lblOrderNo.TabIndex = 14
        Me.lblOrderNo.Text = "Order No.:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(54, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name:"
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNo.Location = New System.Drawing.Point(24, 85)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(85, 20)
        Me.lblPhoneNo.TabIndex = 2
        Me.lblPhoneNo.Text = "&Phone no.:"
        '
        'lblCreditCardNo
        '
        Me.lblCreditCardNo.AutoSize = True
        Me.lblCreditCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditCardNo.Location = New System.Drawing.Point(3, 115)
        Me.lblCreditCardNo.Name = "lblCreditCardNo"
        Me.lblCreditCardNo.Size = New System.Drawing.Size(106, 20)
        Me.lblCreditCardNo.TabIndex = 4
        Me.lblCreditCardNo.Text = "C&redit Card #:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(115, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(167, 26)
        Me.txtName.TabIndex = 1
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNo.Location = New System.Drawing.Point(115, 82)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(167, 26)
        Me.txtPhoneNo.TabIndex = 3
        '
        'txtCreditCardNo
        '
        Me.txtCreditCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCardNo.Location = New System.Drawing.Point(115, 112)
        Me.txtCreditCardNo.Name = "txtCreditCardNo"
        Me.txtCreditCardNo.Size = New System.Drawing.Size(167, 26)
        Me.txtCreditCardNo.TabIndex = 5
        '
        'grpbSize
        '
        Me.grpbSize.Controls.Add(Me.rdbLarge)
        Me.grpbSize.Controls.Add(Me.rdbMidium)
        Me.grpbSize.Controls.Add(Me.rdbSmall)
        Me.grpbSize.Location = New System.Drawing.Point(36, 243)
        Me.grpbSize.Name = "grpbSize"
        Me.grpbSize.Size = New System.Drawing.Size(102, 100)
        Me.grpbSize.TabIndex = 8
        Me.grpbSize.TabStop = False
        Me.grpbSize.Text = "Size:"
        '
        'rdbLarge
        '
        Me.rdbLarge.AutoSize = True
        Me.rdbLarge.Location = New System.Drawing.Point(6, 65)
        Me.rdbLarge.Name = "rdbLarge"
        Me.rdbLarge.Size = New System.Drawing.Size(52, 17)
        Me.rdbLarge.TabIndex = 2
        Me.rdbLarge.Text = "Large"
        Me.rdbLarge.UseVisualStyleBackColor = True
        '
        'rdbMidium
        '
        Me.rdbMidium.AutoSize = True
        Me.rdbMidium.Location = New System.Drawing.Point(6, 42)
        Me.rdbMidium.Name = "rdbMidium"
        Me.rdbMidium.Size = New System.Drawing.Size(62, 17)
        Me.rdbMidium.TabIndex = 1
        Me.rdbMidium.Text = "Medium"
        Me.rdbMidium.UseVisualStyleBackColor = True
        '
        'rdbSmall
        '
        Me.rdbSmall.AutoSize = True
        Me.rdbSmall.Checked = True
        Me.rdbSmall.Location = New System.Drawing.Point(6, 19)
        Me.rdbSmall.Name = "rdbSmall"
        Me.rdbSmall.Size = New System.Drawing.Size(50, 17)
        Me.rdbSmall.TabIndex = 0
        Me.rdbSmall.TabStop = True
        Me.rdbSmall.Text = "Small"
        Me.rdbSmall.UseVisualStyleBackColor = True
        '
        'numPizzaQty
        '
        Me.numPizzaQty.Location = New System.Drawing.Point(6, 19)
        Me.numPizzaQty.Name = "numPizzaQty"
        Me.numPizzaQty.Size = New System.Drawing.Size(60, 20)
        Me.numPizzaQty.TabIndex = 7
        '
        'grpbMeatToppings
        '
        Me.grpbMeatToppings.Controls.Add(Me.ckbHam)
        Me.grpbMeatToppings.Controls.Add(Me.ckbBacon)
        Me.grpbMeatToppings.Controls.Add(Me.ckbSausage)
        Me.grpbMeatToppings.Controls.Add(Me.ckbPepperoni)
        Me.grpbMeatToppings.Location = New System.Drawing.Point(36, 349)
        Me.grpbMeatToppings.Name = "grpbMeatToppings"
        Me.grpbMeatToppings.Size = New System.Drawing.Size(102, 118)
        Me.grpbMeatToppings.TabIndex = 9
        Me.grpbMeatToppings.TabStop = False
        Me.grpbMeatToppings.Text = "Meat Toppings:"
        '
        'ckbHam
        '
        Me.ckbHam.AutoSize = True
        Me.ckbHam.Location = New System.Drawing.Point(7, 88)
        Me.ckbHam.Name = "ckbHam"
        Me.ckbHam.Size = New System.Drawing.Size(48, 17)
        Me.ckbHam.TabIndex = 3
        Me.ckbHam.Text = "Ham"
        Me.ckbHam.UseVisualStyleBackColor = True
        '
        'ckbBacon
        '
        Me.ckbBacon.AutoSize = True
        Me.ckbBacon.Location = New System.Drawing.Point(7, 65)
        Me.ckbBacon.Name = "ckbBacon"
        Me.ckbBacon.Size = New System.Drawing.Size(57, 17)
        Me.ckbBacon.TabIndex = 2
        Me.ckbBacon.Text = "Bacon"
        Me.ckbBacon.UseVisualStyleBackColor = True
        '
        'ckbSausage
        '
        Me.ckbSausage.AutoSize = True
        Me.ckbSausage.Location = New System.Drawing.Point(7, 42)
        Me.ckbSausage.Name = "ckbSausage"
        Me.ckbSausage.Size = New System.Drawing.Size(68, 17)
        Me.ckbSausage.TabIndex = 1
        Me.ckbSausage.Text = "Sausage"
        Me.ckbSausage.UseVisualStyleBackColor = True
        '
        'ckbPepperoni
        '
        Me.ckbPepperoni.AutoSize = True
        Me.ckbPepperoni.Location = New System.Drawing.Point(7, 19)
        Me.ckbPepperoni.Name = "ckbPepperoni"
        Me.ckbPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.ckbPepperoni.TabIndex = 0
        Me.ckbPepperoni.Text = "Pepperoni"
        Me.ckbPepperoni.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(298, 158)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 20)
        Me.lblTime.TabIndex = 15
        Me.lblTime.Text = "time"
        '
        'grpbOtherToppings
        '
        Me.grpbOtherToppings.Controls.Add(Me.ckbOnion)
        Me.grpbOtherToppings.Controls.Add(Me.ckbBellPepper)
        Me.grpbOtherToppings.Controls.Add(Me.ckbMushroom)
        Me.grpbOtherToppings.Controls.Add(Me.ckbCheese)
        Me.grpbOtherToppings.Location = New System.Drawing.Point(36, 473)
        Me.grpbOtherToppings.Name = "grpbOtherToppings"
        Me.grpbOtherToppings.Size = New System.Drawing.Size(102, 118)
        Me.grpbOtherToppings.TabIndex = 10
        Me.grpbOtherToppings.TabStop = False
        Me.grpbOtherToppings.Text = "Other Toppings:"
        '
        'ckbOnion
        '
        Me.ckbOnion.AutoSize = True
        Me.ckbOnion.Location = New System.Drawing.Point(7, 88)
        Me.ckbOnion.Name = "ckbOnion"
        Me.ckbOnion.Size = New System.Drawing.Size(54, 17)
        Me.ckbOnion.TabIndex = 3
        Me.ckbOnion.Text = "Onion"
        Me.ckbOnion.UseVisualStyleBackColor = True
        '
        'ckbBellPepper
        '
        Me.ckbBellPepper.AutoSize = True
        Me.ckbBellPepper.Location = New System.Drawing.Point(7, 65)
        Me.ckbBellPepper.Name = "ckbBellPepper"
        Me.ckbBellPepper.Size = New System.Drawing.Size(80, 17)
        Me.ckbBellPepper.TabIndex = 2
        Me.ckbBellPepper.Text = "Bell Pepper"
        Me.ckbBellPepper.UseVisualStyleBackColor = True
        '
        'ckbMushroom
        '
        Me.ckbMushroom.AutoSize = True
        Me.ckbMushroom.Location = New System.Drawing.Point(7, 42)
        Me.ckbMushroom.Name = "ckbMushroom"
        Me.ckbMushroom.Size = New System.Drawing.Size(75, 17)
        Me.ckbMushroom.TabIndex = 1
        Me.ckbMushroom.Text = "Mushroom"
        Me.ckbMushroom.UseVisualStyleBackColor = True
        '
        'ckbCheese
        '
        Me.ckbCheese.AutoSize = True
        Me.ckbCheese.Location = New System.Drawing.Point(7, 19)
        Me.ckbCheese.Name = "ckbCheese"
        Me.ckbCheese.Size = New System.Drawing.Size(62, 17)
        Me.ckbCheese.TabIndex = 0
        Me.ckbCheese.Text = "Cheese"
        Me.ckbCheese.UseVisualStyleBackColor = True
        '
        'btbExit
        '
        Me.btbExit.Location = New System.Drawing.Point(446, 638)
        Me.btbExit.Name = "btbExit"
        Me.btbExit.Size = New System.Drawing.Size(107, 37)
        Me.btbExit.TabIndex = 12
        Me.btbExit.Text = "E&xit"
        Me.btbExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(446, 595)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 37)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(52, 597)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(107, 37)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'grpbCustomerInfo
        '
        Me.grpbCustomerInfo.Controls.Add(Me.lblName)
        Me.grpbCustomerInfo.Controls.Add(Me.lblPhoneNo)
        Me.grpbCustomerInfo.Controls.Add(Me.lblCreditCardNo)
        Me.grpbCustomerInfo.Controls.Add(Me.txtName)
        Me.grpbCustomerInfo.Controls.Add(Me.txtPhoneNo)
        Me.grpbCustomerInfo.Controls.Add(Me.txtCreditCardNo)
        Me.grpbCustomerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbCustomerInfo.Location = New System.Drawing.Point(4, 4)
        Me.grpbCustomerInfo.Name = "grpbCustomerInfo"
        Me.grpbCustomerInfo.Size = New System.Drawing.Size(290, 151)
        Me.grpbCustomerInfo.TabIndex = 19
        Me.grpbCustomerInfo.TabStop = False
        Me.grpbCustomerInfo.Text = "Customer Info:"
        '
        'grpbQty
        '
        Me.grpbQty.Controls.Add(Me.numPizzaQty)
        Me.grpbQty.Location = New System.Drawing.Point(36, 194)
        Me.grpbQty.Name = "grpbQty"
        Me.grpbQty.Size = New System.Drawing.Size(76, 43)
        Me.grpbQty.TabIndex = 20
        Me.grpbQty.TabStop = False
        Me.grpbQty.Text = "Qty:"
        '
        'lblSummary
        '
        Me.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSummary.Location = New System.Drawing.Point(170, 194)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(385, 397)
        Me.lblSummary.TabIndex = 21
        Me.lblSummary.Text = "Order summary:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbCredit)
        Me.GroupBox1.Controls.Add(Me.rdbCheck)
        Me.GroupBox1.Controls.Add(Me.rdbCash)
        Me.GroupBox1.Location = New System.Drawing.Point(302, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 143)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Method:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbTakeout)
        Me.GroupBox2.Controls.Add(Me.rdbDelivery)
        Me.GroupBox2.Location = New System.Drawing.Point(428, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 143)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "To go?"
        '
        'rdbCash
        '
        Me.rdbCash.AutoSize = True
        Me.rdbCash.Location = New System.Drawing.Point(7, 35)
        Me.rdbCash.Name = "rdbCash"
        Me.rdbCash.Size = New System.Drawing.Size(49, 17)
        Me.rdbCash.TabIndex = 0
        Me.rdbCash.TabStop = True
        Me.rdbCash.Text = "Cash"
        Me.rdbCash.UseVisualStyleBackColor = True
        '
        'rdbCheck
        '
        Me.rdbCheck.AutoSize = True
        Me.rdbCheck.Location = New System.Drawing.Point(7, 59)
        Me.rdbCheck.Name = "rdbCheck"
        Me.rdbCheck.Size = New System.Drawing.Size(56, 17)
        Me.rdbCheck.TabIndex = 1
        Me.rdbCheck.TabStop = True
        Me.rdbCheck.Text = "Check"
        Me.rdbCheck.UseVisualStyleBackColor = True
        '
        'rdbCredit
        '
        Me.rdbCredit.AutoSize = True
        Me.rdbCredit.Location = New System.Drawing.Point(7, 82)
        Me.rdbCredit.Name = "rdbCredit"
        Me.rdbCredit.Size = New System.Drawing.Size(52, 17)
        Me.rdbCredit.TabIndex = 2
        Me.rdbCredit.TabStop = True
        Me.rdbCredit.Text = "Credit"
        Me.rdbCredit.UseVisualStyleBackColor = True
        '
        'rdbDelivery
        '
        Me.rdbDelivery.AutoSize = True
        Me.rdbDelivery.Location = New System.Drawing.Point(7, 35)
        Me.rdbDelivery.Name = "rdbDelivery"
        Me.rdbDelivery.Size = New System.Drawing.Size(63, 17)
        Me.rdbDelivery.TabIndex = 0
        Me.rdbDelivery.TabStop = True
        Me.rdbDelivery.Text = "Delivery"
        Me.rdbDelivery.UseVisualStyleBackColor = True
        '
        'rdbTakeout
        '
        Me.rdbTakeout.AutoSize = True
        Me.rdbTakeout.Location = New System.Drawing.Point(7, 59)
        Me.rdbTakeout.Name = "rdbTakeout"
        Me.rdbTakeout.Size = New System.Drawing.Size(65, 17)
        Me.rdbTakeout.TabIndex = 1
        Me.rdbTakeout.TabStop = True
        Me.rdbTakeout.Text = "Takeout"
        Me.rdbTakeout.UseVisualStyleBackColor = True
        '
        'PizzaOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 679)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTimeOfOrder)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblOrderNo)
        Me.Controls.Add(Me.grpbQty)
        Me.Controls.Add(Me.grpbCustomerInfo)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btbExit)
        Me.Controls.Add(Me.grpbOtherToppings)
        Me.Controls.Add(Me.grpbMeatToppings)
        Me.Controls.Add(Me.grpbSize)
        Me.Controls.Add(Me.btnAnotherOrder)
        Me.Name = "PizzaOrder"
        Me.Text = "Form1"
        Me.grpbSize.ResumeLayout(False)
        Me.grpbSize.PerformLayout()
        CType(Me.numPizzaQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbMeatToppings.ResumeLayout(False)
        Me.grpbMeatToppings.PerformLayout()
        Me.grpbOtherToppings.ResumeLayout(False)
        Me.grpbOtherToppings.PerformLayout()
        Me.grpbCustomerInfo.ResumeLayout(False)
        Me.grpbCustomerInfo.PerformLayout()
        Me.grpbQty.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnotherOrder As Button
    Friend WithEvents lblTimeOfOrder As Label
    Friend WithEvents lblOrderNo As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents lblCreditCardNo As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtCreditCardNo As TextBox
    Friend WithEvents grpbSize As GroupBox
    Friend WithEvents rdbLarge As RadioButton
    Friend WithEvents rdbMidium As RadioButton
    Friend WithEvents rdbSmall As RadioButton
    Friend WithEvents numPizzaQty As NumericUpDown
    Friend WithEvents grpbMeatToppings As GroupBox
    Friend WithEvents ckbHam As CheckBox
    Friend WithEvents ckbBacon As CheckBox
    Friend WithEvents ckbSausage As CheckBox
    Friend WithEvents ckbPepperoni As CheckBox
    Friend WithEvents lblTime As Label
    Friend WithEvents grpbOtherToppings As GroupBox
    Friend WithEvents ckbOnion As CheckBox
    Friend WithEvents ckbBellPepper As CheckBox
    Friend WithEvents ckbMushroom As CheckBox
    Friend WithEvents ckbCheese As CheckBox
    Friend WithEvents btbExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents grpbCustomerInfo As GroupBox
    Friend WithEvents grpbQty As GroupBox
    Friend WithEvents lblSummary As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbCredit As RadioButton
    Friend WithEvents rdbCheck As RadioButton
    Friend WithEvents rdbCash As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbTakeout As RadioButton
    Friend WithEvents rdbDelivery As RadioButton
End Class

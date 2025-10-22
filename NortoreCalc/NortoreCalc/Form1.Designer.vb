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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnPetFood = New Button()
        ItemTypeGroupBox = New GroupBox()
        btnGroceryPointFive = New Button()
        btnToyPointFive = New Button()
        btnGrocery = New Button()
        btnSixFivePetFood = New Button()
        btnLitter = New Button()
        btnHorseFeed = New Button()
        btnTreatsToys = New Button()
        CostLabel = New Label()
        txtCost = New TextBox()
        PriceLabel = New Label()
        lblPrice = New Label()
        PictureBox1 = New PictureBox()
        ItemTypeGroupBox.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPetFood
        ' 
        btnPetFood.Location = New Point(178, 42)
        btnPetFood.Name = "btnPetFood"
        btnPetFood.Size = New Size(158, 53)
        btnPetFood.TabIndex = 3
        btnPetFood.Text = "Pet &Food .7"
        btnPetFood.UseVisualStyleBackColor = True
        ' 
        ' ItemTypeGroupBox
        ' 
        ItemTypeGroupBox.Controls.Add(btnGroceryPointFive)
        ItemTypeGroupBox.Controls.Add(btnToyPointFive)
        ItemTypeGroupBox.Controls.Add(btnGrocery)
        ItemTypeGroupBox.Controls.Add(btnSixFivePetFood)
        ItemTypeGroupBox.Controls.Add(btnLitter)
        ItemTypeGroupBox.Controls.Add(btnHorseFeed)
        ItemTypeGroupBox.Controls.Add(btnTreatsToys)
        ItemTypeGroupBox.Controls.Add(btnPetFood)
        ItemTypeGroupBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ItemTypeGroupBox.Location = New Point(167, 11)
        ItemTypeGroupBox.Name = "ItemTypeGroupBox"
        ItemTypeGroupBox.Size = New Size(349, 288)
        ItemTypeGroupBox.TabIndex = 1
        ItemTypeGroupBox.TabStop = False
        ItemTypeGroupBox.Text = "Item Category"
        ' 
        ' btnGroceryPointFive
        ' 
        btnGroceryPointFive.Location = New Point(178, 160)
        btnGroceryPointFive.Name = "btnGroceryPointFive"
        btnGroceryPointFive.Size = New Size(158, 53)
        btnGroceryPointFive.TabIndex = 7
        btnGroceryPointFive.Text = "G&rocery Food .85"
        btnGroceryPointFive.UseVisualStyleBackColor = True
        ' 
        ' btnToyPointFive
        ' 
        btnToyPointFive.Location = New Point(178, 101)
        btnToyPointFive.Name = "btnToyPointFive"
        btnToyPointFive.Size = New Size(158, 53)
        btnToyPointFive.TabIndex = 5
        btnToyPointFive.Text = "T&oys 2.5"
        btnToyPointFive.UseVisualStyleBackColor = True
        ' 
        ' btnGrocery
        ' 
        btnGrocery.Location = New Point(14, 160)
        btnGrocery.Name = "btnGrocery"
        btnGrocery.Size = New Size(158, 53)
        btnGrocery.TabIndex = 6
        btnGrocery.Text = "&Grocery Food .8"
        btnGrocery.UseVisualStyleBackColor = True
        ' 
        ' btnSixFivePetFood
        ' 
        btnSixFivePetFood.Location = New Point(14, 42)
        btnSixFivePetFood.Name = "btnSixFivePetFood"
        btnSixFivePetFood.Size = New Size(158, 53)
        btnSixFivePetFood.TabIndex = 2
        btnSixFivePetFood.Text = "&Pet Food .65"
        btnSixFivePetFood.UseVisualStyleBackColor = True
        ' 
        ' btnLitter
        ' 
        btnLitter.Location = New Point(178, 219)
        btnLitter.Name = "btnLitter"
        btnLitter.Size = New Size(158, 53)
        btnLitter.TabIndex = 9
        btnLitter.Text = "&Litter"
        btnLitter.UseVisualStyleBackColor = True
        ' 
        ' btnHorseFeed
        ' 
        btnHorseFeed.Location = New Point(14, 219)
        btnHorseFeed.Name = "btnHorseFeed"
        btnHorseFeed.Size = New Size(158, 53)
        btnHorseFeed.TabIndex = 8
        btnHorseFeed.Text = "&Horse Feed"
        btnHorseFeed.UseVisualStyleBackColor = True
        ' 
        ' btnTreatsToys
        ' 
        btnTreatsToys.Location = New Point(14, 101)
        btnTreatsToys.Name = "btnTreatsToys"
        btnTreatsToys.Size = New Size(158, 53)
        btnTreatsToys.TabIndex = 4
        btnTreatsToys.Text = "Pet &Treats and Toys"
        btnTreatsToys.UseVisualStyleBackColor = True
        ' 
        ' CostLabel
        ' 
        CostLabel.AutoSize = True
        CostLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CostLabel.Location = New Point(11, 21)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New Size(44, 21)
        CostLabel.TabIndex = 0
        CostLabel.Text = "&Cost:"
        ' 
        ' txtCost
        ' 
        txtCost.BorderStyle = BorderStyle.FixedSingle
        txtCost.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCost.Location = New Point(61, 21)
        txtCost.MaximumSize = New Size(100, 29)
        txtCost.MinimumSize = New Size(100, 29)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(100, 29)
        txtCost.TabIndex = 1
        ' 
        ' PriceLabel
        ' 
        PriceLabel.AutoSize = True
        PriceLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PriceLabel.Location = New Point(11, 53)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New Size(47, 21)
        PriceLabel.TabIndex = 5
        PriceLabel.Text = "Price:"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = SystemColors.Control
        lblPrice.BorderStyle = BorderStyle.FixedSingle
        lblPrice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.Location = New Point(61, 53)
        lblPrice.MaximumSize = New Size(100, 29)
        lblPrice.MinimumSize = New Size(100, 29)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(100, 29)
        lblPrice.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(13, 183)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(136, 130)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(527, 315)
        Controls.Add(PictureBox1)
        Controls.Add(lblPrice)
        Controls.Add(PriceLabel)
        Controls.Add(txtCost)
        Controls.Add(CostLabel)
        Controls.Add(ItemTypeGroupBox)
        Name = "Form1"
        Text = "NortoreCost"
        ItemTypeGroupBox.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPetFood As Button
    Friend WithEvents ItemTypeGroupBox As GroupBox
    Friend WithEvents btnHorseFeed As Button
    Friend WithEvents btnTreatsToys As Button
    Friend WithEvents CostLabel As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnGrocery As Button
    Friend WithEvents btnSixFivePetFood As Button
    Friend WithEvents btnLitter As Button
    Friend WithEvents btnToyPointFive As Button
    Friend WithEvents btnGroceryPointFive As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class

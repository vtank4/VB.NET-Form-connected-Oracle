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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UpdateStatus = New System.Windows.Forms.Button()
        Me.UpdateCustomerSalesYTD = New System.Windows.Forms.Button()
        Me.GetCustomerString = New System.Windows.Forms.Button()
        Me.DeleteAllCustomers = New System.Windows.Forms.Button()
        Me.AddCustomer = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.DeleteCustomer = New System.Windows.Forms.Button()
        Me.GetAllCustomers = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddProduct = New System.Windows.Forms.Button()
        Me.DeleteAllProducts = New System.Windows.Forms.Button()
        Me.GetProductString = New System.Windows.Forms.Button()
        Me.UpdateProductSalesYTD = New System.Windows.Forms.Button()
        Me.GetAllProducts = New System.Windows.Forms.Button()
        Me.DeleteProduct = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DeleteAllSales = New System.Windows.Forms.Button()
        Me.DeleteSale = New System.Windows.Forms.Button()
        Me.CountProductSales = New System.Windows.Forms.Button()
        Me.GetAllSales = New System.Windows.Forms.Button()
        Me.AddComplexSale = New System.Windows.Forms.Button()
        Me.SumCustSalesYTD = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddSimpleSale = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxProdSaleAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxProdName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxProdID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCustSaleAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCustStatus = New System.Windows.Forms.TextBox()
        Me.TextBoxCustName = New System.Windows.Forms.TextBox()
        Me.CustName = New System.Windows.Forms.Label()
        Me.TextBoxCustID = New System.Windows.Forms.TextBox()
        Me.CustomerID = New System.Windows.Forms.Label()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.ClearDisplay = New System.Windows.Forms.Button()
        Me.AddLocation = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxLocationCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxMaxQty = New System.Windows.Forms.TextBox()
        Me.TextBoxMinQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxNumberofDay = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxSellingPrice = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Operations"
        '
        'UpdateStatus
        '
        Me.UpdateStatus.Location = New System.Drawing.Point(3, 30)
        Me.UpdateStatus.Name = "UpdateStatus"
        Me.UpdateStatus.Size = New System.Drawing.Size(93, 22)
        Me.UpdateStatus.TabIndex = 5
        Me.UpdateStatus.Text = "Update Status"
        Me.UpdateStatus.UseVisualStyleBackColor = True
        '
        'UpdateCustomerSalesYTD
        '
        Me.UpdateCustomerSalesYTD.Location = New System.Drawing.Point(102, 30)
        Me.UpdateCustomerSalesYTD.Name = "UpdateCustomerSalesYTD"
        Me.UpdateCustomerSalesYTD.Size = New System.Drawing.Size(153, 21)
        Me.UpdateCustomerSalesYTD.TabIndex = 5
        Me.UpdateCustomerSalesYTD.Text = "Update Customer SalesYTD"
        Me.UpdateCustomerSalesYTD.UseVisualStyleBackColor = True
        '
        'GetCustomerString
        '
        Me.GetCustomerString.Location = New System.Drawing.Point(220, 3)
        Me.GetCustomerString.Name = "GetCustomerString"
        Me.GetCustomerString.Size = New System.Drawing.Size(114, 21)
        Me.GetCustomerString.TabIndex = 3
        Me.GetCustomerString.Text = "Get Customer String"
        Me.GetCustomerString.UseVisualStyleBackColor = True
        '
        'DeleteAllCustomers
        '
        Me.DeleteAllCustomers.Location = New System.Drawing.Point(96, 3)
        Me.DeleteAllCustomers.Name = "DeleteAllCustomers"
        Me.DeleteAllCustomers.Size = New System.Drawing.Size(118, 21)
        Me.DeleteAllCustomers.TabIndex = 2
        Me.DeleteAllCustomers.Text = "Delete All Customers"
        Me.DeleteAllCustomers.UseVisualStyleBackColor = True
        '
        'AddCustomer
        '
        Me.AddCustomer.Location = New System.Drawing.Point(3, 3)
        Me.AddCustomer.Name = "AddCustomer"
        Me.AddCustomer.Size = New System.Drawing.Size(87, 21)
        Me.AddCustomer.TabIndex = 1
        Me.AddCustomer.Text = "Add Customer"
        Me.AddCustomer.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.AddCustomer)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteAllCustomers)
        Me.FlowLayoutPanel1.Controls.Add(Me.GetCustomerString)
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdateStatus)
        Me.FlowLayoutPanel1.Controls.Add(Me.UpdateCustomerSalesYTD)
        Me.FlowLayoutPanel1.Controls.Add(Me.DeleteCustomer)
        Me.FlowLayoutPanel1.Controls.Add(Me.GetAllCustomers)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 28)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(365, 86)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'DeleteCustomer
        '
        Me.DeleteCustomer.Location = New System.Drawing.Point(261, 30)
        Me.DeleteCustomer.Name = "DeleteCustomer"
        Me.DeleteCustomer.Size = New System.Drawing.Size(93, 21)
        Me.DeleteCustomer.TabIndex = 7
        Me.DeleteCustomer.Text = "Delete Customer"
        Me.DeleteCustomer.UseVisualStyleBackColor = True
        '
        'GetAllCustomers
        '
        Me.GetAllCustomers.Location = New System.Drawing.Point(3, 58)
        Me.GetAllCustomers.Name = "GetAllCustomers"
        Me.GetAllCustomers.Size = New System.Drawing.Size(168, 21)
        Me.GetAllCustomers.TabIndex = 6
        Me.GetAllCustomers.Text = "Get All Customers"
        Me.GetAllCustomers.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(526, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product Operations"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.AddProduct)
        Me.FlowLayoutPanel2.Controls.Add(Me.DeleteAllProducts)
        Me.FlowLayoutPanel2.Controls.Add(Me.GetProductString)
        Me.FlowLayoutPanel2.Controls.Add(Me.UpdateProductSalesYTD)
        Me.FlowLayoutPanel2.Controls.Add(Me.GetAllProducts)
        Me.FlowLayoutPanel2.Controls.Add(Me.DeleteProduct)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(404, 28)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(362, 86)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'AddProduct
        '
        Me.AddProduct.Location = New System.Drawing.Point(3, 3)
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Size = New System.Drawing.Size(87, 21)
        Me.AddProduct.TabIndex = 6
        Me.AddProduct.Text = "Add Product"
        Me.AddProduct.UseVisualStyleBackColor = True
        '
        'DeleteAllProducts
        '
        Me.DeleteAllProducts.Location = New System.Drawing.Point(96, 3)
        Me.DeleteAllProducts.Name = "DeleteAllProducts"
        Me.DeleteAllProducts.Size = New System.Drawing.Size(118, 21)
        Me.DeleteAllProducts.TabIndex = 6
        Me.DeleteAllProducts.Text = "Delete All Products" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DeleteAllProducts.UseVisualStyleBackColor = True
        '
        'GetProductString
        '
        Me.GetProductString.Location = New System.Drawing.Point(220, 3)
        Me.GetProductString.Name = "GetProductString"
        Me.GetProductString.Size = New System.Drawing.Size(114, 21)
        Me.GetProductString.TabIndex = 6
        Me.GetProductString.Text = "Get Product String"
        Me.GetProductString.UseVisualStyleBackColor = True
        '
        'UpdateProductSalesYTD
        '
        Me.UpdateProductSalesYTD.Location = New System.Drawing.Point(3, 30)
        Me.UpdateProductSalesYTD.Name = "UpdateProductSalesYTD"
        Me.UpdateProductSalesYTD.Size = New System.Drawing.Size(157, 21)
        Me.UpdateProductSalesYTD.TabIndex = 6
        Me.UpdateProductSalesYTD.Text = "Update Product SalesYTD"
        Me.UpdateProductSalesYTD.UseVisualStyleBackColor = True
        '
        'GetAllProducts
        '
        Me.GetAllProducts.Location = New System.Drawing.Point(166, 30)
        Me.GetAllProducts.Name = "GetAllProducts"
        Me.GetAllProducts.Size = New System.Drawing.Size(157, 21)
        Me.GetAllProducts.TabIndex = 7
        Me.GetAllProducts.Text = "Get All Products"
        Me.GetAllProducts.UseVisualStyleBackColor = True
        '
        'DeleteProduct
        '
        Me.DeleteProduct.Location = New System.Drawing.Point(3, 57)
        Me.DeleteProduct.Name = "DeleteProduct"
        Me.DeleteProduct.Size = New System.Drawing.Size(118, 21)
        Me.DeleteProduct.TabIndex = 8
        Me.DeleteProduct.Text = "Delete Product"
        Me.DeleteProduct.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddLocation)
        Me.Panel1.Controls.Add(Me.DeleteAllSales)
        Me.Panel1.Controls.Add(Me.DeleteSale)
        Me.Panel1.Controls.Add(Me.CountProductSales)
        Me.Panel1.Controls.Add(Me.GetAllSales)
        Me.Panel1.Controls.Add(Me.AddComplexSale)
        Me.Panel1.Controls.Add(Me.SumCustSalesYTD)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AddSimpleSale)
        Me.Panel1.Location = New System.Drawing.Point(12, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 54)
        Me.Panel1.TabIndex = 7
        '
        'DeleteAllSales
        '
        Me.DeleteAllSales.Location = New System.Drawing.Point(160, 28)
        Me.DeleteAllSales.Name = "DeleteAllSales"
        Me.DeleteAllSales.Size = New System.Drawing.Size(127, 21)
        Me.DeleteAllSales.TabIndex = 14
        Me.DeleteAllSales.Text = "Delete All Sales"
        Me.DeleteAllSales.UseVisualStyleBackColor = True
        '
        'DeleteSale
        '
        Me.DeleteSale.Location = New System.Drawing.Point(627, 7)
        Me.DeleteSale.Name = "DeleteSale"
        Me.DeleteSale.Size = New System.Drawing.Size(127, 21)
        Me.DeleteSale.TabIndex = 13
        Me.DeleteSale.Text = "Delete Sale"
        Me.DeleteSale.UseVisualStyleBackColor = True
        '
        'CountProductSales
        '
        Me.CountProductSales.Location = New System.Drawing.Point(16, 28)
        Me.CountProductSales.Name = "CountProductSales"
        Me.CountProductSales.Size = New System.Drawing.Size(127, 21)
        Me.CountProductSales.TabIndex = 12
        Me.CountProductSales.Text = "Count Product Sales"
        Me.CountProductSales.UseVisualStyleBackColor = True
        '
        'GetAllSales
        '
        Me.GetAllSales.Location = New System.Drawing.Point(517, 7)
        Me.GetAllSales.Name = "GetAllSales"
        Me.GetAllSales.Size = New System.Drawing.Size(104, 21)
        Me.GetAllSales.TabIndex = 11
        Me.GetAllSales.Text = "Get All Sales"
        Me.GetAllSales.UseVisualStyleBackColor = True
        '
        'AddComplexSale
        '
        Me.AddComplexSale.Location = New System.Drawing.Point(392, 7)
        Me.AddComplexSale.Name = "AddComplexSale"
        Me.AddComplexSale.Size = New System.Drawing.Size(104, 21)
        Me.AddComplexSale.TabIndex = 10
        Me.AddComplexSale.Text = "Add Complex Sale"
        Me.AddComplexSale.UseVisualStyleBackColor = True
        '
        'SumCustSalesYTD
        '
        Me.SumCustSalesYTD.Location = New System.Drawing.Point(251, 7)
        Me.SumCustSalesYTD.Name = "SumCustSalesYTD"
        Me.SumCustSalesYTD.Size = New System.Drawing.Size(121, 21)
        Me.SumCustSalesYTD.TabIndex = 9
        Me.SumCustSalesYTD.Text = "Sum Cust Sales YTD"
        Me.SumCustSalesYTD.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sale Operations"
        '
        'AddSimpleSale
        '
        Me.AddSimpleSale.Location = New System.Drawing.Point(137, 7)
        Me.AddSimpleSale.Name = "AddSimpleSale"
        Me.AddSimpleSale.Size = New System.Drawing.Size(94, 21)
        Me.AddSimpleSale.TabIndex = 6
        Me.AddSimpleSale.Text = "Add Simple Sale"
        Me.AddSimpleSale.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Result"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxSellingPrice)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TextBoxNumberofDay)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TextBoxMinQty)
        Me.Panel2.Controls.Add(Me.TextBoxMaxQty)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TextBoxLocationCode)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBoxDate)
        Me.Panel2.Controls.Add(Me.TextBoxQuantity)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TextBoxProdSaleAmount)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBoxProdName)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBoxProdID)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextBoxCustSaleAmount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBoxCustStatus)
        Me.Panel2.Controls.Add(Me.TextBoxCustName)
        Me.Panel2.Controls.Add(Me.CustName)
        Me.Panel2.Controls.Add(Me.TextBoxCustID)
        Me.Panel2.Controls.Add(Me.CustomerID)
        Me.Panel2.Location = New System.Drawing.Point(12, 175)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(754, 141)
        Me.Panel2.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(537, 7)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Date"
        '
        'TextBoxDate
        '
        Me.TextBoxDate.Location = New System.Drawing.Point(571, 5)
        Me.TextBoxDate.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDate.TabIndex = 19
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Location = New System.Drawing.Point(322, 77)
        Me.TextBoxQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxQuantity.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(266, 82)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Quantity"
        '
        'TextBoxProdSaleAmount
        '
        Me.TextBoxProdSaleAmount.Location = New System.Drawing.Point(354, 50)
        Me.TextBoxProdSaleAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxProdSaleAmount.Name = "TextBoxProdSaleAmount"
        Me.TextBoxProdSaleAmount.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxProdSaleAmount.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(266, 56)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ProdSale Amount"
        '
        'TextBoxProdName
        '
        Me.TextBoxProdName.Location = New System.Drawing.Point(322, 28)
        Me.TextBoxProdName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxProdName.Name = "TextBoxProdName"
        Me.TextBoxProdName.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxProdName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(266, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ProdName"
        '
        'TextBoxProdID
        '
        Me.TextBoxProdID.Location = New System.Drawing.Point(322, 5)
        Me.TextBoxProdID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxProdID.Name = "TextBoxProdID"
        Me.TextBoxProdID.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxProdID.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Product ID"
        '
        'TextBoxCustSaleAmount
        '
        Me.TextBoxCustSaleAmount.Location = New System.Drawing.Point(88, 77)
        Me.TextBoxCustSaleAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCustSaleAmount.Name = "TextBoxCustSaleAmount"
        Me.TextBoxCustSaleAmount.Size = New System.Drawing.Size(126, 20)
        Me.TextBoxCustSaleAmount.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Updated Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CustSale Amount"
        '
        'TextBoxCustStatus
        '
        Me.TextBoxCustStatus.Location = New System.Drawing.Point(87, 54)
        Me.TextBoxCustStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCustStatus.Name = "TextBoxCustStatus"
        Me.TextBoxCustStatus.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxCustStatus.TabIndex = 4
        '
        'TextBoxCustName
        '
        Me.TextBoxCustName.Location = New System.Drawing.Point(70, 29)
        Me.TextBoxCustName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCustName.Name = "TextBoxCustName"
        Me.TextBoxCustName.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCustName.TabIndex = 3
        '
        'CustName
        '
        Me.CustName.AutoSize = True
        Me.CustName.Location = New System.Drawing.Point(2, 34)
        Me.CustName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CustName.Name = "CustName"
        Me.CustName.Size = New System.Drawing.Size(56, 13)
        Me.CustName.TabIndex = 2
        Me.CustName.Text = "CustName"
        '
        'TextBoxCustID
        '
        Me.TextBoxCustID.Location = New System.Drawing.Point(70, 5)
        Me.TextBoxCustID.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCustID.Name = "TextBoxCustID"
        Me.TextBoxCustID.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCustID.TabIndex = 1
        '
        'CustomerID
        '
        Me.CustomerID.AutoSize = True
        Me.CustomerID.Location = New System.Drawing.Point(2, 7)
        Me.CustomerID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(62, 13)
        Me.CustomerID.TabIndex = 0
        Me.CustomerID.Text = "CustomerID"
        '
        'TextBoxResult
        '
        Me.TextBoxResult.Location = New System.Drawing.Point(11, 345)
        Me.TextBoxResult.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxResult.Multiline = True
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(755, 123)
        Me.TextBoxResult.TabIndex = 9
        '
        'ClearDisplay
        '
        Me.ClearDisplay.Location = New System.Drawing.Point(662, 320)
        Me.ClearDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearDisplay.Name = "ClearDisplay"
        Me.ClearDisplay.Size = New System.Drawing.Size(104, 21)
        Me.ClearDisplay.TabIndex = 11
        Me.ClearDisplay.Text = "Clear Display"
        Me.ClearDisplay.UseVisualStyleBackColor = True
        '
        'AddLocation
        '
        Me.AddLocation.Location = New System.Drawing.Point(303, 28)
        Me.AddLocation.Name = "AddLocation"
        Me.AddLocation.Size = New System.Drawing.Size(127, 21)
        Me.AddLocation.TabIndex = 15
        Me.AddLocation.Text = "Add Location"
        Me.AddLocation.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(491, 32)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Location Code"
        '
        'TextBoxLocationCode
        '
        Me.TextBoxLocationCode.Location = New System.Drawing.Point(571, 28)
        Me.TextBoxLocationCode.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxLocationCode.Name = "TextBoxLocationCode"
        Me.TextBoxLocationCode.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxLocationCode.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(524, 56)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Min Qty"
        '
        'TextBoxMaxQty
        '
        Me.TextBoxMaxQty.Location = New System.Drawing.Point(571, 78)
        Me.TextBoxMaxQty.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMaxQty.Name = "TextBoxMaxQty"
        Me.TextBoxMaxQty.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxMaxQty.TabIndex = 24
        '
        'TextBoxMinQty
        '
        Me.TextBoxMinQty.Location = New System.Drawing.Point(571, 54)
        Me.TextBoxMinQty.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMinQty.Name = "TextBoxMinQty"
        Me.TextBoxMinQty.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxMinQty.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(524, 80)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Max Qty"
        '
        'TextBoxNumberofDay
        '
        Me.TextBoxNumberofDay.Location = New System.Drawing.Point(571, 102)
        Me.TextBoxNumberofDay.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNumberofDay.Name = "TextBoxNumberofDay"
        Me.TextBoxNumberofDay.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxNumberofDay.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(491, 105)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Number of Day"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(253, 105)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Selling Price"
        '
        'TextBoxSellingPrice
        '
        Me.TextBoxSellingPrice.Location = New System.Drawing.Point(322, 102)
        Me.TextBoxSellingPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSellingPrice.Name = "TextBoxSellingPrice"
        Me.TextBoxSellingPrice.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxSellingPrice.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 479)
        Me.Controls.Add(Me.ClearDisplay)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Customer and Product Form"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UpdateStatus As Button
    Friend WithEvents UpdateCustomerSalesYTD As Button
    Friend WithEvents GetCustomerString As Button
    Friend WithEvents DeleteAllCustomers As Button
    Friend WithEvents AddCustomer As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents AddProduct As Button
    Friend WithEvents DeleteAllProducts As Button
    Friend WithEvents GetProductString As Button
    Friend WithEvents UpdateProductSalesYTD As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents AddSimpleSale As Button
    Friend WithEvents SumCustSalesYTD As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxCustID As TextBox
    Friend WithEvents CustomerID As Label
    Friend WithEvents CustName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCustName As TextBox
    Friend WithEvents TextBoxCustStatus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxProdID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCustSaleAmount As TextBox
    Friend WithEvents TextBoxProdName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxProdSaleAmount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ClearDisplay As Button
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GetAllCustomers As Button
    Friend WithEvents GetAllProducts As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxDate As TextBox
    Friend WithEvents CountProductSales As Button
    Friend WithEvents GetAllSales As Button
    Friend WithEvents AddComplexSale As Button
    Friend WithEvents DeleteCustomer As Button
    Friend WithEvents DeleteProduct As Button
    Friend WithEvents DeleteAllSales As Button
    Friend WithEvents DeleteSale As Button
    Friend WithEvents AddLocation As Button
    Friend WithEvents TextBoxLocationCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxMinQty As TextBox
    Friend WithEvents TextBoxMaxQty As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxNumberofDay As TextBox
    Friend WithEvents TextBoxSellingPrice As TextBox
    Friend WithEvents Label16 As Label
End Class

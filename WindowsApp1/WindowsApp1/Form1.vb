Imports System.Data.OracleClient
Imports System.Globalization
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Public Class Form1

    ' Oracle Connection
    Private connection As System.Data.OracleClient.OracleConnection  ' create a connection object to connect to the Oracle database

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = CreateConnection()  ' create a connection to the Oracle database
    End Sub

    Function CreateConnection() As System.Data.OracleClient.OracleConnection
        Dim rvConn As New System.Data.OracleClient.OracleConnection  ' create a new connection object
        rvConn.ConnectionString = GetConnectionString()  ' set the connection string to the Oracle database
        Return rvConn
    End Function

    Function GetConnectionString() As String
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=*)(PORT=*))"   ' for security reason, I hide the host and port number of the Oracle database. can put the host and port number here (replace * with the host and port number)
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms))); "
        vConnStr = vConnStr & "User Id=*;" ' for security reason, I hide the username of the Oracle database can put the username here (replace * with the username)
        vConnStr = vConnStr & "Password="
        vConnStr = vConnStr & InputBox("Enter your password")
        vConnStr = vConnStr & ";"
        Return vConnStr
    End Function


    ' Execute Stored Procedure
    Private Function ExecuteStoredProcedure(procedureName As Object, Optional parameters() As OracleClient.OracleParameter = Nothing) As Object
        Dim transaction As OracleClient.OracleTransaction = Nothing  ' create a transaction object to manage the transaction
        Try
            connection.Open()  ' open the connection to the Oracle database
            transaction = connection.BeginTransaction()
            Using cmd As New OracleClient.OracleCommand(procedureName, connection)
                cmd.CommandType = CommandType.StoredProcedure  ' specify that we are executing a stored procedure
                cmd.Transaction = transaction ' assign the transaction to the command
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)  ' pass the parameters to the stored procedure if have
                End If
                cmd.ExecuteNonQuery()  ' execute the stored procedure
            End Using
            transaction.Commit()  ' commit the transaction
            TextBoxResult.AppendText($"{procedureName} executed successfully" & vbNewLine)
            Return True
        Catch ex As OracleClient.OracleException  ' catch any Oracle database exceptions
            transaction?.Rollback()
            TextBoxResult.AppendText($"{ex.Message} " & vbNewLine)  ' return the error message from oracle database
            Return False
        Catch ex As Exception  ' catch any other exceptions
            transaction?.Rollback()
            TextBoxResult.AppendText($"Error: {ex.Message} " & vbNewLine)  ' return the error message from the application
            Return False
        Finally
            connection.Close()
        End Try

    End Function


    ' Execute Stored Function return String
    Private Function ExecuteStoredFunction(functionName As Object, Optional parameters() As OracleClient.OracleParameter = Nothing) As Object  ' optional parameters, default to nothing if no parameters are passed
        Dim transaction As OracleClient.OracleTransaction = Nothing  ' create a transaction object to manage the transaction
        Try
            connection.Open()  ' open the connection to the Oracle database
            transaction = connection.BeginTransaction()  ' begin a transaction
            Using cmd As New OracleClient.OracleCommand(functionName, connection)
                cmd.CommandType = CommandType.StoredProcedure  ' specify that we are executing a stored function 
                cmd.Transaction = transaction ' assign the transaction to the command
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)  ' pass the parameters to the stored function if there are any parameters. if not, skip passing parameters
                End If
                Dim returnParameter As New OracleClient.OracleParameter("ReturnValue", OracleType.VarChar, 32767)  ' create a return parameter which datatype is VarChar to capture the result of the stored function
                returnParameter.Direction = ParameterDirection.ReturnValue
                cmd.Parameters.Add(returnParameter)
                cmd.ExecuteNonQuery()  ' execute the stored function
                transaction.Commit()  ' commit the transaction
                TextBoxResult.AppendText($"{functionName} executed successfully" & vbNewLine)
                Return (returnParameter.Value.ToString())  ' return the result of the stored function
            End Using
        Catch ex As OracleClient.OracleException
            transaction?.Rollback()
            TextBoxResult.AppendText($"{ex.Message} " & vbNewLine)  ' return the error message from oracle database
            Return Nothing
        Catch ex As Exception
            transaction?.Rollback()
            TextBoxResult.AppendText($"Error: {ex.Message} " & vbNewLine)  ' return the error message from the application
            Return Nothing
        Finally
            connection.Close()
        End Try
    End Function


    ' Execute Stored Function return Number
    Private Function ExecuteStoredFunctionreturnNumber(functionName As Object, Optional parameters() As OracleClient.OracleParameter = Nothing) As Object  ' optional parameters, default to nothing if no parameters are passed
        Dim transaction As OracleClient.OracleTransaction = Nothing  ' create a transaction object to manage the transaction
        Try
            connection.Open()  ' open the connection to the Oracle database
            transaction = connection.BeginTransaction()  ' begin a transaction
            Using cmd As New OracleClient.OracleCommand(functionName, connection)
                cmd.CommandType = CommandType.StoredProcedure  ' specify that we are executing a stored function (rather than text-base SQL)
                cmd.Transaction = transaction ' assign the transaction to the command
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)  ' pass the parameters to the stored function
                End If
                Dim returnParameter As New OracleClient.OracleParameter("ReturnValue", OracleType.Number)  ' create a return parameter with datatype is Number to capture the result of the stored function
                returnParameter.Direction = ParameterDirection.ReturnValue  ' specify that the return parameter is an output parameter
                cmd.Parameters.Add(returnParameter) ' add the return parameter to the command
                cmd.ExecuteScalar() ' execute the stored function
                transaction.Commit() ' commit the transaction
                TextBoxResult.AppendText($"{functionName} executed successfully" & vbNewLine)
                Return (returnParameter.Value)  ' return the result of the stored function
            End Using
        Catch ex As OracleClient.OracleException  ' catch any Oracle database exceptions
            transaction?.Rollback()
            TextBoxResult.AppendText($"{ex.Message} " & vbNewLine)  ' return the error message from oracle database
            Return Nothing
        Catch ex As Exception  ' catch any other exceptions
            transaction?.Rollback()
            TextBoxResult.AppendText($"Error: {ex.Message} " & vbNewLine)  ' return the error message from the application
            Return Nothing
        Finally
            connection.Close()
        End Try
    End Function

    ' Execute Package Return SysRefcur
    Private Sub ExcutePackageReturnSysRefcur(functionname As Object, Optional parameters() As OracleClient.OracleParameter = Nothing) ' optional parameters, default to nothing if no parameters are passed
        Try
            connection.Open()  ' open the connection to the Oracle database
            Using cmd As New OracleClient.OracleCommand(functionname, connection)  ' create a command object to execute the stored function
                cmd.CommandType = CommandType.StoredProcedure  ' specify that we are executing a stored function 
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)  ' pass the parameters to the stored function
                End If
                Dim returnParameter As New OracleClient.OracleParameter("ReturnValue", OracleType.Cursor)  ' create a return parameter with datatype is Cursor to capture the result of the stored function ( sys_refcursor)
                returnParameter.Direction = ParameterDirection.ReturnValue  ' specify that the return parameter is an output parameter
                cmd.Parameters.Add(returnParameter)
                cmd.ExecuteNonQuery()  ' execute the stored function
                Dim reader As OracleClient.OracleDataReader = CType(returnParameter.Value, OracleClient.OracleDataReader)  ' create a data reader to read the result of the stored function. convert the return parameter value to a data reader type
                TextBoxResult.Clear()
                If functionname = "cust_pkg.get_allcust" Then  ' check if the stored function is get_allcust
                    TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & "Listing All Customer Details" & vbNewLine)
                    While reader.Read()
                        TextBoxResult.AppendText($"ID: {reader("custid")}, Name: {reader("custname")}, Status: {reader("status")}, Sales YTD: {reader("sales_ytd")}" & vbNewLine)
                    End While
                ElseIf functionname = "prod_pkg.get_allprod_from_db" Then  ' check if the stored function is get_allprod_from_db
                    TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & "Listing All Product Details" & vbNewLine)
                    While reader.Read()
                        TextBoxResult.AppendText($"ID: {reader("prodid")}, Name: {reader("prodname")}, Selling Price:{reader("selling_price")} Sales YTD: {reader("sales_ytd")}" & vbNewLine)
                    End While
                ElseIf functionname = "sales_pkg.get_allsales_from_db" Then  ' check if the stored function is get_allsales_from_db
                    TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & "Listing All Complex Sales Details" & vbNewLine)
                    While reader.Read()
                        TextBoxResult.AppendText($"Saleid: {reader("saleid")} CustID: {reader("custid")} ProdID: {reader("prodid")} Date: {reader("saledate")} Amount: {reader("qty") * reader("price")}" & vbNewLine)
                    End While

                End If
                If reader.HasRows = False Then  ' check if the reader has any rows
                    TextBoxResult.AppendText("No rows found" & vbNewLine)
                End If
                TextBoxResult.AppendText($"{functionname} executed successfully" & vbNewLine)
            End Using
        Catch ex As OracleClient.OracleException
            TextBoxResult.AppendText($"{ex.Message} " & vbNewLine)  ' return the error message from oracle database
        Catch ex As Exception
            TextBoxResult.AppendText($"Error: {ex.Message} " & vbNewLine)  ' return the error message from the application
        Finally
            connection.Close()
        End Try
    End Sub

    ' Customer Operations
    Private Sub AddCustomer_Click(sender As Object, e As EventArgs) Handles AddCustomer.Click

        '' use CommandText to execute a stored procedure but if do like this , the code will repeat many times so we use ExecuteStoredProcedure function to reduce the code
        'Try
        '    If String.IsNullOrEmpty(TextBoxCustID.Text) OrElse String.IsNullOrEmpty(TextBoxCustName.Text) Then
        '        TextBoxResult.AppendText("Please enter a customer ID and name for Add Customer" & vbNewLine)
        '    Else
        '        TextBoxResult.AppendText($"--------------------------------------------" & vbNewLine & $"Adding Customer. ID: {TextBoxCustID.Text} Name: {TextBoxCustName.Text}" & vbNewLine)
        '        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        '        rvCmd.Connection = connection
        '        rvCmd.CommandText = $"Begin ADD_CUST_TO_DB({Integer.Parse(TextBoxCustID.Text)}, '{TextBoxCustName.Text}'); end;"
        '        connection.Open()
        '        rvCmd.ExecuteNonQuery()
        '        connection.Close()
        '        TextBoxResult.AppendText("Customer added successfully" & vbNewLine)
        '    End If
        'Catch ex As OracleClient.OracleException
        '    TextBoxResult.AppendText($"{ex.Message} " & vbNewLine)
        'Catch ex As Exception
        '    TextBoxResult.AppendText($"Error: {ex.Message} " & vbNewLine)
        'Finally
        '    connection.Close()
        'End Try

        If String.IsNullOrEmpty(TextBoxCustID.Text) OrElse String.IsNullOrEmpty(TextBoxCustName.Text) Then
            TextBoxResult.AppendText("Please enter a customer ID (range: 1-499) and name for Add Customer" & vbNewLine)  ' if any of the textboxes are empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText($"--------------------------------------------" & vbNewLine & $"Adding Customer. ID: {TextBoxCustID.Text} Name: {TextBoxCustName.Text}" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pcustid", OracleType.Number) With {.Value = Integer.Parse(TextBoxCustID.Text)})  ' create a parameter for the customer ID and set the value to the text in the TextBoxCustID
            parameters.Add(New OracleClient.OracleParameter("pcustname", OracleType.VarChar) With {.Value = TextBoxCustName.Text})   ' create a parameter for the customer name and set the value to the text in the TextBoxCustName
            If ExecuteStoredProcedure("ADD_CUST_TO_DB", parameters.ToArray()) Then
                TextBoxResult.AppendText("Customer added successfully" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub

    Private Sub DeleteAllCustomers_Click(sender As Object, e As EventArgs) Handles DeleteAllCustomers.Click
        TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & "Deleting all customers" & vbNewLine)  ' display a message to show the operation is in progress
        Dim rowsDeleted As Object = ExecuteStoredFunction("DELETE_ALL_CUSTOMERS_FROM_DB")  ' execute the stored function to delete all customers and assign the result to rowsDeleted
        If rowsDeleted IsNot Nothing Then
            TextBoxResult.AppendText($"{rowsDeleted} rows deleted" & vbNewLine)  ' display the number of rows deletedS
        End If
    End Sub

    Private Sub GetCustomerString_Click(sender As Object, e As EventArgs) Handles GetCustomerString.Click

        '' use CommandText to execute a stored procedure but if do like this , the code will repeat many times so we use ExecuteStoredFunction function to reduce the code
        'Try
        '    If String.IsNullOrEmpty(TextBoxCustID.Text) Then
        '        TextBoxResult.AppendText("Please enter a customer ID for Get Customer" & vbNewLine)
        '    Else
        '        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        '        rvCmd.Connection = connection
        '        rvCmd.CommandText = $"Begin :result := GET_CUST_STRING_FROM_DB({Integer.Parse(TextBoxCustID.Text)}); end;"
        '        rvCmd.Parameters.Add(New OracleClient.OracleParameter("result", OracleType.VarChar, 32726)).Direction = ParameterDirection.ReturnValue
        '        connection.Open()
        '        rvCmd.ExecuteNonQuery()
        '        Dim result As String = rvCmd.Parameters("result").Value.ToString()
        '        connection.Close()
        '        TextBoxResult.AppendText(result & vbNewLine)
        '    End If
        'Catch ex As OracleClient.OracleException
        '    TextBoxResult.AppendText($"{ex.Message} " & vbNewLine)
        'Catch ex As Exception
        '    TextBoxResult.AppendText($"Error: {ex.Message} " & vbNewLine)
        'Finally
        '    connection.Close()
        'End Try

        If String.IsNullOrEmpty(TextBoxCustID.Text) Then
            TextBoxResult.AppendText("Please enter a customer ID for Get Customer" & vbNewLine)     ' if the TextBoxCustID is empty, display a message to give the instructions to user     
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Getting Details for CustID {TextBoxCustID.Text}" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pcustid", OracleType.Number) With {.Value = Integer.Parse(TextBoxCustID.Text)})  ' create a parameter for the customer ID and set the value to the text in the TextBoxCustID
            Dim customerDetails As Object = ExecuteStoredFunction("GET_CUST_STRING_FROM_DB", parameters.ToArray())  ' execute the stored function to get the customer details and assign the result to customerDetails
            If customerDetails IsNot Nothing Then
                TextBoxResult.AppendText(customerDetails.ToString() & vbNewLine)  ' display the customer details
            End If
            '' try to use ExecuteReader to get the result but the result is still not the whole string
            'Dim rvCmd As New OracleClient.OracleCommand()
            'rvCmd.Connection = connection
            'rvCmd.CommandText = $"Begin :result := GET_CUST_STRING_FROM_DB({Integer.Parse(TextBoxCustID.Text)}); end;"
            'rvCmd.Parameters.Add(New OracleClient.OracleParameter("result", OracleType.VarChar, 32726)).Direction = ParameterDirection.ReturnValue
            'connection.Open()
            'rvCmd.ExecuteReader()
            'Dim result As String = rvCmd.Parameters("result").Value.ToString()
            'connection.Close()
            'TextBoxResult.AppendText(result & vbNewLine)
        End If
    End Sub

    Private Sub UpdateStatus_Click(sender As Object, e As EventArgs) Handles UpdateStatus.Click
        If String.IsNullOrEmpty(TextBoxCustID.Text) OrElse String.IsNullOrEmpty(TextBoxCustStatus.Text) Then
            TextBoxResult.AppendText("Please enter a customer ID and status for Update Status" & vbNewLine)     ' if any of the textboxes are empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Updating Status. ID: {TextBoxCustID.Text} New Status: {TextBoxCustStatus.Text}" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pcustid", OracleType.Number) With {.Value = Integer.Parse(TextBoxCustID.Text)})  ' create a parameter for the customer ID and set the value to the text in the TextBoxCustID
            parameters.Add(New OracleClient.OracleParameter("pstatus", OracleType.VarChar) With {.Value = TextBoxCustStatus.Text})  ' create a parameter for the status and set the value to the text in the TextBoxCustStatus
            If ExecuteStoredProcedure("UPD_CUST_STATUS_IN_DB", parameters.ToArray()) Then
                TextBoxResult.AppendText("Update OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub

    Private Sub UpdateCustomerSalesYTD_Click(sender As Object, e As EventArgs) Handles UpdateCustomerSalesYTD.Click
        If String.IsNullOrEmpty(TextBoxCustID.Text) OrElse String.IsNullOrEmpty(TextBoxCustSaleAmount.Text) Then
            TextBoxResult.AppendText("Please enter a customer ID and sale amount (range: -999.99-999.999) for Update Sales YTD" & vbNewLine)  ' if any of the textboxes are empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Updating Sales YTD. Customer ID: {TextBoxCustID.Text} Amount: {TextBoxCustSaleAmount.Text}" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pcustid", OracleType.Number) With {.Value = Integer.Parse(TextBoxCustID.Text)})  ' create a parameter for the customer ID and set the value to the text in the TextBoxCustID
            parameters.Add(New OracleClient.OracleParameter("pamt", OracleType.VarChar) With {.Value = TextBoxCustSaleAmount.Text})  ' create a parameter for the sale amount and set the value to the text in the TextBoxCustSaleAmount
            If ExecuteStoredProcedure("UPD_CUST_SALESYTD_IN_DB", parameters.ToArray()) Then
                TextBoxResult.AppendText("Update OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub

    ' Product Operations
    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        If String.IsNullOrEmpty(TextBoxProdID.Text) OrElse String.IsNullOrEmpty(TextBoxProdName.Text) OrElse String.IsNullOrEmpty(TextBoxSellingPrice.Text) Then
            TextBoxResult.AppendText("Please enter a product ID (range: 1000-2500), product Name and Selling price (range: 0-999.99) for Add Product" & vbNewLine)  ' if any of the textboxes are empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Adding Product. ID: {TextBoxProdID.Text} Name: {TextBoxProdName.Text}" & vbNewLine)
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pprodid", OracleType.Number) With {.Value = Integer.Parse(TextBoxProdID.Text)})  ' create a parameter for the product ID and set the value to the text in the TextBoxProdID
            parameters.Add(New OracleClient.OracleParameter("pprodname", OracleType.VarChar) With {.Value = TextBoxProdName.Text})  ' create a parameter for the product name and set the value to the text in the TextBoxProdName
            parameters.Add(New OracleClient.OracleParameter("pprice", OracleType.Number) With {.Value = Integer.Parse(TextBoxSellingPrice.Text)})  ' create a parameter for the selling price and set the value to the text in the TextBoxSellingPrice
            If ExecuteStoredProcedure("ADD_PRODUCT_TO_DB", parameters.ToArray()) Then
                TextBoxResult.AppendText("Product added OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub

    Private Sub DeleteAllProducts_Click(sender As Object, e As EventArgs) Handles DeleteAllProducts.Click
        TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & "Deleting all products" & vbNewLine)  ' display a message to show the operation is in progress
        Dim rowsDeleted As Object = ExecuteStoredFunction("DELETE_ALL_PRODUCTS_FROM_DB")  ' execute the stored function to delete all products and assign the result to rowsDeleted
        If rowsDeleted IsNot Nothing Then
            TextBoxResult.AppendText($"{rowsDeleted} rows deleted" & vbNewLine)  ' display the number of rows deleted
        End If
    End Sub

    Private Sub GetProductString_Click(sender As Object, e As EventArgs) Handles GetProductString.Click
        If String.IsNullOrEmpty(TextBoxProdID.Text) Then
            TextBoxResult.AppendText("Please enter a product ID for Get Product" & vbNewLine)   ' if the TextBoxProdID is empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Getting Details for Product ID {TextBoxProdID.Text}" & vbNewLine)   ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pprodid", OracleType.Number) With {.Value = Integer.Parse(TextBoxProdID.Text)})    ' create a parameter for the product ID and set the value to the text in the TextBoxProdID
            Dim productDetails As Object = ExecuteStoredFunction("GET_PROD_STRING_FROM_DB", parameters.ToArray())   ' execute the stored function to get the product details and assign the result to productDetails
            If productDetails IsNot Nothing Then
                TextBoxResult.AppendText(productDetails.ToString() & vbNewLine)  ' display the product details
            End If
        End If
    End Sub

    Private Sub UpdateProductSalesYTD_Click(sender As Object, e As EventArgs) Handles UpdateProductSalesYTD.Click
        If String.IsNullOrEmpty(TextBoxProdID.Text) OrElse String.IsNullOrEmpty(TextBoxProdSaleAmount.Text) Then
            TextBoxResult.AppendText("Please enter a product ID and sale amount (range: -999.99-999.999) for Update Product Sales YTD" & vbNewLine)  ' if any of the textboxes are empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Updating Product Sales YTD. Product ID: {TextBoxProdID.Text} Amount: {TextBoxProdSaleAmount.Text}" & vbNewLine) ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pprodid", OracleType.Number) With {.Value = Integer.Parse(TextBoxProdID.Text)})    ' create a parameter for the product ID and set the value to the text in the TextBoxProdID
            parameters.Add(New OracleClient.OracleParameter("pamt", OracleType.Number) With {.Value = Integer.Parse(TextBoxProdSaleAmount.Text)})   ' create a parameter for the sale amount and set the value to the text in the TextBoxProdSaleAmount
            If ExecuteStoredProcedure("UPD_PROD_SALESYTD_IN_DB", parameters.ToArray()) Then
                TextBoxResult.AppendText("Update OK" & vbNewLine)   ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub

    ' Sale Operations
    Private Sub AddSimpleSale_Click(sender As Object, e As EventArgs) Handles AddSimpleSale.Click
        If String.IsNullOrEmpty(TextBoxCustID.Text) OrElse String.IsNullOrEmpty(TextBoxProdID.Text) OrElse String.IsNullOrEmpty(TextBoxQuantity.Text) Then
            TextBoxResult.AppendText("Please enter a customer ID, product ID and quantity (range: 1-999) for Add Simple Sale" & vbNewLine) ' if any of the textboxes are empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Adding Simple Sale. Cust ID: {TextBoxCustID.Text} Prod ID: {TextBoxProdID.Text} Qty: {TextBoxQuantity.Text}" & vbNewLine)   ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pcustid", OracleType.Number) With {.Value = Integer.Parse(TextBoxCustID.Text)})  ' create a parameter for the customer ID and set the value to the text in the TextBoxCustID
            parameters.Add(New OracleClient.OracleParameter("pprodid", OracleType.Number) With {.Value = Integer.Parse(TextBoxProdID.Text)})    ' create a parameter for the product ID and set the value to the text in the TextBoxProdID
            parameters.Add(New OracleClient.OracleParameter("pqty", OracleType.Number) With {.Value = Integer.Parse(TextBoxQuantity.Text)}) ' create a parameter for the quantity and set the value to the text in the TextBoxQuantity
            If ExecuteStoredProcedure("ADD_SIMPLE_SALE_TO_DB", parameters.ToArray()) Then
                TextBoxResult.AppendText("Add Simple Sale OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub

    Private Sub SumCustSalesYTD_Click(sender As Object, e As EventArgs) Handles SumCustSalesYTD.Click
        TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & "Summing Customer Sales YTD" & vbNewLine) ' display a message to show the operation is in progress
        Dim sum As Object = ExecuteStoredFunctionreturnNumber("SUM_CUST_SALESYTD")  ' execute the stored function to sum the customer sales YTD and assign the result to sum
        If sum IsNot Nothing Then
            TextBoxResult.AppendText($"All Customer Sales YTD: {sum}" & vbNewLine)  ' display the sum of the customer sales YTD
        Else
            TextBoxResult.AppendText("All Customer Total: 0" & vbNewLine)  ' if the sum is null, display 0
        End If
    End Sub

    Private Sub ClearDisplay_Click(sender As Object, e As EventArgs) Handles ClearDisplay.Click
        TextBoxResult.Clear()  ' clear the TextBoxResult
    End Sub

    ' get all customers
    Private Sub GetAllCustomers_Click(sender As Object, e As EventArgs) Handles GetAllCustomers.Click
        'Dim transaction As OracleClient.OracleTransaction = Nothing
        'Try
        '    connection.Open()
        '    transaction = connection.BeginTransaction()

        '    Dim cmd As New OracleClient.OracleCommand("cust_pkg.get_allcust", connection)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Transaction = transaction

        '    Dim returnParameter As New OracleClient.OracleParameter("ReturnValue", OracleType.Cursor)
        '    returnParameter.Direction = ParameterDirection.ReturnValue
        '    cmd.Parameters.Add(returnParameter)

        '    cmd.ExecuteNonQuery()

        '    Dim reader As OracleClient.OracleDataReader = CType(returnParameter.Value, OracleClient.OracleDataReader)

        '    TextBoxResult.Clear()
        '    TextBoxResult.AppendText("All Customers:" & vbNewLine)
        '    While reader.Read()
        '        TextBoxResult.AppendText($"ID: {reader("custid")}, Name: {reader("custname")}, Status: {reader("status")}, Sales YTD: {reader("sales_ytd")}" & vbNewLine)
        '    End While

        '    reader.Close()
        '    transaction.Commit()
        'Catch ex As Exception
        '    transaction?.Rollback()
        '    TextBoxResult.AppendText($"Error: {ex.Message}" & vbNewLine)
        'Finally
        '    connection.Close()
        'End Try

        ExcutePackageReturnSysRefcur("cust_pkg.get_allcust")  ' execute the stored function to get all customers
    End Sub

    ' get all products
    Private Sub GetAllProducts_Click(sender As Object, e As EventArgs) Handles GetAllProducts.Click
        ExcutePackageReturnSysRefcur("prod_pkg.get_allprod_from_db")    ' execute the stored function to get all products
    End Sub



    Private Sub AddComplexSale_Click(sender As Object, e As EventArgs) Handles AddComplexSale.Click
        Try
            If String.IsNullOrEmpty(TextBoxCustID.Text) OrElse String.IsNullOrEmpty(TextBoxProdID.Text) OrElse String.IsNullOrEmpty(TextBoxQuantity.Text) OrElse String.IsNullOrEmpty(TextBoxDate.Text) Then
                TextBoxResult.AppendText("Please enter a customer ID, product ID, quantity (range: 1-999) and date for Add Complex Sale" & vbNewLine)  ' if any of the textboxes are empty, display a message to give the instructions to user
            Else
                connection.Open()
                Dim rvCmd As New OracleClient.OracleCommand("SELECT selling_price FROM product where prodid = :prodid", connection) ' get the selling price of the product
                rvCmd.Parameters.Add("prodid", OracleType.Number).Value = Integer.Parse(TextBoxProdID.Text) ' set the product ID to the parameter
                Dim v_product_price As Integer = rvCmd.ExecuteScalar()  ' execute the command and assign the result to v_product_price
                connection.Close()

                TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Adding Complex Sale. Cust ID: {TextBoxCustID.Text} Prod ID: {TextBoxProdID.Text} Date{DateTime.ParseExact(TextBoxDate.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture)}   Amount: {Integer.Parse(TextBoxQuantity.Text) * v_product_price} " & vbNewLine)  ' display a message to show the operation is in progress
                Dim parameters As New List(Of OracleClient.OracleParameter)
                parameters.Add(New OracleClient.OracleParameter("pcustid", OracleType.Number) With {.Value = Integer.Parse(TextBoxCustID.Text)})  ' create a parameter for the customer ID and set the value to the text in the TextBoxCustID
                parameters.Add(New OracleClient.OracleParameter("pprodid", OracleType.Number) With {.Value = Integer.Parse(TextBoxProdID.Text)})    ' create a parameter for the product ID and set the value to the text in the TextBoxProdID
                parameters.Add(New OracleClient.OracleParameter("pqty", OracleType.Number) With {.Value = Integer.Parse(TextBoxQuantity.Text)})     ' create a parameter for the quantity and set the value to the text in the TextBoxQuantity
                parameters.Add(New OracleClient.OracleParameter("pdate", OracleType.VarChar) With {.Value = TextBoxDate.Text})  ' create a parameter for the date and set the value to the text in the TextBoxDate
                If ExecuteStoredProcedure("ADD_COMPLEX_SALE_TO_DB", parameters.ToArray()) Then
                    TextBoxResult.AppendText("Added Complex Sale OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
                End If
            End If
        Catch ex As Exception
            TextBoxResult.AppendText($"Error: {ex.Message}" & vbNewLine)  ' return the error message from the application
        End Try
    End Sub

    Private Sub TextBoxDate_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDate.TextChanged
        If Len(TextBoxDate.Text) = 1 Then  ' check if the length of the text in the TextBoxDate is 1
            MsgBox("please ensure the format is yyyymmdd")  ' display a message to give the instructions to user
        End If
    End Sub

    Private Sub TextBoxLocationCode_TextChanged(sender As Object, e As EventArgs) Handles TextBoxLocationCode.TextChanged
        If Len(TextBoxLocationCode.Text) = 1 Then  ' check if the length of the text in the TextBoxLocationCode is 1
            MsgBox("please ensure the format is locnn with 'nn' = number and code length = 5" & vbNewLine & "For example: loc01")  ' display a message to give the instructions to user
        End If
    End Sub
    Private Sub AddLocation_Click(sender As Object, e As EventArgs) Handles AddLocation.Click
        If String.IsNullOrEmpty(TextBoxLocationCode.Text) OrElse String.IsNullOrEmpty(TextBoxMinQty.Text) OrElse String.IsNullOrEmpty(TextBoxMaxQty.Text) Then
            TextBoxResult.AppendText("Please enter a location code (format: 'locnn' with 'nn'=number and code length = 5), min quantity and max quantity for Add Location" & vbNewLine)  ' if any of the textboxes are empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Adding Location LocCode: {TextBoxLocationCode.Text} MinQty: {TextBoxMinQty.Text} MaxQty: {TextBoxMaxQty.Text}" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("ploccode", OracleType.VarChar) With {.Value = TextBoxLocationCode.Text})  ' create a parameter for the location code and set the value to the text in the TextBoxLocationCode
            parameters.Add(New OracleClient.OracleParameter("pminqty", OracleType.Number) With {.Value = Integer.Parse(TextBoxMinQty.Text)})  ' create a parameter for the min quantity and set the value to the text in the TextBoxMinQty
            parameters.Add(New OracleClient.OracleParameter("pmaxqty", OracleType.Number) With {.Value = Integer.Parse(TextBoxMaxQty.Text)})    ' create a parameter for the max quantity and set the value to the text in the TextBoxMaxQty

            If ExecuteStoredProcedure("ADD_LOCATION_TO_DB", parameters.ToArray()) Then
                TextBoxResult.AppendText("Location added OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If

        End If
    End Sub

    Private Sub GetAllSales_Click(sender As Object, e As EventArgs) Handles GetAllSales.Click
        ExcutePackageReturnSysRefcur("sales_pkg.get_allsales_from_db")  ' execute the stored function to get all sales
    End Sub

    Private Sub CountProductSales_Click(sender As Object, e As EventArgs) Handles CountProductSales.Click
        If String.IsNullOrEmpty(TextBoxNumberofDay.Text) Then
            TextBoxResult.AppendText("Please enter the number of days for Count Product Sales")  ' if the TextBoxNumberofDay is empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Counting Product Sales within {TextBoxNumberofDay.Text} days" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pdays", OracleType.Number) With {.Value = Integer.Parse(TextBoxNumberofDay.Text)})  ' create a parameter for the number of days and set the value to the text in the TextBoxNumberofDay
            Dim result As Integer = ExecuteStoredFunctionreturnNumber("count_product_sales_from_db", parameters.ToArray())  ' execute the stored function to count the product sales and assign the result to result
            TextBoxResult.AppendText($"Total number of sales: {result}" & vbNewLine)  ' display the total number of sales
        End If
    End Sub

    Private Sub DeleteSale_Click(sender As Object, e As EventArgs) Handles DeleteSale.Click
        TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Deleting Sale with the smallest SaleID value" & vbNewLine)  ' display a message to show the operation is in progress
        Dim result As Object = ExecuteStoredFunctionreturnNumber("delete_sale_from_db")  ' execute the stored function to delete the sale with the smallest SaleID value and assign the result to result
        If result IsNot Nothing Then
            TextBoxResult.AppendText($"Delete Sale OK. SaleID: {result}" & vbNewLine)  ' display the SaleID of the sale that was deleted
        End If
    End Sub

    Private Sub DeleteAllSales_Click(sender As Object, e As EventArgs) Handles DeleteAllSales.Click
        TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & "Deleting all Sales data in Sale, Customer, and Product tables" & vbNewLine)  ' display a message to show the operation is in progress
        If ExecuteStoredProcedure("delete_all_sales_from_db", Nothing) Then
            TextBoxResult.AppendText("Deletion OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
        End If
    End Sub

    Private Sub DeleteCustomer_Click(sender As Object, e As EventArgs) Handles DeleteCustomer.Click
        If String.IsNullOrEmpty(TextBoxCustID.Text) Then
            TextBoxResult.AppendText("Please enter a customer ID for Delete Customer")  ' if the TextBoxCustID is empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Deleting Customer. Cust ID: {TextBoxCustID.Text}" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pcustid", OracleType.Number) With {.Value = Integer.Parse(TextBoxCustID.Text)})  ' create a parameter for the customer ID and set the value to the text in the TextBoxCustID
            If ExecuteStoredProcedure("delete_customer", parameters.ToArray()) Then
                TextBoxResult.AppendText("Deleted Customer OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub

    Private Sub DeleteProduct_Click(sender As Object, e As EventArgs) Handles DeleteProduct.Click
        If String.IsNullOrEmpty(TextBoxProdID.Text) Then
            TextBoxResult.AppendText("Please enter a product ID for Delete Product")  ' if the TextBoxProdID is empty, display a message to give the instructions to user
        Else
            TextBoxResult.AppendText("--------------------------------------------" & vbNewLine & $"Deleting Product. Prod ID: {TextBoxProdID.Text}" & vbNewLine)  ' display a message to show the operation is in progress
            Dim parameters As New List(Of OracleClient.OracleParameter)
            parameters.Add(New OracleClient.OracleParameter("pprodid", OracleType.Number) With {.Value = Integer.Parse(TextBoxProdID.Text)})  ' create a parameter for the product ID and set the value to the text in the TextBoxProdID
            If ExecuteStoredProcedure("delete_prod_from_db", parameters.ToArray()) Then
                TextBoxResult.AppendText("Deleted Product OK" & vbNewLine)  ' if the stored procedure executes successfully, display a message
            End If
        End If
    End Sub


End Class

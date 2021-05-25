
		Dim connString As String
		Dim conn As OdbcConnection 
		Dim dataReader As OdbcDataReader 
		Dim command As OdbcCommand
		Dim cmdText As String
		
		connString = "DSN=IMDB;Database=Active;Uid=sa;Pwd=Password1" 
		conn = New OdbcConnection(connString)
		
		Dim userList As ListField = eventData.Form.Fields.GetField("UserID")
		Dim operatorList as ListField = eventData.Form.Fields.GetField("Operator")
		
		userList.Items.Clear
		operatorList.Items.Clear
		
		cmdText	= "SELECT [USERID],[USERIDEX],[FULLNAME],[USERNUM] FROM [Active].[MHGROUP].[DOCUSERS] WHERE [LOGIN] = 'Y'"
	
		Try
			command = New OdbcCommand(cmdText) 
			command.Connection = conn
			conn.Open()
			dataReader = command.ExecuteReader() 
			While dataReader.Read()
				
				Dim listItem As listItem = New ListItem(dataReader.GetString(2), dataReader.GetString(0))
				userList.Items.Add(listItem)
				operatorList.Items.Add(listItem)
			End While
			
		Catch ex As Exception
		End Try
	
		If Not(dataReader Is Nothing) Then	
			dataReader.Close() 
		End If
		conn.Close()
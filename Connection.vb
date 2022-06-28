Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml

Module Connection
    Public connect As SqlConnection
    Public dtConfigDB As DataTable = New DataTable()
    Public dtMapAcct As DataTable = New DataTable()
    Friend Command As SqlCommand
    Friend adapter As SqlDataAdapter

#Region "Connection"
    Sub SaveConfigDB(Optional ByVal Runno As String = Nothing, Optional ByVal LastSEQ As String = Nothing)
        Try
            Dim FILE_text1 As String = My.Application.Info.DirectoryPath & "\Configure\Config.ini"

            Dim aryText(5) As String
            Dim i As Integer

            aryText(0) = "CompanyName:" + EncryptDecrypt_Class.Encrypt(FrmDbSetup.Acc_Company.Text, "FMS1")
            aryText(1) = "SageVersion:" + EncryptDecrypt_Class.Encrypt(FrmDbSetup.Acc_Source.Text, "FMS1")
            aryText(2) = "UserName:" + EncryptDecrypt_Class.Encrypt(FrmDbSetup.Acc_UserID.Text, "FMS1")
            aryText(3) = "PassWord:" + EncryptDecrypt_Class.Encrypt(FrmDbSetup.Acc_Password.Text, "FMS1")


            aryText(4) = "DB:" + EncryptDecrypt_Class.Encrypt(FrmDbSetup.Acc_DB.Text, "FMS1")
            aryText(5) = "Authen:" + EncryptDecrypt_Class.Encrypt(FrmDbSetup.BTNAUTHEN_YES.Text, "FMS1")


            Dim objWriter As New System.IO.StreamWriter(FILE_text1)
            For i = 0 To 5
                objWriter.WriteLine(aryText(i))
            Next
            objWriter.Close()
            Console.Read()
        Catch ex As Exception
            WriteLog("Error 35 (SaveConfigDB) : " & ex.Message)

        End Try
    End Sub
    Sub ReadConfig(ByRef dtConfigDB As DataTable)
        Try
            Dim filename As String = My.Application.Info.DirectoryPath & "\Configure\Config.ini"
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(filename)

            '>> Read text push to datatable

            Dim stringReader1 As String
            stringReader1 = fileReader.ReadLine()
            If stringReader1.Contains("CompanyName") = False Then
                Exit Sub
            End If
            Dim Sp1 As String()
            Sp1 = stringReader1.Split(":")
            Dim CompanyName As String = ""
            For i = 1 To Sp1.Length - 1
                CompanyName = CompanyName + Sp1(i).ToString()
            Next
            CompanyName = EncryptDecrypt_Class.Decrypt(CompanyName, "FMS1")

            Dim stringReader2 As String
            stringReader2 = fileReader.ReadLine()
            Dim Sp2 As String()
            Sp2 = stringReader2.Split(":")
            Dim SageVersion As String = ""
            For i = 1 To Sp2.Length - 1
                SageVersion = SageVersion + Sp2(i).ToString()
            Next
            SageVersion = EncryptDecrypt_Class.Decrypt(SageVersion, "FMS1")

            Dim stringReader3 As String
            stringReader3 = fileReader.ReadLine()
            Dim Sp3 As String()
            Sp3 = stringReader3.Split(":")
            Dim UserName As String = ""
            For i = 1 To Sp3.Length - 1
                UserName = UserName + Sp3(i).ToString()
            Next
            UserName = EncryptDecrypt_Class.Decrypt(UserName, "FMS1")

            Dim stringReader4 As String
            stringReader4 = fileReader.ReadLine()
            Dim Sp4 As String()
            Sp4 = stringReader4.Split(":")
            Dim PassWord As String = ""
            For i = 1 To Sp4.Length - 1
                PassWord = PassWord + Sp4(i).ToString()
            Next
            PassWord = EncryptDecrypt_Class.Decrypt(PassWord, "FMS1")

            Dim stringReaderVat2 As String
            stringReaderVat2 = fileReader.ReadLine()
            Dim SpVat2 As String()
            SpVat2 = stringReaderVat2.Split(":")
            Dim DB As String = ""
            For i = 1 To SpVat2.Length - 1
                DB = DB + SpVat2(i).ToString()
            Next
            DB = EncryptDecrypt_Class.Decrypt(DB, "FMS1")

            Dim stringReaderAuthen As String
            stringReaderAuthen = fileReader.ReadLine()

            Dim SpAuthen As String()
            SpAuthen = stringReaderAuthen.Split(":")
            Dim Authen As String = ""
            For i = 1 To SpAuthen.Length - 1
                Authen = Authen + SpAuthen(i).ToString()
            Next
            Authen = EncryptDecrypt_Class.Decrypt(Authen, "FMS1")



            FrmDbSetup.Acc_Company.Text = CompanyName
            FrmDbSetup.Acc_Source.Text = SageVersion
            FrmDbSetup.Acc_UserID.Text = UserName
            FrmDbSetup.Acc_Password.Text = PassWord
            FrmDbSetup.Acc_DB.Text = DB

            dtConfigDB.Rows.Clear()
            dtConfigDB.Columns.Clear()

            dtConfigDB.Columns.Add("CompanyName")
            dtConfigDB.Columns.Add("SourceDB")
            dtConfigDB.Columns.Add("UserName")
            dtConfigDB.Columns.Add("PassWord")
            dtConfigDB.Columns.Add("DatabaseName")
            dtConfigDB.Columns.Add("Authen")

            Dim row As String() = New String() {CompanyName, SageVersion, UserName, PassWord, DB, Authen}
            dtConfigDB.Rows.Add(row)

            fileReader.Close()
            fileReader.Dispose()
        Catch ex As Exception
            WriteLog("Error 137 (ReadConfig) : " & ex.Message)
        End Try
    End Sub
    Sub Openconnect(ByVal DB As String, ByRef connection As SqlConnection)
        Try
            If dtConfigDB.Rows.Count = 0 Then
                'ReadConfig(dtConfigDB)
                dtConfigDB = READDB()
            Else

            End If
            If dtConfigDB.Rows.Count <> 0 Then
                Dim strcon As String = "Data Source= " & dtConfigDB.Rows(0).Item("SERVER").ToString & "  ;Initial Catalog=" & dtConfigDB.Rows(0).Item("DBBILL").ToString & " ;User ID=" & dtConfigDB.Rows(0).Item("USER").ToString & " ;Password= " & dtConfigDB.Rows(0).Item("PASSWORD").ToString & ";Connect Timeout=0 "

                Dim connectionStringSource As String = "Data Source= " & dtConfigDB.Rows(0).Item("SERVER").ToString & ";Initial Catalog= " & dtConfigDB.Rows(0).Item("DBSource").ToString & ";User ID= " & dtConfigDB.Rows(0).Item("USER").ToString & ";Password= " & dtConfigDB.Rows(0).Item("PASSWORD").ToString & ";Connect Timeout=0"
                If DB = "Source" Then
                    connection = New SqlConnection(connectionStringSource)
                Else
                    connection = New SqlConnection(strcon)
                End If
                If connection.State = ConnectionState.Closed Then

                    connection.Open()
                Else
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            WriteLog("Error 165 (Openconnect) :" & ex.Message)
        End Try
    End Sub

    Sub SAVEDB(ByVal dtConfigDB As DataTable)
        Try

            Dim ID As Integer
            Dim SERVER As String = FrmDbSetup.Acc_Company.Text
            Dim USER As String = FrmDbSetup.Acc_UserID.Text
            Dim PASSWORD As String = FrmDbSetup.Acc_Password.Text
            Dim DBSource As String = FrmDbSetup.Acc_Source.Text
            Dim DBBILL As String = FrmDbSetup.Acc_DB.Text
            Dim ACTIVEAUTHEN As Integer
            If FrmDbSetup.BTNAUTHEN_YES.Checked = True Then
                ACTIVEAUTHEN = 1
            Else
                ACTIVEAUTHEN = 0
            End If

            If dtConfigDB.Columns.Count = 0 Or dtConfigDB Is Nothing = True Then
                dtConfigDB.Columns.Add("ID", GetType(Integer))
                dtConfigDB.Columns.Add("SERVER")
                dtConfigDB.Columns.Add("USER")
                dtConfigDB.Columns.Add("PASSWORD")
                dtConfigDB.Columns.Add("DBSource")
                dtConfigDB.Columns.Add("DBBILL")
                dtConfigDB.Columns.Add("AUTHOR")
            End If

            If FrmDbSetup.txtDBID.Text = "***New***" Then
                If FrmDbSetup.Acc_Password.Text.TrimEnd = FrmDbSetup.txtConfirmPass.Text Then
                    Dim ROWID As DataRow()
                    If dtConfigDB.Rows.Count = 0 Then
                        ID = "001"
                    Else
                        ROWID = dtConfigDB.[Select]("ID = MAX(ID)")
                        If ROWID.Count > 0 Then
                            ID = CInt((ROWID(0).Item("ID").ToString)) + 1
                        End If
                    End If
                    Dim row As String() = New String() {ID, SERVER, USER, PASSWORD, DBSource, DBBILL, ACTIVEAUTHEN}
                    dtConfigDB.Rows.Add(row)
                    FrmDbSetup.txtDBID.Text = ID
                Else
                    MessageBox.Show("Warning! Please check and try again. Mismatch Password and Confirm Password. ")
                    Exit Try
                End If

            Else
                'CASE EDIT 
                For i = 0 To dtConfigDB.Rows.Count - 1
                    If dtConfigDB.Rows(i).Item("ID").ToString.TrimEnd = FrmDbSetup.txtDBID.Text.TrimEnd Then
                        dtConfigDB.Rows(i).Delete()
                        dtConfigDB.AcceptChanges()
                        ID = FrmAuthor.txtAuthorUserID.Text
                        Dim row As String() = New String() {ID, SERVER, USER, PASSWORD, DBSource, DBBILL, ACTIVEAUTHEN}
                        dtConfigDB.Rows.Add(row)
                        Exit For
                    End If
                Next

            End If

            dtConfigDB.DefaultView.Sort = "ID ASC"
            dtConfigDB = dtConfigDB.DefaultView.ToTable
            Dim BOM As XElement = New XElement("BOM")
            Dim BO As XElement = New XElement("BO")

            If dtConfigDB.Rows.Count <> 0 Then

                Dim DocumentsLine As XElement = New XElement("Document_Lines")
                For j = 0 To dtConfigDB.Rows.Count - 1
                    Dim Lrow As XElement = New XElement("row")
                    Dim vID As String = dtConfigDB.Rows(j).Item("ID").ToString
                    Dim vServer As String = dtConfigDB.Rows(j).Item("SERVER").ToString
                    Dim vUSER As String = dtConfigDB.Rows(j).Item("USER").ToString
                    Dim vPASSWORD As String = dtConfigDB.Rows(j).Item("PASSWORD").ToString
                    Dim vDBSource As String = dtConfigDB.Rows(j).Item("DBSource").ToString
                    Dim vDBBILL As String = dtConfigDB.Rows(j).Item("DBBILL").ToString
                    Dim vAuthor As String = dtConfigDB.Rows(j).Item("AUTHOR").ToString

                    Dim xmlID As XElement = New XElement("ID", vID)
                    Dim xmlSERVER As XElement = New XElement("SERVER", vServer)
                    Dim xmlUSER As XElement = New XElement("USER", vUSER)
                    Dim xmlPASSWORD As XElement = New XElement("PASSWORD", vPASSWORD)
                    Dim xmlDBSource As XElement = New XElement("DBSource", vDBSource)
                    Dim xmlDBBILL As XElement = New XElement("DBBILL", vDBBILL)
                    Dim xmlAuthor As XElement = New XElement("AUTHOR", vAuthor)

                    Lrow.Add(xmlID)
                    Lrow.Add(xmlSERVER)
                    Lrow.Add(xmlUSER)
                    Lrow.Add(xmlPASSWORD)
                    Lrow.Add(xmlDBSource)
                    Lrow.Add(xmlDBBILL)
                    Lrow.Add(xmlAuthor)

                    DocumentsLine.Add(Lrow)
                Next
                BO.Add(DocumentsLine)

                BOM.Add(BO)
                'Generate xml file
                Dim reader = BOM.CreateReader()
                reader.ReadInnerXml()
                reader.MoveToContent()

                Dim settingPath As XmlWriterSettings = New XmlWriterSettings()
                settingPath.Indent = True

                Dim pathaddr As String

                pathaddr = My.Application.Info.DirectoryPath & "\Configure\DBCONFIG.xml"
                Dim path As System.IO.StreamWriter = New StreamWriter(pathaddr)

                Using writer As New System.Xml.XmlTextWriter(path)
                    writer.WriteStartDocument()
                    writer.WriteRaw(reader.ReadOuterXml)
                End Using
            Else

            End If
            'MessageBox.Show("Save Complete")
        Catch ex As Exception
            Call WriteLog("ERROR 290 (SAVEAUTHOR) : " & ex.Message, "EXPORT")
        End Try
    End Sub

    Public Function READDB(Optional ByVal Comp As String = Nothing) As DataTable

        Dim DT As DataTable = New DataTable
        Dim DTT As DataTable = New DataTable
        If DT.Columns.Count = 0 Or DT Is Nothing = True Then
            DT.Columns.Add("ID", GetType(Integer))
            DT.Columns.Add("SERVER")
            DT.Columns.Add("USER")
            DT.Columns.Add("PASSWORD")
            DT.Columns.Add("DBSource")
            DT.Columns.Add("DBBILL")
            DT.Columns.Add("AUTHOR")
        End If
        Try


            Dim xmlDoc As New XmlDocument 'For loading xml file to read

            Dim ImportFilename As String = My.Application.Info.DirectoryPath & "\Configure\DBCONFIG.xml"
            xmlDoc.Load(ImportFilename) 'loading the xml file, insert your file here
            Dim RND As Integer = xmlDoc.Schemas.Count


            'COUNT  

            Dim ArticleNodeList As XmlNodeList 'For getting the list of main/parent nodes
            ArticleNodeList = xmlDoc.GetElementsByTagName("row") 'Setting all <People> node to list
            For Each articlenode As XmlNode In ArticleNodeList 'Looping through <People> node           
                DT.Rows.Add()
            Next
            DT.Rows.Add()

            For J = 0 To DT.Rows.Count - 1
                ArticleNodeList = xmlDoc.GetElementsByTagName("row") 'Setting all <People> node to list
                RND = 0
                For Each articlenode As XmlNode In ArticleNodeList 'Looping through <People> node
                    RND = RND + 1
                    For Each basenode As XmlNode In articlenode 'Looping all <People> childnodes

                        Dim result As String = ""
                        result = basenode.Name 'use 
                        Select Case result
                            Case "ID"
                                If J = RND Then
                                    DT.Rows(J).Item("ID") = basenode.InnerText
                                End If
                            Case "SERVER"
                                If J = RND Then
                                    DT.Rows(J).Item("SERVER") = basenode.InnerText
                                End If
                            Case "USER"
                                If J = RND Then
                                    DT.Rows(J).Item("USER") = basenode.InnerText
                                End If
                            Case "PASSWORD"
                                If J = RND Then
                                    DT.Rows(J).Item("PASSWORD") = basenode.InnerText
                                End If

                            Case "DBSource"
                                If J = RND Then
                                    DT.Rows(J).Item("DBSource") = basenode.InnerText
                                End If
                            Case "DBBILL"
                                If J = RND Then
                                    DT.Rows(J).Item("DBBILL") = basenode.InnerText
                                End If

                            Case "AUTHOR"
                                If J = RND Then
                                    DT.Rows(J).Item("AUTHOR") = basenode.InnerText
                                End If
                        End Select
                    Next
                Next
            Next

            DT.Rows(0).Delete()

            If DT.Rows.Count <> 0 Then
                If Comp <> Nothing Then
                    For k = 0 To DT.Rows.Count - 1
                        Dim DBSource As String = DT.Rows(k).Item("DBSource").ToString.TrimEnd
                        If DBSource <> Comp Then
                        Else
                            DTT = DT.Clone
                            Dim row As String() = New String() {DT.Rows(k).Item(0).ToString.TrimEnd, DT.Rows(k).Item(1).ToString.TrimEnd, DT.Rows(k).Item(2).ToString.TrimEnd, DT.Rows(k).Item(3).ToString.TrimEnd, DT.Rows(k).Item(4).ToString.TrimEnd, DT.Rows(k).Item(5).ToString.TrimEnd, DT.Rows(k).Item(6).ToString.TrimEnd}
                            DTT.Rows.Add(row)
                        End If
                    Next
                End If

            End If
        Catch ex As Exception
            WriteLog("Error 388 (READDB) : " & ex.Message)
            FrmDbSetup.Show()
        End Try
        If DTT.Rows.Count = 0 Then
            Return DT
        Else
            Return DTT
        End If

    End Function

#End Region

#Region "Setup"
    Public Sub WriteLog(ByVal strlog As String, Optional ByVal EXPORT As String = "")
        Try
            'Generate log file
            Dim FILE_LOG As String = ""
            Select Case EXPORT
                Case ""
                    FILE_LOG = My.Application.Info.DirectoryPath & "\LOG.ini"

            End Select

            Dim lineCount = File.ReadAllLines(FILE_LOG).Length
            If lineCount > 5000 Then ' stored log 10000 lines
                lineCount = 1
                System.IO.File.WriteAllText(FILE_LOG, "Log")
            End If

            'Read old log 
            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(FILE_LOG)
            Dim oldLog As String = ""

            For cntLine = 0 To lineCount - 1
                oldLog &= reader.ReadLine & vbCrLf
            Next
            reader.Close()

            'Write log
            Dim objWriter As New System.IO.StreamWriter(FILE_LOG)
            objWriter.WriteLine(Now & " " & strlog)
            objWriter.WriteLine(oldLog)

            objWriter.Close()
            'MAIN.txtLogImport.Text = Now & " " & MAIN.txtLogImport.Text & vbCrLf & strlog

        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Authorize"
    Sub SAVEAUTHOR(ByVal DTAPP As DataTable)
        Try

            Dim ID As Integer
            Dim USER As String = FrmAuthor.txtAuthorUser.Text.TrimEnd
            Dim PASSWORD As String = FrmAuthor.txtAuthorPassword.Text.TrimEnd
            Dim AUTHOR As String = FrmAuthor.txtAuthorized.Text.TrimEnd

            If FrmAuthor.txtAuthorUserID.Text = "***New***" = True Then
                Dim ROWTEMP As DataRow()
                ROWTEMP = DTAPP.[Select]("USER = '" & USER & "'")
                If ROWTEMP.Count = 0 Then
                    If FrmAuthor.txtAuthorPassword.Text.TrimEnd = FrmAuthor.txtConfirmPass.Text Then
                        Dim ROWID As DataRow()
                        If DTAPP.Rows.Count = 0 Then
                            ID = "001"
                        Else
                            ROWID = DTAPP.[Select]("ID = MAX(ID)")
                            If ROWID.Count > 0 Then
                                ID = CInt((ROWID(0).Item("ID").ToString)) + 1
                            End If
                        End If
                        Dim row As String() = New String() {ID, USER, PASSWORD, AUTHOR}
                        DTAPP.Rows.Add(row)
                        FrmAuthor.txtAuthorUserID.Text = ID
                    Else
                        MessageBox.Show("Warning! Please check and try again. Mismatch Password and Confirm Password. ")
                        Exit Try
                    End If
                Else
                    MessageBox.Show("Error Duplicate User")
                    FrmAuthor.txtAuthorUser.Text = ""
                End If
            Else
                'CASE EDIT 
                For i = 0 To DTAPP.Rows.Count - 1
                    If DTAPP.Rows(i).Item("ID").ToString.TrimEnd = FrmAuthor.txtAuthorUserID.Text.TrimEnd Then
                        DTAPP.Rows(i).Delete()
                        DTAPP.AcceptChanges()
                        ID = FrmAuthor.txtAuthorUserID.Text
                        Dim row As String() = New String() {ID, USER, PASSWORD, AUTHOR}
                        DTAPP.Rows.Add(row)
                        Exit For
                    End If
                Next

            End If

            DTAPP.DefaultView.Sort = "ID ASC"
            DTAPP = DTAPP.DefaultView.ToTable
            Dim BOM As XElement = New XElement("BOM")
            Dim BO As XElement = New XElement("BO")

            If DTAPP.Rows.Count <> 0 Then

                Dim DocumentsLine As XElement = New XElement("Document_Lines")
                For j = 0 To DTAPP.Rows.Count - 1
                    Dim Lrow As XElement = New XElement("row")
                    Dim vID As String = DTAPP.Rows(j).Item("ID").ToString
                    Dim vUSER As String = DTAPP.Rows(j).Item("USER").ToString
                    Dim vPASSWORD As String = DTAPP.Rows(j).Item("PASSWORD").ToString
                    Dim vAuthor As String = DTAPP.Rows(j).Item("AUTHOR").ToString

                    Dim xmlID As XElement = New XElement("ID", vID)
                    Dim xmlUSER As XElement = New XElement("USER", vUSER)
                    Dim xmlPASSWORD As XElement = New XElement("PASSWORD", vPASSWORD)
                    Dim xmlAuthor As XElement = New XElement("AUTHOR", vAuthor)

                    Lrow.Add(xmlID)
                    Lrow.Add(xmlUSER)
                    Lrow.Add(xmlPASSWORD)
                    Lrow.Add(xmlAuthor)

                    DocumentsLine.Add(Lrow)
                Next
                BO.Add(DocumentsLine)

                BOM.Add(BO)
                'Generate xml file
                Dim reader = BOM.CreateReader()
                reader.ReadInnerXml()
                reader.MoveToContent()

                Dim settingPath As XmlWriterSettings = New XmlWriterSettings()
                settingPath.Indent = True

                Dim pathaddr As String

                pathaddr = My.Application.Info.DirectoryPath & "\Configure\APPAUTHORIZED.xml"
                Dim path As System.IO.StreamWriter = New StreamWriter(pathaddr)

                Using writer As New System.Xml.XmlTextWriter(path)
                    writer.WriteStartDocument()
                    writer.WriteRaw(reader.ReadOuterXml)
                End Using
            Else

            End If
            'MessageBox.Show("Save Complete")
        Catch ex As Exception
            Call WriteLog("ERROR 542 (SAVEAUTHOR) : " & ex.Message, "EXPORT")
        End Try
    End Sub

    Public Function READAUTHOR() As DataTable

        Dim DT As DataTable = New DataTable

        'If DT.Columns.Count = 0 Or DT Is Nothing = True Then
        DT.Columns.Add("ID", GetType(Integer))
        DT.Columns.Add("USER")
        DT.Columns.Add("PASSWORD")
        DT.Columns.Add("AUTHOR")

        'End If

        Dim xmlDoc As New XmlDocument 'For loading xml file to read

        Dim ImportFilename As String = My.Application.Info.DirectoryPath & "\Configure\APPAUTHORIZED.xml"
        xmlDoc.Load(ImportFilename) 'loading the xml file, insert your file here
        Dim RND As Integer = xmlDoc.Schemas.Count


        'COUNT  

        Dim ArticleNodeList As XmlNodeList 'For getting the list of main/parent nodes
        ArticleNodeList = xmlDoc.GetElementsByTagName("row") 'Setting all <People> node to list
        For Each articlenode As XmlNode In ArticleNodeList 'Looping through <People> node           
            DT.Rows.Add()
        Next
        DT.Rows.Add()

        For J = 0 To DT.Rows.Count - 1
            ArticleNodeList = xmlDoc.GetElementsByTagName("row") 'Setting all <People> node to list
            RND = 0
            For Each articlenode As XmlNode In ArticleNodeList 'Looping through <People> node
                RND = RND + 1
                For Each basenode As XmlNode In articlenode 'Looping all <People> childnodes

                    Dim result As String = ""
                    result = basenode.Name 'use 
                    Select Case result
                        Case "ID"
                            If J = RND Then
                                DT.Rows(J).Item("ID") = basenode.InnerText
                            End If
                        Case "USER"
                            If J = RND Then
                                DT.Rows(J).Item("USER") = basenode.InnerText
                            End If
                        Case "PASSWORD"
                            If J = RND Then
                                DT.Rows(J).Item("PASSWORD") = basenode.InnerText
                            End If
                        Case "AUTHOR"
                            If J = RND Then
                                DT.Rows(J).Item("AUTHOR") = basenode.InnerText
                            End If
                    End Select
                Next
            Next
        Next

        DT.Rows(0).Delete()

        Return DT
    End Function

    Public Function GETAUTHENNAME(ByVal AUTHENID As String) As String
        Dim AuthenName As String = ""
        Dim dtAUTHEN As DataTable = New DataTable
        dtAUTHEN = READAUTHOR()

        For i = 0 To dtAUTHEN.Rows.Count - 1
            Dim dtAuthenID As String = dtAUTHEN.Rows(i).Item("ID").ToString.TrimEnd
            If dtAuthenID = AUTHENID.TrimEnd Then
                AuthenName = dtAUTHEN.Rows(i).Item("USER").ToString.TrimEnd
            End If
        Next

        Return AuthenName
    End Function

#End Region

End Module

Public Class PatientsBLL
    Inherits BLL

    Private Function ToPatientList(whereClause As String, pageIndex As Long, pageSize As Long) As List(Of Patient)
        Dim list As List(Of Patient) = New List(Of Patient)()

        Dim skip As Integer = CInt((pageSize * (pageIndex - 1)))

        OpenConnection("SELECT Id, FirstName, LastName, DateOfBirth, SchoolId, Gender, Type, Timestamp FROM Patients " & whereClause & "ORDER BY Timestamp DESC LIMIT " & skip & "," & pageSize)

        reader = command.ExecuteReader()
        Do While reader.Read()
            Dim patient As New Patient()
            patient.Id = Guid.Parse(reader.GetString(0))
            patient.FirstName = reader.GetString(1)
            patient.LastName = reader.GetString(2)
            patient.DateOfBirth = DateTime.Parse(reader.GetString(3))
            patient.SchoolId = (If(reader.IsDBNull(4), "", reader.GetString(4)))
            patient.Gender = [Enum].Parse(GetType(Gender), reader.GetString(5))
            patient.Type = [Enum].Parse(GetType(PatientType), reader.GetString(6))
            patient.Timestamp = DateTime.Parse(reader.GetString(7))
            list.Add(patient)
        Loop

        CloseConnection()
        Return list
    End Function

    Public Function SearchPatients(Optional pageIndex As Int32 = 1, Optional pageSize As Int32 = 10, Optional keyword As String = "") As Page(Of Patient)
        Dim patients = New Page(Of Patient)()
        Dim whereClause As String = ""

        If (String.IsNullOrEmpty(keyword) <> True) Then
            whereClause = " WHERE (FirstName LIKE '%" & keyword & "%' OR LastName LIKE '%" & keyword & "%')"
        End If

        Dim totalCount = GetCount("Patients", whereClause)

        Dim pageCount As Integer = CInt(Math.Ceiling(CDec((totalCount / pageSize))))
        Dim modulus As Long = (totalCount Mod pageSize)

        'If modulus > 0 Then
        '    pageCount = pageCount + 1
        'End If

        patients.Data = ToPatientList(whereClause, pageIndex, pageSize)
        patients.TotalItemCount = totalCount
        patients.CurrentPage = pageIndex
        patients.Keyword = keyword
        patients.TotalPageCount = pageCount
        patients.PageSize = pageSize
        Return patients
    End Function

    Public Function Delete(id As Guid) As Integer
        Return DoCmd("DELETE FROM Patients WHERE Id='" & id.ToString() & "'")
    End Function

    Public Function Find(id As Guid) As Patient
        Dim patient As New Patient()
        patient.Id = Guid.Empty

        OpenConnection("SELECT Id, FirstName, LastName, DateOfBirth, SchoolId, Gender, Type, Timestamp FROM Patients WHERE Id ='" & id.ToString() & "'")

        reader = command.ExecuteReader()

        Do While reader.Read()
            If (patient.Id = Guid.Empty) Then
                patient.Id = Guid.Parse(reader.GetString(0))
                patient.FirstName = reader.GetString(1)
                patient.LastName = reader.GetString(2)
                patient.DateOfBirth = DateTime.Parse(reader.GetString(3))
                patient.SchoolId = (If(reader.IsDBNull(4), "", reader.GetString(4)))
                patient.Gender = [Enum].Parse(GetType(Gender), reader.GetString(5))
                patient.Type = [Enum].Parse(GetType(PatientType), reader.GetString(6))
                patient.Timestamp = DateTime.Parse(reader.GetString(7))
            End If
        Loop

        CloseConnection()
        Return patient
    End Function

    Public Function Update(patient As Patient) As Integer
        Dim commandText As String
        commandText = "FirstName='" & patient.FirstName & "', LastName='" & patient.LastName & "', SchoolId='" & patient.SchoolId & "', DateOfBirth='" & patient.DateOfBirth.ToString("yyyy-MM-dd") & "', Gender=" & patient.Gender & ",Type=" & patient.Type & ",Timestamp='" & DateTime.UtcNow.ToString("yyyy-MM-dd") & "'"
        Return DoCmd("UPDATE Patients SET " & commandText & " WHERE Id='" & patient.Id.ToString() & "'")
    End Function

    Public Function Insert(patient As Patient) As Integer
        Dim fields As String = "Id, FirstName, LastName, DateOfBirth, Gender, Type, SchoolId, Timestamp"
        Dim values As String = "'" & Guid.NewGuid().ToString() & "','" & patient.FirstName & "','" & patient.LastName & "','" & patient.DateOfBirth.ToString("yyyy-MM-dd") & "'," & patient.Gender & "," & patient.Type & ",'" & patient.SchoolId & "','" & DateTime.UtcNow.ToString("yyyy-MM-dd") & "'"

        DoCmd("INSERT INTO Patients (" & fields & ") VALUES (" & values & ")")
        Return 1
    End Function

    Public Function Lookup(keyword As String) As List(Of TextValuePair)
        Dim list As List(Of TextValuePair) = New List(Of TextValuePair)()
        Dim whereClause As String = ""

        If (String.IsNullOrEmpty(keyword) <> True) Then
            whereClause = " WHERE (FirstName LIKE '" & keyword & "%' OR LastName LIKE '" & keyword & "%' OR SchoolId LIKE '" & keyword & "%')"
        End If

        OpenConnection("SELECT Id, FirstName, LastName, SchoolId FROM Patients " & whereClause & " LIMIT 6")

        reader = command.ExecuteReader()
        Do While reader.Read()
            Dim item As New TextValuePair()
            item.Value = Guid.Parse(reader.GetString(0))
            item.Text = reader.GetString(1) & " " & reader.GetString(2) & (If(reader.IsDBNull(3), "", " (" & reader.GetString(3) & ")"))
            list.Add(item)
        Loop

        CloseConnection()
        Return list
    End Function
End Class

Public Class Patient
    Public Property Id As Guid?
    Public Property FirstName As String
    Public Property LastName As String
    Public Property DateOfBirth As DateTime
    Public Property Gender As Gender
    Public Property SchoolId As String
    Public Property Type As PatientType
    Public Property Timestamp As DateTime
    Public ReadOnly Property Age As Int32
        Get
            Age = New DateTime(DateTime.Now.Subtract(Me.DateOfBirth).Ticks).Year - 1
        End Get
    End Property

    Public ReadOnly Property FullName As String
        Get
            FullName = Me.FirstName & " " & Me.LastName
        End Get
    End Property
End Class

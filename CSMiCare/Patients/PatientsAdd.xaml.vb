Public Class PatientsAdd
    Dim bll As New CSMiCare.PatientsBLL()
    Private index As PatientsIndex

    Public Sub New(sender As PatientsIndex)
        index = sender
        InitializeComponent()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As RoutedEventArgs) Handles btnCancel.Click
        index.LoadPage(1, 10, "")
        Me.Close()
    End Sub

    Private Sub PatientsAdd_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded, MyBase.Loaded
        cboPatientType.ItemsSource = [Enum].GetValues(GetType(PatientType)).Cast(Of PatientType)()
        cboPatientGender.ItemsSource = [Enum].GetValues(GetType(Gender)).Cast(Of Gender)()
        calPatientDateOfBirth.SelectedDate = DateTime.UtcNow
        calPatientDateOfBirth.DisplayDate = DateTime.UtcNow
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click
        'TO DO: She and Rona - Add Data Validation 
        'All fields are required 

        Dim newPatient = New Patient
        newPatient.Id = Guid.NewGuid()
        newPatient.FirstName = txtPatientFirstName.Text
        newPatient.LastName = txtPatientLastName.Text
        newPatient.SchoolId = txtPatientSchoolId.Text
        newPatient.Gender = cboPatientGender.SelectedValue
        newPatient.Type = cboPatientType.SelectedValue
        newPatient.DateOfBirth = calPatientDateOfBirth.SelectedDate

        bll.Insert(newPatient)
        index.LoadPage(1, 10, "")
        Me.Close()
    End Sub
End Class

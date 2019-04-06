Public Class PatientsEdit
    Dim bll As New CSMiCare.PatientsBLL()
    Private PatientId As Guid
    Private index As PatientsIndex

    Public Sub New(patientId As Guid, sender As PatientsIndex)
        Me.PatientId = patientId
        index = sender
        InitializeComponent()
    End Sub


    Private Sub PatientsEdit_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded, MyBase.Loaded
        Dim patient = bll.Find(Me.PatientId)

        cboPatientType.ItemsSource = [Enum].GetValues(GetType(PatientType)).Cast(Of PatientType)()
        cboPatientGender.ItemsSource = [Enum].GetValues(GetType(Gender)).Cast(Of Gender)()

        If (IsDBNull(patient) = False) Then
            lblPatientId.Content = patient.Id.ToString()
            txtPatientFirstName.Text = patient.FirstName
            txtPatientLastName.Text = patient.LastName
            cboPatientGender.SelectedValue = patient.Gender
            cboPatientType.SelectedValue = patient.Type
            calPatientDateOfBirth.DisplayDate = patient.DateOfBirth
            calPatientDateOfBirth.SelectedDate = patient.DateOfBirth

            If (String.IsNullOrEmpty(patient.SchoolId) = False) Then
                txtPatientSchoolId.Text = patient.SchoolId
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click
        'TO DO: She and Rona - Add Data Validation 
        'All fields are required 

        Dim editPatient = New Patient
        editPatient.Id = Me.PatientId
        editPatient.FirstName = txtPatientFirstName.Text
        editPatient.LastName = txtPatientLastName.Text
        editPatient.SchoolId = txtPatientSchoolId.Text
        editPatient.Gender = cboPatientGender.SelectedValue
        editPatient.Type = cboPatientType.SelectedValue
        editPatient.DateOfBirth = calPatientDateOfBirth.SelectedDate

        bll.Update(editPatient)
        index.LoadPage(1, 10, "")
        Me.Close()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As RoutedEventArgs) Handles btnCancel.Click
        index.LoadPage(1, 10, "")
        Me.Close()
    End Sub
End Class

﻿#ExternalChecksum("..\..\..\Patients\PatientsAdd.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","58A49B02F12260D0AB34E76DF4D79657CF67036C")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CSMiCare
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''PatientsAdd
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class PatientsAdd
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",1)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents PatientsAdd As PatientsAdd
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",10)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblPatient As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtPatientFirstName As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",12)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblPatientNameLabel As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",13)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtPatientLastName As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",14)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblPatientNameLabel_Copy As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",15)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents calPatientDateOfBirth As System.Windows.Controls.Calendar
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",16)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblPatientGenderLabel As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",17)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cboPatientGender As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblPatientTypeLabel As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",19)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents cboPatientType As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",20)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lblSchoolIdLabel As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",21)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtPatientSchoolId As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",22)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnSave As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",23)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnCancel As System.Windows.Controls.Button
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/CSMiCare;component/patients/patientsadd.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\Patients\PatientsAdd.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.PatientsAdd = CType(target,PatientsAdd)
            Return
        End If
        If (connectionId = 2) Then
            Me.lblPatient = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 3) Then
            Me.txtPatientFirstName = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 4) Then
            Me.lblPatientNameLabel = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 5) Then
            Me.txtPatientLastName = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 6) Then
            Me.lblPatientNameLabel_Copy = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 7) Then
            Me.calPatientDateOfBirth = CType(target,System.Windows.Controls.Calendar)
            Return
        End If
        If (connectionId = 8) Then
            Me.lblPatientGenderLabel = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 9) Then
            Me.cboPatientGender = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        If (connectionId = 10) Then
            Me.lblPatientTypeLabel = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 11) Then
            Me.cboPatientType = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        If (connectionId = 12) Then
            Me.lblSchoolIdLabel = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 13) Then
            Me.txtPatientSchoolId = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 14) Then
            Me.btnSave = CType(target,System.Windows.Controls.Button)
            Return
        End If
        If (connectionId = 15) Then
            Me.btnCancel = CType(target,System.Windows.Controls.Button)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class


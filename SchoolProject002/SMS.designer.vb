﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="SMSProjectDB2")>  _
Partial Public Class SMSDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertAssessment(instance As Assessment)
    End Sub
  Partial Private Sub UpdateAssessment(instance As Assessment)
    End Sub
  Partial Private Sub DeleteAssessment(instance As Assessment)
    End Sub
  Partial Private Sub InsertFee(instance As Fee)
    End Sub
  Partial Private Sub UpdateFee(instance As Fee)
    End Sub
  Partial Private Sub DeleteFee(instance As Fee)
    End Sub
  Partial Private Sub InsertStudent(instance As Student)
    End Sub
  Partial Private Sub UpdateStudent(instance As Student)
    End Sub
  Partial Private Sub DeleteStudent(instance As Student)
    End Sub
  Partial Private Sub InsertTeacher(instance As Teacher)
    End Sub
  Partial Private Sub UpdateTeacher(instance As Teacher)
    End Sub
  Partial Private Sub DeleteTeacher(instance As Teacher)
    End Sub
  Partial Private Sub InsertUser(instance As User)
    End Sub
  Partial Private Sub UpdateUser(instance As User)
    End Sub
  Partial Private Sub DeleteUser(instance As User)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.SchoolProject002.My.MySettings.Default.SMSProjectDB2ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Assessments() As System.Data.Linq.Table(Of Assessment)
		Get
			Return Me.GetTable(Of Assessment)
		End Get
	End Property
	
	Public ReadOnly Property Fees() As System.Data.Linq.Table(Of Fee)
		Get
			Return Me.GetTable(Of Fee)
		End Get
	End Property
	
	Public ReadOnly Property Students() As System.Data.Linq.Table(Of Student)
		Get
			Return Me.GetTable(Of Student)
		End Get
	End Property
	
	Public ReadOnly Property Teachers() As System.Data.Linq.Table(Of Teacher)
		Get
			Return Me.GetTable(Of Teacher)
		End Get
	End Property
	
	Public ReadOnly Property Users() As System.Data.Linq.Table(Of User)
		Get
			Return Me.GetTable(Of User)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Assessments")>  _
Partial Public Class Assessment
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _RegistrationNumber As String
	
	Private _FullName As String
	
	Private _Class As String
	
	Private _Stream As String
	
	Private _Subject As String
	
	Private _CA As System.Nullable(Of Decimal)
	
	Private _Exams As System.Nullable(Of Decimal)
	
	Private _Total As System.Nullable(Of Decimal)
	
	Private _Grade As String
	
	Private _Position As String
	
	Private _Remarks As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnRegistrationNumberChanging(value As String)
    End Sub
    Partial Private Sub OnRegistrationNumberChanged()
    End Sub
    Partial Private Sub OnFullNameChanging(value As String)
    End Sub
    Partial Private Sub OnFullNameChanged()
    End Sub
    Partial Private Sub OnClassChanging(value As String)
    End Sub
    Partial Private Sub OnClassChanged()
    End Sub
    Partial Private Sub OnStreamChanging(value As String)
    End Sub
    Partial Private Sub OnStreamChanged()
    End Sub
    Partial Private Sub OnSubjectChanging(value As String)
    End Sub
    Partial Private Sub OnSubjectChanged()
    End Sub
    Partial Private Sub OnCAChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnCAChanged()
    End Sub
    Partial Private Sub OnExamsChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnExamsChanged()
    End Sub
    Partial Private Sub OnTotalChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnTotalChanged()
    End Sub
    Partial Private Sub OnGradeChanging(value As String)
    End Sub
    Partial Private Sub OnGradeChanged()
    End Sub
    Partial Private Sub OnPositionChanging(value As String)
    End Sub
    Partial Private Sub OnPositionChanged()
    End Sub
    Partial Private Sub OnRemarksChanging(value As String)
    End Sub
    Partial Private Sub OnRemarksChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RegistrationNumber", DbType:="NVarChar(50)")>  _
	Public Property RegistrationNumber() As String
		Get
			Return Me._RegistrationNumber
		End Get
		Set
			If (String.Equals(Me._RegistrationNumber, value) = false) Then
				Me.OnRegistrationNumberChanging(value)
				Me.SendPropertyChanging
				Me._RegistrationNumber = value
				Me.SendPropertyChanged("RegistrationNumber")
				Me.OnRegistrationNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FullName", DbType:="NVarChar(50)")>  _
	Public Property FullName() As String
		Get
			Return Me._FullName
		End Get
		Set
			If (String.Equals(Me._FullName, value) = false) Then
				Me.OnFullNameChanging(value)
				Me.SendPropertyChanging
				Me._FullName = value
				Me.SendPropertyChanged("FullName")
				Me.OnFullNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Class", Storage:="_Class", DbType:="NVarChar(50)")>  _
	Public Property [Class]() As String
		Get
			Return Me._Class
		End Get
		Set
			If (String.Equals(Me._Class, value) = false) Then
				Me.OnClassChanging(value)
				Me.SendPropertyChanging
				Me._Class = value
				Me.SendPropertyChanged("[Class]")
				Me.OnClassChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Stream", DbType:="NVarChar(50)")>  _
	Public Property Stream() As String
		Get
			Return Me._Stream
		End Get
		Set
			If (String.Equals(Me._Stream, value) = false) Then
				Me.OnStreamChanging(value)
				Me.SendPropertyChanging
				Me._Stream = value
				Me.SendPropertyChanged("Stream")
				Me.OnStreamChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Subject", DbType:="NVarChar(50)")>  _
	Public Property Subject() As String
		Get
			Return Me._Subject
		End Get
		Set
			If (String.Equals(Me._Subject, value) = false) Then
				Me.OnSubjectChanging(value)
				Me.SendPropertyChanging
				Me._Subject = value
				Me.SendPropertyChanged("Subject")
				Me.OnSubjectChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CA", DbType:="Decimal(18,0)")>  _
	Public Property CA() As System.Nullable(Of Decimal)
		Get
			Return Me._CA
		End Get
		Set
			If (Me._CA.Equals(value) = false) Then
				Me.OnCAChanging(value)
				Me.SendPropertyChanging
				Me._CA = value
				Me.SendPropertyChanged("CA")
				Me.OnCAChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Exams", DbType:="Decimal(18,0)")>  _
	Public Property Exams() As System.Nullable(Of Decimal)
		Get
			Return Me._Exams
		End Get
		Set
			If (Me._Exams.Equals(value) = false) Then
				Me.OnExamsChanging(value)
				Me.SendPropertyChanging
				Me._Exams = value
				Me.SendPropertyChanged("Exams")
				Me.OnExamsChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Total", DbType:="Decimal(18,0)")>  _
	Public Property Total() As System.Nullable(Of Decimal)
		Get
			Return Me._Total
		End Get
		Set
			If (Me._Total.Equals(value) = false) Then
				Me.OnTotalChanging(value)
				Me.SendPropertyChanging
				Me._Total = value
				Me.SendPropertyChanged("Total")
				Me.OnTotalChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Grade", DbType:="NVarChar(50)")>  _
	Public Property Grade() As String
		Get
			Return Me._Grade
		End Get
		Set
			If (String.Equals(Me._Grade, value) = false) Then
				Me.OnGradeChanging(value)
				Me.SendPropertyChanging
				Me._Grade = value
				Me.SendPropertyChanged("Grade")
				Me.OnGradeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Position", DbType:="NVarChar(50)")>  _
	Public Property Position() As String
		Get
			Return Me._Position
		End Get
		Set
			If (String.Equals(Me._Position, value) = false) Then
				Me.OnPositionChanging(value)
				Me.SendPropertyChanging
				Me._Position = value
				Me.SendPropertyChanged("Position")
				Me.OnPositionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Remarks", DbType:="NVarChar(50)")>  _
	Public Property Remarks() As String
		Get
			Return Me._Remarks
		End Get
		Set
			If (String.Equals(Me._Remarks, value) = false) Then
				Me.OnRemarksChanging(value)
				Me.SendPropertyChanging
				Me._Remarks = value
				Me.SendPropertyChanged("Remarks")
				Me.OnRemarksChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Fees")>  _
Partial Public Class Fee
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _RegistrationNumber As String
	
	Private _FullName As String
	
	Private _Class As String
	
	Private _Fee As System.Nullable(Of Decimal)
	
	Private _FeePaid As System.Nullable(Of Decimal)
	
	Private _Balance As System.Nullable(Of Decimal)
	
	Private _Status As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnRegistrationNumberChanging(value As String)
    End Sub
    Partial Private Sub OnRegistrationNumberChanged()
    End Sub
    Partial Private Sub OnFullNameChanging(value As String)
    End Sub
    Partial Private Sub OnFullNameChanged()
    End Sub
    Partial Private Sub OnClassChanging(value As String)
    End Sub
    Partial Private Sub OnClassChanged()
    End Sub
    Partial Private Sub OnFeeChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnFeeChanged()
    End Sub
    Partial Private Sub OnFeePaidChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnFeePaidChanged()
    End Sub
    Partial Private Sub OnBalanceChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnBalanceChanged()
    End Sub
    Partial Private Sub OnStatusChanging(value As String)
    End Sub
    Partial Private Sub OnStatusChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RegistrationNumber", DbType:="NVarChar(50)")>  _
	Public Property RegistrationNumber() As String
		Get
			Return Me._RegistrationNumber
		End Get
		Set
			If (String.Equals(Me._RegistrationNumber, value) = false) Then
				Me.OnRegistrationNumberChanging(value)
				Me.SendPropertyChanging
				Me._RegistrationNumber = value
				Me.SendPropertyChanged("RegistrationNumber")
				Me.OnRegistrationNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FullName", DbType:="NVarChar(50)")>  _
	Public Property FullName() As String
		Get
			Return Me._FullName
		End Get
		Set
			If (String.Equals(Me._FullName, value) = false) Then
				Me.OnFullNameChanging(value)
				Me.SendPropertyChanging
				Me._FullName = value
				Me.SendPropertyChanged("FullName")
				Me.OnFullNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Class", Storage:="_Class", DbType:="NVarChar(50)")>  _
	Public Property [Class]() As String
		Get
			Return Me._Class
		End Get
		Set
			If (String.Equals(Me._Class, value) = false) Then
				Me.OnClassChanging(value)
				Me.SendPropertyChanging
				Me._Class = value
				Me.SendPropertyChanged("[Class]")
				Me.OnClassChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Fee", DbType:="Decimal(18,2)")>  _
	Public Property Fee() As System.Nullable(Of Decimal)
		Get
			Return Me._Fee
		End Get
		Set
			If (Me._Fee.Equals(value) = false) Then
				Me.OnFeeChanging(value)
				Me.SendPropertyChanging
				Me._Fee = value
				Me.SendPropertyChanged("Fee")
				Me.OnFeeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FeePaid", DbType:="Decimal(18,2)")>  _
	Public Property FeePaid() As System.Nullable(Of Decimal)
		Get
			Return Me._FeePaid
		End Get
		Set
			If (Me._FeePaid.Equals(value) = false) Then
				Me.OnFeePaidChanging(value)
				Me.SendPropertyChanging
				Me._FeePaid = value
				Me.SendPropertyChanged("FeePaid")
				Me.OnFeePaidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Balance", DbType:="Decimal(18,2)")>  _
	Public Property Balance() As System.Nullable(Of Decimal)
		Get
			Return Me._Balance
		End Get
		Set
			If (Me._Balance.Equals(value) = false) Then
				Me.OnBalanceChanging(value)
				Me.SendPropertyChanging
				Me._Balance = value
				Me.SendPropertyChanged("Balance")
				Me.OnBalanceChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Status", DbType:="NVarChar(50)")>  _
	Public Property Status() As String
		Get
			Return Me._Status
		End Get
		Set
			If (String.Equals(Me._Status, value) = false) Then
				Me.OnStatusChanging(value)
				Me.SendPropertyChanging
				Me._Status = value
				Me.SendPropertyChanged("Status")
				Me.OnStatusChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Students")>  _
Partial Public Class Student
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _RegistrationNumber As String
	
	Private _FullName As String
	
	Private _Gender As String
	
	Private _Age As System.Nullable(Of Decimal)
	
	Private _Address As String
	
	Private _PhoneNumber As String
	
	Private _Email As String
	
	Private _Class As String
	
	Private _Stream As String
	
	Private _Picture As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnRegistrationNumberChanging(value As String)
    End Sub
    Partial Private Sub OnRegistrationNumberChanged()
    End Sub
    Partial Private Sub OnFullNameChanging(value As String)
    End Sub
    Partial Private Sub OnFullNameChanged()
    End Sub
    Partial Private Sub OnGenderChanging(value As String)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnAgeChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnAgeChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnPhoneNumberChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneNumberChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    Partial Private Sub OnClassChanging(value As String)
    End Sub
    Partial Private Sub OnClassChanged()
    End Sub
    Partial Private Sub OnStreamChanging(value As String)
    End Sub
    Partial Private Sub OnStreamChanged()
    End Sub
    Partial Private Sub OnPictureChanging(value As String)
    End Sub
    Partial Private Sub OnPictureChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RegistrationNumber", DbType:="NVarChar(50)")>  _
	Public Property RegistrationNumber() As String
		Get
			Return Me._RegistrationNumber
		End Get
		Set
			If (String.Equals(Me._RegistrationNumber, value) = false) Then
				Me.OnRegistrationNumberChanging(value)
				Me.SendPropertyChanging
				Me._RegistrationNumber = value
				Me.SendPropertyChanged("RegistrationNumber")
				Me.OnRegistrationNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FullName", DbType:="NVarChar(50)")>  _
	Public Property FullName() As String
		Get
			Return Me._FullName
		End Get
		Set
			If (String.Equals(Me._FullName, value) = false) Then
				Me.OnFullNameChanging(value)
				Me.SendPropertyChanging
				Me._FullName = value
				Me.SendPropertyChanged("FullName")
				Me.OnFullNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="NVarChar(50)")>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Age", DbType:="Decimal(18,0)")>  _
	Public Property Age() As System.Nullable(Of Decimal)
		Get
			Return Me._Age
		End Get
		Set
			If (Me._Age.Equals(value) = false) Then
				Me.OnAgeChanging(value)
				Me.SendPropertyChanging
				Me._Age = value
				Me.SendPropertyChanged("Age")
				Me.OnAgeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(500)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PhoneNumber", DbType:="NVarChar(50)")>  _
	Public Property PhoneNumber() As String
		Get
			Return Me._PhoneNumber
		End Get
		Set
			If (String.Equals(Me._PhoneNumber, value) = false) Then
				Me.OnPhoneNumberChanging(value)
				Me.SendPropertyChanging
				Me._PhoneNumber = value
				Me.SendPropertyChanged("PhoneNumber")
				Me.OnPhoneNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="NVarChar(200)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="Class", Storage:="_Class", DbType:="NVarChar(50)")>  _
	Public Property [Class]() As String
		Get
			Return Me._Class
		End Get
		Set
			If (String.Equals(Me._Class, value) = false) Then
				Me.OnClassChanging(value)
				Me.SendPropertyChanging
				Me._Class = value
				Me.SendPropertyChanged("[Class]")
				Me.OnClassChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Stream", DbType:="NVarChar(50)")>  _
	Public Property Stream() As String
		Get
			Return Me._Stream
		End Get
		Set
			If (String.Equals(Me._Stream, value) = false) Then
				Me.OnStreamChanging(value)
				Me.SendPropertyChanging
				Me._Stream = value
				Me.SendPropertyChanged("Stream")
				Me.OnStreamChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Picture", DbType:="NVarChar(500)")>  _
	Public Property Picture() As String
		Get
			Return Me._Picture
		End Get
		Set
			If (String.Equals(Me._Picture, value) = false) Then
				Me.OnPictureChanging(value)
				Me.SendPropertyChanging
				Me._Picture = value
				Me.SendPropertyChanged("Picture")
				Me.OnPictureChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Teachers")>  _
Partial Public Class Teacher
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _StaffID As String
	
	Private _FullName As String
	
	Private _Gender As String
	
	Private _Age As System.Nullable(Of Decimal)
	
	Private _Designation As String
	
	Private _Picture As String
	
	Private _Address As String
	
	Private _PhoneNumber As String
	
	Private _Email As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnStaffIDChanging(value As String)
    End Sub
    Partial Private Sub OnStaffIDChanged()
    End Sub
    Partial Private Sub OnFullNameChanging(value As String)
    End Sub
    Partial Private Sub OnFullNameChanged()
    End Sub
    Partial Private Sub OnGenderChanging(value As String)
    End Sub
    Partial Private Sub OnGenderChanged()
    End Sub
    Partial Private Sub OnAgeChanging(value As System.Nullable(Of Decimal))
    End Sub
    Partial Private Sub OnAgeChanged()
    End Sub
    Partial Private Sub OnDesignationChanging(value As String)
    End Sub
    Partial Private Sub OnDesignationChanged()
    End Sub
    Partial Private Sub OnPictureChanging(value As String)
    End Sub
    Partial Private Sub OnPictureChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnPhoneNumberChanging(value As String)
    End Sub
    Partial Private Sub OnPhoneNumberChanged()
    End Sub
    Partial Private Sub OnEmailChanging(value As String)
    End Sub
    Partial Private Sub OnEmailChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StaffID", DbType:="NVarChar(50)")>  _
	Public Property StaffID() As String
		Get
			Return Me._StaffID
		End Get
		Set
			If (String.Equals(Me._StaffID, value) = false) Then
				Me.OnStaffIDChanging(value)
				Me.SendPropertyChanging
				Me._StaffID = value
				Me.SendPropertyChanged("StaffID")
				Me.OnStaffIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FullName", DbType:="NVarChar(50)")>  _
	Public Property FullName() As String
		Get
			Return Me._FullName
		End Get
		Set
			If (String.Equals(Me._FullName, value) = false) Then
				Me.OnFullNameChanging(value)
				Me.SendPropertyChanging
				Me._FullName = value
				Me.SendPropertyChanged("FullName")
				Me.OnFullNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Gender", DbType:="NVarChar(50)")>  _
	Public Property Gender() As String
		Get
			Return Me._Gender
		End Get
		Set
			If (String.Equals(Me._Gender, value) = false) Then
				Me.OnGenderChanging(value)
				Me.SendPropertyChanging
				Me._Gender = value
				Me.SendPropertyChanged("Gender")
				Me.OnGenderChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Age", DbType:="Decimal(18,0)")>  _
	Public Property Age() As System.Nullable(Of Decimal)
		Get
			Return Me._Age
		End Get
		Set
			If (Me._Age.Equals(value) = false) Then
				Me.OnAgeChanging(value)
				Me.SendPropertyChanging
				Me._Age = value
				Me.SendPropertyChanged("Age")
				Me.OnAgeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Designation", DbType:="NVarChar(50)")>  _
	Public Property Designation() As String
		Get
			Return Me._Designation
		End Get
		Set
			If (String.Equals(Me._Designation, value) = false) Then
				Me.OnDesignationChanging(value)
				Me.SendPropertyChanging
				Me._Designation = value
				Me.SendPropertyChanged("Designation")
				Me.OnDesignationChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Picture", DbType:="NVarChar(500)")>  _
	Public Property Picture() As String
		Get
			Return Me._Picture
		End Get
		Set
			If (String.Equals(Me._Picture, value) = false) Then
				Me.OnPictureChanging(value)
				Me.SendPropertyChanging
				Me._Picture = value
				Me.SendPropertyChanged("Picture")
				Me.OnPictureChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(50)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PhoneNumber", DbType:="NVarChar(50)")>  _
	Public Property PhoneNumber() As String
		Get
			Return Me._PhoneNumber
		End Get
		Set
			If (String.Equals(Me._PhoneNumber, value) = false) Then
				Me.OnPhoneNumberChanging(value)
				Me.SendPropertyChanging
				Me._PhoneNumber = value
				Me.SendPropertyChanged("PhoneNumber")
				Me.OnPhoneNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Email", DbType:="NVarChar(200)")>  _
	Public Property Email() As String
		Get
			Return Me._Email
		End Get
		Set
			If (String.Equals(Me._Email, value) = false) Then
				Me.OnEmailChanging(value)
				Me.SendPropertyChanging
				Me._Email = value
				Me.SendPropertyChanged("Email")
				Me.OnEmailChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Users")>  _
Partial Public Class User
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As Integer
	
	Private _Username As String
	
	Private _Password As String
	
	Private _FullName As String
	
	Private _Picture As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnUsernameChanging(value As String)
    End Sub
    Partial Private Sub OnUsernameChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnFullNameChanging(value As String)
    End Sub
    Partial Private Sub OnFullNameChanged()
    End Sub
    Partial Private Sub OnPictureChanging(value As String)
    End Sub
    Partial Private Sub OnPictureChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID() As Integer
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Username", DbType:="NVarChar(50)")>  _
	Public Property Username() As String
		Get
			Return Me._Username
		End Get
		Set
			If (String.Equals(Me._Username, value) = false) Then
				Me.OnUsernameChanging(value)
				Me.SendPropertyChanging
				Me._Username = value
				Me.SendPropertyChanged("Username")
				Me.OnUsernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="NVarChar(50)")>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FullName", DbType:="NVarChar(50)")>  _
	Public Property FullName() As String
		Get
			Return Me._FullName
		End Get
		Set
			If (String.Equals(Me._FullName, value) = false) Then
				Me.OnFullNameChanging(value)
				Me.SendPropertyChanging
				Me._FullName = value
				Me.SendPropertyChanged("FullName")
				Me.OnFullNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Picture", DbType:="NVarChar(500)")>  _
	Public Property Picture() As String
		Get
			Return Me._Picture
		End Get
		Set
			If (String.Equals(Me._Picture, value) = false) Then
				Me.OnPictureChanging(value)
				Me.SendPropertyChanging
				Me._Picture = value
				Me.SendPropertyChanged("Picture")
				Me.OnPictureChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

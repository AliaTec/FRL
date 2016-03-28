Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class ReporteConcentradoAnualAR 
    Inherits DataDynamics.ActiveReports.ActiveReport3

#Region " ActiveReports Designer generated code "
    Public Sub New() 

        'This call is required by the ActiveReports Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub 

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean) 
        If disposing Then 
            If Not (components Is Nothing) Then 
                components.Dispose 
            End If 
        End If 
        MyBase.Dispose(disposing) 
    End Sub 

    'Required by the Windows Form Designer
    Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader 
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail 
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter 
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents txtrfc1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtIdRazonSocial1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents txtNombreConcepto1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTotalE1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents txtidtiponominaasig1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents ReportInfo2 As DataDynamics.ActiveReports.ReportInfo
    Private WithEvents ReportInfo3 As DataDynamics.ActiveReports.ReportInfo
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReporteConcentradoAnualAR))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.txtrfc1 = New DataDynamics.ActiveReports.TextBox
        Me.txtIdRazonSocial1 = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.txtidtiponominaasig1 = New DataDynamics.ActiveReports.TextBox
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.ReportInfo2 = New DataDynamics.ActiveReports.ReportInfo
        Me.ReportInfo3 = New DataDynamics.ActiveReports.ReportInfo
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.txtNombreConcepto1 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalE1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrfc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdRazonSocial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtidtiponominaasig1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreConcepto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalE1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label5, Me.txtrfc1, Me.txtIdRazonSocial1, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.txtidtiponominaasig1, Me.Label20, Me.Label21, Me.TextBox29, Me.ReportInfo1, Me.Label2, Me.ReportInfo2, Me.ReportInfo3, Me.Label3, Me.Label4})
        Me.PageHeader1.Height = 1.510417!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.Label1.Text = "CONCENTRADO ANUAL DE NOMINAS"
        Me.Label1.Top = 0.0625!
        Me.Label1.Width = 3.0!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0625!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label5.Text = "RFC"
        Me.Label5.Top = 1.0!
        Me.Label5.Width = 0.9375!
        '
        'txtrfc1
        '
        Me.txtrfc1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtrfc1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtrfc1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtrfc1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtrfc1.Border.RightColor = System.Drawing.Color.Black
        Me.txtrfc1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtrfc1.Border.TopColor = System.Drawing.Color.Black
        Me.txtrfc1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtrfc1.DataField = "rfc"
        Me.txtrfc1.Height = 0.1875!
        Me.txtrfc1.Left = 1.0!
        Me.txtrfc1.Name = "txtrfc1"
        Me.txtrfc1.Style = "font-size: 8pt; font-family: Tahoma; "
        Me.txtrfc1.Text = Nothing
        Me.txtrfc1.Top = 1.0!
        Me.txtrfc1.Width = 2.0!
        '
        'txtIdRazonSocial1
        '
        Me.txtIdRazonSocial1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtIdRazonSocial1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIdRazonSocial1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtIdRazonSocial1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIdRazonSocial1.Border.RightColor = System.Drawing.Color.Black
        Me.txtIdRazonSocial1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIdRazonSocial1.Border.TopColor = System.Drawing.Color.Black
        Me.txtIdRazonSocial1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtIdRazonSocial1.DataField = "IdRazonSocial"
        Me.txtIdRazonSocial1.Height = 0.1875!
        Me.txtIdRazonSocial1.Left = 0.0!
        Me.txtIdRazonSocial1.Name = "txtIdRazonSocial1"
        Me.txtIdRazonSocial1.Style = "font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.txtIdRazonSocial1.Text = Nothing
        Me.txtIdRazonSocial1.Top = 0.3125!
        Me.txtIdRazonSocial1.Width = 3.0!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; font-family: Tahoma; "
        Me.Label6.Text = "Concepto"
        Me.Label6.Top = 1.3125!
        Me.Label6.Width = 2.9375!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.0!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label7.Text = "Enero"
        Me.Label7.Top = 1.3125!
        Me.Label7.Width = 0.9375!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label8.Text = "Febrero"
        Me.Label8.Top = 1.3125!
        Me.Label8.Width = 0.9375!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 5.0!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label9.Text = "Marzo"
        Me.Label9.Top = 1.3125!
        Me.Label9.Width = 0.9375!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 6.0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label10.Text = "Abril"
        Me.Label10.Top = 1.3125!
        Me.Label10.Width = 0.9375!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 7.0!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label11.Text = "Mayo"
        Me.Label11.Top = 1.3125!
        Me.Label11.Width = 0.9375!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 8.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label12.Text = "Junio"
        Me.Label12.Top = 1.3125!
        Me.Label12.Width = 0.9375!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 9.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label13.Text = "Julio"
        Me.Label13.Top = 1.3125!
        Me.Label13.Width = 0.9375!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 10.0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label14.Text = "Agosto"
        Me.Label14.Top = 1.3125!
        Me.Label14.Width = 0.9375!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 11.0!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label15.Text = "Septiembre"
        Me.Label15.Top = 1.3125!
        Me.Label15.Width = 0.9375!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 12.0!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label16.Text = "Octubre"
        Me.Label16.Top = 1.3125!
        Me.Label16.Width = 0.9375!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Height = 0.1875!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 13.0!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label17.Text = "Noviembre"
        Me.Label17.Top = 1.3125!
        Me.Label17.Width = 0.9375!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Height = 0.1875!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 14.0!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label18.Text = "Diciembre"
        Me.Label18.Top = 1.3125!
        Me.Label18.Width = 0.9375!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.125!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.0625!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label19.Text = "TIPO NOMINA"
        Me.Label19.Top = 0.5625!
        Me.Label19.Width = 0.9375!
        '
        'txtidtiponominaasig1
        '
        Me.txtidtiponominaasig1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtidtiponominaasig1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtidtiponominaasig1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtidtiponominaasig1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtidtiponominaasig1.Border.RightColor = System.Drawing.Color.Black
        Me.txtidtiponominaasig1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtidtiponominaasig1.Border.TopColor = System.Drawing.Color.Black
        Me.txtidtiponominaasig1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtidtiponominaasig1.DataField = "idtiponominaasig"
        Me.txtidtiponominaasig1.Height = 0.125!
        Me.txtidtiponominaasig1.Left = 1.0!
        Me.txtidtiponominaasig1.Name = "txtidtiponominaasig1"
        Me.txtidtiponominaasig1.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
        Me.txtidtiponominaasig1.Text = Nothing
        Me.txtidtiponominaasig1.Top = 0.5625!
        Me.txtidtiponominaasig1.Width = 0.625!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Height = 0.188!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 15.0!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Tahoma; "
        Me.Label20.Text = "Total"
        Me.Label20.Top = 1.3125!
        Me.Label20.Width = 0.938!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.Black
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.LeftColor = System.Drawing.Color.Black
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.RightColor = System.Drawing.Color.Black
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.TopColor = System.Drawing.Color.Black
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Height = 0.125!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.0625!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.Label21.Text = "AÑO"
        Me.Label21.Top = 0.75!
        Me.Label21.Width = 0.9375!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox29.DataField = "anio"
        Me.TextBox29.Height = 0.125!
        Me.TextBox29.Left = 1.0!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; "
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 0.75!
        Me.TextBox29.Width = 0.625!
        '
        'ReportInfo1
        '
        Me.ReportInfo1.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo1.FormatString = "{RunDateTime:hh:mm tt}"
        Me.ReportInfo1.Height = 0.1875!
        Me.ReportInfo1.Left = 14.9375!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; "
        Me.ReportInfo1.Top = 0.4375!
        Me.ReportInfo1.Width = 1.9375!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.177!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 14.1875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-weight: bold; font-size: 8.25pt; font-family: Tahoma; "
        Me.Label2.Text = "Fecha"
        Me.Label2.Top = 0.25!
        Me.Label2.Width = 0.728!
        '
        'ReportInfo2
        '
        Me.ReportInfo2.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo2.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo2.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo2.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo2.FormatString = "{RunDateTime:dd/MM/yyyy}"
        Me.ReportInfo2.Height = 0.1875!
        Me.ReportInfo2.Left = 14.9375!
        Me.ReportInfo2.Name = "ReportInfo2"
        Me.ReportInfo2.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; "
        Me.ReportInfo2.Top = 0.25!
        Me.ReportInfo2.Width = 1.9375!
        '
        'ReportInfo3
        '
        Me.ReportInfo3.Border.BottomColor = System.Drawing.Color.Black
        Me.ReportInfo3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo3.Border.LeftColor = System.Drawing.Color.Black
        Me.ReportInfo3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo3.Border.RightColor = System.Drawing.Color.Black
        Me.ReportInfo3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo3.Border.TopColor = System.Drawing.Color.Black
        Me.ReportInfo3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.ReportInfo3.FormatString = "{PageNumber} de {PageCount}"
        Me.ReportInfo3.Height = 0.1875!
        Me.ReportInfo3.Left = 14.9375!
        Me.ReportInfo3.Name = "ReportInfo3"
        Me.ReportInfo3.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; "
        Me.ReportInfo3.Top = 0.0625!
        Me.ReportInfo3.Width = 1.9375!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.177!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 14.1875!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-weight: bold; font-size: 8.25pt; font-family: Tahoma; "
        Me.Label3.Text = "Hora"
        Me.Label3.Top = 0.4375!
        Me.Label3.Width = 0.728!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.177!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 14.1875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-weight: bold; font-size: 8.25pt; font-family: Tahoma; "
        Me.Label4.Text = "Pagina"
        Me.Label4.Top = 0.0625!
        Me.Label4.Width = 0.728!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNombreConcepto1, Me.txtTotalE1, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox25})
        Me.Detail1.Height = 0.21875!
        Me.Detail1.Name = "Detail1"
        '
        'txtNombreConcepto1
        '
        Me.txtNombreConcepto1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtNombreConcepto1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreConcepto1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtNombreConcepto1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreConcepto1.Border.RightColor = System.Drawing.Color.Black
        Me.txtNombreConcepto1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreConcepto1.Border.TopColor = System.Drawing.Color.Black
        Me.txtNombreConcepto1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtNombreConcepto1.DataField = "NombreConcepto"
        Me.txtNombreConcepto1.Height = 0.1875!
        Me.txtNombreConcepto1.Left = 0.0625!
        Me.txtNombreConcepto1.Name = "txtNombreConcepto1"
        Me.txtNombreConcepto1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; font-family: Tahoma; "
        Me.txtNombreConcepto1.Text = "txtNombreConcepto1"
        Me.txtNombreConcepto1.Top = 0.0!
        Me.txtNombreConcepto1.Width = 2.9375!
        '
        'txtTotalE1
        '
        Me.txtTotalE1.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalE1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalE1.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalE1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalE1.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalE1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalE1.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalE1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalE1.DataField = "TotalE"
        Me.txtTotalE1.Height = 0.188!
        Me.txtTotalE1.Left = 3.0!
        Me.txtTotalE1.Name = "txtTotalE1"
        Me.txtTotalE1.OutputFormat = resources.GetString("txtTotalE1.OutputFormat")
        Me.txtTotalE1.Style = "text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.txtTotalE1.Text = "99,999,999.99"
        Me.txtTotalE1.Top = 0.0!
        Me.txtTotalE1.Width = 0.938!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "TotalF"
        Me.TextBox1.Height = 0.188!
        Me.TextBox1.Left = 4.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox1.Text = "99,999,999.99"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.938!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "TotalM"
        Me.TextBox2.Height = 0.188!
        Me.TextBox2.Left = 5.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox2.Text = "99,999,999.99"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.938!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "TotalA"
        Me.TextBox3.Height = 0.188!
        Me.TextBox3.Left = 6.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox3.Text = "99,999,999.99"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.938!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.DataField = "TotalMY"
        Me.TextBox4.Height = 0.188!
        Me.TextBox4.Left = 7.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox4.Text = "99,999,999.99"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.938!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.DataField = "TotalJ"
        Me.TextBox5.Height = 0.188!
        Me.TextBox5.Left = 8.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox5.Text = "99,999,999.99"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.938!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.DataField = "TotalJL"
        Me.TextBox6.Height = 0.188!
        Me.TextBox6.Left = 9.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox6.Text = "99,999,999.99"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.938!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.DataField = "TotalAG"
        Me.TextBox7.Height = 0.188!
        Me.TextBox7.Left = 10.0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox7.Text = "99,999,999.99"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.938!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox8.DataField = "TotalS"
        Me.TextBox8.Height = 0.188!
        Me.TextBox8.Left = 11.0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox8.Text = "99,999,999.99"
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.938!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.DataField = "TotalO"
        Me.TextBox9.Height = 0.188!
        Me.TextBox9.Left = 12.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox9.Text = "99,999,999.99"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.938!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.DataField = "TotalN"
        Me.TextBox10.Height = 0.188!
        Me.TextBox10.Left = 13.0!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox10.Text = "99,999,999.99"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.938!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.DataField = "TotalD"
        Me.TextBox11.Height = 0.188!
        Me.TextBox11.Left = 14.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox11.Text = "99,999,999.99"
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.938!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox25.DataField = "=TotalE+TotalF+TotalM+TotalA+TotalMY+TotalJ+TotalJL+TotalAG+TotalS+TotalO+TotalN+" & _
            "TotalD"
        Me.TextBox25.Height = 0.188!
        Me.TextBox25.Left = 15.0!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.OutputFormat = resources.GetString("TextBox25.OutputFormat")
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox25.Text = "99,999,999.99"
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 0.938!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.02083333!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox24, Me.TextBox27})
        Me.GroupHeader1.DataField = "tipo"
        Me.GroupHeader1.Height = 0.15625!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox24.DataField = "tipo"
        Me.TextBox24.Height = 0.159!
        Me.TextBox24.Left = 0.1041667!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Tahoma; "
        Me.TextBox24.Text = "txtNombreConcepto1"
        Me.TextBox24.Top = 0.04166667!
        Me.TextBox24.Width = 0.0!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox27.DataField = "tipo"
        Me.TextBox27.Height = 0.1875!
        Me.TextBox27.Left = 0.0625!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Style = "font-weight: bold; font-size: 8.25pt; font-family: Tahoma; "
        Me.TextBox27.Text = Nothing
        Me.TextBox27.Top = 0.0!
        Me.TextBox27.Width = 2.9375!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.TextBox26, Me.TextBox28})
        Me.GroupFooter1.Height = 0.21875!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.DataField = "TotalE"
        Me.TextBox12.Height = 0.188!
        Me.TextBox12.Left = 3.0!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
        Me.TextBox12.Style = "text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox12.SummaryGroup = "GroupHeader1"
        Me.TextBox12.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox12.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox12.Text = "999,999,999.99"
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 0.938!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.DataField = "TotalF"
        Me.TextBox13.Height = 0.188!
        Me.TextBox13.Left = 4.0!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox13.SummaryGroup = "GroupHeader1"
        Me.TextBox13.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox13.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox13.Text = "999,999,999.99"
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.938!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.DataField = "TotalM"
        Me.TextBox14.Height = 0.188!
        Me.TextBox14.Left = 5.0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox14.SummaryGroup = "GroupHeader1"
        Me.TextBox14.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox14.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox14.Text = "999,999,999.99"
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 0.938!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox15.DataField = "TotalA"
        Me.TextBox15.Height = 0.188!
        Me.TextBox15.Left = 6.0!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox15.SummaryGroup = "GroupHeader1"
        Me.TextBox15.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox15.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox15.Text = "999,999,999.99"
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.938!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.DataField = "TotalMY"
        Me.TextBox16.Height = 0.188!
        Me.TextBox16.Left = 7.0!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox16.SummaryGroup = "GroupHeader1"
        Me.TextBox16.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox16.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox16.Text = "999,999,999.99"
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 0.938!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.DataField = "TotalJ"
        Me.TextBox17.Height = 0.188!
        Me.TextBox17.Left = 8.0!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox17.SummaryGroup = "GroupHeader1"
        Me.TextBox17.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox17.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox17.Text = "999,999,999.99"
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 0.938!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox18.DataField = "TotalJL"
        Me.TextBox18.Height = 0.188!
        Me.TextBox18.Left = 9.0!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.OutputFormat = resources.GetString("TextBox18.OutputFormat")
        Me.TextBox18.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox18.SummaryGroup = "GroupHeader1"
        Me.TextBox18.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox18.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox18.Text = "999,999,999.99"
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 0.938!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox19.DataField = "TotalAG"
        Me.TextBox19.Height = 0.188!
        Me.TextBox19.Left = 10.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
        Me.TextBox19.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox19.SummaryGroup = "GroupHeader1"
        Me.TextBox19.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox19.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox19.Text = "999,999,999.99"
        Me.TextBox19.Top = 0.0!
        Me.TextBox19.Width = 0.938!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox20.DataField = "TotalS"
        Me.TextBox20.Height = 0.188!
        Me.TextBox20.Left = 11.0!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.OutputFormat = resources.GetString("TextBox20.OutputFormat")
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox20.SummaryGroup = "GroupHeader1"
        Me.TextBox20.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox20.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox20.Text = "999,999,999.99"
        Me.TextBox20.Top = 0.0!
        Me.TextBox20.Width = 0.938!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.DataField = "TotalO"
        Me.TextBox21.Height = 0.188!
        Me.TextBox21.Left = 12.0!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.OutputFormat = resources.GetString("TextBox21.OutputFormat")
        Me.TextBox21.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox21.SummaryGroup = "GroupHeader1"
        Me.TextBox21.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox21.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox21.Text = "999,999,999.99"
        Me.TextBox21.Top = 0.0!
        Me.TextBox21.Width = 0.938!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox22.DataField = "TotalN"
        Me.TextBox22.Height = 0.188!
        Me.TextBox22.Left = 13.0!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.OutputFormat = resources.GetString("TextBox22.OutputFormat")
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox22.SummaryGroup = "GroupHeader1"
        Me.TextBox22.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox22.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox22.Text = "999,999,999.99"
        Me.TextBox22.Top = 0.0!
        Me.TextBox22.Width = 0.938!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox23.DataField = "TotalD"
        Me.TextBox23.Height = 0.188!
        Me.TextBox23.Left = 14.0!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.OutputFormat = resources.GetString("TextBox23.OutputFormat")
        Me.TextBox23.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox23.SummaryGroup = "GroupHeader1"
        Me.TextBox23.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox23.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox23.Text = "999,999,999.99"
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.938!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Height = 0.188!
        Me.TextBox26.Left = 15.0!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.OutputFormat = resources.GetString("TextBox26.OutputFormat")
        Me.TextBox26.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; font-family: Tahoma; "
        Me.TextBox26.Text = "999,999,999.99"
        Me.TextBox26.Top = 0.0!
        Me.TextBox26.Width = 0.938!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Height = 0.1875!
        Me.TextBox28.Left = 0.0625!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Tahoma; "
        Me.TextBox28.Text = "Totales"
        Me.TextBox28.Top = 0.0!
        Me.TextBox28.Width = 0.5625!
        '
        'ReporteConcentradoAnualAR
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.3937008!
        Me.PageSettings.Margins.Left = 0.3937008!
        Me.PageSettings.Margins.Right = 0.3937008!
        Me.PageSettings.Margins.Top = 0.3937008!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 14.0!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 17.11491!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrfc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdRazonSocial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtidtiponominaasig1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreConcepto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalE1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        If Not IsDBNull(Me.TextBox24.Value) Then
            If Me.TextBox24.Value = 0 Then
                Me.TextBox27.Text = "Percepciones"
            ElseIf Me.TextBox24.Value = 1 Then
                Me.TextBox27.Text = "Deducciones"
            ElseIf Me.TextBox24.Value = 2 Then
                Me.TextBox27.Text = "Empresa"
            ElseIf Me.TextBox24.Value = 3 Then
                Me.TextBox27.Text = "Informativos"
            Else
                Me.TextBox27.Text = ""
            End If
        Else
            Me.TextBox27.Text = ""
        End If
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        TextBox26.Value = TextBox12.Value + TextBox13.Value + TextBox14.Value + TextBox15.Value + TextBox16.Value + TextBox17.Value + TextBox18.Value + TextBox19.Value + TextBox20.Value + TextBox21.Value + TextBox22.Value + TextBox23.Value
    End Sub

    Private Sub ReporteConcentradoAnualAR_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Me.ShowParameterUI = False
        Me.SetLicense("Hector Ramirez,Intelexion,DD-APN-30-C000260,S4VKSH448MS77HKH9FH9")
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraSchedulerReport
    Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
        Me.reportWeekView1 = New DevExpress.XtraScheduler.Reporting.ReportWeekView()
        Me.fullWeek1 = New DevExpress.XtraScheduler.Reporting.FullWeek()
        Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
        CType(Me.reportWeekView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'timeIntervalInfo1
        '
        Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 33.0!)
        Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
        Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(233.0!, 92.0!)
        Me.timeIntervalInfo1.TimeCells = Me.fullWeek1
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.horizontalResourceHeaders1, Me.fullWeek1, Me.timeIntervalInfo1, Me.calendarControl1})
        Me.Detail.HeightF = 875.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'horizontalResourceHeaders1
        '
        Me.horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 158.0!)
        Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
        Me.horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
        Me.horizontalResourceHeaders1.View = Me.reportWeekView1
        '
        'reportWeekView1
        '
        Me.reportWeekView1.VisibleResourceCount = 2
        '
        'fullWeek1
        '
        Me.fullWeek1.HorizontalHeaders = Me.horizontalResourceHeaders1
        Me.fullWeek1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 183.0!)
        Me.fullWeek1.Name = "fullWeek1"
        Me.fullWeek1.SizeF = New System.Drawing.SizeF(650.0!, 683.0!)
        Me.fullWeek1.View = Me.reportWeekView1
        '
        'calendarControl1
        '
        Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 8.0!)
        Me.calendarControl1.Name = "calendarControl1"
        Me.calendarControl1.SizeF = New System.Drawing.SizeF(350.0!, 142.0!)
        Me.calendarControl1.TimeCells = Me.fullWeek1
        Me.calendarControl1.View = Me.reportWeekView1
        '
        'XtraSchedulerReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.Version = "13.2"
        Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportWeekView1})
        CType(Me.reportWeekView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
    Friend WithEvents fullWeek1 As DevExpress.XtraScheduler.Reporting.FullWeek
    Friend WithEvents horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders
    Friend WithEvents reportWeekView1 As DevExpress.XtraScheduler.Reporting.ReportWeekView
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
End Class

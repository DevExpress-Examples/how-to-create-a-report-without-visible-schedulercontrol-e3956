Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Scheduler
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Reporting

Class MainWindow
    Private dataSet As CarsDBDataSet
    Private tableAdapter As CarsDBDataSetTableAdapters.CarSchedulingTableAdapter

    Public Sub New()
        InitializeComponent()

        Me.dataSet = New CarsDBDataSet()

        ' Bind the scheduler storage to appointment data.
        Me.storage.AppointmentStorage.DataSource = dataSet.CarScheduling

        ' Load data into the 'CarsDBDataSet.CarScheduling' table. 
        Me.tableAdapter = New CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
        Me.tableAdapter.Fill(dataSet.CarScheduling)

        ' Create a new report.
        Dim report As New XtraSchedulerReport()

        ' Load the report template. 
        ' Change the file name or use the stream if necessary.
        report.LoadLayout("C:\Users\Public\Documents\DevExpress 2012.1 Demos\Components\Data\SchedulerReportTemplates\WeeklyStyle.schrepx")

        ' Specify the scheduler storage for the print adapter.
        printAdapter.SchedulerStorage = storage

        ' Specify the time inteval and start day of week used by the print adapter to create a report.
        printAdapter.TimeInterval = New TimeInterval(New DateTime(2010, 7, 15), _
                                                     New DateTime(2010, 7, 30))
        printAdapter.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Tuesday

        ' Implement appointment filtering.
        AddHandler printAdapter.ValidateAppointments, AddressOf printAdapter_ValidateAppointments

        ' Specify the print adapter which provides data for the report.
        report.SchedulerAdapter = printAdapter.SchedulerAdapter

        ' Create a document from the report, so the report can be displayed or printed.
        report.CreateDocument()

        ' Create a preview model with the specified report.
        Dim previewModel As New XtraReportPreviewModel(report)

        ' Specify the model for the DocumentPreview control.
        documentPreview.Model = previewModel
    End Sub


    Private Sub printAdapter_ValidateAppointments(ByVal sender As Object, _
                                                  ByVal e As AppointmentsValidationEventArgs)
        Dim count As Integer = e.Appointments.Count
        Dim result As New AppointmentBaseCollection()
        For i As Integer = 0 To count - 1
            Dim apt As Appointment = e.Appointments(i)
            If apt.IsRecurring Then
                result.Add(apt)
            End If
        Next i
        e.Appointments.Clear()
        e.Appointments.AddRange(result)
    End Sub
End Class
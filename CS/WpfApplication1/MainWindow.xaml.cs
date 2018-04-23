using System;
using System.Windows;
using DevExpress.Xpf.Printing;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;

namespace WpfApplication1 {
    public partial class MainWindow : Window {

        CarsDBDataSet dataSet;
        CarsDBDataSetTableAdapters.CarSchedulingTableAdapter tableAdapter;

        public MainWindow() {
            InitializeComponent();

            this.dataSet = new CarsDBDataSet();

            // Bind the scheduler storage to appointment data.
            storage.AppointmentStorage.DataSource = dataSet.CarScheduling;

            // Load data into the 'CarsDBDataSet.CarScheduling' table. 
            this.tableAdapter = new CarsDBDataSetTableAdapters.CarSchedulingTableAdapter();
            this.tableAdapter.Fill(dataSet.CarScheduling);

            // Create a new report instance.
            XtraSchedulerReport report = new XtraSchedulerReport();

            // Specify the scheduler storage for the print adapter.
            printAdapter.SchedulerStorage = storage;

            // Specify the time inteval and start day of week used by the print adapter to create a report.
            printAdapter.TimeInterval =
                                new TimeInterval(new DateTime(2010, 7, 15), new DateTime(2010, 7, 30));
            printAdapter.FirstDayOfWeek = FirstDayOfWeek.Tuesday;

            // Implement appointment filtering.
            printAdapter.ValidateAppointments +=
                            new AppointmentsValidationEventHandler(printAdapter_ValidateAppointments);

            // Specify the print adapter which provides data for the report.
            report.SchedulerAdapter = printAdapter.SchedulerAdapter;

            // Create a document from the report, so the report can be displayed or printed.
            report.CreateDocument();

            // Create a preview model with the specified report.
            XtraReportPreviewModel previewModel = new XtraReportPreviewModel(report);

            // Specify the model for the DocumentPreview control.
            documentPreview.Model = previewModel;
        }

        private void printAdapter_ValidateAppointments(object sender, AppointmentsValidationEventArgs e) {
            int count = e.Appointments.Count;
            AppointmentBaseCollection result = new AppointmentBaseCollection();
            for (int i = 0; i < count; i++) {
                Appointment apt = e.Appointments[i];
                if (apt.IsRecurring)
                    result.Add(apt);
            }
            e.Appointments.Clear();
            e.Appointments.AddRange(result);
        }
    }
}

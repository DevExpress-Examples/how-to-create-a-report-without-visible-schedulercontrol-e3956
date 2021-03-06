<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfApplication1/MainWindow.xaml))
<!-- default file list end -->
# How to create a report without visible SchedulerControl


<p>This example demonstrates how a report based on a ready template can be created and bound to data without the necessity to use the <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfSchedulerSchedulerControltopic"><u>SchedulerControl</u></a>.<br />
A standalone <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfSchedulerSchedulerStoragetopic"><u>SchedulerStorage</u></a> object is created, bound to appointment data, and used as a data source for the report's print adapter. The <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraSchedulerReportingXtraSchedulerReporttopic"><u>XtraSchedulerReport</u></a> object is added to the project and a report template is loaded from the DevExpress template gallery at design time in Visual Studio. The Scheduler report is linked to the SchedulerStorage via the <strong>DXSchedulerStoragePrintAdapter</strong> object.</p>


<h3>Description</h3>

<p>You can replicate the same project by performing steps from the following tutorial: <a href="http://documentation.devexpress.com/#WPF/CustomDocument11479"><u>How to: Create a Report without Visible SchedulerControl</u></a>.</p>

<br/>



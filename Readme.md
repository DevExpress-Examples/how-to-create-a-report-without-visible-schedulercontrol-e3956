# How to create a report without visible SchedulerControl


<p>This example demonstrates how a report based on a ready template can be created and bound to data without the necessity to use the <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfSchedulerSchedulerControltopic"><u>SchedulerControl</u></a>.<br />
A standalone <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfSchedulerSchedulerStoragetopic"><u>SchedulerStorage</u></a> object is created, bound to appointment data, and used as a data source for the report's print adapter. The <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraSchedulerReportingXtraSchedulerReporttopic"><u>XtraSchedulerReport</u></a> object is added to the project and a report template is loaded from the DevExpress template gallery at design time in Visual Studio. The Scheduler report is linked to the SchedulerStorage via the <strong>DXSchedulerStoragePrintAdapter</strong> object.</p>


<h3>Description</h3>

<p><br />
</p>

<br/>



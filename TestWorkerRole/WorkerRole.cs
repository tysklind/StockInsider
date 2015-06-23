using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using StockInsiderClass;
using System.Data.Entity;

namespace TestWorkerRole
{
    public class WorkerRole : RoleEntryPoint
    {
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);

        public override void Run()
        {
            Trace.TraceInformation("TestWorkerRole is running");

            try
            {
                this.RunAsync(this.cancellationTokenSource.Token).Wait();
            }
            finally
            {
                this.runCompleteEvent.Set();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

            bool result = base.OnStart();

            Trace.TraceInformation("TestWorkerRole has been started");

            return result;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("TestWorkerRole is stopping");

            this.cancellationTokenSource.Cancel();
            this.runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("TestWorkerRole has stopped"); 
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            //TestTable t = new TestTable();
            //var tests = new List<TestTable>();
            //SIdbEntities context = new SIdbEntities();

            //SIdbEntities db = new SIdbEntities();

            //TestTable objEmp = new TestTable();
            //objEmp.Id = 1;
            //objEmp.Stamping = DateTime.Now;
            //db.TestTables.Add(objEmp);
            //db.SaveChanges();


            // TODO: Replace the following with your own logic.
            while (!cancellationToken.IsCancellationRequested)
            {
                Trace.TraceInformation("Working");
                await Task.Delay(1000);
            }


            //tests.ForEach(te => context.TestTables.Add(te));
            //context.SaveChanges();


        }
    }
}

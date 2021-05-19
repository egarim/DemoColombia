
namespace DemoColombia.Module.Controllers
{
    partial class InvoiceController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saProcess = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saProcess
            // 
            this.saProcess.Caption = "Process";
            this.saProcess.ConfirmationMessage = null;
            this.saProcess.Id = "ef8113bc-69be-4ee9-969b-5f17ea1e6e24";
            this.saProcess.ToolTip = null;
            this.saProcess.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saProcess_Execute);
            // 
            // InvoiceController
            // 
            this.Actions.Add(this.saProcess);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saProcess;
    }
}

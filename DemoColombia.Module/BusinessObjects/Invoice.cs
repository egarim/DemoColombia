using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DemoColombia.Module.BusinessObjects
{
    [DefaultClassOptions]
    [Appearance("Invoice ReadOnly",Criteria = "IsProcessed = true",TargetItems ="*" ,Enabled =false)] 
    public class Invoice : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Invoice(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            this.Date = DateTime.Now;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //xpd8

        bool isProccesed;
        decimal total;
        Customer customer;
        DateTime date;

        public DateTime Date
        {
            get => date;
            set => SetPropertyValue(nameof(Date), ref date, value);
        }
        //xpo
        [RuleRequiredField("Cliente requerido", DefaultContexts.Save)]
        public Customer Customer
        {
            get => customer;
            set => SetPropertyValue(nameof(Customer), ref customer, value);
        }
        //xpde

        public decimal Total
        {
            get => total;
            set => SetPropertyValue(nameof(Total), ref total, value);
        }
        //xpcl
        [DevExpress.Xpo.Aggregated()]
        [Association("Invoice-InvoiceDetails")]
        public XPCollection<InvoiceDetail> InvoiceDetails
        {
            get
            {
                return GetCollection<InvoiceDetail>(nameof(InvoiceDetails));
            }
        }

        //xpb

        [ModelDefault("AllowEdit","false")]
        public bool IsProcessed
        {
            get => isProccesed;
            set => SetPropertyValue(nameof(IsProcessed), ref isProccesed, value);
        }

    }
}